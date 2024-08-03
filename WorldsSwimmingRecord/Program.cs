namespace WorldsSwimmingRecord;

class Program
{
    static void Main(string[] args)
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());

        double timeNeeded = distance * speed;
        int bonusTime = (int)(distance / 15);
        double bonusTimeNeeded = bonusTime * 12.5;
        
        double time = bonusTimeNeeded + timeNeeded;

        if (time<record)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {time.ToString("F2")} seconds.");
        }
        else if(time>=record)
        {
            Console.WriteLine($"No, he failed! He was {(time-record).ToString("F2")} seconds slower.");
        }
    }
}