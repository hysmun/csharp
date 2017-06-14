namespace TripManagerProject
{
    partial class ListForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.trajetLabel = new System.Windows.Forms.Label();
            this.siteLabel = new System.Windows.Forms.Label();
            this.siteList = new System.Windows.Forms.ListBox();
            this.trajetList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(557, 519);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // trajetLabel
            // 
            this.trajetLabel.AutoSize = true;
            this.trajetLabel.Location = new System.Drawing.Point(12, 9);
            this.trajetLabel.Name = "trajetLabel";
            this.trajetLabel.Size = new System.Drawing.Size(45, 17);
            this.trajetLabel.TabIndex = 2;
            this.trajetLabel.Text = "Trajet";
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Location = new System.Drawing.Point(617, 9);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(32, 17);
            this.siteLabel.TabIndex = 3;
            this.siteLabel.Text = "Site";
            // 
            // siteList
            // 
            this.siteList.FormattingEnabled = true;
            this.siteList.ItemHeight = 16;
            this.siteList.Location = new System.Drawing.Point(620, 30);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(555, 484);
            this.siteList.TabIndex = 7;
            // 
            // trajetList
            // 
            this.trajetList.FormattingEnabled = true;
            this.trajetList.ItemHeight = 16;
            this.trajetList.Location = new System.Drawing.Point(13, 30);
            this.trajetList.Name = "trajetList";
            this.trajetList.Size = new System.Drawing.Size(579, 484);
            this.trajetList.TabIndex = 8;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 551);
            this.Controls.Add(this.trajetList);
            this.Controls.Add(this.siteList);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.trajetLabel);
            this.Controls.Add(this.okButton);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label trajetLabel;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.ListBox siteList;
        private System.Windows.Forms.ListBox trajetList;
    }
}