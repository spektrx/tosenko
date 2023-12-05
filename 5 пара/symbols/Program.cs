using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double diameter = 2 * radius;
        double circumference = 2 * 3.14159 * radius;
        double area = 3.14159 * radius * radius;

        Console.WriteLine("Диаметр круга: {0}", diameter);
        Console.WriteLine("Длина окружности: {0}", circumference);
        Console.WriteLine("Площадь круга: {0}", area);
    }
}