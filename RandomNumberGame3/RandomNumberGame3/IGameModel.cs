using RandomNumberGame3;
using System.Collections.Generic;

namespace RandomNumberGame3
{
    public interface IGameModel
    {
        List<string> Guesses { get; set; }
        string DifficultyLevel { get; set; }
        int MaxNumber { get; set; }
        int SecretNumber { get; set; }
        int MaxGuesses { get; set; }
        int CurrentGuessCount { get; set; }
        int Score { get; set; }
        string UN { get; set; }
        bool LevelComplete { get; set; }
        bool GameOver { get; set; }
        int CurrentGuess { get; set; }

        void CalculateScore();
        void EnterUsername(string un);
        int SetSecretNumber();
    }
}