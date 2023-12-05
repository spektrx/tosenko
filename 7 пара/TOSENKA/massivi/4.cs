int number = int.Parse(Console.ReadLine());

int[] factorial = new int[number + 1];

factorial[0] = 1;


for (int i = 1; i <= number; i++)
{
    factorial[i] = factorial[i - 1] * i;
}

Console.WriteLine($"Факториал числа {number} равен {factorial[number]}");

Console.ReadLine();