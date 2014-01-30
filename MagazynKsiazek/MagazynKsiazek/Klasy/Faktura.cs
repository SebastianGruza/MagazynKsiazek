using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    /// <summary>
    /// Pozwala na przechowywanie wszystkich danych dotyczących faktur.
    /// </summary>
    public class Faktura
    {
        /// <summary>
        /// Szczegóły dotyczące poszczególnych pozycji książkowych na tej fakturze.
        /// </summary>
        public IList<SprzedazKsiazek> listaSprzedanychKsiazek = new List<SprzedazKsiazek>();
        /// <summary>
        /// klient, którego faktura dotyczy
        /// </summary>
        public Klient klient=null;
        public Faktura()
        {
            Data = DateTime.Now;
            Id = -1;
        }

        private int _Nr;
        public int Nr
        {
            get
            {
                return _Nr;
            }
            set
            {
                this._Nr = value;
            }
        }

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



        private DateTime _Data;
        /// <summary>
        /// Data drukowania faktury sprzedaży.
        /// </summary>
        public DateTime Data
        {
            get
            {
                return this._Data;
            }
            set
            {
                this._Data = value;
            }
        }
        private int _ID_Klienta;
        public int ID_Klienta
        {
            get
            {
                return this._ID_Klienta;
            }
            set
            {
                this._ID_Klienta = value;
            }
        }

 
        /// <summary>
        /// Obliczenie ceny całkowitej faktury na podstawie ceny poszczególnych pozycji książkowych
        /// (szczegółów faktury).
        /// </summary>
        public decimal Cena
        {
            get
            {
                decimal razem = 0;
                for (int i = 0; i < listaSprzedanychKsiazek.Count; i++)
                {
                    SprzedazKsiazek pozycja = listaSprzedanychKsiazek[i];
                    razem = razem + pozycja.Ilosc * pozycja.Cena;
                }
                return razem;
            }

        }
    }
}
