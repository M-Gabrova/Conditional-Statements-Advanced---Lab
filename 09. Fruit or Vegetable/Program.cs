using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();

            //banana, apple, kiwi, cherry, lemon и grap
            if (food == "banana" || food == "apple" || food == "kiwi" || food == "cherry" || food == "lemon" || food == "grapes")
            {
                Console.WriteLine("fruit");

            }
            //tomato, cucumber, pepper и carro
            //vegetable
            else if (food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot")
            {
                Console.WriteLine("vegetable");

            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
