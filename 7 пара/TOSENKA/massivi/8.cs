
Random random = new Random();
int randomNumber = random.Next(101);

int attempts = 0;

while (attempts < 10)
{
    Console.WriteLine($"Осталось попыток: {10 - attempts}");
    Console.Write("Введите число от 0 до 100: ");
    int guess = int.Parse(Console.ReadLine());

    

    if (guess == randomNumber)
    {
        Console.WriteLine("Класс, вы угадали!");
        break;
    }
    else if (guess < randomNumber)
    {
        Console.WriteLine($"Загаданное число больше {guess}");
    }
    else
    {
        Console.WriteLine($"Загаданное число меньше {guess}");
    }attempts++;
}

if (attempts == 10)
    Console.WriteLine($"Вы исчерпали все 10 попыток. Загаданное число: {randomNumber}");