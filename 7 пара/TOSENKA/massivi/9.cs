
int[,] pattern = new int[4, 4];
bool isPatternNice = true;
Random random = new Random();


for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        pattern[i, j] = random.Next(0, 2);
        Console.Write(pattern[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (pattern[i, j] == pattern[i, j + 1] && pattern[i, j] == pattern[i + 1, j] && pattern[i, j] == pattern[i + 1, j + 1])
        {
            isPatternNice = false;
            break;
        }
    }
    if (!isPatternNice)
    {
        break;
    }
}

Console.WriteLine(isPatternNice);