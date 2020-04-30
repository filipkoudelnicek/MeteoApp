using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Meteo_OOP
{
    class Program
    {
        public static void Main()
        {
            Code calc = new Code();

            calc.Temps();
            calc.Graphics();
            calc.Stats();

            Console.ReadKey(true);
        }
    }
}