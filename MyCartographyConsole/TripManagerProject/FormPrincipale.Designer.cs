namespace TripManagerProject
{
    partial class formPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipale));
            this.principaleTB = new System.Windows.Forms.ToolStrip();
            this.menuDropDownMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.FichierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauVoyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChargerVoyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnregistrerVoyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreGestionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AproposMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSiteDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AjoutSiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enreSiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChargerSiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifSiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupSiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionTrajetDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AjoutTrajetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifTrajetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupTrajetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReordonnerTrajetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinirButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainerPrincipale = new System.Windows.Forms.SplitContainer();
            this.gaucheSplitContainer = new System.Windows.Forms.SplitContainer();
            this.trajetTV = new System.Windows.Forms.TreeView();
            this.siteLB = new System.Windows.Forms.ListBox();
            this.gmapWinPrincipale = new GMap.NET.WindowsForms.GMapControl();
            this.voyageOpen = new System.Windows.Forms.OpenFileDialog();
            this.principaleTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipale)).BeginInit();
            this.splitContainerPrincipale.Panel1.SuspendLayout();
            this.splitContainerPrincipale.Panel2.SuspendLayout();
            this.splitContainerPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaucheSplitContainer)).BeginInit();
            this.gaucheSplitContainer.Panel1.SuspendLayout();
            this.gaucheSplitContainer.Panel2.SuspendLayout();
            this.gaucheSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // principaleTB
            // 
            this.principaleTB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.principaleTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDropDownMenu,
            this.gestionSiteDropDown,
            this.GestionTrajetDropDown,
            this.FinirButton});
            this.principaleTB.Location = new System.Drawing.Point(0, 0);
            this.principaleTB.Name = "principaleTB";
            this.principaleTB.Size = new System.Drawing.Size(1128, 27);
            this.principaleTB.TabIndex = 0;
            this.principaleTB.Text = "principaleTB";
            // 
            // menuDropDownMenu
            // 
            this.menuDropDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FichierMenuItem,
            this.GestionMenuItem,
            this.AproposMenuItem});
            this.menuDropDownMenu.Image = ((System.Drawing.Image)(resources.GetObject("menuDropDownMenu.Image")));
            this.menuDropDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDropDownMenu.Name = "menuDropDownMenu";
            this.menuDropDownMenu.Size = new System.Drawing.Size(60, 24);
            this.menuDropDownMenu.Text = "Menu";
            // 
            // FichierMenuItem
            // 
            this.FichierMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauVoyMenuItem,
            this.ChargerVoyMenuItem,
            this.EnregistrerVoyMenuItem});
            this.FichierMenuItem.Name = "FichierMenuItem";
            this.FichierMenuItem.Size = new System.Drawing.Size(181, 26);
            this.FichierMenuItem.Text = "Fichier";
            // 
            // nouveauVoyMenuItem
            // 
            this.nouveauVoyMenuItem.Name = "nouveauVoyMenuItem";
            this.nouveauVoyMenuItem.Size = new System.Drawing.Size(207, 26);
            this.nouveauVoyMenuItem.Text = "Nouveau Voyage";
            this.nouveauVoyMenuItem.Click += new System.EventHandler(this.nouveauVoyMenuItem_Click);
            // 
            // ChargerVoyMenuItem
            // 
            this.ChargerVoyMenuItem.Name = "ChargerVoyMenuItem";
            this.ChargerVoyMenuItem.Size = new System.Drawing.Size(207, 26);
            this.ChargerVoyMenuItem.Text = "Charger voyage";
            this.ChargerVoyMenuItem.Click += new System.EventHandler(this.ChargerVoyMenuItem_Click);
            // 
            // EnregistrerVoyMenuItem
            // 
            this.EnregistrerVoyMenuItem.Name = "EnregistrerVoyMenuItem";
            this.EnregistrerVoyMenuItem.Size = new System.Drawing.Size(207, 26);
            this.EnregistrerVoyMenuItem.Text = "Enregistrer voyage";
            this.EnregistrerVoyMenuItem.Click += new System.EventHandler(this.EnregistrerVoyMenuItem_Click);
            // 
            // GestionMenuItem
            // 
            this.GestionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametreGestionMenuItem,
            this.listeToolStripMenuItem});
            this.GestionMenuItem.Name = "GestionMenuItem";
            this.GestionMenuItem.Size = new System.Drawing.Size(181, 26);
            this.GestionMenuItem.Text = "Gestion";
            // 
            // parametreGestionMenuItem
            // 
            this.parametreGestionMenuItem.Name = "parametreGestionMenuItem";
            this.parametreGestionMenuItem.Size = new System.Drawing.Size(181, 26);
            this.parametreGestionMenuItem.Text = "Paramètres";
            this.parametreGestionMenuItem.Click += new System.EventHandler(this.parametreGestionMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // AproposMenuItem
            // 
            this.AproposMenuItem.Name = "AproposMenuItem";
            this.AproposMenuItem.Size = new System.Drawing.Size(181, 26);
            this.AproposMenuItem.Text = "A propos ....";
            this.AproposMenuItem.Click += new System.EventHandler(this.AproposMenuItem_Click);
            // 
            // gestionSiteDropDown
            // 
            this.gestionSiteDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gestionSiteDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjoutSiteMenuItem,
            this.enreSiteMenuItem,
            this.ChargerSiteMenuItem,
            this.ModifSiteMenuItem,
            this.SupSiteMenuItem});
            this.gestionSiteDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gestionSiteDropDown.Image")));
            this.gestionSiteDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gestionSiteDropDown.Name = "gestionSiteDropDown";
            this.gestionSiteDropDown.Size = new System.Drawing.Size(102, 24);
            this.gestionSiteDropDown.Text = "Gestion Site";
            // 
            // AjoutSiteMenuItem
            // 
            this.AjoutSiteMenuItem.Name = "AjoutSiteMenuItem";
            this.AjoutSiteMenuItem.Size = new System.Drawing.Size(202, 26);
            this.AjoutSiteMenuItem.Text = "Ajouter un site";
            this.AjoutSiteMenuItem.Click += new System.EventHandler(this.AjoutSiteMenuItem_Click);
            // 
            // enreSiteMenuItem
            // 
            this.enreSiteMenuItem.Name = "enreSiteMenuItem";
            this.enreSiteMenuItem.Size = new System.Drawing.Size(202, 26);
            this.enreSiteMenuItem.Text = "Enregistrer un site";
            this.enreSiteMenuItem.Click += new System.EventHandler(this.enreSiteMenuItem_Click);
            // 
            // ChargerSiteMenuItem
            // 
            this.ChargerSiteMenuItem.Name = "ChargerSiteMenuItem";
            this.ChargerSiteMenuItem.Size = new System.Drawing.Size(202, 26);
            this.ChargerSiteMenuItem.Text = "Charger les sites";
            this.ChargerSiteMenuItem.Click += new System.EventHandler(this.ChargerSiteMenuItem_Click);
            // 
            // ModifSiteMenuItem
            // 
            this.ModifSiteMenuItem.Name = "ModifSiteMenuItem";
            this.ModifSiteMenuItem.Size = new System.Drawing.Size(202, 26);
            this.ModifSiteMenuItem.Text = "Modifier un site";
            this.ModifSiteMenuItem.Click += new System.EventHandler(this.ModifSiteMenuItem_Click);
            // 
            // SupSiteMenuItem
            // 
            this.SupSiteMenuItem.Name = "SupSiteMenuItem";
            this.SupSiteMenuItem.Size = new System.Drawing.Size(202, 26);
            this.SupSiteMenuItem.Text = "Supprimer un site";
            this.SupSiteMenuItem.Click += new System.EventHandler(this.SupSiteMenuItem_Click);
            // 
            // GestionTrajetDropDown
            // 
            this.GestionTrajetDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GestionTrajetDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjoutTrajetMenuItem,
            this.ModifTrajetMenuItem,
            this.SupTrajetMenuItem,
            this.ReordonnerTrajetMenuItem});
            this.GestionTrajetDropDown.Image = ((System.Drawing.Image)(resources.GetObject("GestionTrajetDropDown.Image")));
            this.GestionTrajetDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GestionTrajetDropDown.Name = "GestionTrajetDropDown";
            this.GestionTrajetDropDown.Size = new System.Drawing.Size(121, 24);
            this.GestionTrajetDropDown.Text = "Gestion Trajets";
            // 
            // AjoutTrajetMenuItem
            // 
            this.AjoutTrajetMenuItem.Name = "AjoutTrajetMenuItem";
            this.AjoutTrajetMenuItem.Size = new System.Drawing.Size(229, 26);
            this.AjoutTrajetMenuItem.Text = "Ajouter un trajet";
            this.AjoutTrajetMenuItem.Click += new System.EventHandler(this.AjoutTrajetMenuItem_Click);
            // 
            // ModifTrajetMenuItem
            // 
            this.ModifTrajetMenuItem.Name = "ModifTrajetMenuItem";
            this.ModifTrajetMenuItem.Size = new System.Drawing.Size(229, 26);
            this.ModifTrajetMenuItem.Text = "Modifier un trajet";
            this.ModifTrajetMenuItem.Click += new System.EventHandler(this.ModifTrajetMenuItem_Click);
            // 
            // SupTrajetMenuItem
            // 
            this.SupTrajetMenuItem.Name = "SupTrajetMenuItem";
            this.SupTrajetMenuItem.Size = new System.Drawing.Size(229, 26);
            this.SupTrajetMenuItem.Text = "Supprimer un trajet";
            this.SupTrajetMenuItem.Click += new System.EventHandler(this.SupTrajetMenuItem_Click);
            // 
            // ReordonnerTrajetMenuItem
            // 
            this.ReordonnerTrajetMenuItem.Name = "ReordonnerTrajetMenuItem";
            this.ReordonnerTrajetMenuItem.Size = new System.Drawing.Size(229, 26);
            this.ReordonnerTrajetMenuItem.Text = "Réordonner les trajets";
            this.ReordonnerTrajetMenuItem.Click += new System.EventHandler(this.ReordonnerTrajetMenuItem_Click);
            // 
            // FinirButton
            // 
            this.FinirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FinirButton.Image = ((System.Drawing.Image)(resources.GetObject("FinirButton.Image")));
            this.FinirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FinirButton.Name = "FinirButton";
            this.FinirButton.Size = new System.Drawing.Size(41, 24);
            this.FinirButton.Text = "Finir";
            this.FinirButton.Visible = false;
            this.FinirButton.Click += new System.EventHandler(this.FinirButton_Click);
            // 
            // splitContainerPrincipale
            // 
            this.splitContainerPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipale.Location = new System.Drawing.Point(0, 27);
            this.splitContainerPrincipale.Name = "splitContainerPrincipale";
            // 
            // splitContainerPrincipale.Panel1
            // 
            this.splitContainerPrincipale.Panel1.Controls.Add(this.gaucheSplitContainer);
            // 
            // splitContainerPrincipale.Panel2
            // 
            this.splitContainerPrincipale.Panel2.Controls.Add(this.gmapWinPrincipale);
            this.splitContainerPrincipale.Size = new System.Drawing.Size(1128, 658);
            this.splitContainerPrincipale.SplitterDistance = 376;
            this.splitContainerPrincipale.TabIndex = 2;
            // 
            // gaucheSplitContainer
            // 
            this.gaucheSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaucheSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gaucheSplitContainer.Name = "gaucheSplitContainer";
            this.gaucheSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // gaucheSplitContainer.Panel1
            // 
            this.gaucheSplitContainer.Panel1.Controls.Add(this.trajetTV);
            // 
            // gaucheSplitContainer.Panel2
            // 
            this.gaucheSplitContainer.Panel2.Controls.Add(this.siteLB);
            this.gaucheSplitContainer.Size = new System.Drawing.Size(376, 658);
            this.gaucheSplitContainer.SplitterDistance = 380;
            this.gaucheSplitContainer.TabIndex = 0;
            // 
            // trajetTV
            // 
            this.trajetTV.AllowDrop = true;
            this.trajetTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trajetTV.Location = new System.Drawing.Point(0, 0);
            this.trajetTV.Name = "trajetTV";
            this.trajetTV.Size = new System.Drawing.Size(376, 380);
            this.trajetTV.TabIndex = 0;
            this.trajetTV.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trajetTV_ItemDrag);
            this.trajetTV.DragDrop += new System.Windows.Forms.DragEventHandler(this.trajetTV_DragDrop);
            this.trajetTV.DragOver += new System.Windows.Forms.DragEventHandler(this.trajetTV_DragOver);
            this.trajetTV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trajetTV_KeyDown);
            // 
            // siteLB
            // 
            this.siteLB.AllowDrop = true;
            this.siteLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteLB.FormattingEnabled = true;
            this.siteLB.ItemHeight = 16;
            this.siteLB.Location = new System.Drawing.Point(0, 0);
            this.siteLB.Name = "siteLB";
            this.siteLB.Size = new System.Drawing.Size(376, 274);
            this.siteLB.TabIndex = 0;
            this.siteLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.siteLB_KeyDown);
            this.siteLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.siteLB_MouseDoubleClick);
            // 
            // gmapWinPrincipale
            // 
            this.gmapWinPrincipale.Bearing = 0F;
            this.gmapWinPrincipale.CanDragMap = true;
            this.gmapWinPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapWinPrincipale.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapWinPrincipale.GrayScaleMode = false;
            this.gmapWinPrincipale.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapWinPrincipale.LevelsKeepInMemmory = 5;
            this.gmapWinPrincipale.Location = new System.Drawing.Point(0, 0);
            this.gmapWinPrincipale.MarkersEnabled = true;
            this.gmapWinPrincipale.MaxZoom = 18;
            this.gmapWinPrincipale.MinZoom = 0;
            this.gmapWinPrincipale.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmapWinPrincipale.Name = "gmapWinPrincipale";
            this.gmapWinPrincipale.NegativeMode = false;
            this.gmapWinPrincipale.PolygonsEnabled = true;
            this.gmapWinPrincipale.RetryLoadTile = 0;
            this.gmapWinPrincipale.RoutesEnabled = true;
            this.gmapWinPrincipale.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapWinPrincipale.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapWinPrincipale.ShowTileGridLines = false;
            this.gmapWinPrincipale.Size = new System.Drawing.Size(748, 658);
            this.gmapWinPrincipale.TabIndex = 0;
            this.gmapWinPrincipale.Zoom = 10D;
            this.gmapWinPrincipale.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmapWinPrincipale_OnMarkerClick);
            this.gmapWinPrincipale.Load += new System.EventHandler(this.gmapWinPrincipale_Load);
            this.gmapWinPrincipale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmapWinPrincipale_MouseClick);
            // 
            // formPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 685);
            this.Controls.Add(this.splitContainerPrincipale);
            this.Controls.Add(this.principaleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipale_FormClosing);
            this.principaleTB.ResumeLayout(false);
            this.principaleTB.PerformLayout();
            this.splitContainerPrincipale.Panel1.ResumeLayout(false);
            this.splitContainerPrincipale.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipale)).EndInit();
            this.splitContainerPrincipale.ResumeLayout(false);
            this.gaucheSplitContainer.Panel1.ResumeLayout(false);
            this.gaucheSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaucheSplitContainer)).EndInit();
            this.gaucheSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip principaleTB;
        private System.Windows.Forms.SplitContainer splitContainerPrincipale;
        private System.Windows.Forms.SplitContainer gaucheSplitContainer;
        private System.Windows.Forms.ListBox siteLB;
        private System.Windows.Forms.ToolStripDropDownButton menuDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem FichierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauVoyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChargerVoyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnregistrerVoyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreGestionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AproposMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton gestionSiteDropDown;
        private System.Windows.Forms.ToolStripMenuItem AjoutSiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enreSiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChargerSiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifSiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupSiteMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton GestionTrajetDropDown;
        private System.Windows.Forms.ToolStripMenuItem AjoutTrajetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifTrajetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupTrajetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReordonnerTrajetMenuItem;
        private GMap.NET.WindowsForms.GMapControl gmapWinPrincipale;
        private System.Windows.Forms.ToolStripButton FinirButton;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog voyageOpen;
        public System.Windows.Forms.TreeView trajetTV;
    }
}

