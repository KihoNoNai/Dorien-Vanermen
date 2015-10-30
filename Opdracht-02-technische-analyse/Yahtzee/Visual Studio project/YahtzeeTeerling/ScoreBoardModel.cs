using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class ScoreBoardModel
    {
        private int score;
        private int highSore;

        public int Score
        {
            get {
                return score;
            }
            set {
                score = value;
            }
        }

        public int HighScore
        {
            get
            {
                return highSore;
            }
            set
            {
                highSore = value;
            }
        }
    }
}
