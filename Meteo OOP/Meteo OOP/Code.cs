using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meteo_OOP
{
    class Code
    {
        private int[] temps = new int[7];
        private readonly string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private readonly string[] shortDays = { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };

        public void Temps()
        {
            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write("What was the temperature on {0}?: ", days[i]);

                while (!int.TryParse(Console.ReadLine(), out temps[i]))
                {
                    Console.WriteLine("Invalid input.");
                }
                
            }
            Console.WriteLine();
        }

        public void Graphics()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");

            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", shortDays[i]);

                if (temps[i] < 0)
                {
                    for (int y = 0; y > temps.Min() - temps[i]; y--)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y > temps[i]; y--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                    Console.WriteLine(" {0}", temps[i]);
                }

                if (temps[i] >= 0)
                {
                    for (int y = 0; y > temps.Min(); y--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("|");

                    for (int k = 0; k < temps[i]; k++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine(" {0}", temps[i]);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
        }

        public void Stats()
        {
            int maxIndex = temps.Max();
            int minIndex = temps.Min();

            string minString = "(";
            string maxString = "(";

            int counter = 0;
            foreach (var i in temps)
            {
                if (i == minIndex)
                {
                    if (minString == "(")
                    {
                        minString += String.Format("{0}", shortDays[counter]);
                    }
                    else
                    {
                        minString += String.Format(", {0}", shortDays[counter]);
                    }
                }

                else if (i == maxIndex)
                {
                    if (maxString == "(")
                    {
                        maxString += String.Format("{0}", shortDays[counter]);
                    }
                    else
                    {
                        maxString += String.Format(", {0}", shortDays[counter]);
                    }
                }
                counter++;
            }
            Console.WriteLine("Min temp: {0} {1})", temps.Min(), minString);
            Console.WriteLine("Max temp: {0} {1})", temps.Max(), maxString);
            Console.WriteLine("Avarage temp: {0})", Math.Round(temps.Average(), 1));
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
        }
    }
}