using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class FormConectare : Form
    {
        public FormConectare()
        {
            InitializeComponent();
            Text = "Conectare admin";
            loginUserControl1.ConnString = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB-ProiectPAW;Integrated Security=True";
            loginUserControl1.Tabela = "dbo.administratori";

            //TODO: sa dispara formularul de conectare
            /*if (loginUserControl1.HideForm == true)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }*/
        }
    }
}
