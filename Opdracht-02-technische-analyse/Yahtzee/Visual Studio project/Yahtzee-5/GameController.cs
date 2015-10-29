using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class GameController
    {
        // Member om de view in op te slaan
        private GameView view;

        // De members die de controllers van yahtzee en het scoreboard bevatten
        private YahtzeeController yahtzee;
        private ScoreboardController scoreboard;

        public GameController()
        {
            /*
                Maak de view voor het spel aan
                Belangrijk: de huidige context, de GameController, wordt meegegeven
                met deze view instantie, zodat de view de controller op de hoogte kan
                stellen van eventuele veranderingen en data kan ophalen die in deze
                controller gedefinieerd wordt.
            */
            view = new GameView( this );

            /* 
                Maak een instantie van de controller van Yahtzee
                Injecteer de huidige context (de parent) = Dependency Injection
                zodat de YahtzeeController zijn bovenliggende klassen (=GameController)
                kan verwittigen van zodra er iets veranderd in zijn controller
                
            */
            yahtzee = new YahtzeeController( this );

            /*
                Configureer het maximum aantal worpen die mogelijk zijn in één spelletje
            */
            yahtzee.MaximumThrows = 5;
            yahtzee.NumberOfDice = 3;

            /*
                Initializeer de yahtzeecontroller
                Dit betekent de controller uitvoeren met de net toegewezen variabelen (=MaximumAantalWorpen)
            */
            yahtzee.initialize();

            /*
                Maak een instantie aan van het scoreboard en injecteer de huidige context
            */
            scoreboard = new ScoreboardController( this );
        }

        /*
        
            Deze methode wordt aangesproken van zodra er een verandering heeft plaatsgevonden
            in het scoreboard of de yahtzee instantie
        */
        public void modelHasChanged()
        {
            scoreboard.updateView();
        }

        /*
            Deze methode returnt de view voor het volledige spel
        */
        public GameView getView()
        {
            return view;
        }
        
        /*
            Deze methode returnt de User Control view voor Yahtzee
        */
        public YahtzeeView getViewYahtzee()
        {
            return yahtzee.getView();
        }

        /*
            Deze methode returnt de User Control view voor het Scoreboard
        */
        public ScoreboardView getViewScoreboard()
        {
            return scoreboard.getView();
        }

        /*
            Deze methode returnt het gedefinieerde maximum aantal worpen
        */
        public int MaximumThrows
        {
            get
            {
                return yahtzee.MaximumThrows;
            }
        }


        public int CurrentThrows
        {
            get
            {
                return yahtzee.CurrentThrows;
            }
        }
    }
}
