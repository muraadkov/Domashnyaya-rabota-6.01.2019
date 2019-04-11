using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Array__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, count = 0;
            char i;
            do
            {
                Console.WriteLine("Введите символ");
                do
                {
                    e = Console.Read();
                    i = (char)e;
                } while (i == '\n' | i == '\r');
                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);
                    count++;

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                    count++;
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    i = (char)e;
                    Console.WriteLine(i);
                }
            } while (e != 46);
            Console.WriteLine("Всего введено " + count + " символов");
        }

    }
}