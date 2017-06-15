namespace TripManagerProject
{
    partial class CreateSiteWindow
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
            this.DescritpionLabel = new System.Windows.Forms.Label();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.latitudeNumeric = new System.Windows.Forms.NumericUpDown();
            this.longitudeNumeric = new System.Windows.Forms.NumericUpDown();
            this.DescriptionLongueLabel = new System.Windows.Forms.Label();
            this.DescriptionLongueTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.imageOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DescritpionLabel
            // 
            this.DescritpionLabel.AutoSize = true;
            this.DescritpionLabel.Location = new System.Drawing.Point(13, 44);
            this.DescritpionLabel.Name = "DescritpionLabel";
            this.DescritpionLabel.Size = new System.Drawing.Size(125, 17);
            this.DescritpionLabel.TabIndex = 0;
            this.DescritpionLabel.Text = "Description Courte";
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.Location = new System.Drawing.Point(13, 286);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(59, 17);
            this.LatitudeLabel.TabIndex = 1;
            this.LatitudeLabel.Text = "Latitude";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.Location = new System.Drawing.Point(12, 321);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(71, 17);
            this.LongitudeLabel.TabIndex = 2;
            this.LongitudeLabel.Text = "Longitude";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(144, 44);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(405, 22);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // latitudeNumeric
            // 
            this.latitudeNumeric.DecimalPlaces = 5;
            this.latitudeNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.latitudeNumeric.Location = new System.Drawing.Point(144, 281);
            this.latitudeNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.latitudeNumeric.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.latitudeNumeric.Name = "latitudeNumeric";
            this.latitudeNumeric.Size = new System.Drawing.Size(158, 22);
            this.latitudeNumeric.TabIndex = 4;
            // 
            // longitudeNumeric
            // 
            this.longitudeNumeric.DecimalPlaces = 5;
            this.longitudeNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.longitudeNumeric.Location = new System.Drawing.Point(144, 316);
            this.longitudeNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.longitudeNumeric.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.longitudeNumeric.Name = "longitudeNumeric";
            this.longitudeNumeric.Size = new System.Drawing.Size(158, 22);
            this.longitudeNumeric.TabIndex = 5;
            // 
            // DescriptionLongueLabel
            // 
            this.DescriptionLongueLabel.AutoSize = true;
            this.DescriptionLongueLabel.Location = new System.Drawing.Point(12, 91);
            this.DescriptionLongueLabel.Name = "DescriptionLongueLabel";
            this.DescriptionLongueLabel.Size = new System.Drawing.Size(126, 17);
            this.DescriptionLongueLabel.TabIndex = 6;
            this.DescriptionLongueLabel.Text = "Description longue";
            // 
            // DescriptionLongueTextBox
            // 
            this.DescriptionLongueTextBox.Location = new System.Drawing.Point(144, 91);
            this.DescriptionLongueTextBox.Multiline = true;
            this.DescriptionLongueTextBox.Name = "DescriptionLongueTextBox";
            this.DescriptionLongueTextBox.Size = new System.Drawing.Size(405, 168);
            this.DescriptionLongueTextBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(81, 373);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(227, 373);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 9;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(362, 281);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(185, 131);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 10;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // CreateSiteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 424);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.DescriptionLongueTextBox);
            this.Controls.Add(this.DescriptionLongueLabel);
            this.Controls.Add(this.longitudeNumeric);
            this.Controls.Add(this.latitudeNumeric);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.DescritpionLabel);
            this.Name = "CreateSiteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSiteWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateSiteWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescritpionLabel;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.NumericUpDown latitudeNumeric;
        private System.Windows.Forms.NumericUpDown longitudeNumeric;
        private System.Windows.Forms.Label DescriptionLongueLabel;
        private System.Windows.Forms.TextBox DescriptionLongueTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.OpenFileDialog imageOpen;
    }
}