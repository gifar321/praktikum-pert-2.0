using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Äplikasi Calculator";

            int a = 10; // declarasi variabel a, dg nilai awal 10;
            int b = 6; // declarasi variabel b, dg nilai awal 6;

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(1, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        //TODO: tambahkan method untuk perkalian dan pembagian
    }
}