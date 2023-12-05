using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

uint[] Massiv = new uint[10];

Random Rand = new Random();


for (int i = 0; i < Massiv.Length; i++)
{
     Massiv[i] = (uint)Rand.Next(100);
    Console.Write(Massiv[i] + " ");
}
Console.WriteLine();

uint sum = 0;
ulong mul = 1;

foreach (uint i in Massiv)
{
    sum += i;
    mul *= i;
}

Console.WriteLine("Сумма: "+sum);
Console.WriteLine("ПРоизведение: "+mul);