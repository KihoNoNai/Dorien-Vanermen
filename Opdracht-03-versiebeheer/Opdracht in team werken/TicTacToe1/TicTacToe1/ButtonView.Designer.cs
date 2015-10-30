namespace TicTacToe1
{
  partial class ButtonView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(10, 10);
      this.button1.Margin = new System.Windows.Forms.Padding(0);
      this.button1.Name = "button1";
      this.button1.Padding = new System.Windows.Forms.Padding(10);
      this.button1.Size = new System.Drawing.Size(130, 130);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // ButtonView
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.button1);
      this.Name = "ButtonView";
      this.Size = new System.Drawing.Size(150, 147);
      this.Load += new System.EventHandler(this.ButtonView_Load_1);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
  }
}
