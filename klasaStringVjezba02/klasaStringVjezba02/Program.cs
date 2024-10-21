using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova");
            string unos = Console.ReadLine();
            string ispis = unos.Replace(" ", "_");
            Console.WriteLine(ispis);
            Console.ReadKey();




        }
    }
}
