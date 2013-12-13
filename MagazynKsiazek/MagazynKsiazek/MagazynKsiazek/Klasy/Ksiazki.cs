using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    class Ksiazki
    {
        public int ISBN { get; set; }
        public string Tytul { get; set; }
        public int ID_Autora { get; set; }
        public string Wydawnictwo { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public int Ilosc { get; set; }
        public int Cena { get; set; }

        public Ksiazki(int isbn, string tytul, int id_autora, string wydawnictwo,
        int rokwydania, string gatunek, int ilosc, int cena)
        {
            ISBN = isbn;
            Tytul = tytul;
            ID_Autora = id_autora;
            Wydawnictwo = wydawnictwo;
            RokWydania = rokwydania;
            Gatunek = gatunek;
            Ilosc = ilosc;
            Cena = cena;

        }

        public Ksiazki()
        {
            // TODO: Complete member initialization
        }

    }
}


