namespace GodzillaVsKong;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int statist = int.Parse(Console.ReadLine());
        double costumePrice = double.Parse(Console.ReadLine());

        double decor = budget * 0.10; 
        double statistPrice = statist * costumePrice;
       if (statist>150)
       { 
           statistPrice = statistPrice*0.90;
       }

       double losses = statistPrice + decor;
       if (losses>budget)
       {
           Console.WriteLine("Not enough money!");
           Console.WriteLine($"Wingard needs {(losses-budget).ToString("F2")} leva more.");
       }
       else
       {
           Console.WriteLine("Action!");
           Console.WriteLine($"Wingard starts filming with {(budget-losses).ToString("F2")} leva left.");
       }

    }
}