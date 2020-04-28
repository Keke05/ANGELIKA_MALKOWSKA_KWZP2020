using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium
{
    public partial class Formularz_1 : Form
    {
        private SzwalniaEntities1 db;

        public Formularz_1()
        {
            InitializeComponent();
            btn_przycisk.Enabled = false;
            db = new SzwalniaEntities1();
        }

        private void chb_przycisk_CheckedChanged(object sender, EventArgs e)
        {
            btn_przycisk.Enabled = chb_przycisk.Checked;
        }

        private void tb_tekst_TextChanged(object sender, EventArgs e)
        {
          
            //if (tb_tekst.TextLength > 0)
            //{
            //    btn_przycisk.Text = tb_tekst.Text;
            //}
           
        }

        private void btn_przycisk_Click(object sender, EventArgs e)
        {
            Formularz2 form2 = new Formularz2(db, tb_tekst.Text);
            form2.Show();
        }
    }
}
