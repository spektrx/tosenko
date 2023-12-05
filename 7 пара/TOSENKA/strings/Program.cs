using System;
using System.Linq;

class Program
{
    static bool CheckAnagram(string name1, string name2)
    {
        
        name1 = name1.ToLower().Replace(" ", "");
        name2 = name2.ToLower().Replace(" ", "");

        
        return string.Concat(name1.OrderBy(c => c)) == string.Concat(name2.OrderBy(c => c));
    }

    static void Main()
    {
        // Ввод имен
        Console.Write("Введите первое имя: ");
        string name1 = Console.ReadLine();

        Console.Write("Введите второе имя: ");
        string name2 = Console.ReadLine();

        // Проверка и вывод результата
        if (CheckAnagram(name1, name2))
        {
            Console.WriteLine("Имена являются анаграммами.");
        }
        else
        {
            Console.WriteLine("Имена не являются анаграммами.");
        }
    }
}