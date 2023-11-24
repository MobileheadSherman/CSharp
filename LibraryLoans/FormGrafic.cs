using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ImprumuturiBiblioteca
{
    public partial class FormGrafic : Form
    {
        Form1 form1;
        Cititor c;
        TreeView tv;
        ListView lv;

        int[] nrCarti;
        int nrCititori;

        Color culoare = Color.BlueViolet;
        Font font = new Font(FontFamily.GenericSansSerif, 8);
        public FormGrafic(Form1 f)
        {
            InitializeComponent();

            form1 = f;
            tv = form1.treeViewImprumuturi;
            lv = form1.listViewCititori;
            nrCititori = lv.Items.Count;
            nrCarti = new int[lv.Items.Count];

            for (int i = 0; i < nrCititori; i++) //pentru fiecare cititor din listView
            {
                nrCarti[i] = 0;
                c = (Cititor)lv.Items[i].Tag;
                for (int j = 0; j < tv.Nodes.Count; j++) //il compar cu fiecare imprumut, poate apare de mai multe ori
                {
                    if (c.Nume.CompareTo(tv.Nodes[j].Text.Split(' ')[1] + " " + tv.Nodes[j].Text.Split(' ')[2]) == 0)
                        nrCarti[i] += tv.Nodes[j].Nodes[0].Nodes.Count; //adun numarul de carti din fiecare imprumut efectuat de fiecare cititor
                }
                //nrCarti[i] *= 100;
            }
        }

        /////////////////////////desenare grafic/////////////////////////
        Graphics g;
        Rectangle rectangle;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);

            rectangle = e.ClipRectangle;
            SolidBrush brush = new SolidBrush(culoare);

            rectangle.X += 20;
            rectangle.Y += 20;
            rectangle.Width -= 40;
            rectangle.Height -= 50;

            g.DrawString("Numarul de carti imprumutate de fiecare cititor", new Font("Tw Cen MT", 10, FontStyle.Bold), new SolidBrush(Color.Black), new PointF((rectangle.Right - rectangle.Left) / 2, rectangle.Top - 20));

            //trasare axe
            g.DrawLine(pen, rectangle.Left, rectangle.Bottom, rectangle.Right, rectangle.Bottom); //Ox
            g.DrawLine(pen, rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Bottom); //Oy

            int latime = (rectangle.Right - rectangle.Left) / (int)((nrCititori + 1) * 0.2f + nrCititori); 
            int distanta = (int)(latime * 0.2f);
            int maxim = nrCarti.Max();

            for (int i = 0; i < nrCititori; i++)
            {
                PointF point = new PointF(rectangle.Left + distanta + i * (latime + distanta), rectangle.Bottom - nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim);
                SizeF size = new SizeF(latime, nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim);
                g.FillRectangle(brush, new RectangleF(point, size));

                c = (Cititor)lv.Items[i].Tag;
                g.DrawString((nrCarti[i]).ToString(), font, brush, rectangle.Left - 20, rectangle.Bottom - nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim - 5);
                g.DrawString(c.Nume.Split(' ')[1] + "\n[" + c.ID + "]", font, brush, rectangle.Left + distanta + i * (distanta + latime) + latime / 30, rectangle.Bottom + 5);//TODO
            }

        }

        /////////////////////////redimensionare dupa dim formului/////////////////////////
        private void FormGrafic_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        /////////////////////////schimbare font/////////////////////////
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                font = dialog.Font;
            panel1.Invalidate();
        }

        /////////////////////////salvare grafic ca imagine/////////////////////////
        private void save(Control control, string fileName)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(control.ClientRectangle.X, control.ClientRectangle.Y, control.ClientRectangle.Width, control.ClientRectangle.Height));
            bitmap.Save(fileName);
            bitmap.Dispose();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.CheckPathExists = true;
            dialog.Filter = "(*.bmp)|.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                save(panel1, dialog.FileName);
                MessageBox.Show("Grafic salvat!");
            }
        }

        /////////////////////////schimbare culoare grafic/////////////////////////
        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                culoare = dialog.Color;
            panel1.Invalidate(); // ca sa se schimbe 
        }

        /////////////////////////schimbare fundal/////////////////////////
        private void fundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = dialog.Color;
                panel1.Invalidate();
            }
        }

        /////////////////////////printare grafic/////////////////////////
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            g = e.Graphics;

            Pen pen = new Pen(Color.Black, 3);

            rectangle = new Rectangle(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height);
            SolidBrush brush = new SolidBrush(culoare);

            rectangle.X += 20;
            rectangle.Y += 20;
            rectangle.Width -= 40;
            rectangle.Height -= 50;

            g.DrawString("Numarul de carti imprumutate de fiecare cititor", new Font("Tw Cen MT", 10, FontStyle.Bold), new SolidBrush(Color.Black), new PointF((rectangle.Right - rectangle.Left) / 2, rectangle.Top - 20));

            //trasare axe
            g.DrawLine(pen, rectangle.Left, rectangle.Bottom, rectangle.Right, rectangle.Bottom);
            g.DrawLine(pen, rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Bottom);

            int latime = (rectangle.Right - rectangle.Left) / (int)((nrCititori + 1) * 0.2f + nrCititori);
            int distanta = (int)(latime * 0.2f);
            int maxim = nrCarti.Max();

            for (int i = 0; i < nrCititori; i++)
            {
                PointF point = new PointF(rectangle.Left + distanta + i * (latime + distanta), rectangle.Bottom - nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim);
                SizeF size = new SizeF(latime, nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim);
                g.FillRectangle(brush, new RectangleF(point, size));

                c = (Cititor)lv.Items[i].Tag;
                g.DrawString((nrCarti[i] / 100).ToString(), font, brush, rectangle.Left - 20, rectangle.Bottom - nrCarti[i] * (rectangle.Bottom - rectangle.Top) / maxim - 5);
                g.DrawString(c.Nume.Split(' ')[1] + "\n[" + c.ID + "]", font, brush, rectangle.Left + distanta + i * (distanta + latime) + latime / 20, rectangle.Bottom + 5);
            }
        }

        private void printeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = true; //orientez pagina de printare pe landscape
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDoc;
            printPreview.ShowDialog();
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
