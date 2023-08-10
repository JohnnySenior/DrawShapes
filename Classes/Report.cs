using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawShapes.Classes
{
    public static class Report
    {
        public static void ShowMenu()
        {
            Console.WriteLine("You can draw various shapes!");
            Console.WriteLine();
            Console.WriteLine("--------------- Shapes ---------------");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Rhombus");
            Console.WriteLine("4. Exit");
            Console.WriteLine("--------------- Shapes ---------------");
            Console.Write("Choose the shape: ");
        }

        public static void ExitFromProgram()
        {
            Console.WriteLine("Thank you using our Application ;)");
        }

        public static void DefaultCase()
        {
            Console.WriteLine("We have only 3 shapes now.");
        }
    }
}