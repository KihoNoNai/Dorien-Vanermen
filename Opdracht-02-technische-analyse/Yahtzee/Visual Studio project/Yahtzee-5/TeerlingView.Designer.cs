namespace Yahtzee_5
{
    partial class TeerlingView
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
            this.teerlingWaarde = new System.Windows.Forms.Label();
            this.werpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingWaarde
            // 
            this.teerlingWaarde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teerlingWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.teerlingWaarde.Location = new System.Drawing.Point(10, 10);
            this.teerlingWaarde.Margin = new System.Windows.Forms.Padding(0);
            this.teerlingWaarde.Name = "teerlingWaarde";
            this.teerlingWaarde.Padding = new System.Windows.Forms.Padding(10);
            this.teerlingWaarde.Size = new System.Drawing.Size(130, 130);
            this.teerlingWaarde.TabIndex = 0;
            this.teerlingWaarde.Text = "1";
            this.teerlingWaarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingWaarde.Click += new System.EventHandler(this.teerling_Click);
            // 
            // werpButton
            // 
            this.werpButton.Location = new System.Drawing.Point(10, 144);
            this.werpButton.Name = "werpButton";
            this.werpButton.Size = new System.Drawing.Size(130, 23);
            this.werpButton.TabIndex = 1;
            this.werpButton.Text = "Smijten!";
            this.werpButton.UseVisualStyleBackColor = true;
            this.werpButton.Click += new System.EventHandler(this.throwButton_Click);
            // 
            // TeerlingView
            // 
            this.Controls.Add(this.werpButton);
            this.Controls.Add(this.teerlingWaarde);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(150, 187);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingWaarde;
        private System.Windows.Forms.Button werpButton;
    }
}
