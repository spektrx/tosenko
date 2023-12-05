internal class Program
{
    private static void Main(string[] args)
    {
        
        for(int i = 0; i != 8; i++){
            if(i%2==0){Console.Write(" ");}
            for(int j = 0; j!= 16; j++){
                if(j%2==0){
                    Console.Write(" ");
                }
                else{
                    Console.Write("*");
                }
            
            }
            Console.WriteLine();

        }
    }
}
