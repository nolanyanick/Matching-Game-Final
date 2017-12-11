using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_game
{
    //
    //FormProvider class to allpw the same menu screen to be used throughout the application
    //
    public class FormProvider
    {
        public static MenuScreen MenuScreen
        {
            get
            {

                if (menuScreen == null)
                {
                    menuScreen = new MenuScreen();
                }
                return menuScreen;
            }
        }
        private static MenuScreen menuScreen;
    }            
}
