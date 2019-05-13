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
        }

        private void SubmitGuess_Click(object sender, EventArgs e)
        {
            /*Check which level has been selected and plays the sppropriate class*/
            if (easyLevel.Checked == true && easyGame.CurrentGuessCount < 3)
            {
                testing.Text = easyGame.SecretNumber.ToString();
                int.TryParse(guess.Text, out int result );
                easyGame.CurrentGuess = result;
                guess.Clear();
                easyGame.CalculateScore();
            }
            else if (easyGame.LevelComplete == true)
            {
                mediumLevel.Checked = true;
            }

        }
    }
}
