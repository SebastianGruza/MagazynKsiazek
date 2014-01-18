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
using System.Text.RegularExpressions;

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
            RokWydaniaTB ks = new RokWydaniaTB();
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
        string editedItem;
        int numerID;
        string columnName;
        private void dataGridView_TabelaFaktur(object sender, DataGridViewCellEventArgs e)
        {
            BazaDanych baza = new BazaDanych();
            DataGridView dgv = sender as DataGridView;
            editedItem = dgv.CurrentCell.Value.ToString();
            int number = dgv.CurrentCell.ColumnIndex;
            if (number != 0)
            {
                columnName = dgv.Columns[number].Name;
                numerID = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
                if (MessageBox.Show("Jesteś pewien, że chcesz wprowadzić zmiany?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baza.EdytujFakture(Convert.ToInt32(numerID), columnName, editedItem);
                }
                else
                {
                    DataTable dt = baza.wykonajSelectKsiazki("SELECT * FROM Faktury");
                    this.dataGridView1.DataSource = dt;
                }
            }

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

        private void button5_Click(object sender, EventArgs e)
        {
            Column1.Visible = true;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Faktury");
            this.dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                DataGridViewCheckBoxCell cell = null;
                BazaDanych baza = new BazaDanych();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cell = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (cell.Value != cell.TrueValue)
                    {
                        string numer = row.Cells[1].Value.ToString();
                        if (MessageBox.Show("Jesteś pewien, że chcesz usunąć klienta " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString() + "?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            baza.UsunFakture(Convert.ToInt32(numer));
                        }
                    }
                }
                DataTable dt = baza.wykonajSelect("SELECT * FROM Faktury");
                this.dataGridView1.DataSource = dt;
            }
        }
    }
}
