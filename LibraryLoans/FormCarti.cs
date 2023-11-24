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

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class FormCarti : Form
    {
        Carte c;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True");
        SqlCommand command;
        DataTable dataTable;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public FormCarti()
        {
            InitializeComponent();
        }

        /////////////////////////INSERT/UPDATE/////////////////////////
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command;

                //inserare in baza de date (INSERT)
                if (buttonAdauga.Text == "&Adauga")
                {
                    command = new SqlCommand("insert into dbo.carti (Titlu, Autor, Editura, Categorie) values (@Titlu, @Autor, @Editura, @Categorie)", connection);

                    command.Parameters.AddWithValue("@Titlu", textBoxTitlu.Text);
                    command.Parameters.AddWithValue("@Autor", textBoxAutor.Text);
                    command.Parameters.AddWithValue("@Editura", comboBoxEditura.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Categorie", comboBoxCategoria.SelectedItem.ToString());

                    command.ExecuteNonQuery();

                    MessageBox.Show("Cartea s-a adaugat cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //actualizarea datelor in baza de date (UPDATE)
                else
                {
                    command = new SqlCommand("update dbo.carti set Titlu=@Titlu, Autor=@Autor, Editura=@Editura, Categorie=@Categorie where Cod_carte=@Cod_carte", connection);

                    command.Parameters.AddWithValue("@Titlu", textBoxTitlu.Text);
                    command.Parameters.AddWithValue("@Autor", textBoxAutor.Text);
                    command.Parameters.AddWithValue("@Editura", comboBoxEditura.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Categorie", comboBoxCategoria.SelectedItem.ToString());

                    c = (Carte)listViewCarti.SelectedItems[0].Tag;
                    int Cod_carte = c.Cod;
                    command.Parameters.AddWithValue("@Cod_carte", Cod_carte);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Detaliile cartii s-au actualizat cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAdauga.Text = "&Adauga";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                textBoxTitlu.Text = "";
                textBoxAutor.Text = "";
                comboBoxEditura.Text = "";
                comboBoxCategoria.Text = "";
            }
            buttonAfisCarti_Click_1(sender, e);
        }

        /////////////////////////afisarea cartilor din DB in listview (SELECT)/////////////////////////
        private void buttonAfisCarti_Click_1(object sender, EventArgs e)
        {
            listViewCarti.Items.Clear();
            try
            {
                connection.Open();
                command = new SqlCommand("select * from dbo.carti", connection);
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Carti");
                dataSet.Tables["Carti"].PrimaryKey = new DataColumn[1] { dataSet.Tables["Carti"].Columns["Cod_carte"] };

                dataTable = dataSet.Tables["Carti"];
                List<Carte> carti = new List<Carte>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    carti.Add(new Carte(Convert.ToInt32(dataTable.Rows[i].ItemArray[0]), dataTable.Rows[i].ItemArray[1].ToString(), dataTable.Rows[i].ItemArray[2].ToString(), dataTable.Rows[i].ItemArray[3].ToString(), dataTable.Rows[i].ItemArray[4].ToString()));
                }

                foreach (Carte c in carti)
                {
                    ListViewItem lvi = new ListViewItem(c.Cod.ToString());
                    lvi.SubItems.Add(c.Titlu);
                    lvi.SubItems.Add(c.Autor);
                    lvi.SubItems.Add(c.Editura);
                    lvi.SubItems.Add(c.Categorie);

                    lvi.Tag = c;
                    listViewCarti.Items.Add(lvi);
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

        /////////////////////////editare date/////////////////////////
        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preluareDate();
            buttonAdauga.Text = "&Salveaza";
        }

        /////////////////////////stergerea din BD (DELETE)/////////////////////////
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewCarti.CheckedItems.Count == 1)
            {
                c = (Carte)listViewCarti.CheckedItems[0].Tag;
                DialogResult confirmare = MessageBox.Show("Sigur doriti sa stergeti cartea '" + c.Titlu + "'?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmare == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("delete from dbo.carti where Cod_carte=" + c.Cod, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    buttonAfisCarti_Click_1(sender, e);

                }
            }
            else
                if (listViewCarti.CheckedItems.Count > 1)
                {
                    DialogResult confirmare = MessageBox.Show("Sigur doriti sa stergeti cele " + listViewCarti.CheckedItems.Count + " carti?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmare == DialogResult.Yes)
                    {
                        connection.Open();

                        for (int i = 0; i < listViewCarti.Items.Count; i++)
                        {
                            if (listViewCarti.Items[i].Checked)
                            {
                                command = new SqlCommand("delete from dbo.carti where Cod_carte=@Cod_carte", connection);
                                int Cod_carte = Convert.ToInt32(listViewCarti.Items[i].SubItems[0].Text);
                                command.Parameters.AddWithValue("@Cod_carte", Cod_carte);
                                command.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                        buttonAfisCarti_Click_1(sender, e);
                    }
                }
        }

        /////////////////////////preluarea datelor din Form1/////////////////////////
        public void preluareDate()
        {
            c = (Carte)listViewCarti.SelectedItems[0].Tag;
            textBoxTitlu.Text = c.Titlu;
            textBoxAutor.Text = c.Autor;
            comboBoxEditura.Text = c.Editura;
            comboBoxCategoria.Text = c.Categorie;
        }

        /////////////////////////validarea datelor intorduse/////////////////////////
        //pot inchide chiar daca nu am completat nimic --> (CausesValidation pe False)
        private void textBoxTitlu_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTitlu.Text == "")
            {
                errorProvider1.SetError(textBoxTitlu, "Introduceti un titlu!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxTitlu, "");
        }

        private void textBoxAutor_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAutor.Text == "")
            {
                errorProvider1.SetError(textBoxAutor, "Introduceti un autor!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxAutor, "");
        }
        //numele autorului sa contina doar spatii, litere, . sau -
        private void textBoxAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || e.KeyChar == '.' || e.KeyChar == '-')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void comboBoxEditura_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxEditura.Text == "")
            {
                errorProvider1.SetError(comboBoxEditura, "Alegeti o editura!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(comboBoxEditura, "");
        }

        private void comboBoxCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCategoria.Text == "")
            {
                errorProvider1.SetError(comboBoxCategoria, "Alegeti o categorie!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(comboBoxCategoria, "");
        }

        /////////////////////////dezactivarea/activarea controalelor/////////////////////////
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewCarti.SelectedItems.Count == 1)
            {
                editeazaToolStripMenuItem.Enabled = true;
            }
            else
            {
                editeazaToolStripMenuItem.Enabled = false;
            }

            if (listViewCarti.CheckedItems.Count > 0)
            {
                stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        /////////////////////////salvare in fisier text/////////////////////////
        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.CheckPathExists = true;
                saveFile.Filter = "(*.txt)|*.txt";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);

                    foreach (ListViewItem item in listViewCarti.Items)
                    {
                        writer.WriteLine(item.SubItems[0].Text + ";" + item.SubItems[1].Text + ";" + item.SubItems[2].Text + ";" + item.SubItems[3].Text + ";" + item.SubItems[4].Text);
                    }

                    MessageBox.Show("Fisier text generat!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writer.Close();
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /////////////////////////citire din fisier text/////////////////////////
        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.CheckPathExists = true;
                openFile.CheckFileExists = true;
                openFile.Filter = "(*.txt)|*.txt";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);

                    listViewCarti.Items.Clear();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] vectorLine = line.Split(new char[1] { ';' });
                        ListViewItem item = new ListViewItem(vectorLine[0]);
                        item.SubItems.Add(vectorLine[1]);
                        item.SubItems.Add(vectorLine[2]);
                        item.SubItems.Add(vectorLine[3]);
                        item.SubItems.Add(vectorLine[4]);

                        listViewCarti.Items.Add(item);
                    }
                    reader.Close();
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
