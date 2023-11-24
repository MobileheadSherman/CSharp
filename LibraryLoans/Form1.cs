using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True");
        SqlCommand command;
        DataTable dataTable;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Biblioteca";

            //daca nu am imprumuturi nu pot face grafic/salva in xml
            buttonGrafic.Enabled = false;
            salveazaImprumuturiToolStripMenuItem.Enabled = false;
        }

        /////////////////////////deschidere FormCititor/////////////////////////
        /////pentru adaugare
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCititor fCititor = new FormCititor(this);
            fCititor.Text = "Adaugare cititor";
            fCititor.ShowDialog();
        }
        ////pentru editare
        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listViewCititori.SelectedItems.Count == 1)
            {
                FormCititor fCititor = new FormCititor(this);
                fCititor.preluareDate();
                fCititor.Text = "Editare cititor";
                fCititor.buttonAdauga.Text = "Salveaza";

                fCititor.ShowDialog();
            }

        }

        /////////////////////////steregere din baza de date (DELETE)/////////////////////////
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool are; //ca sa verific daca cititorul are carti de predat
            if (listViewCititori.CheckedItems.Count == 1)
            {
                Cititor c = (Cititor)listViewCititori.CheckedItems[0].Tag;
                DialogResult confirmare = MessageBox.Show("Sigur doriti sa stergeti cititorul '" + c.Nume + "'?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                connection.Open();

                are = areCartiDeRestituit(c.ID);

                if (confirmare == DialogResult.Yes && are == false)
                {
                    command = new SqlCommand("delete from dbo.cititori where ID=" + c.ID, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    buttonAfisCititori_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Cititorul are carti de restituit! Nu poate fi sters inca!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
                if (listViewCititori.CheckedItems.Count > 1)
                {
                    DialogResult confirmare = MessageBox.Show("Sigur doriti sa stergeti cei " + listViewCititori.CheckedItems.Count + " cititori?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmare == DialogResult.Yes)
                    {
                        connection.Open();

                        for (int i = 0; i < listViewCititori.Items.Count; i++)
                        {
                            if (listViewCititori.Items[i].Checked)
                            {
                                int ID = Convert.ToInt32(listViewCititori.Items[i].SubItems[0].Text);

                                are = areCartiDeRestituit(ID);
                                if (are == false)
                                {
                                    command = new SqlCommand("delete from dbo.cititori where ID=@ID", connection);
                                    command.Parameters.AddWithValue("@ID", ID);
                                    command.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Cititorul " + listViewCititori.Items[i].SubItems[1].Text + " are carti de restituit! Inca nu poate fi sters!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        connection.Close();
                        buttonAfisCititori_Click(sender, e);
                    }
                }
        }

        /////////////////////////verificare daca cititorul are carti de resttuit/////////////////////////
        private bool areCartiDeRestituit(int id)
        {
            try
            {
                command = new SqlCommand("select count(*) from dbo.imprumuturi where ID_cititor=@ID_cititor and Data_restituire is null", connection);
                command.Parameters.AddWithValue("@ID_cititor", id);
                int nr = Convert.ToInt32(command.ExecuteScalar());
                if (nr > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /////////////////////////dezactivarea/activarea controalelor/////////////////////////
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (listViewCititori.SelectedItems.Count == 1)
            {
                editeazaToolStripMenuItem.Enabled = true;
            }
            else
            {
                editeazaToolStripMenuItem.Enabled = false;
            }

            if (listViewCititori.CheckedItems.Count > 0)
            {
                stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        /////////////////////////drag&drop/////////////////////////
        private void listViewCititori_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewCititori.SelectedItems.Count == 1)
            {
                listViewCititori.DoDragDrop(listViewCititori.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void treeViewImprumuturi_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void treeViewImprumuturi_DragDrop(object sender, DragEventArgs e)
        {
            Cititor c = (Cititor)listViewCititori.SelectedItems[0].Tag;
            TreeNode parentNode = treeViewImprumuturi.Nodes.Add("[" + c.ID + "] " + c.Nume);
            parentNode.Nodes.Add("Carti");
            parentNode.Nodes.Add("Termen");
            parentNode.Expand();

            FormImprumut fImp = new FormImprumut(c, treeViewImprumuturi);
            fImp.ShowDialog();

            if (treeViewImprumuturi.Nodes.Count > 0)
            {
                buttonGrafic.Enabled = true;
                salveazaImprumuturiToolStripMenuItem.Enabled = true;
            }
        }

        /////////////////////////afisarea cititorilor din DB in listview (SELECT)/////////////////////////
        public void buttonAfisCititori_Click(object sender, EventArgs e)
        {
            listViewCititori.Items.Clear();
            try
            {
                connection.Open();
                command = new SqlCommand("select * from dbo.cititori", connection);
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Cititori");
                dataSet.Tables["Cititori"].PrimaryKey = new DataColumn[1] { dataSet.Tables["Cititori"].Columns["ID"] };

                dataTable = dataSet.Tables["Cititori"];
                List<Cititor> cititori = new List<Cititor>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cititori.Add(new Cititor(Convert.ToInt32(dataTable.Rows[i].ItemArray[0]), dataTable.Rows[i].ItemArray[1].ToString(), Convert.ToDateTime(dataTable.Rows[i].ItemArray[2].ToString()), dataTable.Rows[i].ItemArray[3].ToString(), dataTable.Rows[i].ItemArray[4].ToString()));
                }

                foreach (Cititor c in cititori)
                {
                    ListViewItem lvi = new ListViewItem(c.ID.ToString());
                    lvi.SubItems.Add(c.Nume);
                    lvi.SubItems.Add(c.DataNasterii.ToShortDateString());
                    lvi.SubItems.Add(c.Email);
                    lvi.SubItems.Add(c.Telefon);

                    lvi.Tag = c;
                    listViewCititori.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        /////////////////////////deschidere FormGrafic/////////////////////////
        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fGrafic = new FormGrafic(this);
            fGrafic.Show();
        }

        /////////////////////////deschidere FormCarti/////////////////////////
        private void listaCartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarti fCarte = new FormCarti();
            fCarte.Text = "Lista carti";
            fCarte.ShowDialog();
        }

        /////////////////////////contextMenuStrip1/////////////////////////
        private void seteazaDataRestituiriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprumut i = (Imprumut)treeViewImprumuturi.SelectedNode.Tag; 
            treeViewImprumuturi.SelectedNode.Nodes.Add("Data restituirii: "); //trimit al treilea nod copil adaugat
            FormData fData = new FormData(i, treeViewImprumuturi.SelectedNode.Nodes[2]);

            fData.Text = "Restituire";
            fData.label2.Text = "Data restituirii";
            fData.buttonActualizeaza.Text = "Seteaza";

            fData.ShowDialog();
        }

        private void prelungesteTermenulDeRestituireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprumut i = (Imprumut)treeViewImprumuturi.SelectedNode.Tag;
            FormData fData = new FormData(i, treeViewImprumuturi.SelectedNode.Nodes[1].Nodes[1]); //trimit nodul 2 al nodului copil 2

            fData.Text = "Prelungire termen";
            fData.ShowDialog();
        }
        ////activare/dezactivare
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //sa se deschida meniul doar pt nod radacina si cele care nu au data restituirii setata
            if (treeViewImprumuturi.SelectedNode.Parent == null && treeViewImprumuturi.SelectedNode.ForeColor != Color.LightGray)
            {
                seteazaDataRestituiriiToolStripMenuItem.Enabled = true;
                prelungesteTermenulDeRestituireToolStripMenuItem.Enabled = true;
            }
            else
            {
                seteazaDataRestituiriiToolStripMenuItem.Enabled = false;
                prelungesteTermenulDeRestituireToolStripMenuItem.Enabled = false;
            }
        }

        /////////////////////////serializare/////////////////////////
        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();

                fileDialog.CheckPathExists = true;
                fileDialog.Filter = "(*.bin)|*.bin";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream binFile = File.Create(fileDialog.FileName);
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Cititor> cititori = listViewCititori.Items.Cast<ListViewItem>().Select(item => (Cititor)item.Tag).ToList();
                    bf.Serialize(binFile, cititori);

                    binFile.Close();
                    MessageBox.Show("Fisier binar generat!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /////////////////////////deserializare/////////////////////////
        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.CheckPathExists = true;
                openFile.CheckFileExists = true;
                openFile.Filter = "(*.bin)|*.bin";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Stream binFile = File.OpenRead(openFile.FileName);
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Cititor> cititori = (List<Cititor>)bf.Deserialize(binFile);

                    listViewCititori.Items.Clear();

                    foreach (Cititor c in cititori)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { c.ID.ToString(), c.Nume, c.DataNasterii.ToShortDateString(), c.Email, c.Telefon });
                        listViewCititori.Items.Add(lvi);
                    }

                    binFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /////////////////////////salvare in xml/////////////////////////
        private void salveazaImprumuturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("Lista-imprumuturi");

                for (int i = 0; i < treeViewImprumuturi.Nodes.Count; i++)
                {
                    writer.WriteStartElement("Imprumut");

                    writer.WriteElementString("Cititor", treeViewImprumuturi.Nodes[i].Text);

                    writer.WriteStartElement("Carti");
                    for (int j = 0; j < treeViewImprumuturi.Nodes[i].Nodes[0].Nodes.Count; j++)
                    {
                        writer.WriteString(treeViewImprumuturi.Nodes[i].Nodes[0].Nodes[j].Text + ",");
                    }
                    writer.WriteEndElement();

                    writer.WriteStartElement("Termen");
                    for (int j = 0; j < 2; j++)
                    {
                        writer.WriteString(treeViewImprumuturi.Nodes[i].Nodes[1].Nodes[j].Text + ",");
                    }
                    writer.WriteEndElement();

                    if (treeViewImprumuturi.Nodes[i].Nodes.Count == 3)
                        writer.WriteElementString(treeViewImprumuturi.Nodes[i].Nodes[2].Text.Substring(0, 16), treeViewImprumuturi.Nodes[i].Nodes[2].Text.Substring(18));

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                string s = Encoding.UTF8.GetString(stream.ToArray());

                stream.Close();
                stream.Dispose();

                StreamWriter streamWriter = new StreamWriter("Imprumuturi.xml");
                streamWriter.WriteLine(s);
                streamWriter.Close();

                MessageBox.Show("Fisier XML generat!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* private void afiseazaImprumuturiToolStripMenuItem_Click(object sender, EventArgs e)
         {
             treeViewImprumuturi.Nodes.Clear();
             StreamReader stream = new StreamReader("Imprumuturi.xml");
             string s = stream.ReadToEnd();

             XmlReader reader = XmlReader.Create(new StreamReader(s)); //crapa aici
             while (reader.Read())
             {
                 if (reader.Name == "Imprumut" && reader.NodeType == XmlNodeType.Element)
                 {
                     while (reader.Read() && reader.Name != "Cititor")
                     {
                         reader.Read();
                         parentNode = treeViewImprumuturi.Nodes.Add(reader.Value);
                         parentNode.Nodes.Add("Termen");
                         treeViewImprumuturi.ExpandAll();
                     }
                     while (reader.Read() && reader.Name != "Carti")
                     {
                         parentNode.Nodes.Add("Carti");
                         string[] carti = reader.Value.Split(',');
                         for (int i = 0; i < carti.Length - 1; i++)
                             parentNode.Nodes[0].Nodes.Add(carti[i]);
                     }
                 }
             }
         }*/


        /////////////////////////intoarcerea la formul de logare/////////////////////////
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////pt mine
        /* private void button1_Click(object sender, EventArgs e)
         {
             connection.Open();
             command = new SqlCommand("delete from dbo.imprumuturi", connection);
             command.ExecuteNonQuery();
             connection.Close();
         }*/
    }
}
