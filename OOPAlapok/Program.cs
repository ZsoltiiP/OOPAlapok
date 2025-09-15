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
        private string _nev;
        private int _kor;

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

    class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Kor = 23;
            person.Nev = "Kiss Ilona";
            Console.WriteLine(person);



            /*
            Szemely person = new Szemely("Peti", 22);
            Console.WriteLine(person.Kiir());
            */
        }


    }
}
