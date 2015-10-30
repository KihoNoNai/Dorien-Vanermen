using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  class TicTacToeModel
  {
    private List<ButtonController> buttons = new List<ButtonController>();

    private int numberOfButtons = 0;

    internal void addButton(ButtonController button)
    {
      buttons.Add(button);
    }

    public List<ButtonController> Buttons
    {
      get
      {
        return buttons;
      }
    }

    public int NumberOfButtons
    {
      get
      {
        return numberOfButtons;
      }
      set
      {
        numberOfButtons = value;
      }
    }
  }
}
