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
    public partial class Formularz2 : Form
    {
        public Formularz2(string labeltext)
        {
            InitializeComponent();
            lbl_tekst2.Text = labeltext;
        }

        private void Formularz2_Load(object sender, EventArgs e)
        {

        }
    }
}
