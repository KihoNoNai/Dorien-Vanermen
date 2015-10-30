namespace TicTacToe1
{
  partial class GameView
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AllowDrop = true;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.Location = new System.Drawing.Point(129, 549);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(365, 100);
      this.label1.TabIndex = 0;
      this.label1.Text = "Click once for \"X\" and twice for \"O\".\r\n\r\nGet three symbols in a horizontal, verti" +
    "cal\r\nor diagonal row to win the game!";
      // 
      // GameView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(601, 670);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "GameView";
      this.Text = "TicTacToe";
      this.Load += new System.EventHandler(this.GameView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
  }
}

