using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class YahtzeeModel
    {
        // List die alle teerlingen zal bewaren
        private List<TeerlingController> teerlingen = new List<TeerlingController>();

        /*
            De members die de configuratie voor het Yahtzeespel zullen onthouden
        */
        private int numberOfDice = 0;
        private int currentThrows = 0;
        private int maximumThrows = 0;

        /*
            Voeg een teerling toe aan de lijst met teerlingen
        */
        internal void addTeerling(TeerlingController teerling)
        {
            teerlingen.Add(teerling);
        }

        /*
            Getter voor de lijst met teerlingen
        */
        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
            }
        }

        /*
            getter voor het aantal worpen
        */
        public int numberOfThrows
        {
            get
            {
                return currentThrows;
            }
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int MaximumThrows
        {
            get
            {
                return maximumThrows;
            }
            set
            {
                maximumThrows = value;
            }
        }

        /*
            getter en setter voor het aantal teerlingen
        */
        public int NumberOfDice
        {
            get
            {
                return numberOfDice;
            }
            set
            {
                numberOfDice = value;
            }
        }

        /*
            tel eentje bij het huidig aantal worpen
        */
        public int addThrow()
        {
            return ++currentThrows;
        }

    }
}
