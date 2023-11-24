
namespace Proiect_ImprumuturiBiblioteca
{
    partial class FormCarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarti));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.comboBoxEditura = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonInchide = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAfisCarti = new System.Windows.Forms.Button();
            this.listViewCarti = new System.Windows.Forms.ListView();
            this.columnHeaderCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEditura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(962, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(962, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(962, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(962, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.BackColor = System.Drawing.Color.Snow;
            this.textBoxTitlu.Location = new System.Drawing.Point(1070, 70);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(169, 26);
            this.textBoxTitlu.TabIndex = 6;
            this.textBoxTitlu.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitlu_Validating);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.Color.Snow;
            this.textBoxAutor.Location = new System.Drawing.Point(1070, 108);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(169, 26);
            this.textBoxAutor.TabIndex = 7;
            this.textBoxAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAutor_KeyPress);
            this.textBoxAutor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAutor_Validating);
            // 
            // comboBoxEditura
            // 
            this.comboBoxEditura.BackColor = System.Drawing.Color.Snow;
            this.comboBoxEditura.FormattingEnabled = true;
            this.comboBoxEditura.Items.AddRange(new object[] {
            "Academiei Române",
            "Accent",
            "Adevărul Holding",
            "Albatros",
            "Aldine",
            "ALL",
            "ALLFA",
            "Altius Media",
            "Ambra",
            "Andreiana",
            "Arania",
            "Ars Libri",
            "Art",
            "Artemis",
            "Arthur",
            "Booklet",
            "Canonica",
            "Cartea de Nisip",
            "Cartea Universitară",
            "Casa Cărții de Știință",
            "Călin",
            "Ceres",
            "Codecs",
            "Compania ",
            "Corint",
            "Curtea Veche",
            "Cartea Daath",
            "Cartea Românească Educațional",
            "Dacia",
            "Didactică și Pedagogică",
            "Eagle",
            "Economică",
            "Edago",
            "Egmont",
            "Erc Press",
            "Etnous",
            "Facla",
            "Fundației Culturale Române",
            "Gama",
            "Ganesha",
            "Garamond",
            "Muzicală Grafoart",
            "Gramar",
            "Hamangiu",
            "Hasefer",
            "Historia",
            "Hoffman",
            "Humanitas",
            "IDEA",
            "Istros a Muzeului Brăilei",
            "Infarom",
            "Kriterion",
            "Litera",
            "Lucman",
            "Levant ",
            "Casa de Editură Max Blecher",
            "Mașina de scris",
            "Mediamorphosis",
            "Meridiane",
            "Meronia",
            "Minerva",
            "Militară",
            "Miracol",
            "Mușatinia din Roman",
            "MyBestseller",
            "Națiunea",
            "Nemira",
            "Niculescu",
            "Noapte Alba",
            "Nomina",
            "Nouă",
            "Napoca Nova",
            "Paralela 45",
            "PIM ",
            "Polirom ",
            "Politehnica Press ",
            "„Politehnica” ",
            "Politică",
            "Publica",
            "Pygmalion",
            "Rao",
            "Ramida",
            "Recif",
            "Ratio et Revelatio",
            "România Rațională",
            "Salco",
            "Sebastian Publishing House",
            "Scrisul Românesc",
            "Seven Stars",
            "Sfântul Ierarh Nicolae ",
            "Sfântul Ioan",
            "Socec ",
            "Sport Turism",
            "Științifică",
            "Științifică și Enciclopedică",
            "Tact",
            "Teora",
            "Tehnică",
            "Tineretului",
            "Tracus Arte",
            "Trei",
            "Tritonic",
            "Triskelion",
            "Uniunii Scriitorilor",
            "Univers Enciclopedic",
            "Universității din București",
            "Unirea",
            "Universitară",
            "Valdo",
            "Victor Babeș Timișoara",
            "Viață și Sănătate",
            "Vinea",
            "Virtuală",
            "Vivaldi",
            "Vremea"});
            this.comboBoxEditura.Location = new System.Drawing.Point(1070, 146);
            this.comboBoxEditura.Name = "comboBoxEditura";
            this.comboBoxEditura.Size = new System.Drawing.Size(169, 28);
            this.comboBoxEditura.TabIndex = 8;
            this.comboBoxEditura.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEditura_Validating);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.BackColor = System.Drawing.Color.Snow;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Agricultura / Pomicultura / Zootehnie",
            "Antropologie",
            "Arta",
            "Asistenta Sociala",
            "Atlas",
            "Audiobooks",
            "Bibliografie Scolara",
            "Carti Cadou pentru Toti",
            "Carti in Limba Engleza",
            "Carti pentru copii",
            "Comunicare",
            "Cresterea / Sanatatea / Alimentatia copilului",
            "Cursuri limbi straine",
            "Dictionare",
            "Diverse",
            "Documentare",
            "Drept",
            "Economie",
            "Enciclopedii",
            "Etnografie/ Civilizatie/ Mitologie",
            "Examene Cambridge",
            "Ezoterism / Mistere / Paranormal",
            "Filosofie",
            "Geografie / Turism",
            "Ghiduri de calatorie",
            "Informatica",
            "Instrumente de scris",
            "Invatamant - Educatie",
            "Istorie",
            "Jucarii",
            "Lingvistica / Filologie",
            "Literatura Romana",
            "Literatura Straina",
            "Management",
            "Manuale Scolare",
            "Marketing",
            "Media",
            "Medicina",
            "Medicina traditionala si naturista",
            "Metodica",
            "Mistere/ Paranormal",
            "Motivationale/ Dezvoltare personala",
            "Politica",
            "Psihanaliza",
            "Psihologie",
            "Relatii Publice",
            "Religie si Spiritualitate",
            "Roman",
            "Science Fiction - SF",
            "Sociologie",
            "Stiinta",
            "Stiinta Popularizata",
            "Stiinte Exacte",
            "Stiinte Politice",
            "Tehnica",
            "Teorie Matematica/ Fizica"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(1070, 184);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(169, 28);
            this.comboBoxCategoria.TabIndex = 9;
            this.comboBoxCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCategoria_Validating);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdauga.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdauga.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAdauga.Location = new System.Drawing.Point(1042, 250);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(111, 41);
            this.buttonAdauga.TabIndex = 10;
            this.buttonAdauga.Text = "&Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonInchide
            // 
            this.buttonInchide.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonInchide.CausesValidation = false;
            this.buttonInchide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInchide.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchide.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonInchide.Location = new System.Drawing.Point(1154, 352);
            this.buttonInchide.Name = "buttonInchide";
            this.buttonInchide.Size = new System.Drawing.Size(111, 41);
            this.buttonInchide.TabIndex = 11;
            this.buttonInchide.Text = "&Inchide";
            this.buttonInchide.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonAfisCarti
            // 
            this.buttonAfisCarti.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAfisCarti.CausesValidation = false;
            this.buttonAfisCarti.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisCarti.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAfisCarti.Location = new System.Drawing.Point(12, 352);
            this.buttonAfisCarti.Name = "buttonAfisCarti";
            this.buttonAfisCarti.Size = new System.Drawing.Size(160, 41);
            this.buttonAfisCarti.TabIndex = 14;
            this.buttonAfisCarti.Text = "Afiseaza &carti";
            this.buttonAfisCarti.UseVisualStyleBackColor = false;
            this.buttonAfisCarti.Click += new System.EventHandler(this.buttonAfisCarti_Click_1);
            // 
            // listViewCarti
            // 
            this.listViewCarti.BackColor = System.Drawing.Color.Snow;
            this.listViewCarti.CausesValidation = false;
            this.listViewCarti.CheckBoxes = true;
            this.listViewCarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCod,
            this.columnHeaderTitlu,
            this.columnHeaderAutor,
            this.columnHeaderEditura,
            this.columnHeaderCategorie});
            this.listViewCarti.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewCarti.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCarti.FullRowSelect = true;
            this.listViewCarti.GridLines = true;
            this.listViewCarti.HideSelection = false;
            this.listViewCarti.Location = new System.Drawing.Point(12, 52);
            this.listViewCarti.Name = "listViewCarti";
            this.listViewCarti.Size = new System.Drawing.Size(913, 294);
            this.listViewCarti.TabIndex = 12;
            this.listViewCarti.UseCompatibleStateImageBehavior = false;
            this.listViewCarti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCod
            // 
            this.columnHeaderCod.Text = "Cod";
            // 
            // columnHeaderTitlu
            // 
            this.columnHeaderTitlu.Text = "Titlu";
            this.columnHeaderTitlu.Width = 177;
            // 
            // columnHeaderAutor
            // 
            this.columnHeaderAutor.Text = "Autor";
            this.columnHeaderAutor.Width = 136;
            // 
            // columnHeaderEditura
            // 
            this.columnHeaderEditura.Text = "Editura";
            this.columnHeaderEditura.Width = 102;
            // 
            // columnHeaderCategorie
            // 
            this.columnHeaderCategorie.Text = "Categorie";
            this.columnHeaderCategorie.Width = 155;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem,
            this.editeazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 64);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 36);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.deschideToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // FormCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1277, 398);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAfisCarti);
            this.Controls.Add(this.listViewCarti);
            this.Controls.Add(this.buttonInchide);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxEditura);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCarti";
            this.Text = "FormCarte";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.ComboBox comboBoxEditura;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button buttonInchide;
        public System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button buttonAfisCarti;
        public System.Windows.Forms.ListView listViewCarti;
        private System.Windows.Forms.ColumnHeader columnHeaderCod;
        private System.Windows.Forms.ColumnHeader columnHeaderTitlu;
        private System.Windows.Forms.ColumnHeader columnHeaderAutor;
        private System.Windows.Forms.ColumnHeader columnHeaderEditura;
        private System.Windows.Forms.ColumnHeader columnHeaderCategorie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
    }
}