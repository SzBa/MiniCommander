namespace TotalComander
{
    partial class ComandControlPanel
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
            this.minTCPanel1 = new TotalComander.minTCPanel();
            this.SuspendLayout();
            // 
            // minTCPanel1
            // 
            this.minTCPanel1.CurrentPath = "";
            this.minTCPanel1.Location = new System.Drawing.Point(12, 12);
            this.minTCPanel1.Name = "minTCPanel1";
            this.minTCPanel1.Size = new System.Drawing.Size(510, 638);
            this.minTCPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 644);
            this.Controls.Add(this.minTCPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private minTCPanel userControl11;
        private minTCPanel minTCPanel1;
    }
}

