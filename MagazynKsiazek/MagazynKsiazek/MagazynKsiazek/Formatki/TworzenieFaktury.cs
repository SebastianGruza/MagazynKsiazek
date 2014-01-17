using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazynKsiazek
{
    public partial class TworzenieFaktury : Form
    {
        public TworzenieFaktury()
        {
            InitializeComponent();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            OknoGlowne og = new OknoGlowne();
            og.ShowDialog();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_BazaKsiazek(object sender, EventArgs e)
        {
            Hide();
            DodajKsiazke ks = new DodajKsiazke();
            ks.ShowDialog();
        }

        private void ToolStripMenuItem_BazaKlientow(object sender, EventArgs e)
        {
            Hide();
            DodajKlienta kl = new DodajKlienta();
            kl.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Data(object sender, EventArgs e)
        {

        }

        private void comboBox_Tytul(object sender, EventArgs e)
        {

        }

        private void comboBox_Klient(object sender, EventArgs e)
        {

        }

        private void textBox_KodPocztowy(object sender, EventArgs e)
        {

        }

        private void textBox_Miejscowosc(object sender, EventArgs e)
        {

        }

        private void textBox_Ulica(object sender, EventArgs e)
        {

        }

        private void textBox_IDKlienta(object sender, EventArgs e)
        {

        }

        private void textBox_Cena(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Ilosc(object sender, EventArgs e)
        {

        }

        private void textBox_ISBN(object sender, EventArgs e)
        {

        }

        private void button_Dodaj(object sender, EventArgs e)
        {

        }

        private void button_Aktualizuj(object sender, EventArgs e)
        {

        }

        private void button_Usun(object sender, EventArgs e)
        {

        }

        private void dataGridView_TabelaFaktur(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_StworzFakture(object sender, EventArgs e)
        {

        }

        private void listaFakturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StatystykiSprzedazy ss = new StatystykiSprzedazy();
            ss.ShowDialog();
        }

        private void TworzenieFaktury_Load(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Zamknij(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
            Application.Exit();
        }
    }
}
