namespace TimePlus15Minutes;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int plusMinutes = minutes + 15;
        int leftMinutes = plusMinutes % 60;
        int hourPlus = plusMinutes / 60;
        int summedHours = hours + hourPlus;
   
        if (summedHours == 24 && leftMinutes < 10)
        {
            summedHours = 0;
            Console.WriteLine($"{summedHours}:0{leftMinutes}");
        }
        else if (summedHours == 24 && leftMinutes >= 10)
        {
            summedHours = 0;
            Console.WriteLine($"{summedHours}:{leftMinutes}");
        }
        else if (summedHours < 24 && leftMinutes < 10)
        {
           
            Console.WriteLine($"{summedHours}:0{leftMinutes}");
        }
        else if (summedHours < 24 && leftMinutes >= 10)
        {
            
            Console.WriteLine($"{summedHours}:{leftMinutes}");
        }

        Console.WriteLine();
    }
}