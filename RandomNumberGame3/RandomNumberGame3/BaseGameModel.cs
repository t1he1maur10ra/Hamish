using RandomNumberGame3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class BaseGameModel : IGameModel
    {
        Random rnd = new Random();

        public int SecretNumber { get; set; }
        public int MaxNumber { get; set; }
        public string DifficultyLevel { get; set; }
        public int MaxGuesses { get; set; }
        public int CurrentGuessCount { get; set; }
        public List<string> Guesses { get; set; }
        public int Score { get; set; }
        public string UN { get; set; }
        public bool LevelComplete { get; set; }
        public bool GameOver { get; set; }
        public int CurrentGuess { get; set; }

        public void CalculateScore()
        {
        }

        public int SetSecretNumber()
        {
            int secretNum = rnd.Next(1, MaxNumber);
            return secretNum;
        }
        public void EnterUsername(string un)
        {

        }

    }
}
