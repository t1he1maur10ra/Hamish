using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class Program
    {
        static IGameModel EasyGame = new EasyLevel();
        static IGameModel mediumGame = new MediumLevel();
        static void Main(string[] args)
        {
            
            // Select Level
            // Make guesses
            // If correct, score points
            // Display results to player (points scored, level points scored on, enter username)

            Console.WriteLine(StandardMessages.StartApp());
            Console.WriteLine("\n\nSelect your game level\n\t1 - Easy\n\t2 - Medium\n\t3 - Hard\n\t4 - Exit");
            int input = int.Parse(Console.ReadLine());

            /*Easy*/
            if (input == 1)
            { 
                do
                {
                    /*Display the easy level and take the input*/
                    DisplayGame(EasyGame.SecretNumber, EasyGame.DifficultyLevel, EasyGame.MaxNumber, EasyGame.MaxGuesses, EasyGame.CurrentGuessCount);
                    EasyGame.CurrentGuess = int.Parse(Console.ReadLine());

                    /*Play the Game*/
                    EasyGame.CalculateScore();

                    /*Move to the next level if completed*/
                    if (EasyGame.LevelComplete)
                        input++;
                } while (EasyGame.LevelComplete == false && EasyGame.GameOver == false);

                if (EasyGame.GameOver && EasyGame.Score > 0)
                    EasyGame.EnterUsername(GetName(EasyGame.Score));

                Console.WriteLine($"Thank you for playing {EasyGame.UN}\nPress ENTER to continue...");
            }

            /*Medium*/
            if (input == 2)
            {
                do
                {
                    /*Carry over the score from previous level*/
                    mediumGame.Score = EasyGame.Score;
                    DisplayGame(mediumGame.SecretNumber, mediumGame.DifficultyLevel, mediumGame.MaxNumber, mediumGame.MaxGuesses, mediumGame.CurrentGuessCount);
                    mediumGame.CurrentGuess = int.Parse(Console.ReadLine());

                    mediumGame.CalculateScore();

                    if (mediumGame.LevelComplete)
                        input++;
                } while (mediumGame.LevelComplete == false && mediumGame.GameOver == false);

                if (mediumGame.GameOver && mediumGame.Score > 0)
                    mediumGame.EnterUsername(GetName(mediumGame.Score));

                Console.WriteLine($"Thank you for playing {mediumGame.UN}\nPress ENTER to continue...");
            }

            /*Hard*/
            if (input == 3)
            {
            }

            /*?*/
            if (input == 4)
            {
            }


            Console.ReadLine();
        }

        /*Not required but something i noticed is that your code repeats alot 
          which indicates there should be a method there*/
        static void DisplayGame(int num, string level, int max, int guesses, int currentGuess)
        {
            Console.Clear();
            Console.WriteLine($"Secret Num: {num}");//For Testing only, delete
            Console.WriteLine($"Random Number Guessing Game || {level} Level");
            Console.WriteLine($"Choose a number between 1 and {max}. You get {guesses} guesses.");
            Console.Write($"\n\nAttempt number {currentGuess}: ");
        }

        static string GetName(int score)
        {
            Console.Clear();
            Console.Write($"\nGame Over\nYour score was: {score}\nPlease enter your name: ");
            return Console.ReadLine();
        }
    }
}
