using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {
        // Onthoudt het aantal ogen van de teerling
        int _aantalOgen;

        // Onthoudt de true of false van de teerling
        Boolean _clicked = true;

        // Getters en setters van het aantal ogen
        public int AantalOgen
        {
            get{
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }

        public Boolean Clicked
        {
            get
            {
                return _clicked;
            }
            set
            {
                _clicked = value;
            }
        }
    }
}
