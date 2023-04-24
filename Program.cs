using System;
using System.Collections.Generic;

namespace ocenap
{
    class MainClass
    /*
     List<string> lista = new List<string>();
        Console.WriteLine("Wpisz 5 razy: imie spacja ocena");
        for (int i = 0; i < 5; i++)
        {
            //Console.WriteLine("Wpisz 5 razy: imie spacja ocena");
            var wpis = Console.ReadLine();
            //avoid problems with empty or nullstrings
            if (!String.IsNullOrEmpty(wpis))
            {
                lista.Add(wpis);
            }
        }
        foreach(string a in lista)
        {
            Console.WriteLine(a);
        }
     */

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ocena pracownika");
            //rezygnuje z tupla na rzecz listy
           /*(string,float) t1=("adam",23.56F);//lista pracownikow i ocen jako tuple
            Pracownik ja = new Pracownik("ja", 55.5F);
            //foreach (string a in t1)
            //{
                Console.WriteLine(t1.Item1+" "+t1.Item2);
            //}
            //for(int i=0; i<iT.Length;i++) //iteracja po tuple
            //Console.WriteLine(iT[i]);
            */
            Pracownik ty = new Pracownik("ty", 72.1F);
            Pracownik on = new Pracownik("on",44.6F);
            Pracownik ona = new Pracownik("ona",32.1F);
            Pracownik ono = new Pracownik("ono", 66.1F);
            Console.WriteLine(on.name + " "+ on.ocena);
            Console.WriteLine(ona.name +" "+ ona.ocena);
            var person = Tuple.Create(ja.name, ja.ocena);
            person. (ty.name, ty.ocena);
            Console.WriteLine(person.Item1 + " " + person.Item2);
            Console.WriteLine(person);//drukuje caly tuple
        }
    }
    class Pracownik
    {
        public string name; //= "Adam Bojanowski";
        public float ocena; //= 23.7F;

       public Pracownik(string pName, float pOcena)//konstruktor inicjalizuje 
        {
            //this.name = "janek";
            //this.ocena = 22.1F;
            this.name = pName;
            this.ocena = pOcena;
        }
        }
}
