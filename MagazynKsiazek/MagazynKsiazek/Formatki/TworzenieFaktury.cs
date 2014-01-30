using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagazynKsiazek.Klasy;
using System.Text.RegularExpressions;
using MagazynKsiazek.Formatki;

namespace MagazynKsiazek
{
    /// <summary>
    /// Formatka pozwala na wyświetlenie i przejrzenie listy wszystkich faktur, możliwość dodawania 
    /// i usunięcia faktur występujących na liście i uruchomienie dalszego modułu dotyczącego szczegółów
    /// faktury.
    /// </summary>
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
            /*
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
            */
        }

        private void button_StworzFakture(object sender, EventArgs e)
        {
            EdycjaFaktury no = new EdycjaFaktury(null);
            no.MdiParent = this.MdiParent;
            no.Rodzic = this;
            no.Show();
            no.BringToFront();
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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            //Column1.Visible = true;
            BazaDanych baza = new BazaDanych();
            IList<Faktura> listaFaktur=baza.pobierzListeFaktur();

            this.dataGridView1.Rows.Clear();

            for (int i = 0; i < listaFaktur.Count; i++)
            {
                DataGridViewRow wiersz = this.dataGridView1.RowTemplate.Clone() as DataGridViewRow;
                wiersz.CreateCells(this.dataGridView1);
                Faktura f = listaFaktur[i];
                wiersz.Tag = f;
                wiersz.Cells[1].Value = f.Nr;
                wiersz.Cells[2].Value = f.ID_Klienta;
                wiersz.Cells[3].Value = f.klient.Imie + " " + f.klient.Nazwisko;
                wiersz.Cells[4].Value = f.Data.ToShortDateString();
                wiersz.Cells[5].Value = f.listaSprzedanychKsiazek.Count;
                wiersz.Cells[6].Value = String.Format("{0:C}", f.Cena);

                this.dataGridView1.Rows.Add(wiersz);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Czy chcesz usunąć zaznaczoną fakturę?",
                    "Kasowanie faktury",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Faktura faktura = this.dataGridView1.SelectedRows[0].Tag as Faktura;
                    if (faktura != null)
                    {
                        BazaDanych db = new BazaDanych();
                        db.UsunFakture(faktura.Id);
                        this.dataGridView1.Rows.Remove(this.dataGridView1.SelectedRows[0]);
                    }

                }

            }
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0) //sprawdzamy, czy jest zaznaczony element
            {
                Faktura faktObj = this.dataGridView1.SelectedRows[0].Tag as Faktura;
                if (faktObj != null)
                {
                    EdycjaFaktury ef = new EdycjaFaktury(faktObj);
                    ef.MdiParent = this.MdiParent;
                    ef.Rodzic = this;
                    ef.Show();
                    ef.BringToFront();
                }
            }
        }
    }
}
