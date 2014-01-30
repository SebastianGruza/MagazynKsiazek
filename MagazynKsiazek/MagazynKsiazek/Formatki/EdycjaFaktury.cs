using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagazynKsiazek.Klasy;

namespace MagazynKsiazek.Formatki
{
    /// <summary>
    /// Formatka pozwala na edycję faktury: zmiany jej parametrów, wyboru książek, itd..
    /// </summary>
    public partial class EdycjaFaktury : Form
    {

        private Faktura faktura;
     


        public Form Rodzic;

        public EdycjaFaktury(Faktura faktura)
        {
            InitializeComponent();
            this.faktura = faktura;
            BazaDanych db = new BazaDanych();


            IList<Klient> klienci = db.pobierzListeKlientow();
            IList<Ksiazki> ksiazki = db.pobierzListeKsiazek();

            if (klienci.Count > 0)
            {
                for (int i =0; i< klienci.Count; i++)
                {
                    this.comboBox1.Items.Add(klienci[i]);
                    if (faktura!=null && klienci[i].ID_Klienta == faktura.ID_Klienta)
                        this.comboBox1.SelectedIndex = i;
                }
            }
            if (ksiazki.Count > 0)
            {
                foreach (Ksiazki ksiazka in ksiazki)
                {
                    this.listBox1.Items.Add(ksiazka);
                }

            }
            AktualizujFormatke();
        }

        private void DodajWiersz(SprzedazKsiazek t)
        {
            DataGridViewRow wiersz = this.GListaTowarow.RowTemplate.Clone() as DataGridViewRow;
            wiersz.CreateCells(this.GListaTowarow);
            wiersz.Tag = t;
            wiersz.Cells[0].Value = t.ksi.ISBN;
            wiersz.Cells[1].Value = t.ksi.Tytul;
            wiersz.Cells[2].Value = t.ksi.DaneAutora;
            wiersz.Cells[3].Value = t.Ilosc;
            wiersz.Cells[4].Value = String.Format("{0:C}", t.Cena);
            wiersz.Cells[5].Value = String.Format("{0:C}", t.Cena * t.Ilosc);
            this.GListaTowarow.Rows.Add(wiersz);
        }

        public void AktualizujFormatke()
        {
            if (faktura != null)
            {
                dateTimePicker1.Value = faktura.Data;
                GListaTowarow.Rows.Clear();
                for (int i = 0; i < faktura.listaSprzedanychKsiazek.Count; i++)
                {
                    SprzedazKsiazek t = faktura.listaSprzedanychKsiazek[i];
                    DodajWiersz(t);
                }
                PodliczCene();
            }
        }

        private void PodliczCene()
        {
            lblCena.Text = String.Format("{0:C}", this.faktura.Cena);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Klient kl = (Klient)comboBox1.SelectedItem;
            this.txtID.Text =  kl.ID_Klienta.ToString();
            this.txtKod.Text = kl.KodPocztowy;
            this.txtMiejscowosc.Text=kl.Miejscowosc;
            this.txtUlica.Text = kl.Ulica + " " + kl.NrDomu + " / " + kl.NrLokalu;
            if (faktura == null)
                StworzFakture();
            if (kl.ID_Klienta > 0)
            {
                faktura.ID_Klienta = kl.ID_Klienta;
                faktura.klient = kl;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.GListaTowarow.SelectedRows.Count > 0) //sprawdzamy, czy jest zaznaczony element
            {
                SprzedazKsiazek sprzedaz = this.GListaTowarow.SelectedRows[0].Tag as SprzedazKsiazek;
                if (sprzedaz != null)
                {
                    EdycjaPozycji t = new EdycjaPozycji(sprzedaz);
                    t.MdiParent = this.MdiParent;
                    t.Rodzic = this;
                    t.Show();
                    t.BringToFront();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                Ksiazki ksiazka = (Ksiazki)listBox1.SelectedItems[i];
                SprzedazKsiazek pozycja = new SprzedazKsiazek();
                pozycja.IdKsiazki = ksiazka.ISBN;
                pozycja.ksi = ksiazka;
                pozycja.Ilosc = 1;
                pozycja.Cena = ksiazka.Cena * Convert.ToDecimal(1.2);



                if (faktura==null)
                {
                    StworzFakture();
                }
                Boolean CzyStworzycPozycje = true;
                foreach (SprzedazKsiazek item in faktura.listaSprzedanychKsiazek)
                {
                    if (item.IdKsiazki==pozycja.IdKsiazki && item.Cena==pozycja.Cena)
                    {
                        CzyStworzycPozycje = false;
                        item.Ilosc += pozycja.Ilosc;
                        GListaTowarow.Rows.Clear();
                        for (int j = 0; j < faktura.listaSprzedanychKsiazek.Count; j++)
                        {
                            SprzedazKsiazek t = faktura.listaSprzedanychKsiazek[j];
                            DodajWiersz(t);
                        }
                        break;
                    }
                }
                if (CzyStworzycPozycje)
                {
                    DodajWiersz(pozycja);
                    faktura.listaSprzedanychKsiazek.Add(pozycja);
                }
            }
            PodliczCene();
            listBox1.ClearSelected();
        }

        private void StworzFakture()
        {
            faktura = new Faktura();
            faktura.listaSprzedanychKsiazek = new List<SprzedazKsiazek>();
            faktura.Data = dateTimePicker1.Value;
            
            // dobieranie minimalnego, dopuszczalnego numeru faktury:
            BazaDanych baza = new BazaDanych();
            IList<Faktura> listaFaktur = baza.pobierzListeFaktur();
            List<int> NumeryFaktur = new List<int>();
            foreach (Faktura fakt in listaFaktur)
            {
                NumeryFaktur.Add(fakt.Nr);
            }
            int min = 0;
            for (int i = 0; i < NumeryFaktur.Count; i++)
            {
                if (NumeryFaktur.Contains(min))
                    min++;
                else
                    break;
            }
            
            faktura.Nr = min;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (faktura == null)
                StworzFakture();
            faktura.Data = dateTimePicker1.Value;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ((TworzenieFaktury)this.Rodzic).button5_Click(null, null);
            base.OnClosing(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.GListaTowarow.SelectedRows.Count > 0)
            {
                SprzedazKsiazek pozycja = this.GListaTowarow.SelectedRows[0].Tag as SprzedazKsiazek;
                if (pozycja != null)
                {
                    this.faktura.listaSprzedanychKsiazek.Remove(pozycja);
                    this.GListaTowarow.Rows.Remove(this.GListaTowarow.SelectedRows[0]);
                }
                PodliczCene();
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.faktura == null || this.faktura.klient == null || this.faktura.listaSprzedanychKsiazek == null || this.faktura.listaSprzedanychKsiazek.Count == 0)
            {
                MessageBox.Show("Nie wypełniono wszystkich danych niezbędnych do stworzenia faktury!", "Uzupełnij formularz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BazaDanych db = new BazaDanych();
                if (this.faktura.Id > -1)
                    db.UsunFakture(this.faktura.Id);
                db.DodajFakture(this.faktura);
                    ((TworzenieFaktury)this.Rodzic).button5_Click(null, null);
                this.Dispose();
            }
        }
    }
}
