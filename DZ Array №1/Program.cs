using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Array__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSpace = 0;
            Console.WriteLine("Введите символы: ");
            char input = ' ';
            while (input != '.')
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                {
                    countOfSpace += 1;
                }
            }
            Console.WriteLine($"\nКоличество пробелов: {countOfSpace}");
            Console.ReadLine();
        }
    }
}
