 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class TicTacToeController
  {
    private GameController container;

    private TicTacToeView view;
    private TicTacToeModel model;

    public TicTacToeController(GameController cont)
    {
      container = cont;
      view = new TicTacToeView(this);
      model = new TicTacToeModel();
    }

    public void initialize()
    {
      createField();
    }

    private void createField()
    {
      for (int buttonNumber = 0; buttonNumber < NumberOfButtons; ++buttonNumber)
      {
        ButtonController button = new ButtonController();
        model.addButton(button);
      }
    }

    public List<ButtonView> getButtonsView()
    {
      List<ButtonView> buttonsView = new List<ButtonView>();

      foreach (ButtonController button in model.Buttons)
      {
        ButtonView buttonView = button.getView();
        buttonsView.Add(buttonView);
      }
      return buttonsView;
    }

    public TicTacToeView getView()
    {
      return view;
    }


    public int NumberOfButtons
    {
      get
      {
        return model.NumberOfButtons;
      }
      set
      {
        model.NumberOfButtons = value;
      }
    }

  }
}
