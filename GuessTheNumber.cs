namespace GuessTheNumber
{
    class GuessTheNumber
    {
        static void Main(string[] args)
        {
            // A line to generate a random number between 0 and 20 and assign it to the variable 'theNumber'
            int theNumber = new Random().Next(20);

            System.Console.WriteLine("Let's play!!");
            System.Console.WriteLine("I will be thinking of a number between 0 and 20 and you guess!!");
            System.Console.WriteLine("Enter your guess or '-1' to give up");
            int tries = 0; // A variable that increments every time the user inputs a guess
            int inputInNumbers = 0;

            // A while loop to loop every time until the user guessed number is equal to the actual number
            while (theNumber != inputInNumbers)
            {
                #pragma warning disable CS8600 // To disable C# CS8600 warning
                string input = Console.ReadLine();
                try // A try catch statement to ensure that the user inputs and integer
                {
                    #pragma warning disable CS8604 // To disable C# CS8600 warning
                    inputInNumbers = int.Parse(input); // Converts user input from a string to an integer
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Oops, try again");
                    continue;
                }
                if (inputInNumbers == -1)
                {
                    System.Console.WriteLine("See you again :D");
                    return;
                }
                else if (inputInNumbers > 20 || inputInNumbers < -1)
                {
                    System.Console.WriteLine("Please, enter a number between 0 and 20 or -1 to give up");
                    continue;
                }
                if (theNumber > inputInNumbers)
                {
                    System.Console.WriteLine("Your number is LOWER than my number, guess again!");
                }
                else if (theNumber < inputInNumbers)
                {
                    System.Console.WriteLine("Your number is HIGHER than my number, guess again!");
                }
                tries++;
            }
            System.Console.WriteLine($"That's CORRECT!, the number I chosen is {inputInNumbers}");
            System.Console.WriteLine($"You guessed it after {tries} tries!");
        }
    }
}
