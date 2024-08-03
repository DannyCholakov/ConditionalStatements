namespace SumSeconds;

class Program
{
    static void Main(string[] args)
    {
        int firstRunner = int.Parse(Console.ReadLine());
        int secondRunner = int.Parse(Console.ReadLine());
        int thirdRunner = int.Parse(Console.ReadLine());

        int sumTime = firstRunner + secondRunner + thirdRunner;
        int minutes = sumTime / 60;
        int seconds = sumTime % 60;
        if (seconds<10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");

        }else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }

    }
}