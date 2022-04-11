using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Ornek1_YuzdeHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yuzde Hesaplama
            // A sayısının yüzde B'si kaçtır?

            double numbers1, numbers2,result1,result2;
            Console.WriteLine("Lütfen Sayı giriniz (A SAYISI) :");
            numbers1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Yüzde giriniz (B SAYISI) :");
            numbers2 = Convert.ToDouble(Console.ReadLine());
            result1 = numbers1 * numbers2 / 100;
            Console.WriteLine("Girilen Sayının % :" + result1);
            result2 = numbers1 - result1;
            Console.WriteLine("Kalan : " + result2);
            Console.ReadLine();

        }
    }
}
