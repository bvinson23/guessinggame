using System;


Main();

void Main()
{
    int numberOfGuesses = 0;
    int totalGuesses = 0;
    string a = "\u221e";
    Random i = new Random();
    int secretNumber = i.Next(1, 100);
    Console.WriteLine("-----------------");
    Console.WriteLine("| Guessing Game |");
    Console.WriteLine("-----------------");
    Console.WriteLine("Select your difficulty.");
    Console.WriteLine("1) Easy");
    Console.WriteLine("2) Medium");
    Console.WriteLine("3) Hard");

    string difficulty = Console.ReadLine();
    int playDifficulty = int.Parse(difficulty);
    int easyGuesses = 8;
    int mediumGuesses = 6;
    int hardGuesses = 4;

    if (playDifficulty == 1)
    {
        totalGuesses = easyGuesses;
        int maxGuesses = 8;
        Play(easyGuesses, maxGuesses);
    }
    else if (playDifficulty == 2)
    {
        totalGuesses = mediumGuesses;
        int maxGuesses = 6;
        Play(mediumGuesses, maxGuesses);
    }
    else if (playDifficulty == 3)
    {
        totalGuesses = hardGuesses;
        int maxGuesses = 4;
        Play(hardGuesses, maxGuesses);
    }
    else if (playDifficulty == 69)
    {
        while (true)
        {
            Console.WriteLine("Guess the secret number");
            Console.WriteLine("-----------------------");
            Console.Write($"Your guess({numberOfGuesses + 1})");
            string userGuess = Console.ReadLine();

            void Game()
            {
                if (secretNumber == int.Parse(userGuess))
                {
                    Console.WriteLine("You won! But you must have been cheating");
                    System.Environment.Exit(0);
                }
                else
                {
                    if (int.Parse(userGuess) > secretNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {a} left.");
                        Console.WriteLine();
                    }
                    else if (int.Parse(userGuess) < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {a} left.");
                        Console.WriteLine();
                    }
                }
            }
            Game();
        }
    }

    void Play(int totalGuesses, int maxGuesses)
    {
        while (numberOfGuesses < totalGuesses)
        {
            Console.WriteLine("Guess the secret number");
            Console.WriteLine("-----------------------");
            Console.Write($"Your guess({numberOfGuesses + 1})");
            string userGuess = Console.ReadLine();

            void Game()
            {
                if (secretNumber == int.Parse(userGuess))
                {
                    Console.WriteLine("Whoa, can you read my mind?");
                    numberOfGuesses = maxGuesses + 1;
                }
                else
                {
                    if (int.Parse(userGuess) > secretNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {maxGuesses - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                    else if (int.Parse(userGuess) < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {maxGuesses - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                }
                if (numberOfGuesses == maxGuesses)
                {
                    Console.WriteLine("No more guesses, you lose!");
                }
            }
            Game();
        }
    }
}