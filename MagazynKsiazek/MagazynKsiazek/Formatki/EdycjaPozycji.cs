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
    /// Formatka pozwala na edycję szczegółów pojedynczej pozycji dotyczącej konkretnej faktury.
    /// </summary>
    public partial class EdycjaPozycji : Form
    {
        public SprzedazKsiazek sprzedaz;

        public Form Rodzic;

        public EdycjaPozycji(SprzedazKsiazek sprzedaz)
        {
            InitializeComponent();
            this.sprzedaz = sprzedaz;
            BazaDanych db = new BazaDanych();
            IList<Ksiazki> ksiazki = db.pobierzListeKsiazek();
            for (int i = 0; i < ksiazki.Count; i++)
            {
                VPozycja.Items.Add(ksiazki[i]);
                if (sprzedaz.IdKsiazki == ksiazki[i].ISBN)
                    VPozycja.SelectedIndex = i;
            }
            VIlosc.Value = sprzedaz.Ilosc;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void VPozycja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ksiazki ks = (Ksiazki)VPozycja.SelectedItem;
            VTytul.Text = ks.Tytul;
            VAutor.Text = ks.DaneAutora;
            VWydawnictwo.Text = ks.Wydawnictwo;
            VRok.Text = ks.RokWydania;
            VCenaHurt.Text = String.Format("{0:C}",ks.Cena);
            VCenaZak.Value = ks.Cena * Convert.ToDecimal(1.2);
            VIloscMag.Text = ks.Ilosc.ToString();
            VGat.Text = ks.Gatunek;
            try
            {
                VCenaRazem.Text = String.Format("{0:C}",VIlosc.Value * VCenaZak.Value);
            }
            catch
            {

            }

        }

        private void VIlosc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                VCenaRazem.Text = String.Format("{0:C}", VIlosc.Value * VCenaZak.Value);
            }
            catch
            {

            }
        }

        private void VCenaZak_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                VCenaRazem.Text = String.Format("{0:C}", VIlosc.Value * VCenaZak.Value);
            }
            catch
            {

            }
        }

        private void BZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Ksiazki ks = (Ksiazki)VPozycja.SelectedItem;
                this.sprzedaz.IdKsiazki = ks.ISBN;
                this.sprzedaz.ksi = ks;
                this.sprzedaz.Ilosc = Convert.ToInt32(VIlosc.Value);
                this.sprzedaz.Cena = Convert.ToDecimal(VCenaZak.Value);
                ((EdycjaFaktury)this.Rodzic).AktualizujFormatke();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd! Wypełnij poprawnie wszystkie pola!\n");
            }
        }

        private void BAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}