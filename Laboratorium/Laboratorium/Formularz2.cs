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
        public Formularz2(SzwalniaEntities1 db, string labeltext)
        {
            InitializeComponent();
            Pracownicy employee = db.Pracownicy.Where(pracownik => pracownik.Nazwisko == labeltext).First();
            lbl_tekst2.Text = employee.Imie.TrimEnd() + " " + employee.Nazwisko;
            tbImie.Text = employee.Imie;
            tbNazwisko.Text = employee.Nazwisko;
            tbPesel.Text = employee.Pesel;
            tbAdres.Text = employee.Adres;


            dgvRecordsList.DataSource = db.Stanowisko.ToList();
        }

        private void Formularz2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
