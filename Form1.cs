using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_change_me.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            btn_change_me.Enabled = check_btn.Checked;
            }

            private void tb_wpisz_TextChanged(object sender, EventArgs e)
            {
                if (tb_wpisz.TextLength > 0)
                {

                    btn_change_me.Text = tb_wpisz.Text;
                }
            }

        private void btn_change_me_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
