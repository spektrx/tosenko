internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if(a==b || a==c || b==c){
            Console.WriteLine($"koroche est' ravnye int");
        }

        if(a > b && a > c){
            Console.WriteLine($"{a} samoe bol'shoe");

        }

        if(b > a && b > c){
            Console.WriteLine($"{b} samoe bol'shoe");

        }


        if(c > b && c > a){
            Console.WriteLine($"{c} samoe bol'shoe");

        }



        if(a < b && a < c){
            Console.WriteLine($"{a} samoe malen'kkoe");

        }

        if(b < a && b < c){
            Console.WriteLine($"{b} samoe malen'kkoe");

        }


        if(c < b && c < a){
            Console.WriteLine($"{c} samoe malen'kkoe");

        }

    }
}