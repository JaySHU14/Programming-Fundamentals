using System;

namespace NumberGuessingGameWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuePlaying = true;

            while (continuePlaying)
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Play one round");
                Console.WriteLine("2. Play multiple rounds");
                Console.WriteLine("3. Quit");

                // Read user's menu choice
                if (int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            PlayOneRound();
                            break;
                        case 2:
                            PlayMultipleRounds();
                            break;
                        case 3:
                            continuePlaying = false;
                            break;
                        default:
                            Console.WriteLine("Invalid menu option. Please choose 1, 2, or 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu option (1, 2, or 3).");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        static void PlayOneRound()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int guessAttempts = 0;
            int maxAttempts = 3;

            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.WriteLine("You have 3 attempts to guess it.");

            while (guessAttempts < maxAttempts)
            {
                Console.Write($"Attempt {guessAttempts + 1}: Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if (userGuess == secretNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed it correctly.");
                        break;
                    }
                    else
                    {
                        string message = (userGuess < secretNumber) ? "too low" : "too high";
                        Console.WriteLine($"Your guess is {message}. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                guessAttempts++;
            }

            if (guessAttempts == maxAttempts)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {secretNumber}.");
            }
        }

        static void PlayMultipleRounds()
        {
            Console.Write("Enter the number of rounds (1-10): ");
            if (int.TryParse(Console.ReadLine(), out int rounds))
            {
                rounds = Math.Min(rounds, 10);

                for (int i = 0; i < rounds; i++)
                {
                    Console.WriteLine($"Round {i + 1}:");
                    PlayOneRound();

                    if (i < rounds - 1)
                    {
                        Console.Write("Do you want to play another round? (yes/no): ");
                        string response = Console.ReadLine().ToLower();
                        if (response != "yes")
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number of rounds between 1 and 10.");
            }
        }
    }
}
