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
        private string nev;
        private int kor;

        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kiir()
        {
            return $"A személy neve: {nev}, az életkora: {kor}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Peti", 22);
            Console.WriteLine(person.Kiir());
        }


    }
}
