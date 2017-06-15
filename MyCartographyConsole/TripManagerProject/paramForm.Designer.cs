namespace TripManagerProject
{
    partial class ParamForm
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
            this.precisionLabel = new System.Windows.Forms.Label();
            this.pathnameLabel = new System.Windows.Forms.Label();
            this.couleurLabel = new System.Windows.Forms.Label();
            this.precisionNumeric = new System.Windows.Forms.NumericUpDown();
            this.pathnameTB = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.couleurComboBox = new System.Windows.Forms.ComboBox();
            this.localiteLabel = new System.Windows.Forms.Label();
            this.localiteTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.precisionNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(12, 78);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(74, 17);
            this.precisionLabel.TabIndex = 0;
            this.precisionLabel.Text = "Precision :";
            // 
            // pathnameLabel
            // 
            this.pathnameLabel.AutoSize = true;
            this.pathnameLabel.Location = new System.Drawing.Point(12, 133);
            this.pathnameLabel.Name = "pathnameLabel";
            this.pathnameLabel.Size = new System.Drawing.Size(80, 17);
            this.pathnameLabel.TabIndex = 1;
            this.pathnameLabel.Text = "Pathname :";
            // 
            // couleurLabel
            // 
            this.couleurLabel.AutoSize = true;
            this.couleurLabel.Location = new System.Drawing.Point(13, 207);
            this.couleurLabel.Name = "couleurLabel";
            this.couleurLabel.Size = new System.Drawing.Size(65, 17);
            this.couleurLabel.TabIndex = 2;
            this.couleurLabel.Text = "Couleur :";
            // 
            // precisionNumeric
            // 
            this.precisionNumeric.DecimalPlaces = 3;
            this.precisionNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.precisionNumeric.Location = new System.Drawing.Point(122, 76);
            this.precisionNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.precisionNumeric.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.precisionNumeric.Name = "precisionNumeric";
            this.precisionNumeric.Size = new System.Drawing.Size(150, 22);
            this.precisionNumeric.TabIndex = 3;
            // 
            // pathnameTB
            // 
            this.pathnameTB.Location = new System.Drawing.Point(122, 133);
            this.pathnameTB.Name = "pathnameTB";
            this.pathnameTB.Size = new System.Drawing.Size(700, 22);
            this.pathnameTB.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(247, 265);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(492, 265);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 6;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // couleurComboBox
            // 
            this.couleurComboBox.FormattingEnabled = true;
            this.couleurComboBox.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Yellow",
            "Black",
            "Red",
            "Purple",
            "Pink"});
            this.couleurComboBox.Location = new System.Drawing.Point(122, 207);
            this.couleurComboBox.Name = "couleurComboBox";
            this.couleurComboBox.Size = new System.Drawing.Size(121, 24);
            this.couleurComboBox.TabIndex = 7;
            // 
            // localiteLabel
            // 
            this.localiteLabel.AutoSize = true;
            this.localiteLabel.Location = new System.Drawing.Point(13, 25);
            this.localiteLabel.Name = "localiteLabel";
            this.localiteLabel.Size = new System.Drawing.Size(65, 17);
            this.localiteLabel.TabIndex = 8;
            this.localiteLabel.Text = "Localite :";
            // 
            // localiteTB
            // 
            this.localiteTB.Location = new System.Drawing.Point(122, 25);
            this.localiteTB.Name = "localiteTB";
            this.localiteTB.Size = new System.Drawing.Size(700, 22);
            this.localiteTB.TabIndex = 9;
            // 
            // ParamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 306);
            this.Controls.Add(this.localiteTB);
            this.Controls.Add(this.localiteLabel);
            this.Controls.Add(this.couleurComboBox);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.pathnameTB);
            this.Controls.Add(this.precisionNumeric);
            this.Controls.Add(this.couleurLabel);
            this.Controls.Add(this.pathnameLabel);
            this.Controls.Add(this.precisionLabel);
            this.Name = "ParamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paramForm";
            ((System.ComponentModel.ISupportInitialize)(this.precisionNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label pathnameLabel;
        private System.Windows.Forms.Label couleurLabel;
        private System.Windows.Forms.NumericUpDown precisionNumeric;
        private System.Windows.Forms.TextBox pathnameTB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox couleurComboBox;
        private System.Windows.Forms.Label localiteLabel;
        private System.Windows.Forms.TextBox localiteTB;
    }
}