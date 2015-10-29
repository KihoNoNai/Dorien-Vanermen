using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class ScoreboardController
    {
        // Member die de bovenliggende klasse opslaagt
        private GameController container;

        /*
            Members die het huidige model en view zullen opslaan
        */
        private ScoreboardView view;
        private ScoreboardModel model;

        public ScoreboardController( GameController cont )
        {
            // Vang de geïnjecteerde bovenliggende klasse op in de member container
            container = cont;

            /*
                Maak een view en een model aan voor deze klasse
            */
            view = new ScoreboardView(this);
            model = new ScoreboardModel();
        }

        /*
            Return de view van het scoreboard
        */
        public ScoreboardView getView()
        {
            return view;
        }

        /*
            Return het maximum aantal worden
        */
        public int MaximumAantalWorpen
        {
            get
            {
                /*
                    Het maximum aantal worpen wordt gedefinieerd in de bovenliggende klasse
                    Deze klasse is de container en bevat een methode MaximumAantalWorpen
                    die deze waarde zal returnen
                */
                return container.MaximumThrows;
            }
        }

        /*
            Return het huidig aantal worden
        */
        public int CurrentThrows
        {
            get
            {
                /*
                    Het huidig aantal worpen wordt onthouden in de bovenliggende klasse
                    Deze klasse is de container en bevat een methode HuidigAantalWorpen
                    die deze waarde zal returnen
                */
                return container.CurrentThrows;
            }
        }

        /*
            Deze methode spreekt de view aan die een methode updateView heeft
            In deze methode wordt gedefinieerd wat er moet gebeuren wanneer er iets wijzigt
            (zoals bv. drukken op de "smijt allemaal" knop waardoor het huidig aantal worpen 
            wijzigt)
        */
        public void updateView()
        {
            view.updateView();
        }

    }
}
