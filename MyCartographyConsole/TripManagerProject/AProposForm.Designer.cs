namespace TripManagerProject
{
    partial class AProposForm
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
            this.descripionLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.coryprightLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descripionLabel
            // 
            this.descripionLabel.Location = new System.Drawing.Point(21, 26);
            this.descripionLabel.Name = "descripionLabel";
            this.descripionLabel.Size = new System.Drawing.Size(315, 255);
            this.descripionLabel.TabIndex = 0;
            this.descripionLabel.Text = "description";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(342, 26);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(152, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label2";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(21, 281);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(153, 17);
            this.nomLabel.TabIndex = 2;
            this.nomLabel.Text = "Brajkovic Antoine 2221";
            // 
            // coryprightLabel
            // 
            this.coryprightLabel.AutoSize = true;
            this.coryprightLabel.Location = new System.Drawing.Point(21, 315);
            this.coryprightLabel.Name = "coryprightLabel";
            this.coryprightLabel.Size = new System.Drawing.Size(104, 17);
            this.coryprightLabel.TabIndex = 3;
            this.coryprightLabel.Text = "Copyright 2017";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(202, 365);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AProposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 400);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.coryprightLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descripionLabel);
            this.Name = "AProposForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AProposForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descripionLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label coryprightLabel;
        private System.Windows.Forms.Button OKButton;
    }
}