namespace ToyShop;

class Program
{
    static void Main(string[] args)
    {
        double excursionPrice = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int talkingDolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double puzzlePrice = 2.60;
        double talkingDollsPrice = 3;
        double bearsPrice = 4.10;
        double minionsPrice = 8.20;
        double trucksPrice = 2;

        int toys = puzzles + talkingDolls + bears + minions + trucks;
        double  summ = puzzles * puzzlePrice + bears * bearsPrice + talkingDolls * talkingDollsPrice +
                       minions * minionsPrice + trucks * trucksPrice;
        double saleWin = 0.00;
        if (toys>=50)
        {
            double sale = summ * 0.25;
          saleWin = (summ - sale)*0.90;
            
        }
         else if(toys<50)
         {
             saleWin = summ*0.90;
         }
        double leftmoney = saleWin - excursionPrice;
        double neededMoney = excursionPrice - saleWin;
        if (saleWin - excursionPrice >= 0)
        {
            Console.WriteLine($"Yes! {leftmoney.ToString("F2")} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {neededMoney.ToString("F2")} lv needed.");
        }
    }
}