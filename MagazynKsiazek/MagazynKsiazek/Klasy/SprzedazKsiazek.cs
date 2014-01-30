using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    /// <summary>
    /// Klasa umożliwia przechowywanie danych odnośnie szczegółów pozycji faktury 
    /// sprzedawanych książek
    /// </summary>
    public class SprzedazKsiazek
    {

        private int _Id;
        /// <summary>
        /// id szczegółu (pozycji) na fakturze, przechowywany w bazie danych
        /// </summary>
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
        /// <summary>
        /// id książki, której pozycja na fakturze dotyczy
        /// </summary>
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
        /// <summary>
        /// Szczegółowy opis książki, której pozycja dotyczy
        /// </summary>
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
        /// <summary>
        /// Cena jednostkowa sprzedaży tej pozycji.
        /// </summary>
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

        /// <summary>
        /// Pozwala na wyświetlanie ceny książki z kropką '.' zamiast przecinka ','
        /// niezbędne do prawidłowego stosowana ceny w zapytaniach SQLite.
        /// </summary>
        public string CenaString
        {
            get
            {
                IFormatProvider FormatProvider = new System.Globalization.CultureInfo("");
                StringBuilder SB = new StringBuilder();
                SB.AppendFormat(FormatProvider, "{0}", this.Cena);
                return SB.ToString();
            }
        }

        private decimal _Ilosc;
        /// <summary>
        /// Ile jest na fakturze pozycji danej książki.
        /// </summary>
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

/*
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
*/
    }
}
