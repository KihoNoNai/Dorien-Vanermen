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
    public partial class TeerlingView : UserControl
    {
        // member die de controller onthoudt
        private TeerlingController controller;

        /*
            Constructor die de dependency injection van de controller opvangt
        */
        public TeerlingView(TeerlingController teerlingController)
        {
            InitializeComponent();

            // Ken de controller injection toe aan de member
            controller = teerlingController;
        }

        /*
            Event handler voor wanneer er op de teerling wordt geklikt
        */
        private void teerling_Click(object sender, EventArgs e)
        {
            // Draai de isvast waarde van de teerling om
            controller.toggleLocked();
        }

        /*
            Event handler voor wanneer er op de smijt-knop wordt geklikt
        */
        private void throwButton_Click(object sender, EventArgs e)
        {
            // Controleer of de teerling niet vast staat
            if (!controller.Locked)
            {
                // Voer een worp uit
                controller.Throw();
            }
        }

        /*
            Update de view met de nieuwe waarde van de teerling
        */
        public void updateUI()
        {
            teerlingWaarde.BackColor = (controller.Locked) ? Color.Red : default(Color);
            teerlingWaarde.Text = controller.NumberOfEyes.ToString();
        }

        

        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }
    }
}
