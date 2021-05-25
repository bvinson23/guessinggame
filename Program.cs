using System;

Play();
void Play()
{
    int numberOfGuesses = 0;
    int secretNumber = 42;
    while (numberOfGuesses < 4)
    {
        Console.WriteLine("Guess the secret number");
        Console.WriteLine("-----------------------");
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
            }
            if (numberOfGuesses == 4)
            {
                Console.WriteLine("No more guesses, you lose!");
            }
        }
        Game();
    }
}