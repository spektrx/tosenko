Console.Write("Columns: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Rows: ");
int rows = int.Parse(Console.ReadLine());

char[,] ad = new char[columns, rows];
short[,] board = new short[columns, rows];

Console.WriteLine("Colors of ad");
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        ad[i, j] = char.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.WriteLine("Colors of board");
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        board[i, j] = short.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}



for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(ad[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(board[i, j] + " ");
    }
    Console.WriteLine();
}

bool flag = true;
for(int i = 0; flag && i < columns; i++)
{
    for(int j = 0; j < rows; j++)
    {
        if (ad[i, j] == '.') continue;

        if (!Check(ad[i, j], board[i, j]))
        {
            flag = false;
            Console.WriteLine($"Не совместимы {ad[i, j]} {board[i, j]}");
            break;
        }                
    }
}

if (flag)
    Console.Write("all good");


bool Check(char adColor, short boardColor)
{
    if (adColor == 'R')
    {
        if (boardColor < 4)
            return false;
    }
    else if(adColor == 'G')
    {
        if (boardColor != 2 && boardColor != 3 && boardColor != 6 && boardColor != 7)
            return false;
    }
    else
    {
        if (boardColor != 1 && boardColor != 3 && boardColor != 5 && boardColor != 7)
            return false;
    }

    return true;
}
