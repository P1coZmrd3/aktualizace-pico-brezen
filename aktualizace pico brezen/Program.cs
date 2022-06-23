using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidovaKuchyne               
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = 1;
            int cislo2 = 5;
            int[] cisla = { cislo1, cislo2 };
            Console.Clear();
            int max = cisla.Max();
            int min = cisla.Min();
            Console.WriteLine(max + ", " + min);
            
            Console.ReadLine();
        }
    }
}