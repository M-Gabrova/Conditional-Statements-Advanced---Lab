using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((hour < 19 && hour > 9) && (day == "Monday" || day == "Tuesday" || day =="Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
