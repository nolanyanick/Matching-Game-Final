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
    public partial class MenuScreen : Form
    {        
        public MenuScreen()
        {
            InitializeComponent();
            #region Colors

            //
            //form background color
            //
            BackColor = Theme.backgroundColor;

            //
            //button colors
            //
            btnStart.BackColor = Theme.elementBackColor;
            btnTheme.BackColor = Theme.elementBackColor;
            btnStart.ForeColor = Theme.elementForeColor;
            btnTheme.ForeColor = Theme.elementForeColor;

            //
            //title color
            //
            lblTitle.BackColor = Theme.elementBackColor;
            lblTitle2.BackColor = Theme.elementBackColor;
            lblTitle.ForeColor = Theme.elementForeColor;
            lblTitle2.ForeColor = Theme.elementForeColor;

            //
            //grid selector colors
            //
            udGridSelection.BackColor = Theme.elementBackColor;
            udGridSelection.ForeColor = Theme.elementForeColor;
            #endregion
        }

        /// <summary>
        /// opens one of the game form
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (udGridSelection.SelectedItem)
            {
                case "4X4":                    
                    Game4X4 openForm4X4 = new Game4X4(); //instantiate new form 
                    openForm4X4.Show();                    
                    break;

                case "6X6":
                    Game6X6 openForm6X6 = new Game6X6(); //instantiate new form
                    openForm6X6.Show();                  
                    break;

                case "8X8":
                    Game8X8 openForm8X8 = new Game8X8(); //instantiate new form
                    openForm8X8.Show();                    
                    break;

                default:
                    MessageBox.Show("Please select a grid size to play!");
                    return;                    
            }            

            //
            //close menu form
            //
            FormProvider.MenuScreen.Hide();
        }        

        /// <summary>
        /// changes the color of the application
        /// </summary>
        private void btnTheme_Click(object sender, EventArgs e)
        {        
            switch (Theme.themeColor)
            {
                case Style.YELLOW:

                    //
                    //assign new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.LightCyan;
                    Theme.elementBackColor = System.Drawing.Color.LightSkyBlue;
                    Theme.elementForeColor = System.Drawing.Color.DeepPink;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.BLUE;
                    break;

                case Style.BLUE:

                    //
                    //assign new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.PaleGreen;
                    Theme.elementBackColor = System.Drawing.Color.ForestGreen;
                    Theme.elementForeColor = System.Drawing.Color.Yellow;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.GREEN;
                    break;

                case Style.GREEN:

                    //
                    //assign new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.LightCoral;
                    Theme.elementBackColor = System.Drawing.Color.Red;
                    Theme.elementForeColor = System.Drawing.Color.Aqua;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.RED;
                    break;

                case Style.RED:

                    //
                    //assing new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.NavajoWhite;
                    Theme.elementBackColor = System.Drawing.Color.Orange;
                    Theme.elementForeColor = System.Drawing.Color.RoyalBlue;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.ORANGE;
                    break;

                case Style.ORANGE:

                    //
                    //assing new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.Pink;
                    Theme.elementBackColor = System.Drawing.Color.HotPink;
                    Theme.elementForeColor = System.Drawing.Color.DarkViolet;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.PINK;
                    break;

                case Style.PINK:

                    //
                    //assing new color values - these colors affect all forms
                    // 
                    Theme.backgroundColor = System.Drawing.Color.Plum;
                    Theme.elementBackColor = System.Drawing.Color.DarkViolet;
                    Theme.elementForeColor = System.Drawing.Color.Lime;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;
                  
                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.PURPLE;
                    break;

                case Style.PURPLE:

                    //
                    //assing new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.WhiteSmoke;                    
                    Theme.elementBackColor = System.Drawing.Color.DimGray;
                    Theme.elementForeColor = System.Drawing.Color.White;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.WHITE;
                    break;

                case Style.WHITE:

                    //
                    //assing new color values - these colors affect all forms
                    //
                    Theme.backgroundColor = System.Drawing.Color.LightYellow;
                    Theme.elementBackColor = System.Drawing.Color.Yellow;
                    Theme.elementForeColor = System.Drawing.Color.Red;

                    //
                    //background color
                    //
                    BackColor = Theme.backgroundColor;

                    //
                    //title colors
                    //
                    lblTitle.BackColor = Theme.elementBackColor;
                    lblTitle2.BackColor = Theme.elementBackColor;
                    lblTitle.ForeColor = Theme.elementForeColor;
                    lblTitle2.ForeColor = Theme.elementForeColor;

                    //
                    //button colors
                    //
                    btnStart.BackColor = Theme.elementBackColor;
                    btnTheme.BackColor = Theme.elementBackColor;
                    btnStart.ForeColor = Theme.elementForeColor;
                    btnTheme.ForeColor = Theme.elementForeColor;

                    //
                    //grid selector colors
                    //
                    udGridSelection.BackColor = Theme.elementBackColor;
                    udGridSelection.ForeColor = Theme.elementForeColor;

                    //
                    //assign new theme color
                    //
                    Theme.themeColor = Style.YELLOW;
                    break;

                default:
                    break;
            }
        }
    }
}
