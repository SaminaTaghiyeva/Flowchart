using System;

namespace Flowcharts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1

            int a = 3;
        Begin:
            if (a == 5)
            {
                Console.WriteLine("Carpe diem");
            }
            else
            {
                ++a;
                goto Begin;
            }

            //Task2

            string[] word = { "a", "l", "m", "a" };
            if (word[0] == "a")
            {
                Console.WriteLine("Please, write a new word");
            }
            else
            {
                Console.WriteLine("alma");
            }

        //Task3

        Begin:
            int a = 3527;
            if (a >= 1000 && a <= 9999)
            {
                Console.WriteLine(a / 100);
            }
            else
            {
                goto Begin;
            }
        }
    }
}
