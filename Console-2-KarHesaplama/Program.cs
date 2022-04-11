using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_2_KarHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KarHesaplama
            double numbers, numbers2, numbers3;
            Console.WriteLine("Sayı girini");
            numbers =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kar girini");
            numbers2 = Convert.ToDouble(Console.ReadLine());
            numbers3 = numbers2 + (numbers* numbers2/100);

            Console.WriteLine("Sonuç :"+ numbers3);
            Console.ReadKey();
        }
    }
}
