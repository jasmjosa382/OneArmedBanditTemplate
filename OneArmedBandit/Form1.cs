using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Jasmine Josan
//October 2022
//One Armed Bandit casino game

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();  

        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)


            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources


            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources


            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         


            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }
    }
}
