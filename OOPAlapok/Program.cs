using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string _nev;
        private int _kor;


        public Szemely(string nev, int kor)
        {
            _nev = nev;
            Kor = kor;
        }

        public string Nev
        {
            get { return _nev; }
            set { _nev = value; }
        }
        public int Kor
        {
            get { return _kor; }
            set 
            {
                if (value > 0)
                    _kor = value;
                else
                    Console.WriteLine("Nem lehet negatív.");
            }
        }
        public override string ToString()
        {
            return $"A személy neve: {_nev} és az életkora {_kor}";
        }


        /*
        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }*/

        //public string Kiir()
        //{
        //    return $"A személy neve: {nev}, az életkora: {kor}";
        //}
    }
    public class BankSzamla
    {
        private int _egyenleg;

        public int Egyenleg
        {
            get { return _egyenleg; }
            set 
            {
                if (value > 0)
                    _egyenleg = value;
                else
                    Console.WriteLine("Egyenleg nem lehet nulla!");
            }
        }
        public void Betesz()
        {

        }
        public void Kivesz()
        {

        }

    }
    

    public class Hallgato : Szemely
    {
        
        private string _neptunkod;


        public Hallgato(string nev, int kor) : base(nev, kor)
        {

        }

        public string Neptunkod
        {
            get { return _neptunkod; }
            set
            {
                if (_neptunkod.Length <= 6)
                    _neptunkod = value;
                else
                    Console.WriteLine("Túl hosszú!");
            }
        }

        public override string ToString()
        {
            _nev = "Gábor";
            return $"A hallgató neve {_nev}";
        }
    }
    public class Dolgozo : Szemely
    {
        public int _ber;


        public override string ToString()
        {
            return $"A dolgozó neve {_nev}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Kiss Ilona", 23);
            person.Kor = 23;
            person.Nev = "Kiss Ilona";
            Console.WriteLine(person);

            Hallgato student = new Hallgato(person.Nev, person.Kor);
            Console.WriteLine(student);

            List<Hallgato> studentList = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Hallgato student2 = new Hallgato();
                Console.Write($"Kérem a {i+1} hallgató nevét: ");
                student2.Nev = Console.ReadLine();
                Console.Write($"Kérem a {i + 1} hallgató életkorát: ");
                student2.Kor = int.Parse(Console.ReadLine());
                studentList.Add(student2);
            }
            foreach (var item in studentList)
            {
                Console.WriteLine(item.Nev);
            }

            Dolgozo worker = new Dolgozo();
            Console.WriteLine(worker);

            /*
            Szemely person = new Szemely("Peti", 22);
            Console.WriteLine(person.Kiir());
            */
        }


    }
}
