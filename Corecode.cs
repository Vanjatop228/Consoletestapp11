using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] cars = new long[100000000];
            Random rand = new Random();
            for (long i = 0; i < cars.Length; i++) 
            {
                cars[i] = rand.Next(0, 1000000000);
                Console.WriteLine(cars[i]);
            }
        }
    }
}

