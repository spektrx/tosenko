using System.Runtime.CompilerServices;

NewMethod();

static void NewMethod()
{
    Console.WriteLine("enter 3 num.");
    int num1 = Convert.ToInt16(Console.ReadLine());
    int num2 = Convert.ToInt16(Console.ReadLine());
    int num3 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"{num1+num2+num3}");

}
