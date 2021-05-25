using System;

Play();
void Play()
{
    int numberOfGuesses = 0;
    string a ="\u221e";
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

    if (playDifficulty == 1)
    {
        while (numberOfGuesses < 8)
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
                    numberOfGuesses = 9;
                }
                else
                {
                    if (int.Parse(userGuess) > secretNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {8 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                    else if (int.Parse(userGuess) < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {8 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                }
                if (numberOfGuesses == 8)
                {
                    Console.WriteLine("No more guesses, you lose!");
                }
            }
            Game();
        }
    }
    else if (playDifficulty == 2)
    {
        while (numberOfGuesses < 6)
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
                    numberOfGuesses = 7;
                }
                else
                {
                    if (int.Parse(userGuess) > secretNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {6 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                    else if (int.Parse(userGuess) < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {6 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                }
                if (numberOfGuesses == 6)
                {
                    Console.WriteLine("No more guesses, you lose!");
                }
            }
            Game();
        }
    }
    else if (playDifficulty == 3)
    {
        while (numberOfGuesses < 4)
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
                    numberOfGuesses = 5;
                }
                else
                {
                    if (int.Parse(userGuess) > secretNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {4 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                    else if (int.Parse(userGuess) < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                        numberOfGuesses++;
                        Console.WriteLine($"You have {4 - numberOfGuesses} left.");
                        Console.WriteLine();
                    }
                }
                if (numberOfGuesses == 4)
                {
                    Console.WriteLine("No more guesses, you lose!");
                }
            }
            Game();
        }
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
                    Play();
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
}