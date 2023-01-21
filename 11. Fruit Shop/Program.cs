using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                //(banana / apple / orange / grapefruit / kiwi / pineapple / grapes
                //2.50 1.20 0.85 1.45 2.70 5.50 3.85
                if (fruit == "banana")
                {
                    price = 2.5 ;
                }
                else if (fruit == "apple")
                {
                    price = 1.2;
                }
                else if (fruit == "orange")
                {
                    price = 0.85 ;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.7 ;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.5;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85 ;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            //2.70 1.25 0.90 1.60 3.00 5.60 4.20
            else if (day == "Sunday" || day == "Saturday")
            {
                if (fruit == "banana")
                {
                    price = 2.7;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.9;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.6;
                }
                else if (fruit == "kiwi")
                {
                    price = 3;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.6;
                }
                else if (fruit == "grapes")
                {
                    price = 4.2;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            double sum = quantity * price;
            if (sum>0)
            {
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
