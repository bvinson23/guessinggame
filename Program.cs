using System;

Console.Write("Guess the secret number >>");
string userGuess = Console.ReadLine();

int secretNumber = 42;

if (secretNumber == int.Parse(userGuess))
{
    Console.WriteLine("Whoa, can you read my mind?");
}
else
{
    Console.WriteLine("Seriously, that's your guess? Nope.");
}