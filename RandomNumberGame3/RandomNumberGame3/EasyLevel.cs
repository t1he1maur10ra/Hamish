using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class EasyLevel : IGameModel
    {
        Random rnd = new Random();
        // PROPERTIES
        public int MaxGuesses { get; set; } = 3;
        public int MaxNumber { get; set; } = 5;
        public int CurrentGuessCount { get; set; } = 1;
        public int Score { get; set; } = 0;
        public string UN { get; set; }="";
        public string DifficultyLevel { get; set; } = "EASY";
        public List<string> Guesses { get; set; } = new List<string>();
        public bool GameOver { get; set; } = false;
        public bool LevelComplete { get; set; } = false;

        public int CurrentGuess { get; set; }// Will be passed to CalculateScore();
        public int SecretNumber { get; set; }

        // Constructor
        public EasyLevel()
        {
            SecretNumber = SetSecretNumber();
        }

        // METHODS
        public int SetSecretNumber()
        {
            int secretNum = rnd.Next(1, MaxNumber);
            return secretNum;
        }


        public void CalculateScore()
        {
            //Guesses.Add(CurrentGuess);
            Guesses.Add($"{CurrentGuess} @ {DifficultyLevel}");

            if (CurrentGuess == SecretNumber && CurrentGuessCount == 1)
            {
                Score += 10;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 2)
            {
                Score += 6;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == MaxGuesses)
            {
                Score += 2;
                LevelComplete = true;
            }
            else if (CurrentGuessCount >= MaxGuesses)
                GameOver = true;

            CurrentGuessCount++;
        }

        public void EnterUsername(string un)
        {
            char[] constrained = new char[5];
            char[] original = un.ToCharArray();
            if (un.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                    constrained[i] = original[i];
            }
            else
            {
                for (int i = 0; i < un.Length; i++)
                    constrained[i] = original[i];
            }
            //concantinate the string back together and use it to set UN
            foreach (char x in constrained)
                UN += x;
        }
    }
}