namespace LunchBreak;

class Program
{
    static void Main(string[] args)
    {
        string seriesName = Console.ReadLine();
        int episodeLenght = int.Parse(Console.ReadLine());
        int restTime = int.Parse(Console.ReadLine());

        double lunchTime = restTime * 0.125;
        double breakTime = restTime * 0.25;
        double timeLeft = (restTime - breakTime) - lunchTime;

        if (timeLeft>=episodeLenght)
        {
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft-episodeLenght)} minutes free time.");
        }
        else
        {
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLenght-timeLeft)} more minutes.");
        }

    }
}