
using static System.Console;
namespace consoleapp
{
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello, World!");
        byte i = 100;
        for (int k = 0; k < 160; k++)
        {
            try
            {
            WriteLine($"{i}");
            i = checked((byte)(i +1));
            }
            catch(Exception ex){
                WriteLine(ex);
            }
        };
    }
}
}