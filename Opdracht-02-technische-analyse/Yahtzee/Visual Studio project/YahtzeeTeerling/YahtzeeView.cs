using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class YahtzeeView : UserControl
    {

        YahtzeeController _controller;
        public int aantalworpen = 3;

        public YahtzeeView( YahtzeeController controller )
        {
            _controller = controller;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
        }

        public void UpdateUI()
        {
            if(aantalworpen > 0)
            {
                aantalworpen--;
                lblWorpen.Text = "Aantal Overige Worpen: " + aantalworpen.ToString();
            }
            
        }
    }
}
