using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var Massiv = new int[10];

Random Rand = new Random();


for (int i = 0; i < Massiv.Length; i++)
{
    Massiv[i] = Rand.Next(100);
    Console.Write(Massiv[i] + " ");
}
Console.WriteLine();
   


int even = 0;
int odd = 0;

foreach (int i in Massiv)
{
    if (i % 2 == 0)
    {
        even += 1;
    }
    else
    {
        odd += 1;
    }
}

Console.WriteLine("odd: "+odd);
Console.WriteLine("even: "+even);
