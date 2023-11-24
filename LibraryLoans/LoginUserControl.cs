using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class LoginUserControl : UserControl
    {
        private string tabela = null; //numele tabelei pe care se va executa comanda sql
        private string connString = null; //conexiunea bazei de date
        // private bool hideForm = false;
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public string Tabela
        {
            set { if (value != null) tabela = value; }
        }
        public string ConnString
        {
            set { if (value != null) connString = value; }
        }
        /*public bool HideForm
        {
            get { return hideForm; }
            set { hideForm = value; }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command;
            try
            {
                connection.Open();
                command = new SqlCommand("select count(*) from " + tabela + " where Nume=@Nume and Parola=@Parola", connection);

                command.Parameters.AddWithValue("@Nume", textBoxNume.Text);
                command.Parameters.AddWithValue("@Parola", textBoxParola.Text);

                int nr = Convert.ToInt32(command.ExecuteScalar());

                if (nr > 0)
                {
                    //this.hideForm = true;
                    MessageBox.Show("Bine ai (re)venit, " + textBoxNume.Text + "!", "Conectare reusita", MessageBoxButtons.OK);
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Numele sau parola sunt incorecte!", "Conectare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNume.Clear();
                    textBoxParola.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /////////////////////////validari/////////////////////////
        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNume.Text == "")
            {
                errorProvider1.SetError(textBoxNume, "Introduceti numele!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxNume, "");
        }

        private void textBoxParola_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxParola.Text == "")
            {
                errorProvider1.SetError(textBoxParola, "Introduceti parola!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxParola, "");
        }
    }
}
