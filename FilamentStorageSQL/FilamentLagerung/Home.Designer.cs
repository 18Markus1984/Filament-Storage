namespace FilamentLagerung
{
    partial class Home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ad = new System.Windows.Forms.Button();
            this.searc = new System.Windows.Forms.Button();
            this.mater = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geöffnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gesamt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.searc);
            this.panel1.Controls.Add(this.mater);
            this.panel1.Controls.Add(this.sell);
            this.panel1.Controls.Add(this.dash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 966);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // ad
            // 
            this.ad.FlatAppearance.BorderSize = 0;
            this.ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.Image = global::FilamentLagerung.Properties.Resources.icons8_plus_50px_1;
            this.ad.Location = new System.Drawing.Point(0, 794);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(300, 151);
            this.ad.TabIndex = 9;
            this.ad.Text = "Hinzufügen";
            this.ad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ad.UseVisualStyleBackColor = true;
            this.ad.Click += new System.EventHandler(this.Menue_Click);
            // 
            // searc
            // 
            this.searc.FlatAppearance.BorderSize = 0;
            this.searc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searc.ForeColor = System.Drawing.Color.White;
            this.searc.Image = global::FilamentLagerung.Properties.Resources.icons8_search_50px;
            this.searc.Location = new System.Drawing.Point(0, 634);
            this.searc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searc.Name = "searc";
            this.searc.Size = new System.Drawing.Size(300, 151);
            this.searc.TabIndex = 8;
            this.searc.Text = "Suchen";
            this.searc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searc.UseVisualStyleBackColor = true;
            this.searc.Click += new System.EventHandler(this.Menue_Click);
            // 
            // mater
            // 
            this.mater.FlatAppearance.BorderSize = 0;
            this.mater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mater.ForeColor = System.Drawing.Color.White;
            this.mater.Image = global::FilamentLagerung.Properties.Resources.icons8_3d_printer_50px;
            this.mater.Location = new System.Drawing.Point(0, 474);
            this.mater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mater.Name = "mater";
            this.mater.Size = new System.Drawing.Size(300, 151);
            this.mater.TabIndex = 7;
            this.mater.Text = "Materialien";
            this.mater.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mater.UseVisualStyleBackColor = true;
            this.mater.Click += new System.EventHandler(this.Menue_Click);
            // 
            // sell
            // 
            this.sell.FlatAppearance.BorderSize = 0;
            this.sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell.ForeColor = System.Drawing.Color.White;
            this.sell.Image = global::FilamentLagerung.Properties.Resources.icons8_user_group_60px;
            this.sell.Location = new System.Drawing.Point(4, 314);
            this.sell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(300, 151);
            this.sell.TabIndex = 6;
            this.sell.Text = "Verkäufer";
            this.sell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.Menue_Click);
            // 
            // dash
            // 
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.ForeColor = System.Drawing.Color.White;
            this.dash.Image = global::FilamentLagerung.Properties.Resources.icons8_home_50px;
            this.dash.Location = new System.Drawing.Point(0, 154);
            this.dash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(300, 151);
            this.dash.TabIndex = 4;
            this.dash.Text = "Dashboard";
            this.dash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.Menue_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 154);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, -22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 176);
            this.label3.TabIndex = 0;
            this.label3.Text = "m";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(300, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 42);
            this.panel4.TabIndex = 7;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FilamentLagerung.Properties.Resources.icons8_subtract_10px;
            this.button1.Location = new System.Drawing.Point(915, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 42);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Image = global::FilamentLagerung.Properties.Resources.icons8_x_10px;
            this.close.Location = new System.Drawing.Point(953, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 42);
            this.close.TabIndex = 6;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(855, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 924);
            this.panel3.TabIndex = 9;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 886);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 38);
            this.panel7.TabIndex = 0;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(398, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 38);
            this.panel8.TabIndex = 1;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(300, 595);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 371);
            this.panel5.TabIndex = 10;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(300, 42);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(555, 112);
            this.panel6.TabIndex = 11;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1291, 966);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(0, 650);
            this.Name = "Home";
            this.Text = "FilamentLagerung";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button mater;
        private System.Windows.Forms.Button searc;
        private System.Windows.Forms.Button ad;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

