using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_game
{
    public partial class Game6X6 : Form
    {
        public Game6X6()
        {
            InitializeComponent();

            gameTimer.Start();
            #region Colors
            //
            //form background color
            //
            BackColor = Theme.backgroundColor;

            //
            //button & timer colors
            //        
            btnReturn.BackColor = Theme.elementBackColor;
            btnReturn.ForeColor = Theme.elementForeColor;
            lblTimer.BackColor = Theme.elementBackColor;
            lblTimer.ForeColor = Theme.elementForeColor;

            //
            //table colors
            //
            tblGame.BackColor = Theme.backgroundColor;
            tblGame.ForeColor = Theme.elementForeColor;
            #endregion 

            AssignRanodmIconToLabel();
        }        

        //
        //Label variables that will track wich icons have been selected
        //
        Label firstIcon = null;
        Label secondIcon = null;

        //
        //Random object that will be used to assing a random icon to a label
        //
        Random randomIcon = new Random();

        //
        //int variable for a start time,
        //and to keep track of the current time for the gameTimer
        //
        int startTime = 241;

        //
        //list of icons to be used in the game grid
        //
        List<string> icons = new List<string>()
        {
            "f", "f",
            "t", "t",
            "j", "j",
            "k", "k",
            "w", "w",
            "o", "o",
            "b", "b",
            "m", "m",
            "p", "p",
            ",", ",",
            "l", "l",
            "-", "-",
            "'", "'",
            "%", "%",
            "$", "$",
            "!", "!",
            "~", "~",
            "x", "x",
        };

        /// <summary>
        /// assigns a random icon to each cell in the game grid table
        /// </summary>
        private void AssignRanodmIconToLabel()
        {
            foreach (Control icon in tblGame.Controls)
            {
                //
                //Label variable
                //
                Label iconLabel = icon as Label;

                if (iconLabel != null)
                {
                    int randomNumber = randomIcon.Next(icons.Count); //create a variable that will select random characters from the "icons" list                    
                    iconLabel.Text = icons[randomNumber]; //adds text to labels taen from the "icons" list
                    iconLabel.ForeColor = iconLabel.BackColor; //changes color to match background
                    icons.RemoveAt(randomNumber); //removes any already used characters from the "icons" list
                }
            }
        }

        /// <summary>
        /// reveals the icon once it has been clicked, and changes color if it is a match
        /// </summary>
        private void lbl_Click(object sender, EventArgs e)
        {
            //
            //Label variable that will
            //store the value of the selected label
            //
            Label selectedLabel = sender as Label;

            //
            //if the timer is already running,
            //then ignore any extra clicks until it shuts off
            //
            if (iconTimer.Enabled == true)
            {
                return;
            }

            //
            //execute code if a label has been selected
            //
            if (selectedLabel != null)
            {
                //
                //if icon is already selected, then ignore the click
                //
                if (selectedLabel.ForeColor == Theme.elementForeColor || selectedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                //
                //if the first icon hasn't been selected, and then is clicked,
                //set the variable firstIcon = to selectedLabel,
                //and change its color to black
                //
                if (firstIcon == null)
                {
                    firstIcon = selectedLabel;
                    firstIcon.ForeColor = Color.Black;
                    return;
                }

                //
                //if the first icon has already been selected,
                //then set the variable secondIcon = selectedLabel,
                //and change its color to black
                //
                else if (firstIcon != null)
                {
                    secondIcon = selectedLabel;
                    secondIcon.ForeColor = Color.Black;
                }

                //
                //checks to see if the user has won
                //
                ValidateWin();

                //
                //if the value of the fistIcon variable is
                //equal to value of the secondIcon variable,
                //then set both variables = null and change the color
                //
                if (firstIcon.Text == secondIcon.Text)
                {
                    firstIcon.ForeColor = Theme.elementForeColor;
                    secondIcon.ForeColor = Theme.elementForeColor;
                    firstIcon = null;
                    secondIcon = null;
                    return;
                }

                //
                //if two different icons have been selected,
                //then execute the timer
                //
                iconTimer.Start();
            }
        }

        /// <summary>
        /// confirms if the user has won or not
        /// </summary>
        private void ValidateWin()
        {
            //
            //verifys that all selected icons do have a match
            //
            foreach (Control icon in tblGame.Controls)
            {
                Label iconLabel = icon as Label;

                if (iconLabel != null)
                {
                    //
                    //if icon fore color equals the theme background color,
                    //then return and exit method
                    //
                    if (iconLabel.ForeColor == Theme.backgroundColor)
                    {
                        return;
                    }
                }
            }

            //
            //stop game timer if all matches are found
            //
            gameTimer.Stop();

            //
            //allows the last two icons to change color before message appears
            //
            msgTimer.Start();
            firstIcon.ForeColor = Theme.elementForeColor;
            secondIcon.ForeColor = Theme.elementForeColor;
            msgTimer.Stop();

            //
            //displays a message congratualting the user on winning the game
            //
            MessageBox.Show("You've matched all the icons, You Win!", "Congratulations!");

            //
            //closes Game6X6 form and opens up the MenuScreen form
            //
            Close();       
        }

        /// <summary>
        /// game timer for a 6X6 game grid
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //
            //decrement the start time by 1
            //
            startTime--;

            //
            //displays the current time
            //
            lblTimer.Text = startTime / 60 + " : " + ((startTime % 60) >= 10 ? (startTime % 60).ToString() : "0" + startTime % 60);

            //
            //if the timer reaches zero           
            //    
            if (lblTimer.Text == "0 : 00")
            {
                //
                //stop timer
                //
                gameTimer.Stop();

                //
                //displays a message when the user loses
                //
                MessageBox.Show("Out of time. You lose :(");

                //
                //closes Game6X6 form and opens up the MenuScreen form
                //               
                Close();
            }
        }

        /// <summary>
        /// icon timer used to show selected icons then re-hide them after 750ms (if they are different)
        /// </summary>
        private void iconTimer_Tick(object sender, EventArgs e)
        {
            //
            //stops the timer
            //
            iconTimer.Stop();

            //
            //re-hide the icons that were selceted
            //
            firstIcon.ForeColor = Theme.backgroundColor;
            secondIcon.ForeColor = Theme.backgroundColor;

            //
            //reset selected icons
            //
            firstIcon = null;
            secondIcon = null;
        }

        /// <summary>
        /// opens the menu screen form       
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //
            //close game form
            //
            Close();

            //
            //open menu form
            //
            FormProvider.MenuScreen.Show();
        }

        /// <summary>
        /// opens the MenuScreen form when closing the Game6X6 form
        /// </summary>
        private void Game6X6_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.MenuScreen.Show();
        }
    }
}
