using System;

class Program
{
    static void Main()
    {
        DrawFigure1();
        Console.WriteLine();
        DrawFigure2();
        Console.WriteLine();
        DrawFigure3();
    }

    static void DrawFigure1()
    {
        Console.WriteLine("Фигура 1");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (j < 8 - i || j == 4 || j > 4 + i)
                    Console.Write("p");
                else
                    Console.Write("0");
            }
            Console.WriteLine();
        }
    }

    static void DrawFigure2()
    {
        Console.WriteLine("Фигура 2");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (j < 5 - i || j > 5 + i || i == 4)
                    Console.Write("j");
                else
                    Console.Write("0");
            }
            Console.WriteLine();
        }
    }

    static void DrawFigure3()
    {
        Console.WriteLine("Фигура 3");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (j < i || j == 8 || i == j || i == 4)
                    Console.Write("d");
                else
                    Console.Write("0");
            }
            Console.WriteLine();
        }
    }
}