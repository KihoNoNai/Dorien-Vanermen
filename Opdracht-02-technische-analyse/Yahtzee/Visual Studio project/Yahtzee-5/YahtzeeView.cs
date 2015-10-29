using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class YahtzeeView : UserControl
    {
        // Member die de controller opvangt
        private YahtzeeController controller;

        public YahtzeeView(YahtzeeController yahtzeeController)
        {
            // Ken de controller die die werd meegegeven tijdens de instantiatie 
            // toe aan de class member 
            controller = yahtzeeController;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
            // Maak een lijst die alle views van de teerlingen zal bevatten
            List<TeerlingView> teerlingen = controller.getTeerlingenView();

            // De breedte van één teerling ophalen om de positie te kunnen berekenen
            int teerlingWidth = teerlingen.First().Width;

            // De hoogte van een teerling ophalen om de "smijt ze allemaal" knop op de juiste
            // positie te kunnen zetten
            int teerlingHeight = teerlingen.First().Height;

            // Teerlingen overlopen om zo de horizontale positie van elke teerling te kunnen bepalen
            foreach (TeerlingView teerling in teerlingen)
            {
                // View van één teerling ophalen
                TeerlingView huidigeTeerling = teerling;

                /*
                    De positie van de huidige teerling bepalen op basis van de index van de lijst
                    bv. teerling[0] => 0 * width = 0 * 150 => xPos = 0
                    teerling[1] => 1 * width = 1 * 150 => xPos = 150
                    etc. 
                */
                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth;

                // De positie van de huidige teerling setten
                huidigeTeerling.Location = new Point(xPos, 0);

                // De view van de huidige teerling toevoegen
                Controls.Add(huidigeTeerling);
            }

            // De "Smijt alle teerlingen" knop setten op basis van de hoogte van één teerling
            werpAlleTeerlingenButton.Location = new Point(10, teerlingHeight );
        }

        /*
            Event handler die opvangt wat er moet gebeuren wanneer op de "smijt alle teerlingen" wordt geklikt
        */
        private void smijtAlleTeerlingenButton_click(object sender, EventArgs e)
        {
            // Roep de smijtAlleTeerlingen methode aan die in de controller gedefinieerd is
            controller.throwAllDice();
        }
    }
}
