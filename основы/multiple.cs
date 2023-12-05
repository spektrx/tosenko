internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if(a%b == 0){
            Console.WriteLine("true");
        }
        else{
            Console.WriteLine("false");
        }
    }
}