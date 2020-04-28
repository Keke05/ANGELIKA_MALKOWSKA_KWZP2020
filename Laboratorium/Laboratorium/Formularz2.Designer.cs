namespace Laboratorium
{
    partial class Formularz2
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
            this.lbl_tekst2 = new System.Windows.Forms.Label();
            this.dgvRecordsList = new System.Windows.Forms.DataGridView();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZatrudnienie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tekst2
            // 
            this.lbl_tekst2.AutoSize = true;
            this.lbl_tekst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_tekst2.Location = new System.Drawing.Point(34, 33);
            this.lbl_tekst2.Name = "lbl_tekst2";
            this.lbl_tekst2.Size = new System.Drawing.Size(60, 24);
            this.lbl_tekst2.TabIndex = 0;
            this.lbl_tekst2.Text = "label1";
            // 
            // dgvRecordsList
            // 
            this.dgvRecordsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordsList.Location = new System.Drawing.Point(12, 266);
            this.dgvRecordsList.Name = "dgvRecordsList";
            this.dgvRecordsList.Size = new System.Drawing.Size(680, 82);
            this.dgvRecordsList.TabIndex = 1;
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(122, 143);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(212, 20);
            this.tbPesel.TabIndex = 2;
            this.tbPesel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(122, 117);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(212, 20);
            this.tbNazwisko.TabIndex = 2;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(122, 91);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(212, 20);
            this.tbImie.TabIndex = 2;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(122, 169);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(212, 20);
            this.tbAdres.TabIndex = 2;
            this.tbAdres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(53, 117);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(53, 13);
            this.lblNazwisko.TabIndex = 3;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(53, 91);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(26, 13);
            this.lblImie.TabIndex = 3;
            this.lblImie.Text = "Imię";
            this.lblImie.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(53, 169);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(53, 146);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(41, 13);
            this.lblPesel.TabIndex = 3;
            this.lblPesel.Text = "PESEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pracownicy";
            // 
            // dgvZatrudnienie
            // 
            this.dgvZatrudnienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZatrudnienie.Location = new System.Drawing.Point(12, 388);
            this.dgvZatrudnienie.Name = "dgvZatrudnienie";
            this.dgvZatrudnienie.Size = new System.Drawing.Size(680, 82);
            this.dgvZatrudnienie.TabIndex = 1;
            // 
            // Formularz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.dgvZatrudnienie);
            this.Controls.Add(this.dgvRecordsList);
            this.Controls.Add(this.lbl_tekst2);
            this.Name = "Formularz2";
            this.Text = "Formularz2";
            this.Load += new System.EventHandler(this.Formularz2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tekst2;
        private System.Windows.Forms.DataGridView dgvRecordsList;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZatrudnienie;
    }
}