namespace YahtzeeTeerling
{
    partial class YahtzeeView
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
            this.aantalWerpen = new System.Windows.Forms.Label();
            this.lblWorpen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aantalWerpen
            // 
            this.aantalWerpen.AutoSize = true;
            this.aantalWerpen.Location = new System.Drawing.Point(12, 196);
            this.aantalWerpen.Name = "aantalWerpen";
            this.aantalWerpen.Size = new System.Drawing.Size(0, 13);
            this.aantalWerpen.TabIndex = 0;
            // 
            // lblWorpen
            // 
            this.lblWorpen.AutoSize = true;
            this.lblWorpen.Location = new System.Drawing.Point(15, 207);
            this.lblWorpen.Name = "lblWorpen";
            this.lblWorpen.Size = new System.Drawing.Size(133, 13);
            this.lblWorpen.TabIndex = 1;
            this.lblWorpen.Text = "Aantal Overige Worpen: 3 ";
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWorpen);
            this.Controls.Add(this.aantalWerpen);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(193, 229);
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aantalWerpen;
        private System.Windows.Forms.Label lblWorpen;
    }
}
