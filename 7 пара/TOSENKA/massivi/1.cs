using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


var Massiv = new int[10];

Random Rand = new Random();


for (int i = 0; i < Massiv.Length; i++)
{
    Massiv[i] = Rand.Next(100);
    Console.Write(Massiv[i] + " ");
}
Console.WriteLine();

int maxx = 0;


foreach (int i in Massiv)
{
    if (i > maxx)
    {
        maxx = i;
    }
}

Console.WriteLine(maxx);