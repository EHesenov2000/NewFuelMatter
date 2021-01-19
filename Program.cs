using System;

namespace FuelQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // commmon fuel  -  l
            // way length    -  m
            // fuel for 1 km -  k
            int l = 100; 
            double k = 1.5;
            int m = 100;

            if (l > 0 && k > 0 && m > 0)
            {
                if (l > m * k)
                {
                    Console.WriteLine("You can go this distance with your car's fuel");

                }
                else
                {
                    Console.WriteLine("You can not go this distance with your car's fuel");

                }
            }
            else
            {
                Console.WriteLine("Please, enter correct numbers...");

            }
        }
    }
}
