using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1
{
  public partial class GameView : Form
  {

    private GameController controller;

    public GameView(GameController c)
    {
      controller = c;
      
      InitializeComponent();
    }

    private void GameView_Load(object sender, EventArgs e)
    {
      //ScoreboardView scoreboard = controller.getViewScoreboard();
      TicTacToeView ticTacToe = controller.getViewTicTacToe();

      //ticTacToe.Location = new Point(0, scoreboard.Height);

      //Controls.Add(scoreboard);
      Controls.Add(ticTacToe);
    }
  }
}
