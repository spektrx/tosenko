using System.Runtime.CompilerServices;

NewMethod();

static void NewMethod()
{
    Console.WriteLine("enter num.");
    int num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"{num1+1},  {num1-1}");

}
