using System;
using System.Collections.Generic;
using System.Linq;
namespace ocenap
{

    class Pracownik
    {
        public int id; //=1;
        public string name; //= "Adam Bojanowski";
        public float ocena; //= 23.7F;

        public Pracownik(int pId, string pName, float pOcena)//konstruktor inicjalizuje 
        {
            this.id = pId;
            this.name = pName;
            this.ocena = pOcena;
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Ocena pracownika");

                var pracownicy = new List<Pracownik>
            {

                new Pracownik(0, "ja", 55.5F),
                new Pracownik(1, "ty", 72.1F),
                new Pracownik(2, "on", 44.6F),
                new Pracownik(3, "ona", 32.1F),
                new Pracownik(4, "ono", 66.1F),
                new Pracownik(5, "bill" ,66.6F)
            };
                Console.WriteLine("Liczba pracownikow:");
                Console.WriteLine(pracownicy.Count);

                Console.WriteLine("----Lista wg. kolejnosci zapisu:----");
                foreach (var item in pracownicy)
                {
                    //Console.WriteLine(string.Join(",",item.name,item.ocena));// also ok
                    Console.WriteLine(item.id + " " + item.name + " " + item.ocena);
                }

                Console.WriteLine("----lista posortowana wg. ocen----");
                //with a great help from https://zetcode.com/csharp/sortlist/
                var enum1 = from Pracownik in pracownicy
                            orderby Pracownik.ocena
                            select Pracownik;

                foreach (var e in enum1)
                {
                    //Console.WriteLine(e);//doesn't work
                    Console.WriteLine(e.id + " " + e.name + " " + e.ocena);
                }

                Console.WriteLine("----najgorszy pracownik----");
            
                Console.WriteLine(enum1.FirstOrDefault().id + " " + enum1.FirstOrDefault().name + " " + enum1.FirstOrDefault().ocena);

                Console.WriteLine("----najlepszy pracownik----");
                Console.WriteLine(enum1.Last().id + " " + enum1.Last().name + " " + enum1.Last().ocena);

            }


            }
        }
    }


