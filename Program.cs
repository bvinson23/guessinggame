using System;

Play();
void Play()
{
    int numberOfGuesses = 0;
    Random i = new Random();
    int secretNumber = i.Next(1, 100);
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
                Console.WriteLine("Seriously, that's your guess? Try again.");
                numberOfGuesses++;
                Console.WriteLine($"You have {4 - numberOfGuesses} left.");
            }
            if (numberOfGuesses == 4)
            {
                Console.WriteLine("No more guesses, you lose!");
            }
        }
        Game();
    }
}