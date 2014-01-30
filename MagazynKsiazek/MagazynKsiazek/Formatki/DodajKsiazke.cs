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
    /// <summary>
    /// Formatka pozwala na dodawanie, usuwanie i edycję danych dotyczących książek w magazynie.
    /// </summary>
    public partial class DodajKsiazke : Form
    {
        public DodajKsiazke()
        {
            InitializeComponent();
        }

        private bool Walidacja()
        {
            bool w1 = Regex.IsMatch(TytulTB.Text, "^[a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ0-9 -]{1,100}$");
            if (w1 == false)
            {
                TytulTB.BackColor = new Color();
                TytulTB.BackColor = Color.Red;
            }
            else
            {
                TytulTB.BackColor = new Color();
                TytulTB.BackColor = Color.White;
            }
            bool w2 = Regex.IsMatch(AutorTB.Text, "^[a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ -]{1,100}$");
            if (w2 == false)
            {
                AutorTB.BackColor = new Color();
                AutorTB.BackColor = Color.Red;
            }
            else
            {
                AutorTB.BackColor = new Color();
                AutorTB.BackColor = Color.White;
            }


            bool w3 = Regex.IsMatch(WydawnictwoTB.Text, "^[a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ0-9 -]{1,100}$");
            if (w3 == false)
            {
                WydawnictwoTB.BackColor = new Color();
                WydawnictwoTB.BackColor = Color.Red;
            }
            else
            {
                WydawnictwoTB.BackColor = new Color();
                WydawnictwoTB.BackColor = Color.White;
            }
            bool w4 = Regex.IsMatch(RokTB.Text, "^[0-9]{1,}$");
            if (w4 == false)
            {
                RokTB.BackColor = new Color();
                RokTB.BackColor = Color.Red;
            }
            else
            {
                RokTB.BackColor = new Color();
                RokTB.BackColor = Color.White;
            }
            bool w5 = Regex.IsMatch(CenaTB.Text, "^[0-9]{1,}[a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ -]*$");
            if (w5 == false)
            {
                CenaTB.BackColor = new Color();
                CenaTB.BackColor = Color.Red;
            }
            else
            {
                CenaTB.BackColor = new Color();
                CenaTB.BackColor = Color.White;
            }
            bool w6 = Regex.IsMatch(GatunekTB.Text, "^[a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ0-9 -]{1,100}$");
            if (w3 == false)
            {
                GatunekTB.BackColor = new Color();
                GatunekTB.BackColor = Color.Red;
            }
            else
            {
                GatunekTB.BackColor = new Color();
                GatunekTB.BackColor = Color.White;
            }
            if (w1 == false || w2 == false || w3 == false || w4 == false || w5 == false || w6 == false)
            {
                return false;
            }
            return true;
        }
        
        private void ListaBT_Click(object sender, EventArgs e)
        {
            Column1.Visible = true;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Ksiazki");
            this.dataGridView1.DataSource = dt;
        }


        private void DodajBT_Click(object sender, EventArgs e)
        {
            BazaDanych baza = new BazaDanych();
            Ksiazki kk = new Ksiazki();
            if (Walidacja() == true)
            {
                
                kk.Tytul = TytulTB.Text;
                kk.DaneAutora = AutorTB.Text;
                kk.Wydawnictwo = WydawnictwoTB.Text;
                kk.RokWydania = RokTB.Text;
                kk.Gatunek = GatunekTB.Text;
                kk.Ilosc = Int32.Parse(IloscTB.Text);
                kk.Cena = Decimal.Parse(CenaTB.Text);
                baza.DodajKsiazke(kk);
           
            }
            DataTable dt = baza.wykonajSelectKsiazki("SELECT * FROM Ksiazki");
            this.dataGridView1.DataSource = dt;

            
        }
        
        private void UsunTB_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell cell = null;
            BazaDanych baza = new BazaDanych();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != cell.TrueValue)
                {
                    string numer = row.Cells[1].Value.ToString();
                    if (MessageBox.Show("Jesteś pewien, że chcesz usunąć książkę " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString() + "?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        baza.UsunKsiazke(Convert.ToInt32(numer));
                    }
                }
            }
            DataTable dt = baza.wykonajSelectKsiazki("SELECT * FROM Ksiazki");
            this.dataGridView1.DataSource = dt;
        }
        string editedItem;
        int numerID;
        string columnName;


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                    baza.EdytujKsiazke(Convert.ToInt32(numerID), columnName, editedItem);
                }
                else
                {
                    DataTable dt = baza.wykonajSelectKsiazki("SELECT * FROM Ksiazki");
                    this.dataGridView1.DataSource = dt;
                }
            }

        }

        private void WyszukajTB_TextChanged(object sender, EventArgs e)
        {
            string text = WyszukajTB.Text;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Ksiazki WHERE Tytul LIKE '" +
                text + "%' OR Autor LIKE '" + text + "%' OR Wydawnictwo LIKE '" + text + "%' OR RokWydania LIKE '" +
                text + "%' OR Gatunek LIKE '%" + text + "' OR Cena LIKE '" + text + "%'");
            this.dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
