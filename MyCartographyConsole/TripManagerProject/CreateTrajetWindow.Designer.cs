namespace TripManagerProject
{
    partial class CreateTrajetWindow
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 37);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 82);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // DateCalendar
            // 
            this.DateCalendar.Location = new System.Drawing.Point(16, 108);
            this.DateCalendar.MaxSelectionCount = 1;
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 2;
            this.DateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateSelected);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(97, 37);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(386, 22);
            this.DescriptionTB.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(97, 341);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(282, 341);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 5;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // CreateTrajetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 376);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DateCalendar);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Name = "CreateTrajetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTrajetWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.MonthCalendar DateCalendar;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}