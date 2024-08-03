namespace Shopping;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int graphicCards = int.Parse(Console.ReadLine());
        int processors = int.Parse(Console.ReadLine());
        int ram = int.Parse(Console.ReadLine());

        int graphicCardsPrice = 250*graphicCards;

        double processorsPrice = (graphicCardsPrice * 0.35)*processors;
        double ramPrice = (graphicCardsPrice * 0.10) * ram;

        double fullPrice = graphicCardsPrice + processorsPrice + ramPrice;
        
        if (graphicCards>processors)
        {
            fullPrice = fullPrice * 0.85;
        }
        
        if (fullPrice<=budget)
        {
            Console.WriteLine($"You have {(budget-fullPrice):F2} leva left!");
        }
        else if(fullPrice>budget)
        {
            Console.WriteLine($"Not enough money! You need {(fullPrice-budget):F2} leva more!");
        }

    }
}