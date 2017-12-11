using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_game
{
    //
    //Style enum to determine which theme is currently selected,
    //and which theme will be selected next
    //
    public enum Style
    {
        YELLOW,
        ORANGE,
        BLUE,
        GREEN,
        PURPLE,
        PINK,
        RED,
        WHITE,
    }

    //
    //Theme class that will contain all color values
    //for all the different components of my forms
    //
    public static class Theme
    {
        //
        //Style to determine which theme is selected/next
        //
        public static Style themeColor;

        //
        //colors
        //
        public static Color backgroundColor = Color.LightYellow; // form background color
        public static Color elementBackColor = Color.Yellow; // background color for all elements within form
        public static Color elementForeColor = Color.Red; // fore color for all elements within form
    }
}
