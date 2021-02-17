using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*author: RLisasi
 * channel: RL7_slimkat video: High low/ guess the number c# game
 https://youtu.be/smGMqfxuIZc
 */
namespace HighLow
{
    public partial class Form1 : Form
    {
        //properties
        int guess = 0;
        int result = 0;
        int difference = 0;
        Random rnd = new Random();
        String height = null;
        int attempts=0;
        int prog = 50;

        public Form1()
        {
            InitializeComponent();
            //draw a random result and store it in result varieable
            result = GetRandom();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //play the game on button click
            PlayGame();
            //increase the number of attempts after each click
            attempts++;
            lblAttempts.Text = attempts.ToString();
        }

        public void PlayGame()
        {
            //call all methods
            GetGuess();
            SetDifference();
            SetStrings();
            SetProgBar();
            Display();
        }

        public void Display()
        {
            //display info back to user
            lblHeight.Text = $"Your guess was {height}";
            Console.WriteLine($"Your guess is {guess}, the difference is {difference},\n " +
                $"Actual result is : {result}, your guess was {height}");
        }

        public int GetRandom()
        {
            //generate a random number between 1 and 100
            result = rnd.Next(1, 101);
            return result;
        }

        public int GetGuess()
        {
            //get the user input
           guess = (int)userInput.Value;
            return guess;
        }

        public void SetDifference()
        {
            //process the guess vs result and store the difference in difference variable
            int x = GetGuess();
            int y = result;
            difference = (x - y);

        }

        public void SetStrings()
        {
            //set progress bar/ display according to the difference between guess and result
            if(difference <= -12)
            {
                height = "low";
                prog = 20;
            }
            if(difference <= -25)
            {
                height = "too low";
                prog = 0;
            }
            if(difference >= 12)
            {
                height = "high";
                prog = 80;
            }
            if(difference >= 25)
            {
                height = "too High";
                prog = 100;
            }
            if(difference <= 6 && difference >=1){
                height = "close";
                prog = 60;
            }
            if(difference >= -6 && difference <=-1){
                height = "close";
                prog = 40;
            }
            if(difference == 0){
                height = "right";
                prog = 50;
                lblResult.Text = $"{result}";
                lblHeight.Text = $"Your guess was {height}";
                // exit confirmation prompt
                DialogResult confirmExit = MessageBox.Show("You guessed correctly, smash yes to replay or no to exit",
                    "WIN", MessageBoxButtons.YesNo);

                if (confirmExit == DialogResult.Yes)
                {
                    lblResult.Text = result.ToString();
                    //SetNull();
                    attempts = -1;
                    result = GetRandom();

                }
                else
                {
                    this.Close();
                }
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            //reset
            lblResult.Text = result.ToString();
            SetNull();
            //get a new value
            GetRandom();
        }
        private void SetProgBar()
        {
            //set the progreesbar to equal to prog variable
            progressBar.Value =prog;
        }

        public void SetNull()
        {
            //reset
            guess = 0;
            result = 0;
            difference = 0;
            height = null;
            attempts = 0;
            prog = 50;
            userInput.Text = 0.ToString();
            lblAttempts.Text = 0.ToString();
            progressBar.Value = 0;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
                         // exit confirmation prompt
                DialogResult confirmExit = MessageBox.Show("Would you like to exit?",
                    "QUIT?", MessageBoxButtons.YesNo);

                if (confirmExit == DialogResult.Yes)
                {
                    //close the app
                   this.Close();
                }
              
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
// exit confirmation prompt
            DialogResult confirmHelp = MessageBox.Show("Guess the number in the center of the screen and click guess, The bar will indicate how close you are. If it's close the bar will be centered, if it's too high the bar will be full and vice versa",
                "HELP", MessageBoxButtons.OK);
        }
    }
}
