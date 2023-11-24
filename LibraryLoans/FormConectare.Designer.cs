
namespace Proiect_ImprumuturiBiblioteca
{
    partial class FormConectare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConectare));
            this.loginUserControl1 = new Proiect_ImprumuturiBiblioteca.LoginUserControl();
            this.SuspendLayout();
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.BackColor = System.Drawing.Color.Linen;
            this.loginUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUserControl1.Location = new System.Drawing.Point(0, 0);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(474, 302);
            this.loginUserControl1.TabIndex = 0;
            // 
            // FormConectare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 302);
            this.Controls.Add(this.loginUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConectare";
            this.Text = "FormConectare";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginUserControl loginUserControl1;
    }
}