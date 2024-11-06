using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Zvirata{
    class Program
    {
        public static void Main(string[] args)
        {
            Zvire Kocka = new Zvire("meow", "černé", 5);
            Zvire Kocka1 = new Zvire("meow", "bílá", 5); 
            Zvire Kocka2 = new Zvire("meow", "tříbaevná", 5);  
            Zvire Pes = new Zvire("Haf", "bílé", 2);
            Zvire had = new Zvire("SSSSsssSSSSS", "Zelený", 3);
            Zvire zirafa = new Zvire("Žirafuje", "žlutá", 10);
            Zvire mravenecnik = new Zvire("Mravenečnikuje", "hnědá", 3);
            Zvire koala = new Zvire("koaluje", "hnědá", 2);
            Zvire mravenec = new Zvire("pracuje", "malinký", 1);
            Zvire fretka = new Zvire("war dance", "bandita", 4);
            Zvire krtek = new Zvire("zvuk hrabání", "černý", 3);
            Zvire medved = new Zvire("bububu", "hnědá", 3);
            
            Zvire.print(Kocka);
            Zvire.print(Kocka1);
            Zvire.print(Kocka2);
            Zvire.print(Pes);
            Zvire.print(had);
            Zvire.print(zirafa);
            Zvire.print(mravenec);
            Zvire.print(mravenecnik);
            Zvire.print(koala);
            Zvire.print(fretka);
            Zvire.print(krtek);
            Zvire.print(medved);
        }
    }
}
