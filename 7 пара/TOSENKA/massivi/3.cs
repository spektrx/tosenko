

Console.Write("min: ");
int min = int.Parse(Console.ReadLine());
Console.Write("max: ");
int max = int.Parse(Console.ReadLine());
Console.Write("step: ");
int step = int.Parse(Console.ReadLine());


for (int i = min; i <= max; i+=step)
{
    Console.Write(i + " ");
}

