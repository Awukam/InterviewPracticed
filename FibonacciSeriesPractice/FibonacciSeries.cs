using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesPractice
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int Number, PreviousNumber = -1, NextNumber = +1;
            Console.WriteLine("Please Enter Fibonacci Number and Press Enter");
            Number = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series");

            for (int i = 0; i< Number; i++) 
            {
                int SumNumber = PreviousNumber + NextNumber;
                Console.WriteLine(SumNumber);
                PreviousNumber = NextNumber;
                NextNumber = SumNumber;

                Console.ReadLine();
            }
        }
    }
}
