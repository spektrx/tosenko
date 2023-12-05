using System.Text.RegularExpressions;

string str = Console.ReadLine();

Regex pattern = new Regex(@"(?=(>>-->|<--<<))");

Console.WriteLine(pattern.Matches(str).Count());

