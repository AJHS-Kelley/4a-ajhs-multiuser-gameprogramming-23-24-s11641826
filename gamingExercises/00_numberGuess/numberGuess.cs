// Albert Laguerre, Program Template, v0.01
/*
Genrate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print game instructions including range and num. of guesses aloowed.
    MATCH == first player to score 3 points
    ROUND == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on
Ask the player what their guess is.
Determine if guess is correct or not.
Print game instructions including range and num. of guesses allowed
Ask the player what their guess is.
Determine if guess is correct or not
    If guess is correct {
        Tell them they guessed correctly.
        Award the player a point
    } else {
        Tell them they are wrong. 
        Tell player if guess is too high or too low
        Check to see if they have guesses remaining{
            if guess remain: {
                allow player to guess again
            } else {
                CPU wins the round
            }
        }
    }
*/
using System;

namespace numberGuess
{

    class numberGuess
    {

        static void Main(string[] args)
        {
            int secretNumber = -1; 
            int numGuesses = 0; //Number of guesses the player is ALLOWED.
            int numAttempts = 0; //Number of guesses TAKEN.
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rnageMac = -1;

            Console.WriteLine("Welcome to the Number Guess Game! \nYou wull select adifficulty next.\n");
            Console.WriteLine("Easy mode: Range is 0 - 10 with 4 guesses. \nNormal mode: Range is 0 - 25 with 4 guesses. \nHard mode: Range is 0 - 50 with 3 guesses.");

            // DIFFICULTY SELECTION
            Console.WriteLine("Please type Easy, Normal, or Hard and press enter.");
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to String by default.
            Console.WriteLine("You have selected: " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;

            } else if (NORMAL MODE) {
                // Code to run.
            } else if (HARD MODE) {
                // Code to run
            } else {
                // Code to run if no difficulty is selected.

            }
            Console.WriteLine("Minimun: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numguesses); 
        }
    }
}
