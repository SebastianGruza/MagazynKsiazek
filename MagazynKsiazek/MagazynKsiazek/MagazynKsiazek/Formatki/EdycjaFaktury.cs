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


        private void AktualizujFormatke()
        {
            if (faktura != null)
            {
                dateTimePicker1.Value = faktura.Data;

                for (int i = 0; i < faktura.listaSprzedanychKsiazek.Count; i++)
                {
                    DataGridViewRow wiersz = this.GListaTowarow.RowTemplate.Clone() as DataGridViewRow;
                    wiersz.CreateCells(this.GListaTowarow);
                    SprzedazKsiazek t = faktura.listaSprzedanychKsiazek[i];
                    wiersz.Tag = t;
                    wiersz.Cells[0].Value = t.ksi.ISBN;
                    wiersz.Cells[1].Value = t.ksi.Tytul;
                    wiersz.Cells[2].Value = t.ksi.DaneAutora;
                    wiersz.Cells[3].Value = t.Ilosc;
                    wiersz.Cells[4].Value = String.Format("{0:C}", t.Cena);
                    wiersz.Cells[5].Value = String.Format("{0:C}", t.Cena * t.Ilosc);
                    this.GListaTowarow.Rows.Add(wiersz);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.GListaTowarow.SelectedRows.Count > 0) //sprawdzamy, czy jest zaznaczony element
            {
                SprzedazKsiazek sprzedaz = this.GListaTowarow.SelectedRows[0].Tag as SprzedazKsiazek;
                if (sprzedaz != null)
                {
                    EdycjaPozycji t = new EdycjaPozycji();
                    t.sprzedaz = sprzedaz;    
                    t.MdiParent = this.MdiParent;
                    t.Rodzic = this;
                    t.Show();
                    t.BringToFront();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
