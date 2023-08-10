using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawShapes.Classes
{
    public class Draw
    {
        public void DrawTriangle()
        {
            int height = ValueManipulator.GetValueByMessage("Enter the height of the triangle:");

            for (int iteration = 1; iteration <= height; iteration++)
            {
                for (int spaceIteration = height - 1; spaceIteration >= iteration; spaceIteration--)
                {
                    Console.Write(" ");
                }
                for (int starsIteration = 1; starsIteration <= 2 * iteration - 1; starsIteration++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void DrawRectangle()
        {
            int height = ValueManipulator.GetValueByMessage("Enter the height of the rectangle:");
            int width = ValueManipulator.GetValueByMessage("Enter the width of the rectangle:");

            for (int iteration = 1; iteration <= height; iteration++)
            {
                for (int starsIteration = 1; starsIteration <= width; starsIteration++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void DrawRhombus()
        {
            int height = ValueManipulator.GetValueByMessage("Enter the height which is half of the rhombus:");

            for (int iteration = 1; iteration <= height; iteration++)
            {
                for (int spaceIteration = 1; spaceIteration <= height - iteration; spaceIteration++)
                {
                    Console.Write(" ");
                }
                for (int spaceIteration = 1; spaceIteration <= 2 * iteration - 1; spaceIteration++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int iteration = height - 1; iteration >= 1; iteration--)
            {
                for (int spaceIteration = 1; spaceIteration <= height - iteration; spaceIteration++)
                {
                    Console.Write(" ");
                }
                for (int spaceIteration = 1; spaceIteration <= 2 * iteration - 1; spaceIteration++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}