using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class ButtonController
  {
    public ButtonModel model;
    private ButtonView view;

    public ButtonController()
    {
      model = new ButtonModel();
      view = new ButtonView(this);
    }

    public ButtonView getView()
    {
      return view;
    }

    public int Player
    {
      get
      {
        return model.Player;
      }
    }

    public void onClick()
    {
      if (model.Player == 1)
      {
        model._value = "X";
        view.updateUI();
        PlayerChange();
      }
      else
      {
        model._value = "O";
        view.updateUI();
        PlayerChange();
      }
    }

    public void PlayerChange()
    {
      model.PlayerChange();
      view.updateUI();
    }
  }
}
