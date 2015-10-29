using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // De applicatie wordt hier opgestart
            GameController game = new GameController();

            // De view van het spel wordt hier uitgevoerd en getoond
            // De controller bevat een methode getView die het volledig samengestelde
            // formulier (yahtzee met teerlingen en het scoreboard)
            Application.Run(game.getView());
        }
    }
}
