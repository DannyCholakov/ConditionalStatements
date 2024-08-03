namespace SpeedInfo;

class Program
{
    static void Main(string[] args)
    {
        double speed = Convert.ToDouble(Console.ReadLine());

        string speedCategory = speed switch
        {
            <= 10 => "slow",
            > 10 and <= 50 => "average",
            > 50 and <= 150 => "fast",
            > 150 and <= 1000 => "ultra fast",
            _ => "extremely fast"
        };

        Console.WriteLine(speedCategory);
    }
}