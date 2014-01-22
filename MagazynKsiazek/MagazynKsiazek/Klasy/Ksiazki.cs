﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    public class Ksiazki
    {
        public int ISBN { get; set; }
        public string Tytul { get; set; }
        public string DaneAutora { get; set; }
        public string Wydawnictwo { get; set; }
        public string RokWydania { get; set; }
        public string Gatunek { get; set; }
        public Int32 Ilosc { get; set; }
        public Decimal Cena { get; set; }

        public Ksiazki(int isbn, string tytul, string daneAutora, string wydawnictwo,
        string rokwydania, string gatunek, Int32 ilosc, Decimal cena)
        {
            ISBN = isbn;
            Tytul = tytul;
            DaneAutora = daneAutora;
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

        public override string ToString()
        {
            return String.Format("{0,-4} {1,-23} {2,-21} ", this.ISBN, this.Tytul, this.DaneAutora);
        }
    }
}


