using static System.Console;

using System.Text.RegularExpressions;


string? s = ReadLine();
Regex pattern = new(@"^[ABCEHKMOPT]{1}\d\d\d[ABCEHKMOPT]{2}$");


while (s != "")
{


    if (pattern.IsMatch(s))
    {
        WriteLine("Correct");
    }
    else {
        WriteLine("Wrong");
    }
    s = ReadLine();
}

