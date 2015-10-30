using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class ButtonModel
  {
    private int player = 1;
    public String _value;

    public void PlayerChange()
    {
      if (player == 1)
      {
        player = 2;
      }
      else
      {
        player = 1;
      }
    }

    public int Player
    {
      get
      {
        return player;
      }
    }
  }
}
