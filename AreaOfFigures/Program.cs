namespace AreaOfFigures;

class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(side*side);
        }else if (figure == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine(sideA*sideB);
        }else if (figure =="circle")
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(radius*radius*Math.PI);
        }else if (figure =="triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(side*height/2);
        }
    }
}