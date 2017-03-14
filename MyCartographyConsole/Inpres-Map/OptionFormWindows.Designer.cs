namespace Inpres_Map
{
    partial class OptionFormWindow
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
            this.PrecisionLabelTool = new System.Windows.Forms.Label();
            this.CouleurLabelTool = new System.Windows.Forms.Label();
            this.numericOption = new System.Windows.Forms.NumericUpDown();
            this.AideTool = new System.Windows.Forms.Label();
            this.ColorButtonTool = new System.Windows.Forms.Button();
            this.OKButtonOption = new System.Windows.Forms.Button();
            this.AppliquerButtonOption = new System.Windows.Forms.Button();
            this.CancelButtonOption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericOption)).BeginInit();
            this.SuspendLayout();
            // 
            // PrecisionLabelTool
            // 
            this.PrecisionLabelTool.AutoSize = true;
            this.PrecisionLabelTool.Location = new System.Drawing.Point(12, 57);
            this.PrecisionLabelTool.Name = "PrecisionLabelTool";
            this.PrecisionLabelTool.Size = new System.Drawing.Size(74, 17);
            this.PrecisionLabelTool.TabIndex = 0;
            this.PrecisionLabelTool.Text = "Précision :";
            // 
            // CouleurLabelTool
            // 
            this.CouleurLabelTool.AutoSize = true;
            this.CouleurLabelTool.Location = new System.Drawing.Point(12, 92);
            this.CouleurLabelTool.Name = "CouleurLabelTool";
            this.CouleurLabelTool.Size = new System.Drawing.Size(65, 17);
            this.CouleurLabelTool.TabIndex = 1;
            this.CouleurLabelTool.Text = "Couleur :";
            // 
            // numericOption
            // 
            this.numericOption.DecimalPlaces = 3;
            this.numericOption.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericOption.Location = new System.Drawing.Point(92, 55);
            this.numericOption.Name = "numericOption";
            this.numericOption.Size = new System.Drawing.Size(120, 22);
            this.numericOption.TabIndex = 2;
            // 
            // AideTool
            // 
            this.AideTool.AutoSize = true;
            this.AideTool.Location = new System.Drawing.Point(12, 9);
            this.AideTool.Name = "AideTool";
            this.AideTool.Size = new System.Drawing.Size(58, 17);
            this.AideTool.TabIndex = 3;
            this.AideTool.Text = "Option :";
            // 
            // ColorButtonTool
            // 
            this.ColorButtonTool.BackColor = System.Drawing.Color.Blue;
            this.ColorButtonTool.Location = new System.Drawing.Point(92, 92);
            this.ColorButtonTool.Name = "ColorButtonTool";
            this.ColorButtonTool.Size = new System.Drawing.Size(24, 23);
            this.ColorButtonTool.TabIndex = 4;
            this.ColorButtonTool.UseCompatibleTextRendering = true;
            this.ColorButtonTool.UseVisualStyleBackColor = false;
            this.ColorButtonTool.Click += new System.EventHandler(this.ColorButtonTool_Click);
            // 
            // OKButtonOption
            // 
            this.OKButtonOption.Location = new System.Drawing.Point(11, 164);
            this.OKButtonOption.Name = "OKButtonOption";
            this.OKButtonOption.Size = new System.Drawing.Size(75, 36);
            this.OKButtonOption.TabIndex = 5;
            this.OKButtonOption.Text = "OK";
            this.OKButtonOption.UseVisualStyleBackColor = true;
            this.OKButtonOption.Click += new System.EventHandler(this.OKButtonOption_Click);
            // 
            // AppliquerButtonOption
            // 
            this.AppliquerButtonOption.Location = new System.Drawing.Point(92, 164);
            this.AppliquerButtonOption.Name = "AppliquerButtonOption";
            this.AppliquerButtonOption.Size = new System.Drawing.Size(80, 36);
            this.AppliquerButtonOption.TabIndex = 6;
            this.AppliquerButtonOption.Text = "Appliquer";
            this.AppliquerButtonOption.UseVisualStyleBackColor = true;
            this.AppliquerButtonOption.Click += new System.EventHandler(this.AppliquerButtonOption_Click);
            // 
            // CancelButtonOption
            // 
            this.CancelButtonOption.Location = new System.Drawing.Point(178, 164);
            this.CancelButtonOption.Name = "CancelButtonOption";
            this.CancelButtonOption.Size = new System.Drawing.Size(75, 36);
            this.CancelButtonOption.TabIndex = 7;
            this.CancelButtonOption.Text = "Cancel";
            this.CancelButtonOption.UseVisualStyleBackColor = true;
            this.CancelButtonOption.Click += new System.EventHandler(this.CancelButtonOption_Click);
            // 
            // OptionFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 212);
            this.Controls.Add(this.CancelButtonOption);
            this.Controls.Add(this.AppliquerButtonOption);
            this.Controls.Add(this.OKButtonOption);
            this.Controls.Add(this.ColorButtonTool);
            this.Controls.Add(this.AideTool);
            this.Controls.Add(this.numericOption);
            this.Controls.Add(this.CouleurLabelTool);
            this.Controls.Add(this.PrecisionLabelTool);
            this.Name = "OptionFormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.numericOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrecisionLabelTool;
        private System.Windows.Forms.Label CouleurLabelTool;
        private System.Windows.Forms.NumericUpDown numericOption;
        private System.Windows.Forms.Label AideTool;
        private System.Windows.Forms.Button ColorButtonTool;
        private System.Windows.Forms.Button OKButtonOption;
        private System.Windows.Forms.Button AppliquerButtonOption;
        private System.Windows.Forms.Button CancelButtonOption;
    }
}