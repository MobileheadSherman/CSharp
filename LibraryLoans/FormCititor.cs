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
using System.Text.RegularExpressions;

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class FormCititor : Form
    {
        Regex regex;

        Cititor c;
        Form1 parent;
        string connectionStr = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True";
        public FormCititor(Form1 f1)
        {
            InitializeComponent();
            parent = f1;
        }

        /////////////////////////inserare/actualizare in baza de date (INSERT)/////////////////////////
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            try
            {
                connection.Open();
                SqlCommand command;
                if (buttonAdauga.Text == "&Adauga")
                {
                    command = new SqlCommand("insert into dbo.cititori (Nume, Data_nasterii, Email, Telefon) values (@Nume, @Data_nasterii, @Email, @Telefon)", connection);

                    command.Parameters.AddWithValue("@Nume", textBoxNume.Text);
                    command.Parameters.AddWithValue("@Data_nasterii", dateTimePickerDataN.Value);
                    command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Cititorul a fost adaugat cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    command = new SqlCommand("update dbo.cititori set Nume=@Nume, Data_nasterii=@Data_nasterii, Email=@Email, Telefon=@Telefon where ID=@ID", connection);

                    command.Parameters.AddWithValue("@Nume", textBoxNume.Text);
                    command.Parameters.AddWithValue("@Data_nasterii", dateTimePickerDataN.Value);
                    command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);

                    c = (Cititor)parent.listViewCititori.SelectedItems[0].Tag;
                    int ID = c.ID;
                    command.Parameters.AddWithValue("@ID", ID);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Detaliile cititorului s-au actualizat cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                textBoxNume.Text = "";
                dateTimePickerDataN.Value = DateTime.Now;
                textBoxEmail.Text = "";
                textBoxTelefon.Text = "";
            }
            parent.buttonAfisCititori_Click(sender, e);
        }

        /////////////////////////preluarea valorilor din Form1/////////////////////////
        public void preluareDate()
        {
            c = (Cititor)parent.listViewCititori.SelectedItems[0].Tag;
            textBoxNume.Text = c.Nume;
            textBoxEmail.Text = c.Email;
            textBoxTelefon.Text = c.Telefon;
            dateTimePickerDataN.Value = c.DataNasterii;
        }

        /////////////////////////validari valori introduse/////////////////////////
        private void textBoxNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || e.KeyChar == '-')
                e.Handled = false;
            else
            {
                e.Handled = true;
            }
        }

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

        private void dateTimePickerDataN_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerDataN.Value.Year > 2011)
            {
                errorProvider1.SetError(dateTimePickerDataN, "Varsta minima este de 10 ani!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dateTimePickerDataN, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            regex = new Regex(@"^([A-Za-z0-9._]+)@([A-Za-z0-9.]+)\.(com|ro)$");
            if (textBoxEmail.Text == "")
            {
                errorProvider1.SetError(textBoxEmail, "Introduceti emailul!");
                e.Cancel = true;
            }
            else
                if (regex.IsMatch(textBoxEmail.Text) == false)
                {
                    errorProvider1.SetError(textBoxEmail, "Introduceti o adresa de email in formatul standard!(ex: exemplu@adresa.com/ro)");
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(textBoxEmail, "");
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            regex = new Regex("^07[0-9]{2}.[0-9]{3}.[0-9]{3}$");
            if (textBoxTelefon.Text == "")
            {
                errorProvider1.SetError(textBoxTelefon, "Introduceti numarul de telefon!");
                e.Cancel = true;
            }
            else
                if (regex.IsMatch(textBoxTelefon.Text) == false)
                {
                    errorProvider1.SetError(textBoxTelefon, "Introduceti un numar de telefon de forma 07xx.xxx.xxx!");
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(textBoxTelefon, "");
        }

    }
}
