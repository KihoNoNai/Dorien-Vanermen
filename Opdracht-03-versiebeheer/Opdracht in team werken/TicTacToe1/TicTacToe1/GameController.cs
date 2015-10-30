using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class GameController
  {
    private GameView view;

    private TicTacToeController ticTacToe;

    public GameController()
    {
      view = new GameView(this);

      ticTacToe = new TicTacToeController(this);
      ticTacToe.NumberOfButtons = 9;
      ticTacToe.initialize();
    }


    public GameView getView()
    {
      return view;
    }

    public TicTacToeView getViewTicTacToe()
    {
      return ticTacToe.getView();
    }
  }
}
