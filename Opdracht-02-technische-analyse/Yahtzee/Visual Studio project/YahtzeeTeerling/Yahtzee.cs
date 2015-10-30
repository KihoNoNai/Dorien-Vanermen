using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        // Maak een lijst aan waarin de teerlingen worden opgevangen
        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        YahtzeeController aantalWorpen = new YahtzeeController();
        ScoreBoardController scoreBoard = new ScoreBoardController();
        private int aantalTeerlingen = 5;
        int maxAantal = 3;
        int score = 0;
        int highscore = 0;

        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            resetBtn.Enabled = false;
            // Aantal teerlingen dat getoond moet worden
            int aantalTeerlingen = 5;
            Controls.Add(scoreBoard.getView());

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for ( int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer )
            {
                // maak nieuwe instantie van teerling controller;
                TeerlingController nieuweTeerling = new TeerlingController();

                // Voeg controller toe aan teerlingen lijst
                teerlingen.Add(nieuweTeerling);
            }

                // Maak instanties van de teerlingen aan en voeg deze toe aan de list
                for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
                {
                    // Haal de teerling op basis van de key uit de teerlingen list 
                    TeerlingController huidigeTeerling = teerlingen[teerlingNummer];

                    // Haal de teerling view uit de teerling controller
                    TeerlingView huidigeTeerlingview = huidigeTeerling.getView();

                    // Bepaald de huidige x positie (horizontaal) van de teerling
                    int xPos = huidigeTeerlingview.Width * teerlingNummer;

                    // Zet de locatie van de teerling op basis van de x pos
                    huidigeTeerlingview.Location = new Point(xPos, 0);

                    // Voeg de view toe aan de huidige view
                    Controls.Add(huidigeTeerlingview);

            Controls.Add(aantalWorpen.getView());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aantalWorpen._model.AantalWorpen < maxAantal)
            {
       
                for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
                {
                    TeerlingController huidigeTeerling = teerlingen[teerlingNummer];
                    if (huidigeTeerling._model.Clicked)
                    {
                        huidigeTeerling.werpTeerling();
                        huidigeTeerling.updateUI();

                        score += huidigeTeerling._model.AantalOgen;
                        
                    }
                }

                scoreBoard._model.Score = score;

                aantalWorpen._model.AantalWorpen++;
                aantalWorpen.UpdateUI();

                scoreBoard.UpdateUI();
            }

            if(aantalWorpen._model.AantalWorpen == maxAantal)
            {
                button1.Enabled = false;
                resetBtn.Enabled = true;
                if(score > highscore)
                {
                    scoreBoard._model.HighScore = score;
                    scoreBoard.UpdateUIHighscore();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aantalWorpen._model.AantalWorpen = 0;
            aantalWorpen.getView().aantalworpen = 4;
            resetBtn.Enabled = false;
            button1.Enabled = true;
            ScoreBoardController controller = new ScoreBoardController();
            controller._view.label1.Text = "0";

            aantalWorpen.UpdateUI();

        }
    }
}
