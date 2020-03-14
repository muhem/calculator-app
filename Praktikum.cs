using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
           

            Console.WriteLine("Pilih :");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Penngurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Input [1]...[4] : ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (c < 1)
            {
                Console.WriteLine("Input yang anda masukan salah");
            }
            else if (c > 4)
            {
                Console.WriteLine("Input yang anda masukan salah");
            }
            else
            {
                if (c == 1)
                {
                    Console.Write("Input angka pertama = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Input angka kedua = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil {0} + {1} = {2} ", a, b, Penjumlahan(a, b));
                }
                else if (c == 2)
                {
                    Console.Write("Input angka pertama = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Input angka kedua = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                }
                else if (c == 3)
                {
                    Console.Write("Input angka pertama = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Input angka kedua = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil {0} * {1} = {2} ", a, b, Perkalian(a, b));
                }
                else if (c == 4)
                {
                    Console.Write("Input angka pertama = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Input angka kedua = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil {0} / {1} = {2} ", a, b, Pembagian(a, b));
                }
            }

                Console.WriteLine("\nTekan apapun untuk keluar");
            Console.ReadKey();
        }
        static int Penjumlahan(int a, int b)
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
    }
}
