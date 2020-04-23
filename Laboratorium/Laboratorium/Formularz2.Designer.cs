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
            this.SuspendLayout();
            // 
            // lbl_tekst2
            // 
            this.lbl_tekst2.AutoSize = true;
            this.lbl_tekst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_tekst2.Location = new System.Drawing.Point(159, 132);
            this.lbl_tekst2.Name = "lbl_tekst2";
            this.lbl_tekst2.Size = new System.Drawing.Size(60, 24);
            this.lbl_tekst2.TabIndex = 0;
            this.lbl_tekst2.Text = "label1";
            // 
            // Formularz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 313);
            this.Controls.Add(this.lbl_tekst2);
            this.Name = "Formularz2";
            this.Text = "Formularz2";
            this.Load += new System.EventHandler(this.Formularz2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tekst2;
    }
}