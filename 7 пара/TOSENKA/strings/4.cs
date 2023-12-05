
Console.Write("enter ypour age ");
int age = int.Parse(Console.ReadLine());

double seconds = (long)31536000 * age;
Console.WriteLine(seconds);


int divisor = 10;
int sum = 0;
int count = 0;


while (seconds >= 1)
{
    sum += Convert.ToInt32(seconds % divisor);
    seconds /= divisor;
    seconds = Math.Truncate(seconds);
    count++;
}
Console.WriteLine(sum);

while (sum > 9)
{
    seconds = sum;
    sum = 0;
    while (seconds >= 1)
    {
        sum += Convert.ToInt32(seconds % divisor);
        seconds /= divisor;
        seconds = Math.Truncate(seconds);
        count++;
    }
}



Console.Write($"sum: {sum} count: {count}");



