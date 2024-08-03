namespace PasswordGuess;

class Program
{
    static void Main(string[] args)
    {
        string pass = Console.ReadLine();
        string realpass = "s3cr3t!P@ssw0rd";
        if (pass == realpass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}