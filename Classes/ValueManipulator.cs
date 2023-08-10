using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawShapes.Classes
{
    public static class ValueManipulator
    {
        public static int ConvertOptionValue()
        {
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            return int.Parse(input);
        }

        public static int GetValueByMessage(string message)
        {
            Console.Write(message + " ");
            string stringHeight = Console.ReadLine();
            return int.Parse(stringHeight);
        }
    }
}