using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B, которое больше A: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A >= B)
            {
                Console.WriteLine("число B меньше числа A");
            }
            else
            {
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
