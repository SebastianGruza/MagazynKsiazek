using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    public class SprzedazKsiazek
    {

        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                this._Id = value;
            }
        }
        private int _IdKsiazki;
        public int IdKsiazki
        {
            get
            {
                return _IdKsiazki;
            }
            set
            {
                this._IdKsiazki = value;
            }
        }

        private Ksiazki _ksi;
        public Ksiazki ksi
        {
            get
            {
                return _ksi;
            }
            set
            {
                this._ksi = value;
            }
        }

        private decimal _Cena;
        public decimal Cena
        {
            get
            {
                return this._Cena;
            }
            set
            {
                this._Cena = value;
            }
        }

        public string CenaString
        {
            get
            {
                IFormatProvider FormatProvider = new System.Globalization.CultureInfo("");
                StringBuilder SB = new StringBuilder();
                SB.AppendFormat(FormatProvider, "{0}", this.Ilosc);
                return SB.ToString();
            }
        }

        private decimal _Ilosc;
        public decimal Ilosc
        {
            get
            {
                return this._Ilosc;
            }
            set
            {
                this._Ilosc = value;
            }
        }

        public string IloscString
        {
            get
            {
                IFormatProvider FormatProvider = new System.Globalization.CultureInfo("");
                StringBuilder SB = new StringBuilder();
                SB.AppendFormat(FormatProvider, "{0}", this.Ilosc);
                return SB.ToString();
            }
        }

    }
}
