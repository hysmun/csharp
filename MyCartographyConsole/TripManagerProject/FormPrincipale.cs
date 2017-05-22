using GMap.NET;
using GMap.NET.WindowsForms;
using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TripManagerObjects;

namespace TripManagerProject
{
    public partial class formPrincipale : Form
    {
        public static TripParamManager tripParam;
        public static BindingList<Site> lSite = new BindingList<Site>();
        public static BindingList<Trajet> lTrajet = new BindingList<Trajet>();
        public static BindingList<Voyage> lVoyage = new BindingList<Voyage>();
        public static Voyage tmpVoyage;
        public static Trajet tmpTrajet;
        public static Site tmpSite;

        public const int MODENORMAL = 0;
        public const int AJOUTSITE = 1;
        public const int AJOUTTRAJET = 2;
        public static int mode = 0;

        public formPrincipale()
        {
            try
            {
                InitializeComponent();
                //gmapWinPrincipale.
                tripParam = new TripParamManager();
                siteLB.DataSource = lSite;
                
            }
            catch(Exception e)
            {
                MessageBox.Show("init Fenetre principale\n" + e.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gmapWinPrincipale_Load(object sender, EventArgs e)
        {
            gmapWinPrincipale.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapWinPrincipale.SetPositionByKeywords("Liege");
            gmapWinPrincipale.ShowCenter = false;
        }

        private void formPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            tripParam.SaveRegistryParameter();
        }

        private void AjoutSiteMenuItem_Click(object sender, EventArgs e)
        {
            CreateSiteWindow newSiteWin = new CreateSiteWindow();
            newSiteWin.ShowDialog();
        }

        private void AjoutTrajetMenuItem_Click(object sender, EventArgs e)
        {
            mode = AJOUTTRAJET;
            tmpTrajet = new Trajet();
            FinirButton.Visible = true;
        }

        private void nouveauVoyMenuItem_Click(object sender, EventArgs e)
        {
            CreateVoyageWindow newVoyageWin = new CreateVoyageWindow();
            //newVoyageWin.Show();
            newVoyageWin.ShowDialog();

        }

        private void gmapWinPrincipale_MouseClick(object sender, MouseEventArgs e)
        {
            switch(mode)
            {
                case MODENORMAL:
                    break;
                case AJOUTTRAJET:
                    tmpTrajet.Polyline.LPOI.Add(new POI(e.X, e.Y));
                    break;
            }
        }

        private void FinirButton_Click(object sender, EventArgs e)
        {
            switch(mode)
            {
                case AJOUTTRAJET:
                    CreateTrajetWindow newTrajetWin = new CreateTrajetWindow();
                    newTrajetWin.ShowDialog();
                    break;
            }
        }
    }
}
