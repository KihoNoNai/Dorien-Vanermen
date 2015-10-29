using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class GameView : Form
    {
        private GameController controller;

        /*
            Vang de gamecontroller op via de constructor zodat andere methodes
            aan deze controllers kunnen
        */
        public GameView( GameController c )
        {
            controller = c;

            InitializeComponent();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            /* 
                Haal de views op, op basis van de controller die bij het aanmaken
                van deze klasse werd meegegeven
            */
            ScoreboardView scoreboard = controller.getViewScoreboard();
            YahtzeeView yahtzee = controller.getViewYahtzee();

            /*
                Haal de hoogte van het scoreboard op zodat de yahtzee met de teerlingen
                hier onder geplaatst kunnen worden
            */
            yahtzee.Location = new Point(0, scoreboard.Height);

            /*
                Voeg de views toe aan het formulier
            */
            Controls.Add( scoreboard );
            Controls.Add( yahtzee );
        }
    }
}
