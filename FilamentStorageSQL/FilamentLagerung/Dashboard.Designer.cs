namespace FilamentLagerung
{
    partial class Dashboard
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
            this.Lager = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Lager
            // 
            this.Lager.AutoScroll = true;
            this.Lager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lager.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Lager.Location = new System.Drawing.Point(12, 12);
            this.Lager.Name = "Lager";
            this.Lager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lager.Size = new System.Drawing.Size(756, 477);
            this.Lager.TabIndex = 1;
            this.Lager.WrapContents = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(781, 504);
            this.Controls.Add(this.Lager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel Lager;
    }
}