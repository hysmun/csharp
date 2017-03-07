namespace Inpres_Map
{
    partial class WindowPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPrincipale));
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.POIButton = new System.Windows.Forms.ToolStripButton();
            this.PolylineButton = new System.Windows.Forms.ToolStripButton();
            this.PolygonButton = new System.Windows.Forms.ToolStripButton();
            this.DescriptionLabel = new System.Windows.Forms.ToolStripLabel();
            this.DescriptionTB = new System.Windows.Forms.ToolStripTextBox();
            this.ModeToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.CreationModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeplacementModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerButton = new System.Windows.Forms.ToolStripButton();
            this.POILB = new System.Windows.Forms.ListBox();
            this.PolylineLB = new System.Windows.Forms.ListBox();
            this.PolygonLB = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.PolygonLabel = new System.Windows.Forms.Label();
            this.PolylineLabel = new System.Windows.Forms.Label();
            this.POIlabel = new System.Windows.Forms.Label();
            this.CouleurLabelToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.ColorButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(258, 56);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(1370, 775);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POIButton,
            this.PolylineButton,
            this.PolygonButton,
            this.DescriptionLabel,
            this.DescriptionTB,
            this.CouleurLabelToolStrip,
            this.ColorButtonToolStrip,
            this.ModeToolStrip,
            this.SupprimerButton,
            this.toolStripButton1});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1640, 27);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // POIButton
            // 
            this.POIButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.POIButton.Image = ((System.Drawing.Image)(resources.GetObject("POIButton.Image")));
            this.POIButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.POIButton.Name = "POIButton";
            this.POIButton.Size = new System.Drawing.Size(24, 24);
            this.POIButton.Text = "POI";
            // 
            // PolylineButton
            // 
            this.PolylineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolylineButton.Image = ((System.Drawing.Image)(resources.GetObject("PolylineButton.Image")));
            this.PolylineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolylineButton.Name = "PolylineButton";
            this.PolylineButton.Size = new System.Drawing.Size(24, 24);
            this.PolylineButton.Text = "Polyline";
            // 
            // PolygonButton
            // 
            this.PolygonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("PolygonButton.Image")));
            this.PolygonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(24, 24);
            this.PolygonButton.Text = "Polygon";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(85, 24);
            this.DescriptionLabel.Text = "Descritpion";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(200, 27);
            // 
            // ModeToolStrip
            // 
            this.ModeToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ModeToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreationModeItem,
            this.SelectionModeItem,
            this.DeplacementModeItem});
            this.ModeToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModeToolStrip.Name = "ModeToolStrip";
            this.ModeToolStrip.Size = new System.Drawing.Size(62, 24);
            this.ModeToolStrip.Text = "Mode";
            this.ModeToolStrip.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // CreationModeItem
            // 
            this.CreationModeItem.Checked = true;
            this.CreationModeItem.CheckOnClick = true;
            this.CreationModeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreationModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreationModeItem.Name = "CreationModeItem";
            this.CreationModeItem.Size = new System.Drawing.Size(181, 26);
            this.CreationModeItem.Text = "Création";
            // 
            // SelectionModeItem
            // 
            this.SelectionModeItem.CheckOnClick = true;
            this.SelectionModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectionModeItem.Name = "SelectionModeItem";
            this.SelectionModeItem.Size = new System.Drawing.Size(181, 26);
            this.SelectionModeItem.Text = "Selection";
            // 
            // DeplacementModeItem
            // 
            this.DeplacementModeItem.CheckOnClick = true;
            this.DeplacementModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeplacementModeItem.Name = "DeplacementModeItem";
            this.DeplacementModeItem.Size = new System.Drawing.Size(181, 26);
            this.DeplacementModeItem.Text = "Déplacement";
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SupprimerButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerButton.Image")));
            this.SupprimerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(82, 24);
            this.SupprimerButton.Text = "Supprimer";
            // 
            // POILB
            // 
            this.POILB.AccessibleDescription = "";
            this.POILB.AccessibleName = "";
            this.POILB.FormattingEnabled = true;
            this.POILB.ItemHeight = 16;
            this.POILB.Location = new System.Drawing.Point(0, 76);
            this.POILB.Name = "POILB";
            this.POILB.Size = new System.Drawing.Size(252, 180);
            this.POILB.TabIndex = 3;
            // 
            // PolylineLB
            // 
            this.PolylineLB.FormattingEnabled = true;
            this.PolylineLB.ItemHeight = 16;
            this.PolylineLB.Location = new System.Drawing.Point(0, 279);
            this.PolylineLB.Name = "PolylineLB";
            this.PolylineLB.Size = new System.Drawing.Size(252, 164);
            this.PolylineLB.TabIndex = 4;
            // 
            // PolygonLB
            // 
            this.PolygonLB.FormattingEnabled = true;
            this.PolygonLB.ItemHeight = 16;
            this.PolygonLB.Location = new System.Drawing.Point(0, 466);
            this.PolygonLB.Name = "PolygonLB";
            this.PolygonLB.Size = new System.Drawing.Size(252, 132);
            this.PolygonLB.TabIndex = 5;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(0, 604);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(252, 227);
            this.propertyGrid1.TabIndex = 6;
            // 
            // PolygonLabel
            // 
            this.PolygonLabel.AutoSize = true;
            this.PolygonLabel.Location = new System.Drawing.Point(-3, 446);
            this.PolygonLabel.Name = "PolygonLabel";
            this.PolygonLabel.Size = new System.Drawing.Size(59, 17);
            this.PolygonLabel.TabIndex = 7;
            this.PolygonLabel.Text = "Polygon";
            // 
            // PolylineLabel
            // 
            this.PolylineLabel.AutoSize = true;
            this.PolylineLabel.Location = new System.Drawing.Point(-3, 259);
            this.PolylineLabel.Name = "PolylineLabel";
            this.PolylineLabel.Size = new System.Drawing.Size(57, 17);
            this.PolylineLabel.TabIndex = 8;
            this.PolylineLabel.Text = "Polyline";
            // 
            // POIlabel
            // 
            this.POIlabel.AutoSize = true;
            this.POIlabel.Location = new System.Drawing.Point(-3, 56);
            this.POIlabel.Name = "POIlabel";
            this.POIlabel.Size = new System.Drawing.Size(94, 17);
            this.POIlabel.TabIndex = 9;
            this.POIlabel.Text = "point d\'interêt";
            // 
            // CouleurLabelToolStrip
            // 
            this.CouleurLabelToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CouleurLabelToolStrip.Name = "CouleurLabelToolStrip";
            this.CouleurLabelToolStrip.Size = new System.Drawing.Size(60, 24);
            this.CouleurLabelToolStrip.Text = "Couleur";
            // 
            // ColorButtonToolStrip
            // 
            this.ColorButtonToolStrip.BackColor = System.Drawing.Color.Red;
            this.ColorButtonToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorButtonToolStrip.ForeColor = System.Drawing.Color.Red;
            this.ColorButtonToolStrip.ImageTransparentColor = System.Drawing.Color.Crimson;
            this.ColorButtonToolStrip.Name = "ColorButtonToolStrip";
            this.ColorButtonToolStrip.Size = new System.Drawing.Size(23, 24);
            this.ColorButtonToolStrip.Text = "ColorButton";
            this.ColorButtonToolStrip.Click += new System.EventHandler(this.ClickOnButtonColor);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1640, 28);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // WindowPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 843);
            this.Controls.Add(this.POIlabel);
            this.Controls.Add(this.PolylineLabel);
            this.Controls.Add(this.PolygonLabel);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.PolygonLB);
            this.Controls.Add(this.PolylineLB);
            this.Controls.Add(this.POILB);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.MainPictureBox);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "WindowPrincipale";
            this.Text = "Inpres-Map";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ListBox POILB;
        private System.Windows.Forms.ListBox PolylineLB;
        private System.Windows.Forms.ListBox PolygonLB;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripButton POIButton;
        private System.Windows.Forms.ToolStripButton PolylineButton;
        private System.Windows.Forms.ToolStripButton PolygonButton;
        private System.Windows.Forms.ToolStripLabel DescriptionLabel;
        private System.Windows.Forms.ToolStripTextBox DescriptionTB;
        private System.Windows.Forms.ToolStripButton SupprimerButton;
        private System.Windows.Forms.Label PolygonLabel;
        private System.Windows.Forms.Label PolylineLabel;
        private System.Windows.Forms.Label POIlabel;
        private System.Windows.Forms.ToolStripDropDownButton ModeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CreationModeItem;
        private System.Windows.Forms.ToolStripMenuItem SelectionModeItem;
        private System.Windows.Forms.ToolStripMenuItem DeplacementModeItem;
        private System.Windows.Forms.ToolStripLabel CouleurLabelToolStrip;
        private System.Windows.Forms.ToolStripButton ColorButtonToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

