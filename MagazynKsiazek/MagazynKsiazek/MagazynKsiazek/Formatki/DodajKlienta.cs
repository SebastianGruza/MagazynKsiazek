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

namespace MagazynKsiazek
{
    public partial class DodajKlienta : Form
    {
 
        public DodajKlienta()
        {
            InitializeComponent();
        }

        private bool Walidacja()
        {
            bool w1 = Regex.IsMatch(ImieTB.Text, "^[A-ZĄŚŁÓŻŹŃĘĆ]{1}[a-ząćżźńółęś]{2,}$");
            if (w1 == false)
            {
                ImieTB.BackColor = new Color();
                ImieTB.BackColor = Color.Red;
            }
            else
            {
                ImieTB.BackColor = new Color();
                ImieTB.BackColor = Color.White;
            }
            bool w2 = Regex.IsMatch(NazwiskoTB.Text, "^[A-ZĄŚŁŻŹĘÓĆ]{1}[a-ząćżźńółęś-]{2,}$");
            if (w2 == false)
            {
                NazwiskoTB.BackColor = new Color();
                NazwiskoTB.BackColor = Color.Red;
            }
            else
            {
                NazwiskoTB.BackColor = new Color();
                NazwiskoTB.BackColor = Color.White;
            }

            bool w3 = Regex.IsMatch(MailTB.Text, "^[a-z0-9_]{2,}@[a-z0-9]{1,}.[a-z]{2,3}$");
            if (w3 == false)
            {
                MailTB.BackColor = new Color();
                MailTB.BackColor = Color.Red;
            }
            else
            {
                MailTB.BackColor = new Color();
                MailTB.BackColor = Color.White;
            }
            bool w4 = Regex.IsMatch(MiejscowoscTB.Text, "^[A-ZĄŚŁÓŻŹŃĘĆ][a-ząćżźńółęśA-ZĄŚŁÓŻŹŃĘĆ -]{2,}$");
            if (w4 == false)
            {
                MiejscowoscTB.BackColor = new Color();
                MiejscowoscTB.BackColor = Color.Red;
            }
            else
            {
                MiejscowoscTB.BackColor = new Color();
                MiejscowoscTB.BackColor = Color.White;
            }
            bool w5 = Regex.IsMatch(UlicaTB.Text, "^[0-9A-ZĄŚŁÓŻŹŃĘĆa-ząćżźńółęś -]{2,}$");
            if (w5 == false)
            {
                UlicaTB.BackColor = new Color();
                UlicaTB.BackColor = Color.Red;
            }
            else
            {
                UlicaTB.BackColor = new Color();
                UlicaTB.BackColor = Color.White;
            }
            bool w6 = Regex.IsMatch(NrDomuTB.Text, "^[0-9]{1,}[a-z]*$");
            if (w6 == false)
            {
                NrDomuTB.BackColor = new Color();
                NrDomuTB.BackColor = Color.Red;
            }
            else
            {
                NrDomuTB.BackColor = new Color();
                NrDomuTB.BackColor = Color.White;
            }
            bool w7 = Regex.IsMatch(NrLokaluTB.Text, "^[0-9]*$");
            if (w7 == false)
            {
                NrLokaluTB.BackColor = new Color();
                NrLokaluTB.BackColor = Color.Red;
            }
            else
            {
                NrLokaluTB.BackColor = new Color();
                NrLokaluTB.BackColor = Color.White;
            }
            bool w8 = Regex.IsMatch(KodPocztTB.Text, "^[0-9]{2}-[0-9]{3}$");
            if (w8 == false)
            {
                KodPocztTB.BackColor = new Color();
                KodPocztTB.BackColor = Color.Red;
            }
            else
            {
                KodPocztTB.BackColor = new Color();
                KodPocztTB.BackColor = Color.White;
            }
            if(w1 == false || w2 == false || w3 == false || w4 == false || w5 == false || w6 == false || w7 == false || w8 == false)
            {
                return false;
            }
            return true;
        }

        private void ToolStripMenuItem_OknoGlowne(object sender, EventArgs e)
        {
            Hide();
            OknoGlowne og = new OknoGlowne();
            og.ShowDialog();
        }

        private void ToolStripMenuItem_TworzenieFaktury(object sender, EventArgs e)
        {
            Hide();
            TworzenieFaktury fk = new TworzenieFaktury();
            fk.ShowDialog();
        }

        private void ToolStripMenuItem_DodajKsiazke(object sender, EventArgs e)
        {
            Hide();
            DodajKsiazke ks = new DodajKsiazke();
            ks.ShowDialog();
        }

        private void ToolStripMenuItem_Wyjscie(object sender, EventArgs e)
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

        private void ListaBT_Click(object sender, EventArgs e)
        {
            Column1.Visible = true;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci");
            this.dataGridView1.DataSource = dt;
        }

        private void DodajBT_Click(object sender, EventArgs e)
        {
            BazaDanych baza = new BazaDanych();
            Klient kk = new Klient();
            if (Walidacja() == true)
            {
                kk.Imie = ImieTB.Text;
            kk.Nazwisko = NazwiskoTB.Text;
            kk.Email = MailTB.Text;
            kk.Miejscowosc = MiejscowoscTB.Text;
            kk.Ulica = UlicaTB.Text;
            kk.NrDomu = NrDomuTB.Text;
            kk.NrLokalu = NrLokaluTB.Text;
            kk.KodPocztowy = KodPocztTB.Text;
            baza.DodajKlienta(kk);
            }
            DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci");
            this.dataGridView1.DataSource = dt;

            
        }

        private void UsunBT_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell cell = null;
            BazaDanych baza = new BazaDanych();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != cell.TrueValue)
                {
                    string numer = row.Cells[1].Value.ToString();
                    if (MessageBox.Show("Jesteś pewien, że chcesz usunąć klienta "+row.Cells[2].Value.ToString()+" "+row.Cells[3].Value.ToString()+"?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        baza.UsunKlienta(Convert.ToInt32(numer));
                    }    
                }
            }
            DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci");
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
                    baza.EdytujKlienta(Convert.ToInt32(numerID), columnName, editedItem);
                }
                else
                {
                    DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci");
                    this.dataGridView1.DataSource = dt;
                }
            }
            
        }

        private void WyszukajTB_TextChanged(object sender, EventArgs e)
        {
            string text = WyszukajTB.Text;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci WHERE Nazwisko LIKE '" +
                text + "%' OR Nazwisko LIKE '%" + text + "' OR Nazwisko LIKE '%" + text + "%' OR Imie LIKE '" +
                text + "%' OR Imie LIKE '%" + text + "' OR Imie LIKE '%" + text + "%'");
            this.dataGridView1.DataSource = dt;
        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImieTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
