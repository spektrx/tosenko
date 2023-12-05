internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if(a%2 == 0){
            Console.WriteLine("even");
        }
        else{
            Console.WriteLine("odd");
        }
    }
}