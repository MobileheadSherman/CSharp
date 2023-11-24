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

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class FormImprumut : Form
    {
        Cititor cititor;
        TreeView parentTv;
        Carte carte;

        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True");
        SqlCommand command;

        List<Carte> carti = new List<Carte>();
        public FormImprumut(Cititor c, TreeView t)
        {
            InitializeComponent();

            Text = "Imprumut";
            cititor = c;
            parentTv = t;
            textBoxNumeCititor.Text = c.Nume;
            
            //setez automat termenul de restituire la 14 zile de la data imprumutului (poate fi modificat ulterior)
            dateTimePickerRestituire.Value = dateTimePickerImprumut.Value.AddDays(14); 

            preluareCarti();
        }

        /////////////////////////preluare carti din BD in comboBox/////////////////////////
        void preluareCarti()
        {
            connection.Open();

            adapter = new SqlDataAdapter("select * from dbo.carti", connection);
            adapter.Fill(dataSet, "Carti");
            dataSet.Tables["Carti"].PrimaryKey = new DataColumn[1] { dataSet.Tables["Carti"].Columns["Cod_carte"] };

            connection.Close();

            comboBoxCarti.DataSource = dataSet.Tables["Carti"];
            comboBoxCarti.DisplayMember = "Titlu";
            comboBoxCarti.ValueMember = "Cod_carte";
        }

        /////////////////////////adaugare carti in lista/////////////////////////
        private void buttonAdaugaCarte_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter("select * from dbo.carti where Cod_carte =" + comboBoxCarti.SelectedValue.ToString(), connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                carte = new Carte(Convert.ToInt32(dataTable.Rows[0][0]), dataTable.Rows[0][1].ToString(), dataTable.Rows[0][2].ToString(), dataTable.Rows[0][3].ToString(), dataTable.Rows[0][4].ToString());

                //verific sa nu adauge aceeasi carte de mai multe ori
                bool exists = false;
                foreach (Carte c in carti)
                {
                    if (c.Titlu.CompareTo(carte.Titlu) == 0)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists == false)
                {
                    carti.Add(carte);
                    MessageBox.Show("Cartea '" + comboBoxCarti.Text + "' a fost adaugata cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Cartea '" + comboBoxCarti.Text + "' a fost deja adaugata!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                buttonAdaugaImprumut.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

                //ca sa nu se mai poata modifica data imprumutului
                dateTimePickerImprumut.Enabled = false;
            }
        }

        /////////////////////////INSERT imprumut in BD/////////////////////////
        private void buttonAdaugaImprumut_Click(object sender, EventArgs e)
        {
            Imprumut imprumut = new Imprumut(cititor, carti, dateTimePickerImprumut.Value, dateTimePickerRestituire.Value, false);

            foreach (Carte c in carti)
            {
                parentTv.Nodes[parentTv.Nodes.Count - 1].Nodes[0].Nodes.Add("[" + c.Cod + "] " + c.Titlu + " - " + c.Autor);
                try
                {
                    connection.Open();
                    command = new SqlCommand("insert into dbo.imprumuturi (Cod_carte, ID_cititor, Data_imprumut, Termen_restituire, Depasire_termen) values (@Cod_carte, @ID_cititor, @Data_imprumut, @Termen_restituire, @Depasire_termen)", connection);

                    command.Parameters.AddWithValue("@ID_cititor", cititor.ID);
                    command.Parameters.AddWithValue("@Cod_carte", c.Cod);
                    command.Parameters.AddWithValue("@Data_imprumut", imprumut.DataImprumut);
                    command.Parameters.AddWithValue("@Termen_restituire", imprumut.TermenRestituire);
                    command.Parameters.AddWithValue("@Depasire_termen", imprumut.DepasireTermen);

                    command.ExecuteNonQuery();
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

            //adaugare noduri copii la nodul radacina nou creat
            parentTv.Nodes[parentTv.Nodes.Count - 1].Nodes[1].Nodes.Add("Data imprumut: " + dateTimePickerImprumut.Value.ToShortDateString());
            parentTv.Nodes[parentTv.Nodes.Count - 1].Nodes[1].Nodes.Add("Termen restituire: " + dateTimePickerRestituire.Value.ToShortDateString());

            parentTv.Nodes[parentTv.Nodes.Count - 1].Tag = imprumut; //pun info despre fiecare imp in tag

            parentTv.Nodes[parentTv.Nodes.Count - 1].Expand();
            parentTv.Nodes[parentTv.Nodes.Count - 1].Nodes[0].Expand();
            parentTv.Nodes[parentTv.Nodes.Count - 1].Nodes[1].Expand();

            DialogResult = DialogResult.OK; //sa se inchida formularul
        }

        /////////////////////////modificare termen automata in functie de data imprumut/////////////////////////
        private void dateTimePickerImprumut_ValueChanged(object sender, EventArgs e)
        {
            //adaug termenul de restituire automat, atunci cand schimb data imprumutului
            dateTimePickerRestituire.Value = dateTimePickerImprumut.Value.AddDays(14);
        }

        /////////////////////////eliminare nod radacina creat/////////////////////////
        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            parentTv.Nodes[parentTv.Nodes.Count - 1].Remove();
        }

        /////////////////////////validare/////////////////////////
        private void dateTimePickerImprumut_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerImprumut.Value > DateTime.Now)
            {
                errorProvider1.SetError(dateTimePickerImprumut, "Nu se pot introduce date din viitor!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dateTimePickerImprumut, "");
        }
    }
}
