internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter num");
        int a = Convert.ToInt32(Console.ReadLine());
        int zero = 0;
        for(int i = 0; i!=a; i++){
            int x = Convert.ToInt32(Console.ReadLine());
            if(x == 0){
                zero ++;
            };
        };
        Console.WriteLine($"VVVV");
        Console.WriteLine($"{zero}");


    }
}