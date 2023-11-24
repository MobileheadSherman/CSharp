
namespace Proiect_ImprumuturiBiblioteca
{
    partial class FormImprumut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprumut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumeCititor = new System.Windows.Forms.TextBox();
            this.dateTimePickerImprumut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRestituire = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCarti = new System.Windows.Forms.ComboBox();
            this.buttonAdaugaCarte = new System.Windows.Forms.Button();
            this.buttonAdaugaImprumut = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume cititor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data imprumut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(64, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termen restituire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(64, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carte";
            // 
            // textBoxNumeCititor
            // 
            this.textBoxNumeCititor.BackColor = System.Drawing.Color.Snow;
            this.textBoxNumeCititor.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeCititor.Location = new System.Drawing.Point(244, 58);
            this.textBoxNumeCititor.Name = "textBoxNumeCititor";
            this.textBoxNumeCititor.ReadOnly = true;
            this.textBoxNumeCititor.Size = new System.Drawing.Size(288, 29);
            this.textBoxNumeCititor.TabIndex = 4;
            // 
            // dateTimePickerImprumut
            // 
            this.dateTimePickerImprumut.CalendarForeColor = System.Drawing.Color.Snow;
            this.dateTimePickerImprumut.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerImprumut.Location = new System.Drawing.Point(244, 106);
            this.dateTimePickerImprumut.Name = "dateTimePickerImprumut";
            this.dateTimePickerImprumut.Size = new System.Drawing.Size(288, 29);
            this.dateTimePickerImprumut.TabIndex = 5;
            this.dateTimePickerImprumut.ValueChanged += new System.EventHandler(this.dateTimePickerImprumut_ValueChanged);
            this.dateTimePickerImprumut.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerImprumut_Validating);
            // 
            // dateTimePickerRestituire
            // 
            this.dateTimePickerRestituire.CalendarForeColor = System.Drawing.Color.Snow;
            this.dateTimePickerRestituire.Enabled = false;
            this.dateTimePickerRestituire.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRestituire.Location = new System.Drawing.Point(244, 154);
            this.dateTimePickerRestituire.Name = "dateTimePickerRestituire";
            this.dateTimePickerRestituire.Size = new System.Drawing.Size(288, 29);
            this.dateTimePickerRestituire.TabIndex = 6;
            // 
            // comboBoxCarti
            // 
            this.comboBoxCarti.BackColor = System.Drawing.Color.Snow;
            this.comboBoxCarti.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarti.FormattingEnabled = true;
            this.comboBoxCarti.Location = new System.Drawing.Point(244, 202);
            this.comboBoxCarti.Name = "comboBoxCarti";
            this.comboBoxCarti.Size = new System.Drawing.Size(288, 30);
            this.comboBoxCarti.TabIndex = 7;
            // 
            // buttonAdaugaCarte
            // 
            this.buttonAdaugaCarte.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdaugaCarte.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaCarte.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAdaugaCarte.Location = new System.Drawing.Point(12, 303);
            this.buttonAdaugaCarte.Name = "buttonAdaugaCarte";
            this.buttonAdaugaCarte.Size = new System.Drawing.Size(155, 38);
            this.buttonAdaugaCarte.TabIndex = 8;
            this.buttonAdaugaCarte.Text = "Adauga &carte";
            this.buttonAdaugaCarte.UseVisualStyleBackColor = false;
            this.buttonAdaugaCarte.Click += new System.EventHandler(this.buttonAdaugaCarte_Click);
            // 
            // buttonAdaugaImprumut
            // 
            this.buttonAdaugaImprumut.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdaugaImprumut.Enabled = false;
            this.buttonAdaugaImprumut.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaImprumut.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonAdaugaImprumut.Location = new System.Drawing.Point(189, 303);
            this.buttonAdaugaImprumut.Name = "buttonAdaugaImprumut";
            this.buttonAdaugaImprumut.Size = new System.Drawing.Size(198, 38);
            this.buttonAdaugaImprumut.TabIndex = 9;
            this.buttonAdaugaImprumut.Text = "Adauga &imprumut";
            this.buttonAdaugaImprumut.UseVisualStyleBackColor = false;
            this.buttonAdaugaImprumut.Click += new System.EventHandler(this.buttonAdaugaImprumut_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonRenunta.CausesValidation = false;
            this.buttonRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRenunta.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenunta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonRenunta.Location = new System.Drawing.Point(409, 303);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(155, 38);
            this.buttonRenunta.TabIndex = 10;
            this.buttonRenunta.Text = "&Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = false;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(576, 353);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonAdaugaImprumut);
            this.Controls.Add(this.buttonAdaugaCarte);
            this.Controls.Add(this.comboBoxCarti);
            this.Controls.Add(this.dateTimePickerRestituire);
            this.Controls.Add(this.dateTimePickerImprumut);
            this.Controls.Add(this.textBoxNumeCititor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImprumut";
            this.Text = "FormImprumut";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerImprumut;
        private System.Windows.Forms.DateTimePicker dateTimePickerRestituire;
        private System.Windows.Forms.ComboBox comboBoxCarti;
        private System.Windows.Forms.Button buttonAdaugaCarte;
        private System.Windows.Forms.Button buttonAdaugaImprumut;
        private System.Windows.Forms.Button buttonRenunta;
        public System.Windows.Forms.TextBox textBoxNumeCititor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}