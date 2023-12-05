

internal class Program
{
    private static void Main(string[] args)
    {
        static void Sum(int num, int num2, out int reusult)
        {
            reusult = num + num2;
        }

        Sum(1, 2, out int result);

        Console.WriteLine(result);
    }
}