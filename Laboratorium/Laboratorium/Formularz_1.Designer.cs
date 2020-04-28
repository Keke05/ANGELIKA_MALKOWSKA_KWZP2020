namespace Laboratorium
{
    partial class Formularz_1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tekst2 = new System.Windows.Forms.Label();
            this.chb_przycisk = new System.Windows.Forms.CheckBox();
            this.tb_tekst = new System.Windows.Forms.TextBox();
            this.btn_przycisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tekst2
            // 
            this.lbl_tekst2.AutoSize = true;
            this.lbl_tekst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_tekst2.Location = new System.Drawing.Point(73, 9);
            this.lbl_tekst2.Name = "lbl_tekst2";
            this.lbl_tekst2.Size = new System.Drawing.Size(259, 25);
            this.lbl_tekst2.TabIndex = 0;
            this.lbl_tekst2.Text = "Laboratorium KWZP 2020";
            // 
            // chb_przycisk
            // 
            this.chb_przycisk.AutoSize = true;
            this.chb_przycisk.Location = new System.Drawing.Point(147, 127);
            this.chb_przycisk.Name = "chb_przycisk";
            this.chb_przycisk.Size = new System.Drawing.Size(141, 17);
            this.chb_przycisk.TabIndex = 1;
            this.chb_przycisk.Text = "włącz / wyłącz przycisk";
            this.chb_przycisk.UseVisualStyleBackColor = true;
            this.chb_przycisk.CheckedChanged += new System.EventHandler(this.chb_przycisk_CheckedChanged);
            // 
            // tb_tekst
            // 
            this.tb_tekst.Location = new System.Drawing.Point(48, 73);
            this.tb_tekst.Name = "tb_tekst";
            this.tb_tekst.Size = new System.Drawing.Size(293, 20);
            this.tb_tekst.TabIndex = 2;
            this.tb_tekst.TextChanged += new System.EventHandler(this.tb_tekst_TextChanged);
            // 
            // btn_przycisk
            // 
            this.btn_przycisk.Location = new System.Drawing.Point(125, 178);
            this.btn_przycisk.Name = "btn_przycisk";
            this.btn_przycisk.Size = new System.Drawing.Size(141, 23);
            this.btn_przycisk.TabIndex = 3;
            this.btn_przycisk.Text = "Szukaj pracownika";
            this.btn_przycisk.UseVisualStyleBackColor = true;
            this.btn_przycisk.Click += new System.EventHandler(this.btn_przycisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wyszukaj pracownika (Nazwisko)";
            // 
            // Formularz_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_przycisk);
            this.Controls.Add(this.tb_tekst);
            this.Controls.Add(this.chb_przycisk);
            this.Controls.Add(this.lbl_tekst2);
            this.Name = "Formularz_1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tekst2;
        private System.Windows.Forms.CheckBox chb_przycisk;
        private System.Windows.Forms.TextBox tb_tekst;
        private System.Windows.Forms.Button btn_przycisk;
        private System.Windows.Forms.Label label1;
    }
}

