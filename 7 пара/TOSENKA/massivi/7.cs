
int n = int.Parse(Console.ReadLine());

double b = 1.0;
double q = -0.5;

double sum = 0;

for (int i = 0; i < n; i++)
{
    Console.Write(b + " ");
    sum += b;
    b *= q;
}

Console.WriteLine();
Console.WriteLine(sum);
Console.Write(((1.0 * (Math.Pow(q, n) - 1)) / (q - 1)));