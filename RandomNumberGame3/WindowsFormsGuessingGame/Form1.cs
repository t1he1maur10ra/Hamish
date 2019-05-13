using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGame3;//Reference the previous project to carry across the classes

/*Astart on the windows forms version for ya*/

namespace WindowsFormsGuessingGame
{
    public partial class Form1 : Form
    {
        /*static object instatiations*/
        static IGameModel easyGame = new EasyLevel();
        static IGameModel mediumGame = new MediumLevel();
        static IGameModel hardGame = new MediumLevel();

        public Form1()
        {
            InitializeComponent();
            testing.Text = easyGame.SecretNumber.ToString();//for testing purposes only, delete.
        }

        private void SubmitGuess_Click(object sender, EventArgs e)
        {
            /*Check which level has been selected and plays the sppropriate class*/
            if (easyLevel.Checked == true && easyGame.CurrentGuessCount <= 3)
            {
                countDown.Text = easyGame.CurrentGuessCount.ToString();
                int.TryParse(guess.Text, out int result );
                easyGame.CurrentGuess = result;
                guess.Clear();
                easyGame.CalculateScore();
                guessesList.Items.Add(easyGame.Guesses[easyGame.Guesses.Count-1]);
                if (easyGame.LevelComplete == true)
                {
                    mediumLevel.Checked = true;
                    guessesList.Items.Add($"{easyGame.DifficultyLevel} complete...");
                }
            }
            if (mediumLevel.Checked == true && mediumGame.CurrentGuessCount < 3)
            {
                testing.Text = mediumGame.SecretNumber.ToString();//for testing purposes only, delete.
                countDown.Text = mediumGame.CurrentGuessCount.ToString();
                int.TryParse(guess.Text, out int result);
                mediumGame.CurrentGuess = result;
                guess.Clear();
                mediumGame.CalculateScore();
                if (mediumGame.LevelComplete == true)
                    hardLevel.Checked = true;
            }
            

            /*Display the user name input*/
            if (easyGame.GameOver == true || mediumGame.GameOver == true || hardGame.GameOver == true)
            {
                enterNameLbl.Visible = true;
                playerName.Visible = true;
                submitName.Visible = true;
                submitGuess.Visible = false;
                guess.Visible = false;
                makeGuessLbl.Text = "Game over";
                guessesList.Items.Add($"...Game Over...");
            }
        }
    }
}
