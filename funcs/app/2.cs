using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

(int res, int remainder) Div(int dividend, int divisor)
{

    if (divisor == 0)
    {
        throw new DivideByZeroException("Деление на ноль невозможно.");
    }

    int sign = Math.Sign(dividend) * Math.Sign(divisor);

    dividend = Math.Abs(dividend);
    divisor = Math.Abs(divisor);

    int res = 0;
    int remainder = dividend;

    while (remainder >= divisor)
    {
        remainder -= divisor;
        res++;
    }

    res *= sign;
    remainder *= sign;

    return (res, remainder);
}

var result = Div(7, 3);

Console.WriteLine($"Частное: {result.res}");
Console.WriteLine($"Остаток: {result.remainder}");