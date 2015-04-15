using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    public class Program
    {
        //this is the number the user needs to guess.  Set its value in your code using a RNG.
        static int NumberToGuess = 0;


        static int amountOfGuesses = 0;


        static void Main(string[] args)
        {
            Random rng = new Random();
            NumberToGuess = rng.Next(0, 101);
            bool flagGuessed = false;
            while (!flagGuessed)
            {
                Console.WriteLine("Guess? ");
                string valueInput = Console.ReadLine().ToString();
                if (ValidateInput(valueInput))
                {

                    if (Convert.ToInt32(valueInput) == NumberToGuess)
                    {
                        Console.WriteLine("You won");
                        flagGuessed = true;
                    }
                    else
                    {
                        IsGuessTooHigh(Convert.ToInt32(valueInput));
                        IsGuessTooLow(Convert.ToInt32(valueInput));
                    }
                }
            }



        }
        public static bool ValidateInput(string userInput)
        {

            int guessMade = 0;

            if (int.TryParse(userInput, out guessMade))
            {
                if (guessMade < 0 && guessMade > 100)
                {
                    Console.WriteLine("Please enter a value between 1-100");
                    return false;
                }
                if (guessMade > 0 && guessMade < 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void SetNumberToGuess(int number)
        {
            //TODO: make this function override your global variable holding the number the user needs to guess.  This is used only for testing methods.
            NumberToGuess = number;
        }

        public static bool IsGuessTooHigh(int userGuess)
        {

            //TODO: return true if the number guessed by the user is too high
            if (userGuess > NumberToGuess)
            {
                Console.WriteLine("Your number is too high!");
                amountOfGuesses++;
                return true;
            }
            return false;
        }

        public static bool IsGuessTooLow(int userGuess)
        {
            if (userGuess < NumberToGuess)
            {
                Console.WriteLine("The number you entered is too low");
                amountOfGuesses++;
                return true;
            }
            //TODO: return true if the number guessed by the user is too low
            return false;
        }
    }
}
