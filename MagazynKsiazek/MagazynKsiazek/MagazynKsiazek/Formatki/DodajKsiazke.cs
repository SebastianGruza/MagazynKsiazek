using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using MagazynKsiazek.Klasy;

namespace MagazynKsiazek
{
    public partial class DodajKsiazke : Form
    {
        public DodajKsiazke()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Gatunek(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            OknoGlowne og = new OknoGlowne();
            og.ShowDialog();
        }

        private void button_Aktualizuj(object sender, EventArgs e)
        {

        }

        private void fakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TworzenieFaktury fk = new TworzenieFaktury();
            fk.ShowDialog();
        }

        private void klienciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DodajKlienta kl = new DodajKlienta();
            kl.ShowDialog();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }

        private void textBox_Wydawnictwo(object sender, EventArgs e)
        {

        }

        private void textBox_RokWydania(object sender, EventArgs e)
        {

        }

        private void textBox_ISBN(object sender, EventArgs e)
        {

        }

        private void textBox_Tytul(object sender, EventArgs e)
        {

        }

        private void textBox_Autor(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Ilosc(object sender, EventArgs e)
        {

        }

        private void textBox_Cena(object sender, EventArgs e)
        {

        }

        private void button_Dodaj(object sender, EventArgs e)
        {

            BazaDanych baza1 = new BazaDanych();
            Ksiazki mm = new Ksiazki();
           

                mm.Tytul = KTytul.Text;
                mm.Autor = KAutor.Text;
                mm.Wydawnictwo = KWydawnictwo.Text;
                mm.RokWydania = KRokWydania.Text;
                mm.Gatunek =  KGatuenk.Text;
                mm.Ilosc = KIlosc.Text;
                mm.Cena = KCena.Text;

                baza1.DodajKsiazke(mm);


        }

        private void button_Usun(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell cell = null;
            BazaDanych baza1 = new BazaDanych();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != cell.TrueValue)
                {
                    string numer = row.Cells[1].Value.ToString();
                    if (MessageBox.Show("Jesteś pewien, że chcesz usunąć ksiazke " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString() + "?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        baza1.UsunKsiazke(Convert.ToInt32(numer));
                    }
                }
            }
            DataTable dt = baza1.wykonajSelect("SELECT * FROM Klienci");
            this.dataGridView1.DataSource = dt;
        }

        private void textBox_Wyszukaj(object sender, EventArgs e)
        {

        }

        private void dataGridView_TabelaKsiazek(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ZaladujPelnaListe(object sender, EventArgs e)
        {
            Column1.Visible = true;
            BazaDanych baza1 = new BazaDanych();
            DataTable dt = baza1.wykonajSelect("SELECT * FROM Ksiazki");
            this.dataGridView1.DataSource = dt;
        }

        private void ToolStripMenuItem_Zamknij(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
            Application.Exit();
        }

        private void ToolStripMenuItem_StatystykiSprzedazy(object sender, EventArgs e)
        {
            Hide();
            StatystykiSprzedazy ss = new StatystykiSprzedazy();
            ss.ShowDialog();
        }

        private void ToolStripMenuItem_Wyloguj(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Hide();
            OknoLogowania ol = new OknoLogowania();
            ol.ShowDialog();
        }
    }
}
