using System;
using System.Runtime.InteropServices;

namespace Zvirata{
    class Zvire{
            private string zvuk;

            private string rasa;

            private int vek;

            public Zvire(string zvuk, string rasa, int vek){
                this.zvuk = zvuk;
                this.rasa = rasa;
                this.vek = vek;
            }

            public static void print(Zvire zvire){
                Console.WriteLine("Rasa = " + zvire.rasa);
                Console.WriteLine("Věk = " + zvire.vek);
                Console.WriteLine("Zvuk = " + zvire.zvuk);
            }


        }
}