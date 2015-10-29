using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class TeerlingModel
    {
        // Members die de waarde van de teerling onthouden
        private bool isLocked;
        private int numberOfEyes;
        private static Random randomNummer;

        public TeerlingModel()
        {
            // Zet elke teerling standaard niet vast
            isLocked = false;

            // Standaard waarde is 1
            numberOfEyes = 1;

            // Maak een instantie van de random generator
            if (randomNummer == null)
            {
                randomNummer = new Random();
            }
        }

        /*
            Methode die een willekeurig getal berekent voor de teerling
        */
        public void Throw()
        {
            numberOfEyes = randomNummer.Next(1, 7);
        }

        /*
            Getter voor het aantal ogen (= waarde van de teerling)
        */
        public int NumberOfEyes
        {
            get
            {
                return numberOfEyes;
            }
        }

        /*
            Draai de isVast waarde om
        */
        public void toggleLocked()
        {
            isLocked = !isLocked;
        }

        /*
            Getter voor de isVast waarde
        */
        public bool Locked
        {
            get
            {
                return isLocked;
            }
        }
    }
}
