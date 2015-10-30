namespace YahtzeeTeerling
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
            this.teerlingLabel = new System.Windows.Forms.Label();
            this.werpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingLabel
            // 
            this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teerlingLabel.Location = new System.Drawing.Point(24, 12);
            this.teerlingLabel.Name = "teerlingLabel";
            this.teerlingLabel.Size = new System.Drawing.Size(100, 95);
            this.teerlingLabel.TabIndex = 0;
            this.teerlingLabel.Text = "label1";
            this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
            // 
            // werpButton
            // 
            this.werpButton.Location = new System.Drawing.Point(36, 119);
            this.werpButton.Name = "werpButton";
            this.werpButton.Size = new System.Drawing.Size(75, 23);
            this.werpButton.TabIndex = 1;
            this.werpButton.Text = "Werp";
            this.werpButton.UseVisualStyleBackColor = true;
            this.werpButton.Click += new System.EventHandler(this.werpButton_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.werpButton);
            this.Controls.Add(this.teerlingLabel);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(150, 181);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLabel;
        private System.Windows.Forms.Button werpButton;
    }
}
