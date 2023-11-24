
namespace Proiect_ImprumuturiBiblioteca
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaImprumuturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCititori = new System.Windows.Forms.Label();
            this.listViewCititori = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeViewImprumuturi = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seteazaDataRestituiriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prelungesteTermenulDeRestituireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAfisCititori = new System.Windows.Forms.Button();
            this.buttonGrafic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.adaugaToolStripMenuItem,
            this.listaCartiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.deschideToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaImprumuturiToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // salveazaImprumuturiToolStripMenuItem
            // 
            this.salveazaImprumuturiToolStripMenuItem.Name = "salveazaImprumuturiToolStripMenuItem";
            this.salveazaImprumuturiToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.salveazaImprumuturiToolStripMenuItem.Text = "Salveaza imprumuturi";
            this.salveazaImprumuturiToolStripMenuItem.Click += new System.EventHandler(this.salveazaImprumuturiToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.adaugaToolStripMenuItem.Text = "Adauga cititor";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // listaCartiToolStripMenuItem
            // 
            this.listaCartiToolStripMenuItem.Name = "listaCartiToolStripMenuItem";
            this.listaCartiToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.listaCartiToolStripMenuItem.Text = "&Carti";
            this.listaCartiToolStripMenuItem.Click += new System.EventHandler(this.listaCartiToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(68, 30);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.Bisque;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(151, 64);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // labelCititori
            // 
            this.labelCititori.AutoSize = true;
            this.labelCititori.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCititori.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelCititori.Location = new System.Drawing.Point(343, 43);
            this.labelCititori.Name = "labelCititori";
            this.labelCititori.Size = new System.Drawing.Size(70, 24);
            this.labelCititori.TabIndex = 3;
            this.labelCititori.Text = "Cititori";
            // 
            // listViewCititori
            // 
            this.listViewCititori.BackColor = System.Drawing.Color.Snow;
            this.listViewCititori.CheckBoxes = true;
            this.listViewCititori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNume,
            this.columnHeaderDataN,
            this.columnHeaderEmail,
            this.columnHeaderTel});
            this.listViewCititori.ContextMenuStrip = this.contextMenuStrip2;
            this.listViewCititori.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCititori.FullRowSelect = true;
            this.listViewCititori.GridLines = true;
            this.listViewCititori.HideSelection = false;
            this.listViewCititori.Location = new System.Drawing.Point(12, 70);
            this.listViewCititori.Name = "listViewCititori";
            this.listViewCititori.Size = new System.Drawing.Size(785, 551);
            this.listViewCititori.TabIndex = 4;
            this.listViewCititori.UseCompatibleStateImageBehavior = false;
            this.listViewCititori.View = System.Windows.Forms.View.Details;
            this.listViewCititori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewCititori_MouseDown);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 127;
            // 
            // columnHeaderDataN
            // 
            this.columnHeaderDataN.Text = "Data nasterii";
            this.columnHeaderDataN.Width = 79;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 146;
            // 
            // columnHeaderTel
            // 
            this.columnHeaderTel.Text = "Telefon";
            this.columnHeaderTel.Width = 103;
            // 
            // treeViewImprumuturi
            // 
            this.treeViewImprumuturi.AllowDrop = true;
            this.treeViewImprumuturi.BackColor = System.Drawing.Color.Snow;
            this.treeViewImprumuturi.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewImprumuturi.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewImprumuturi.Location = new System.Drawing.Point(846, 70);
            this.treeViewImprumuturi.Name = "treeViewImprumuturi";
            this.treeViewImprumuturi.Size = new System.Drawing.Size(458, 551);
            this.treeViewImprumuturi.TabIndex = 5;
            this.treeViewImprumuturi.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewImprumuturi_DragDrop);
            this.treeViewImprumuturi.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewImprumuturi_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seteazaDataRestituiriiToolStripMenuItem,
            this.prelungesteTermenulDeRestituireToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(347, 64);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // seteazaDataRestituiriiToolStripMenuItem
            // 
            this.seteazaDataRestituiriiToolStripMenuItem.Name = "seteazaDataRestituiriiToolStripMenuItem";
            this.seteazaDataRestituiriiToolStripMenuItem.Size = new System.Drawing.Size(346, 30);
            this.seteazaDataRestituiriiToolStripMenuItem.Text = "Seteaza data restituirii";
            this.seteazaDataRestituiriiToolStripMenuItem.Click += new System.EventHandler(this.seteazaDataRestituiriiToolStripMenuItem_Click);
            // 
            // prelungesteTermenulDeRestituireToolStripMenuItem
            // 
            this.prelungesteTermenulDeRestituireToolStripMenuItem.Name = "prelungesteTermenulDeRestituireToolStripMenuItem";
            this.prelungesteTermenulDeRestituireToolStripMenuItem.Size = new System.Drawing.Size(346, 30);
            this.prelungesteTermenulDeRestituireToolStripMenuItem.Text = "Prelungeste termenul de restituire";
            this.prelungesteTermenulDeRestituireToolStripMenuItem.Click += new System.EventHandler(this.prelungesteTermenulDeRestituireToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(1007, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Imprumuturi";
            // 
            // buttonAfisCititori
            // 
            this.buttonAfisCititori.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAfisCititori.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisCititori.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAfisCititori.Location = new System.Drawing.Point(12, 627);
            this.buttonAfisCititori.Name = "buttonAfisCititori";
            this.buttonAfisCititori.Size = new System.Drawing.Size(156, 44);
            this.buttonAfisCititori.TabIndex = 9;
            this.buttonAfisCititori.Text = "&Afiseaza cititori";
            this.buttonAfisCititori.UseVisualStyleBackColor = false;
            this.buttonAfisCititori.Click += new System.EventHandler(this.buttonAfisCititori_Click);
            // 
            // buttonGrafic
            // 
            this.buttonGrafic.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonGrafic.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafic.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonGrafic.Location = new System.Drawing.Point(1148, 627);
            this.buttonGrafic.Name = "buttonGrafic";
            this.buttonGrafic.Size = new System.Drawing.Size(156, 44);
            this.buttonGrafic.TabIndex = 10;
            this.buttonGrafic.Text = "&Grafic";
            this.buttonGrafic.UseVisualStyleBackColor = false;
            this.buttonGrafic.Click += new System.EventHandler(this.buttonGrafic_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1554, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "DON\'T CLICK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(1414, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Legenda culori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(1348, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Light Gray";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1441, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "-  Imprumuturile finalizate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(1348, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1441, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "-  Incadrare in termen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1348, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Red";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1441, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "-  Depasire termen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1700, 679);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGrafic);
            this.Controls.Add(this.buttonAfisCititori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewImprumuturi);
            this.Controls.Add(this.listViewCititori);
            this.Controls.Add(this.labelCititori);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Label labelCititori;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderDataN;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderTel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewCititori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.Button buttonAfisCititori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seteazaDataRestituiriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prelungesteTermenulDeRestituireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaImprumuturiToolStripMenuItem;
        public System.Windows.Forms.TreeView treeViewImprumuturi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGrafic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

