using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(счетчик;условие;изменение счетчика) 
            // while
            // do..while
            // foreach
            // F = n! - факториал

            //for(int i = 0;i < 9;i++)
            //{
            //    Console.WriteLine($"{i} - {i * i}");
            //}

            //int i = 6;
            //while(i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //int i = 6;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);

            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine($"{i}");
            //}

            int n = 6; // 720
            int result = 1;
            for (int i = 1; i <=n; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
