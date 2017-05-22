namespace TripManagerProject
{
    partial class CreateVoyageWindow
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
            this.LibelleLabel = new System.Windows.Forms.Label();
            this.DateDebutLabel = new System.Windows.Forms.Label();
            this.DateFinLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LibelleTextBox = new System.Windows.Forms.TextBox();
            this.calendarDebut = new System.Windows.Forms.MonthCalendar();
            this.calendarFin = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 48);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(87, 17);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description :";
            // 
            // LibelleLabel
            // 
            this.LibelleLabel.AutoSize = true;
            this.LibelleLabel.Location = new System.Drawing.Point(12, 96);
            this.LibelleLabel.Name = "LibelleLabel";
            this.LibelleLabel.Size = new System.Drawing.Size(57, 17);
            this.LibelleLabel.TabIndex = 1;
            this.LibelleLabel.Text = "Libellé :";
            // 
            // DateDebutLabel
            // 
            this.DateDebutLabel.AutoSize = true;
            this.DateDebutLabel.Location = new System.Drawing.Point(12, 141);
            this.DateDebutLabel.Name = "DateDebutLabel";
            this.DateDebutLabel.Size = new System.Drawing.Size(106, 17);
            this.DateDebutLabel.TabIndex = 2;
            this.DateDebutLabel.Text = "Date de début :";
            // 
            // DateFinLabel
            // 
            this.DateFinLabel.AutoSize = true;
            this.DateFinLabel.Location = new System.Drawing.Point(319, 141);
            this.DateFinLabel.Name = "DateFinLabel";
            this.DateFinLabel.Size = new System.Drawing.Size(85, 17);
            this.DateFinLabel.TabIndex = 3;
            this.DateFinLabel.Text = "Date de fin :";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(163, 48);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(428, 22);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // LibelleTextBox
            // 
            this.LibelleTextBox.Location = new System.Drawing.Point(163, 96);
            this.LibelleTextBox.Name = "LibelleTextBox";
            this.LibelleTextBox.Size = new System.Drawing.Size(428, 22);
            this.LibelleTextBox.TabIndex = 5;
            // 
            // calendarDebut
            // 
            this.calendarDebut.Location = new System.Drawing.Point(15, 162);
            this.calendarDebut.MaxSelectionCount = 1;
            this.calendarDebut.Name = "calendarDebut";
            this.calendarDebut.ShowTodayCircle = false;
            this.calendarDebut.TabIndex = 6;
            this.calendarDebut.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarDebut_DateSelected);
            // 
            // calendarFin
            // 
            this.calendarFin.Location = new System.Drawing.Point(322, 162);
            this.calendarFin.MaxSelectionCount = 1;
            this.calendarFin.Name = "calendarFin";
            this.calendarFin.ShowTodayCircle = false;
            this.calendarFin.TabIndex = 7;
            this.calendarFin.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarFin_DateSelected);
            // 
            // CreateVoyageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 393);
            this.Controls.Add(this.calendarFin);
            this.Controls.Add(this.calendarDebut);
            this.Controls.Add(this.LibelleTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DateFinLabel);
            this.Controls.Add(this.DateDebutLabel);
            this.Controls.Add(this.LibelleLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Name = "CreateVoyageWindow";
            this.Text = "Creation d\'un nouveau voyage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateVoyageWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label LibelleLabel;
        private System.Windows.Forms.Label DateDebutLabel;
        private System.Windows.Forms.Label DateFinLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox LibelleTextBox;
        private System.Windows.Forms.MonthCalendar calendarDebut;
        private System.Windows.Forms.MonthCalendar calendarFin;
    }
}