﻿namespace Inpres_Map
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
            this.CouleurLabelToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.ColorButtonToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ModeToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.CreationModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeplacementModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerButton = new System.Windows.Forms.ToolStripButton();
            this.FiniToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.POILB = new System.Windows.Forms.ListBox();
            this.PolylineLB = new System.Windows.Forms.ListBox();
            this.PolygonLB = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.PolygonLabel = new System.Windows.Forms.Label();
            this.PolylineLabel = new System.Windows.Forms.Label();
            this.POIlabel = new System.Windows.Forms.Label();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.propertyGridLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(258, 56);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(1370, 862);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPictureBox_Paint);
            this.MainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseClick);
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
            this.FiniToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1634, 27);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // POIButton
            // 
            this.POIButton.Checked = true;
            this.POIButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.POIButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.POIButton.Image = ((System.Drawing.Image)(resources.GetObject("POIButton.Image")));
            this.POIButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.POIButton.Name = "POIButton";
            this.POIButton.Size = new System.Drawing.Size(24, 24);
            this.POIButton.Text = "POI";
            this.POIButton.ToolTipText = "Point d\'interêt";
            this.POIButton.Click += new System.EventHandler(this.POIButton_Click);
            // 
            // PolylineButton
            // 
            this.PolylineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolylineButton.Image = ((System.Drawing.Image)(resources.GetObject("PolylineButton.Image")));
            this.PolylineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolylineButton.Name = "PolylineButton";
            this.PolylineButton.Size = new System.Drawing.Size(24, 24);
            this.PolylineButton.Text = "Polyline";
            this.PolylineButton.ToolTipText = "Polyline (ligne brisée)";
            this.PolylineButton.Click += new System.EventHandler(this.PolylineButton_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("PolygonButton.Image")));
            this.PolygonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(24, 24);
            this.PolygonButton.Text = "Polygon";
            this.PolygonButton.ToolTipText = "Polygon (ensemble de Polyline)";
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(85, 24);
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(200, 27);
            this.DescriptionTB.ToolTipText = "Veuillez entrez la description ici";
            this.DescriptionTB.Enter += new System.EventHandler(this.DescriptionTB_Enter);
            this.DescriptionTB.Leave += new System.EventHandler(this.DescriptionTB_Leave);
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
            this.ColorButtonToolStrip.ToolTipText = "Changer la couleur des prochains objets lors de leurs création";
            this.ColorButtonToolStrip.Click += new System.EventHandler(this.ClickOnButtonColor);
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
            this.ModeToolStrip.ToolTipText = "Changer de mode : Création, Séléction, Déplacement";
            // 
            // CreationModeItem
            // 
            this.CreationModeItem.Checked = true;
            this.CreationModeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreationModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreationModeItem.Name = "CreationModeItem";
            this.CreationModeItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.CreationModeItem.Size = new System.Drawing.Size(222, 26);
            this.CreationModeItem.Text = "Création";
            this.CreationModeItem.Click += new System.EventHandler(this.CreationModeItem_Click);
            // 
            // SelectionModeItem
            // 
            this.SelectionModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectionModeItem.Name = "SelectionModeItem";
            this.SelectionModeItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.SelectionModeItem.Size = new System.Drawing.Size(222, 26);
            this.SelectionModeItem.Text = "Selection";
            this.SelectionModeItem.Click += new System.EventHandler(this.SelectionModeItem_Click);
            // 
            // DeplacementModeItem
            // 
            this.DeplacementModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeplacementModeItem.Name = "DeplacementModeItem";
            this.DeplacementModeItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.DeplacementModeItem.Size = new System.Drawing.Size(222, 26);
            this.DeplacementModeItem.Text = "Déplacement";
            this.DeplacementModeItem.Click += new System.EventHandler(this.DeplacementModeItem_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SupprimerButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerButton.Image")));
            this.SupprimerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(82, 24);
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.ToolTipText = "Supprimer l\'objet selection dans le PropertyGrid";
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // FiniToolStripButton
            // 
            this.FiniToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FiniToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiniToolStripButton.Image")));
            this.FiniToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiniToolStripButton.Name = "FiniToolStripButton";
            this.FiniToolStripButton.Size = new System.Drawing.Size(36, 24);
            this.FiniToolStripButton.Text = "Fini";
            this.FiniToolStripButton.Visible = false;
            this.FiniToolStripButton.Click += new System.EventHandler(this.FiniToolStripButton_Click);
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
            this.POILB.SelectedIndexChanged += new System.EventHandler(this.POILB_SelectedIndexChanged);
            // 
            // PolylineLB
            // 
            this.PolylineLB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PolylineLB.FormattingEnabled = true;
            this.PolylineLB.ItemHeight = 16;
            this.PolylineLB.Location = new System.Drawing.Point(0, 279);
            this.PolylineLB.Name = "PolylineLB";
            this.PolylineLB.Size = new System.Drawing.Size(252, 164);
            this.PolylineLB.TabIndex = 4;
            this.PolylineLB.SelectedIndexChanged += new System.EventHandler(this.PolylineLB_SelectedIndexChanged);
            // 
            // PolygonLB
            // 
            this.PolygonLB.FormattingEnabled = true;
            this.PolygonLB.ItemHeight = 16;
            this.PolygonLB.Location = new System.Drawing.Point(0, 466);
            this.PolygonLB.Name = "PolygonLB";
            this.PolygonLB.Size = new System.Drawing.Size(252, 132);
            this.PolygonLB.TabIndex = 5;
            this.PolygonLB.SelectedIndexChanged += new System.EventHandler(this.PolygonLB_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(0, 621);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(252, 289);
            this.propertyGrid.TabIndex = 6;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            this.propertyGrid.Enter += new System.EventHandler(this.propertyGrid_Enter);
            this.propertyGrid.Leave += new System.EventHandler(this.propertyGrid_Leave);
            // 
            // PolygonLabel
            // 
            this.PolygonLabel.AutoSize = true;
            this.PolygonLabel.Location = new System.Drawing.Point(8, 446);
            this.PolygonLabel.Name = "PolygonLabel";
            this.PolygonLabel.Size = new System.Drawing.Size(59, 17);
            this.PolygonLabel.TabIndex = 7;
            this.PolygonLabel.Text = "Polygon";
            // 
            // PolylineLabel
            // 
            this.PolylineLabel.AutoSize = true;
            this.PolylineLabel.Location = new System.Drawing.Point(8, 259);
            this.PolylineLabel.Name = "PolylineLabel";
            this.PolylineLabel.Size = new System.Drawing.Size(57, 17);
            this.PolylineLabel.TabIndex = 8;
            this.PolylineLabel.Text = "Polyline";
            // 
            // POIlabel
            // 
            this.POIlabel.AutoSize = true;
            this.POIlabel.Location = new System.Drawing.Point(3, 55);
            this.POIlabel.Name = "POIlabel";
            this.POIlabel.Size = new System.Drawing.Size(95, 17);
            this.POIlabel.TabIndex = 9;
            this.POIlabel.Text = "Point d\'interêt";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenu});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionToolStripMenu
            // 
            this.optionToolStripMenu.Name = "optionToolStripMenu";
            this.optionToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionToolStripMenu.Size = new System.Drawing.Size(179, 26);
            this.optionToolStripMenu.Text = "Option";
            this.optionToolStripMenu.Click += new System.EventHandler(this.optionToolStripMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutItem.Size = new System.Drawing.Size(173, 26);
            this.aboutItem.Text = "About";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1634, 28);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // propertyGridLabel
            // 
            this.propertyGridLabel.AutoSize = true;
            this.propertyGridLabel.Location = new System.Drawing.Point(8, 601);
            this.propertyGridLabel.Name = "propertyGridLabel";
            this.propertyGridLabel.Size = new System.Drawing.Size(89, 17);
            this.propertyGridLabel.TabIndex = 10;
            this.propertyGridLabel.Text = "PropretyGrid";
            // 
            // WindowPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 922);
            this.Controls.Add(this.propertyGridLabel);
            this.Controls.Add(this.POIlabel);
            this.Controls.Add(this.PolylineLabel);
            this.Controls.Add(this.PolygonLabel);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.PolygonLB);
            this.Controls.Add(this.PolylineLB);
            this.Controls.Add(this.POILB);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.MainPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "WindowPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inpres-Map";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowPrincipale_KeyDown);
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
        private System.Windows.Forms.PropertyGrid propertyGrid;
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenu;
        private System.Windows.Forms.ListBox PolylineLB;
        private System.Windows.Forms.ListBox PolygonLB;
        private System.Windows.Forms.ToolStripButton FiniToolStripButton;
        private System.Windows.Forms.ListBox POILB;
        private System.Windows.Forms.Label propertyGridLabel;
    }
}

