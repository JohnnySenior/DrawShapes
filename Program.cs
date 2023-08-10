int shape;
do
{
ShowMenu();

shape = ConvertOptionValue();

if (shape == 1)
{
    DrawTriangle();
}
else if (shape == 2)
{
    DrawRectangle();
}

else if (shape == 3)
{
    DrawRhombus();
}
else if (shape == 4)
{
    ExitFromProgram();
}
else
{
    DefaultCase();
}
}while(shape != 4);

void ShowMenu()
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

int ConvertOptionValue()
{
    string input = Console.ReadLine();
    Console.Clear();
    Console.WriteLine();
    return int.Parse(input);
}

void DrawTriangle()
{
    int height = GetValueByMessage("Enter the height of the triangle:");

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

void DrawRectangle()
{
    int height = GetValueByMessage("Enter the height of the rectangle:");
    int width = GetValueByMessage("Enter the width of the rectangle:");

    for (int iteration = 1; iteration <= height; iteration++)
    {
        for (int starsIteration = 1; starsIteration <= width; starsIteration++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

void DrawRhombus()
{
    int height = GetValueByMessage("Enter the height which is half of the rhombus:");

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

void ExitFromProgram()
{
    Console.WriteLine("Thank you using our Application ;)");
}

void DefaultCase()
{
    Console.WriteLine("We have only 3 shapes now.");
}

int GetValueByMessage(string message)
{
    Console.Write(message + " ");
    string stringHeight = Console.ReadLine();
    return int.Parse(stringHeight);
}


