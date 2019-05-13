using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class MediumLevel : IGameModel
    {
        Random rnd = new Random();
        // PROPERTIES
        public int MaxGuesses { get; set; } = 3;
        public int MaxNumber { get; set; } = 10;
        public int CurrentGuessCount { get; set; } = 1;
        public int Score { get; set; } = 0;
        public string UN { get; set; } = "";
        public string DifficultyLevel { get; set; } = "MEDIUM";
        public List<string> Guesses { get; set; } = new List<string>();
        public bool LevelComplete { get; set; } = false;
        public bool GameOver { get; set; } = false;

        public int SecretNumber { get; set; }
        public int CurrentGuess { get; set; }// Will be passed to CalculateScore();



        // Constructor
        public MediumLevel()
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
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 3)
            {
                Score += 2;
                LevelComplete = true;
            }
            else if (CurrentGuessCount >= 3)
                GameOver = true;

            CurrentGuessCount++;
        }
        public void EnterUsername(string userName)
        {
            char[] constrained = new char[5];
            char[] original = userName.ToCharArray();
            if (userName.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                    constrained[i] = original[i];
            }
            else
            {
                for (int i = 0; i < userName.Length; i++)
                    constrained[i] = original[i];
            }
            //concantinate the string back together and use it to set UN
            foreach (char x in constrained)
                UN += x;
        }
    }
}
