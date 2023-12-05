using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите бинарную последовательность:");
        string binarySequence = Console.ReadLine();

        if (binarySequence.Length > 26)
        {
            Console.WriteLine("Ошибка:последовательность более чем 26 символов.");
        }
        else
        {
            string compressedSequence = CompressBinarySequence(binarySequence);
            Console.WriteLine("Сжатая последовательность: " + compressedSequence);
        }

        Console.ReadLine();
    }

    static string CompressBinarySequence(string binarySequence)
    {
        string compressed = "";
        int count = 0;

        foreach (char bit in binarySequence)
        {
            if (bit == '0')
            {
                count++;
            }
            else
            {
                char compressedChar = (char)('a' + count);
                compressed += compressedChar;
                count = 0;
            }
        }

        if (count > 0)
        {
            char compressedChar = (char)('a' + count);
            compressed += compressedChar;
        }

        return compressed;
    }
}
