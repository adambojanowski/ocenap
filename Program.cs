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
            //this.name = "janek";
            //this.ocena = 22.1F;
            this.id = pId;
            this.name = pName;
            this.ocena = pOcena;
        }
        class MainClass
        {

            //List<string> lista = new List<string>();
            //var wpis = ja.name; //Console.ReadLine();
            //lista.Add(ja.name,ja.ocena);//(wpis);
            /*Console.WriteLine("Wpisz 5 razy: imie spacja ocena");
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


            public static void Main(string[] args) //bez static
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

                Pracownik ja = new Pracownik(Id=0,"ja", 55.5F);
                Pracownik ty = new Pracownik(Id=1,"ty", 72.1F);
                Pracownik on = new Pracownik(Id=2,"on", 44.6F);
                Pracownik ona = new Pracownik(Id=3,"ona", 32.1F);
                Pracownik ono = new Pracownik(Id=4,"ono", 66.1F);*/
                //Console.WriteLine(on.name + " "+ on.ocena);
                //Console.WriteLine(ona.name +" "+ ona.ocena);
                //var person = Tuple.Create(ja.name, ja.ocena);
                //person. (ty.name, ty.ocena);
                //Console.WriteLine(person.Item1 + " " + person.Item2);
                //Console.WriteLine(person);//drukuje caly tuple
                var pracownicy = new List<Pracownik>
            {
                //List<string,float> lista = new List<string,float>();
                //var wpis = ja.name; //Console.ReadLine();
                /* { Id=1,ja.name +" "+ja.ocena }, //oszukuje klejac dwa pola w jedno
                 { ty.name +" "+ty.ocena },
                 { on.name +" "+on.ocena },
                 { ona.name +" "+ona.ocena },
                 { ono.name +" "+ono.ocena }
                 */
               
                new Pracownik(0, "ja", 55.5F),
                new Pracownik(1, "ty", 72.1F),
                new Pracownik(2, "on", 44.6F),
                new Pracownik(3, "ona", 32.1F),
                new Pracownik(4, "ono", 66.1F),
                new Pracownik(5, "billja" ,66.6F)
            };
                //lista.Sort(ja.name);
                Console.WriteLine(pracownicy.Count);
                //lista.
                /*for (int i = 0; i < pracownicy.Count; i++)
                {
                    Pracownik a = pracownicy[i];*/
                    Console.WriteLine(pracownicy);//tylko 1 linia
                //}
            }
        }

        /*class Pracownik
        {
            public int Id; //=1;
            public string name; //= "Adam Bojanowski";
            public float ocena; //= 23.7F;

            public Pracownik(int Id, string pName, float pOcena)//konstruktor inicjalizuje 
            {
                //this.name = "janek";
                //this.ocena = 22.1F;
                this.Id = Id;
                this.name = pName;
                this.ocena = pOcena;
            }*/
    }
}
