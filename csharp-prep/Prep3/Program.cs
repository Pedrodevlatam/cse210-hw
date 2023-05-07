using System;

using System;

class GuessMyNumberGame
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Guess My Number game!");

        while (true)
        {
            // Generate a random number from 1 to 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int numGuesses = 0;

            // Game loop
            while (true)
            {
                Console.Write("What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                numGuesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it in {0} guesses!", numGuesses);
                    break;
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() != "yes")
            {
                break;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}