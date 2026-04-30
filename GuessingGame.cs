namespace Games;

public class GuessingGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int guess = random.Next(1,101);

        Console.WriteLine("Welcome to the Guesser Game 3000!");
        int guess = Convert.ToInt32(Console.ReadLine("Enter a number between 1 and 100: "));
        Console.WriteLine($"Your guess of \"{guess}\" was wront");
    }
}