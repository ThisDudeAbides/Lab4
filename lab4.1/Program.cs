using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

                Console.WriteLine("please enter a numer less than 100");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"{"Number",-10}{"square",-10}{"cubed",-10}");
                Console.WriteLine($"{"======",-10}{"======",-10}{"======",- 10}");
                for (int i = 1; i <= number; i++)
                {
                int num = i;
                int square = i * i;
                int cube = i * i * i;

                    Console.WriteLine($"{num,-10}{square,-10}{cube,-10}");

                }
                Console.WriteLine("do you want to continie: y/n");
                string response = (Console.ReadLine());
                if (response.ToLower() == "n")
                {
                    break;
                }

                Console.WriteLine("hope you had fun");

            }

        }
    }
}
