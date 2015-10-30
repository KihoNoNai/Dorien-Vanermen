using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{ 
    public class ScoreBoardController
    {

        public ScoreBoardView _view;
        public ScoreBoardModel _model;
        public int _score;

        public ScoreBoardView getView()
        {
            return _view;
        }

        public ScoreBoardController()
        {
            _view = new ScoreBoardView( this );
            _model = new ScoreBoardModel();
        }

        public void getScore(int score)
        {
            _score = score;
        }

        public void UpdateUI()
        {
            _view.UpdateUI();
        }

        public void UpdateUIHighscore()
        {
            _view.UpdateUIHighscore();
        }
    }
}
