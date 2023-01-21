using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();

            double sales = double.Parse(Console.ReadLine());

            if (sales > 0)
            {
                double percentDifference;

                double totalSelling = 0;

                if (city == "Sofia")
                {
                    if ((sales >= 0) && (sales < 501))
                    {
                        percentDifference = sales * 0.05;
                    }

                    else if (sales < 1001)
                    {
                        percentDifference = sales * 0.07;
                    }

                    else if (sales <= 10000)
                    {
                        percentDifference = sales * 0.08;
                    }

                    else if (sales > 10000)
                    {
                        percentDifference = sales * 0.12;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else if (city == "Varna")
                {
                    if ((sales >= 0) && (sales < 501))
                    {
                        percentDifference = sales * 0.045;
                    }

                    else if (sales < 1001)
                    {
                        percentDifference = sales * 0.075;
                    }

                    else if (sales <= 10000)
                    {
                        percentDifference = sales * 0.1;
                    }

                    else if (sales > 10000)
                    {
                        percentDifference = sales * 0.13;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else if (city == "Plovdiv")
                {
                    if ((sales >= 0) && (sales < 501))
                    {
                        percentDifference = sales * 0.055;
                    }

                    else if (sales < 1001)
                    {
                        percentDifference = sales * 0.08;
                    }

                    else if (sales <= 10000)
                    {
                        percentDifference = sales * 0.12;
                    }

                    else if (sales > 10000)
                    {
                        percentDifference = sales * 0.145;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else
                {
                    Console.WriteLine("error");

                    return;
                }

                totalSelling -= percentDifference;
                Console.WriteLine($"{Math.Abs(totalSelling):F2}");
            }

            else
            {
                Console.WriteLine("error");

                return;
            }
        }
    }
}