internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter num");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0){
            Console.WriteLine($"{num}");
        }

        else{
        
              num = num * -1;
              Console.WriteLine($"{num}");
        };
    }
}
