namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_change_me = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.CheckBox();
            this.lbl_laboratorium = new System.Windows.Forms.Label();
            this.tb_wpisz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_change_me
            // 
            this.btn_change_me.Location = new System.Drawing.Point(141, 183);
            this.btn_change_me.Name = "btn_change_me";
            this.btn_change_me.Size = new System.Drawing.Size(101, 23);
            this.btn_change_me.TabIndex = 0;
            this.btn_change_me.Text = "CHANGE ME";
            this.btn_change_me.UseVisualStyleBackColor = true;
            this.btn_change_me.Click += new System.EventHandler(this.btn_change_me_Click);
            // 
            // check_btn
            // 
            this.check_btn.AutoSize = true;
            this.check_btn.Location = new System.Drawing.Point(129, 125);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(144, 17);
            this.check_btn.TabIndex = 1;
            this.check_btn.Text = "Włącz/ Wyłącz przycisk";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // lbl_laboratorium
            // 
            this.lbl_laboratorium.AutoSize = true;
            this.lbl_laboratorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_laboratorium.Location = new System.Drawing.Point(65, 22);
            this.lbl_laboratorium.Name = "lbl_laboratorium";
            this.lbl_laboratorium.Size = new System.Drawing.Size(263, 25);
            this.lbl_laboratorium.TabIndex = 2;
            this.lbl_laboratorium.Text = "Laboratoria KWZP 2020";
            this.lbl_laboratorium.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_wpisz
            // 
            this.tb_wpisz.Location = new System.Drawing.Point(21, 69);
            this.tb_wpisz.Name = "tb_wpisz";
            this.tb_wpisz.Size = new System.Drawing.Size(363, 20);
            this.tb_wpisz.TabIndex = 3;
            this.tb_wpisz.TextChanged += new System.EventHandler(this.tb_wpisz_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 230);
            this.Controls.Add(this.tb_wpisz);
            this.Controls.Add(this.lbl_laboratorium);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.btn_change_me);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change_me;
        private System.Windows.Forms.CheckBox check_btn;
        private System.Windows.Forms.Label lbl_laboratorium;
        private System.Windows.Forms.TextBox tb_wpisz;
    }
}

