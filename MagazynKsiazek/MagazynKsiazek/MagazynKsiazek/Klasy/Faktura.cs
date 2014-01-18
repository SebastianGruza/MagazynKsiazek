using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    public class Faktura
    {

        public IList<SprzedazKsiazek> listaSprzedanychKsiazek = new List<SprzedazKsiazek>();
        public Klient klient = new Klient();
        public Faktura()
        {
            Data = DateTime.Now;
            Id = -1;
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
