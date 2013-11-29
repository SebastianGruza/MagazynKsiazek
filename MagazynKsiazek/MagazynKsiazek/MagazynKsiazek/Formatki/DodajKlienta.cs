using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagazynKsiazek.Klasy;

namespace MagazynKsiazek
{
    public partial class DodajKlienta : Form
    {
 
        public DodajKlienta()
        {
            InitializeComponent();

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

        private void WyszukajTB_TextChanged(object sender, EventArgs e)
        {
            string text = WyszukajTB.Text;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Klienci WHERE Nazwisko LIKE '" +
                text + "%' OR Nazwisko LIKE '%" + text + "' OR Nazwisko LIKE '%" + text + "%' OR Imie LIKE '" +
                text + "%' OR Imie LIKE '%" + text + "' OR Imie LIKE '%" + text + "%'");
            this.dataGridView1.DataSource = dt;
        }
    }
}
