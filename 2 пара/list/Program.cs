internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[]  list = {20, 87, 82, 91, 35, 83, 89, 90, 61, 51};
        int count = 0;
        for (int i = 1; i < 10; i++){
            if(list[i] > list[i-1]){
                count++;
            }
        };

        Console.WriteLine($"{count}");

    }
}