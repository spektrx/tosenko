int Mul(int a, int b)
{
    int res = 0;

    if( (a > 0 && b > 0) || (a < 0 && b > 0) )
    {
        for(int i  = 0; i < b; i++)
        {
            res += a;
        }
    }
    else if(a > 0 && b < 0)
    {
        for (int i = 0; i < -b; i++)
        {
            res -= a;
        }
    }
    else if (a < 0 && b < 0)
    {
        for (int i = 0; i < -b; i++)
        {
            res -= a;
        }
    }

    return res;
}

Console.WriteLine(Mul(2, 3));    6
Console.WriteLine(Mul(2, -3));  -6
Console.WriteLine(Mul(-2, 3));  -6
Console.WriteLine(Mul(-2, -3));  6
Console.WriteLine(Mul(0, 3));    0
Console.WriteLine(Mul(-3, 0));   0
