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
    public partial class FormData : Form
    {
        Imprumut f1Imp;
        TreeNode f1Node;

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True");

        public FormData(Imprumut i, TreeNode node)
        {
            InitializeComponent();
            f1Imp = i;
            f1Node = node;
            
            //preiau termenul de restituire in picker
            dateTimePicker2.Value = i.TermenRestituire;
            
        }

        /////////////////////////UPDATE/////////////////////////
        private void buttonActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command;
                //finalizare imprumut
                if (buttonActualizeaza.Text == "Seteaza")
                {
                    command = new SqlCommand("update dbo.imprumuturi set Data_restituire=@Data_restituire where ID_cititor=@ID_cititor and Data_imprumut=@Data_imprumut", connection);

                    command.Parameters.AddWithValue("@Data_restituire", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ID_cititor", f1Imp.Cititor.ID);
                    command.Parameters.AddWithValue("@Data_imprumut", f1Imp.DataImprumut.ToShortDateString());

                    command.ExecuteNonQuery();

                    //actualizez si in obiectul de tip Imprumut
                    f1Imp.DataRestituire = dateTimePicker2.Value;
                    f1Node.Text += dateTimePicker2.Value.ToShortDateString();

                    //stabilesc si daca a fost depasit termenul de restituire
                    if (dateTimePicker2.Value > f1Imp.TermenRestituire)
                    {
                        f1Node.ForeColor = Color.Red; //marchez faptul ca a depasit termenul
                        f1Imp.DepasireTermen = true;
                        command = new SqlCommand("update dbo.imprumuturi set Depasire_termen=@Depasire_termen where ID_cititor=@ID_cititor and Data_imprumut=@Data_imprumut", connection);

                        command.Parameters.AddWithValue("@Depasire_termen", f1Imp.DepasireTermen);
                        command.Parameters.AddWithValue("@ID_cititor", f1Imp.Cititor.ID);
                        command.Parameters.AddWithValue("@Data_imprumut", f1Imp.DataImprumut.ToShortDateString());

                        command.ExecuteNonQuery();
                    }
                    else
                        f1Node.ForeColor = Color.Green; //marchez faptul ca nu a depasit termenul

                    //marchez imprumutul ca fiind finalizat
                    f1Node.Parent.ForeColor = Color.LightGray;

                    MessageBox.Show("Data restituirii a fost setata!","Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                //prelungire imprumut
                else
                {
                    command = new SqlCommand("update dbo.imprumuturi set Termen_restituire=@Termen_restituire where ID_cititor=@ID_cititor and Data_imprumut=@Data_imprumut", connection);

                    command.Parameters.AddWithValue("@Termen_restituire", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ID_cititor", f1Imp.Cititor.ID);
                    command.Parameters.AddWithValue("@Data_imprumut", f1Imp.DataImprumut.ToShortDateString());

                    command.ExecuteNonQuery();

                    //actualizez si in obiectul de tip Imprumut
                    f1Imp.TermenRestituire = dateTimePicker2.Value;
                    f1Node.Text = "Termen restituire: " + dateTimePicker2.Value.ToShortDateString();

                    MessageBox.Show("Termenul a fost prelungit!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
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

        /////////////////////////validare date/////////////////////////
        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (buttonActualizeaza.Text == "Seteaza")
                if (dateTimePicker2.Value <= f1Imp.DataImprumut)
                {
                    errorProvider1.SetError(dateTimePicker2, "Returnarea se poate face doar de a doua zi!");
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(dateTimePicker2, "");
            else
                // daca data de prelungire este mai mica decat termenul de restituire sau
                // daca data de prelungire este mai mare de 14 zile fata de termenul de restituire initial
                if (dateTimePicker2.Value < f1Imp.TermenRestituire || f1Imp.TermenRestituire.AddDays(14) < dateTimePicker2.Value)
                {
                    errorProvider1.SetError(dateTimePicker2, "Prelungirea trebuie sa fie cu maxim 14 zile mai mare fata de termenul initial!");
                    e.Cancel = true;
                }
            else
                errorProvider1.SetError(dateTimePicker2, "");
        }

        /////////////////////////eliminarea nodului creat/////////////////////////
        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            if (buttonActualizeaza.Text == "Seteaza")
            {
                f1Node.Remove();
            }
        }
    }
}
