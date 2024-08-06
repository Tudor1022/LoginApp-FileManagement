namespace lloginApp
{
    partial class Aplicatie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicatie));
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFoldere = new System.Windows.Forms.ListBox();
            this.btnFoldere = new System.Windows.Forms.Button();
            this.lstFisiere = new System.Windows.Forms.ListBox();
            this.btnFisiere2 = new System.Windows.Forms.Button();
            this.btnFisiere = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAfisareSpecifica = new System.Windows.Forms.Button();
            this.btnScriere = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocatie
            // 
            this.txtLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocatie.Location = new System.Drawing.Point(148, 129);
            this.txtLocatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(268, 30);
            this.txtLocatie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Locatie";
            // 
            // lstFoldere
            // 
            this.lstFoldere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFoldere.FormattingEnabled = true;
            this.lstFoldere.ItemHeight = 25;
            this.lstFoldere.Location = new System.Drawing.Point(540, 59);
            this.lstFoldere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFoldere.Name = "lstFoldere";
            this.lstFoldere.Size = new System.Drawing.Size(232, 329);
            this.lstFoldere.TabIndex = 5;
            this.lstFoldere.Visible = false;
            // 
            // btnFoldere
            // 
            this.btnFoldere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoldere.Location = new System.Drawing.Point(132, 359);
            this.btnFoldere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFoldere.Name = "btnFoldere";
            this.btnFoldere.Size = new System.Drawing.Size(309, 49);
            this.btnFoldere.TabIndex = 6;
            this.btnFoldere.Text = "Afisare foldere";
            this.btnFoldere.UseVisualStyleBackColor = true;
            this.btnFoldere.Visible = false;
            this.btnFoldere.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstFisiere
            // 
            this.lstFisiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFisiere.FormattingEnabled = true;
            this.lstFisiere.ItemHeight = 25;
            this.lstFisiere.Location = new System.Drawing.Point(817, 59);
            this.lstFisiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFisiere.Name = "lstFisiere";
            this.lstFisiere.Size = new System.Drawing.Size(232, 329);
            this.lstFisiere.TabIndex = 7;
            this.lstFisiere.Visible = false;
            // 
            // btnFisiere2
            // 
            this.btnFisiere2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFisiere2.Location = new System.Drawing.Point(540, 433);
            this.btnFisiere2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFisiere2.Name = "btnFisiere2";
            this.btnFisiere2.Size = new System.Drawing.Size(233, 54);
            this.btnFisiere2.TabIndex = 8;
            this.btnFisiere2.Text = "Afisare toate fisiere";
            this.btnFisiere2.UseVisualStyleBackColor = true;
            this.btnFisiere2.Visible = false;
            this.btnFisiere2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFisiere
            // 
            this.btnFisiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFisiere.Location = new System.Drawing.Point(132, 438);
            this.btnFisiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFisiere.Name = "btnFisiere";
            this.btnFisiere.Size = new System.Drawing.Size(309, 49);
            this.btnFisiere.TabIndex = 9;
            this.btnFisiere.Text = "Afisare fisiere";
            this.btnFisiere.UseVisualStyleBackColor = true;
            this.btnFisiere.Visible = false;
            this.btnFisiere.Click += new System.EventHandler(this.btnFisiere_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Navy;
            this.radioButton1.CausesValidation = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(212, 202);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 33);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Foldere";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Navy;
            this.radioButton2.CausesValidation = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(212, 244);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 33);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fisiere";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(817, 433);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(233, 54);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAfisareSpecifica
            // 
            this.btnAfisareSpecifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisareSpecifica.Location = new System.Drawing.Point(540, 501);
            this.btnAfisareSpecifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfisareSpecifica.Name = "btnAfisareSpecifica";
            this.btnAfisareSpecifica.Size = new System.Drawing.Size(233, 54);
            this.btnAfisareSpecifica.TabIndex = 13;
            this.btnAfisareSpecifica.Text = "Afisare fisiere specifica";
            this.btnAfisareSpecifica.UseVisualStyleBackColor = true;
            this.btnAfisareSpecifica.Visible = false;
            this.btnAfisareSpecifica.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnScriere
            // 
            this.btnScriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScriere.Location = new System.Drawing.Point(817, 501);
            this.btnScriere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScriere.Name = "btnScriere";
            this.btnScriere.Size = new System.Drawing.Size(233, 54);
            this.btnScriere.TabIndex = 14;
            this.btnScriere.Text = "Scriere";
            this.btnScriere.UseVisualStyleBackColor = true;
            this.btnScriere.Visible = false;
            this.btnScriere.Click += new System.EventHandler(this.btnScriere_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1132, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScriere);
            this.Controls.Add(this.btnAfisareSpecifica);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnFisiere);
            this.Controls.Add(this.btnFisiere2);
            this.Controls.Add(this.lstFisiere);
            this.Controls.Add(this.btnFoldere);
            this.Controls.Add(this.lstFoldere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocatie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Aplicatie";
            this.Text = "Aplicatie";
            this.Load += new System.EventHandler(this.Aplicatie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFoldere;
        private System.Windows.Forms.Button btnFoldere;
        private System.Windows.Forms.ListBox lstFisiere;
        private System.Windows.Forms.Button btnFisiere2;
        private System.Windows.Forms.Button btnFisiere;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAfisareSpecifica;
        private System.Windows.Forms.Button btnScriere;
        private System.Windows.Forms.Button button1;
    }
}