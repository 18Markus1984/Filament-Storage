namespace FilamentLagerung
{
    partial class NeuFilament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuFilament));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.labeldurchmesser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.durchmesser = new System.Windows.Forms.ComboBox();
            this.marke = new System.Windows.Forms.ComboBox();
            this.art = new System.Windows.Forms.ComboBox();
            this.Druckkopf = new System.Windows.Forms.ComboBox();
            this.geoeffnet = new System.Windows.Forms.TextBox();
            this.menge = new System.Windows.Forms.TextBox();
            this.labelmarke = new System.Windows.Forms.Label();
            this.farbe = new System.Windows.Forms.TextBox();
            this.lagerung = new System.Windows.Forms.TextBox();
            this.speichern = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.51145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.48855F));
            this.tableLayoutPanel1.Controls.Add(this.labeldurchmesser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.durchmesser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.marke, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.art, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Druckkopf, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.geoeffnet, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.menge, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelmarke, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.farbe, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lagerung, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(460, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Farbe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labeldurchmesser
            // 
            this.labeldurchmesser.AutoSize = true;
            this.labeldurchmesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldurchmesser.ForeColor = System.Drawing.Color.White;
            this.labeldurchmesser.Location = new System.Drawing.Point(3, 31);
            this.labeldurchmesser.Name = "labeldurchmesser";
            this.labeldurchmesser.Size = new System.Drawing.Size(108, 20);
            this.labeldurchmesser.TabIndex = 1;
            this.labeldurchmesser.Text = "Durchmesser:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Art:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Farbe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Druckkopf:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Geöffnet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Menge:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lagerung:";
            // 
            // durchmesser
            // 
            this.durchmesser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durchmesser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durchmesser.FormattingEnabled = true;
            this.durchmesser.Items.AddRange(new object[] {
            "1,75",
            "2,85"});
            this.durchmesser.Location = new System.Drawing.Point(174, 34);
            this.durchmesser.Name = "durchmesser";
            this.durchmesser.Size = new System.Drawing.Size(205, 21);
            this.durchmesser.TabIndex = 11;
            // 
            // marke
            // 
            this.marke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marke.FormattingEnabled = true;
            this.marke.Location = new System.Drawing.Point(174, 3);
            this.marke.Name = "marke";
            this.marke.Size = new System.Drawing.Size(205, 21);
            this.marke.TabIndex = 12;
            // 
            // art
            // 
            this.art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.art.ForeColor = System.Drawing.Color.Black;
            this.art.FormattingEnabled = true;
            this.art.Location = new System.Drawing.Point(174, 65);
            this.art.Name = "art";
            this.art.Size = new System.Drawing.Size(205, 21);
            this.art.TabIndex = 13;
            // 
            // Druckkopf
            // 
            this.Druckkopf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Druckkopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Druckkopf.FormattingEnabled = true;
            this.Druckkopf.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC"});
            this.Druckkopf.Location = new System.Drawing.Point(174, 127);
            this.Druckkopf.Name = "Druckkopf";
            this.Druckkopf.Size = new System.Drawing.Size(205, 21);
            this.Druckkopf.TabIndex = 14;
            // 
            // geoeffnet
            // 
            this.geoeffnet.Location = new System.Drawing.Point(174, 158);
            this.geoeffnet.Name = "geoeffnet";
            this.geoeffnet.Size = new System.Drawing.Size(205, 20);
            this.geoeffnet.TabIndex = 15;
            this.geoeffnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menge_KeyPress);
            // 
            // menge
            // 
            this.menge.Location = new System.Drawing.Point(174, 189);
            this.menge.Name = "menge";
            this.menge.Size = new System.Drawing.Size(205, 20);
            this.menge.TabIndex = 16;
            this.menge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menge_KeyPress);
            // 
            // labelmarke
            // 
            this.labelmarke.AutoSize = true;
            this.labelmarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarke.ForeColor = System.Drawing.Color.White;
            this.labelmarke.Location = new System.Drawing.Point(3, 0);
            this.labelmarke.Name = "labelmarke";
            this.labelmarke.Size = new System.Drawing.Size(57, 20);
            this.labelmarke.TabIndex = 0;
            this.labelmarke.Text = "Marke:";
            // 
            // farbe
            // 
            this.farbe.Location = new System.Drawing.Point(174, 96);
            this.farbe.Name = "farbe";
            this.farbe.Size = new System.Drawing.Size(205, 20);
            this.farbe.TabIndex = 21;
            // 
            // lagerung
            // 
            this.lagerung.Location = new System.Drawing.Point(173, 219);
            this.lagerung.Margin = new System.Windows.Forms.Padding(2);
            this.lagerung.Name = "lagerung";
            this.lagerung.Size = new System.Drawing.Size(207, 20);
            this.lagerung.TabIndex = 22;
            // 
            // speichern
            // 
            this.speichern.BackColor = System.Drawing.Color.ForestGreen;
            this.speichern.FlatAppearance.BorderSize = 0;
            this.speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speichern.ForeColor = System.Drawing.Color.White;
            this.speichern.Location = new System.Drawing.Point(12, 283);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(152, 80);
            this.speichern.TabIndex = 1;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = false;
            this.speichern.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = global::FilamentLagerung.Properties.Resources.icons8_help_100px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(454, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 4;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NeuFilament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(553, 397);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.speichern);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NeuFilament";
            this.Text = "Neues Filament";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelmarke;
        private System.Windows.Forms.Label labeldurchmesser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox durchmesser;
        private System.Windows.Forms.ComboBox marke;
        private System.Windows.Forms.ComboBox art;
        private System.Windows.Forms.ComboBox Druckkopf;
        private System.Windows.Forms.TextBox geoeffnet;
        private System.Windows.Forms.TextBox menge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox farbe;
        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox lagerung;
    }
}