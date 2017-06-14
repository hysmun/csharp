namespace TripManagerProject
{
    partial class AddSiteMarker
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
            this.ajoutButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajoutButton
            // 
            this.ajoutButton.Location = new System.Drawing.Point(25, 22);
            this.ajoutButton.Name = "ajoutButton";
            this.ajoutButton.Size = new System.Drawing.Size(208, 23);
            this.ajoutButton.TabIndex = 0;
            this.ajoutButton.Text = "Ajouter au trajet selectionner";
            this.ajoutButton.UseVisualStyleBackColor = true;
            this.ajoutButton.Click += new System.EventHandler(this.ajoutButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(267, 22);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 1;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // AddSiteMarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 65);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.ajoutButton);
            this.Name = "AddSiteMarker";
            this.Text = "Ajout Site";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ajoutButton;
        private System.Windows.Forms.Button annulerButton;
    }
}