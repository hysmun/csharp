using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCartographyObjects;

namespace Inpres_Map
{
    public partial class WindowPrincipale : Form
    {
        //variable pour l'app
        double precisionGlobal = 5.00;
        double largeurGlobal = 2.00;
        Color couleurGlobal = Color.Blue;

        //variable temporaire pour creation de Polyline et Polygon
        Polyline tmpCreationPolyline;
        Polygon tmpCreationPolygon;

        //BidingList
        BindingList<POI> listePOI = new BindingList<POI>();
        BindingList<Polyline> listePolyline = new BindingList<Polyline>();
        BindingList<Polygon> listePolygon = new BindingList<Polygon>();

        public WindowPrincipale()
        {
            InitializeComponent();
            CreationModeItem.Checked = false;
        }

        private void ClickOnButtonColor(object sender, EventArgs e)
        {
            ColorDialog ColorDial = new ColorDialog();
            ColorDial.AllowFullOpen = false;
            ColorDialog.ShowHelp = true;
            ColorDialog.Color = ColorButtonToolStrip.BackColor;
            if (ColorDial.ShowDialog() == DialogResult.OK)
                ColorButtonToolStrip.BackColor = ColorDial.Color;
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            string aboutText = "Application Crée par Antoine Brajkovic, 2221\nFait en 2017 !\n";
            MessageBox.Show(aboutText);

        }

        private void CreationModeItem_Click(object sender, EventArgs e)
        {
            if(CreationModeItem.Checked == false)
            {
                CreationModeItem.Checked = true;
                if (SelectionModeItem.Checked == true)
                    SelectionModeItem.Checked = false;
                if (DeplacementModeItem.Checked == true)
                    DeplacementModeItem.Checked = false;
            }
        }

        private void SelectionModeItem_Click(object sender, EventArgs e)
        {
            if (SelectionModeItem.Checked == false)
            {
                SelectionModeItem.Checked = true;
                if (CreationModeItem.Checked == true)
                    CreationModeItem.Checked = false;
                if (DeplacementModeItem.Checked == true)
                    DeplacementModeItem.Checked = false;
            }
        }

        private void DeplacementModeItem_Click(object sender, EventArgs e)
        {
            if (DeplacementModeItem.Checked == false)
            {
                DeplacementModeItem.Checked = true;
                if (SelectionModeItem.Checked == true)
                    SelectionModeItem.Checked = false;
                if (CreationModeItem.Checked == true)
                    CreationModeItem.Checked = false;
            }
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void POIButton_Click(object sender, EventArgs e)
        {
            if(POIButton.Checked == false)
            {
                POIButton.Checked = true;
                if (PolylineButton.Checked == true)
                    PolylineButton.Checked = false;
                if (PolygonButton.Checked == true)
                    PolygonButton.Checked = false;
            }
        }

        private void PolylineButton_Click(object sender, EventArgs e)
        {
            if (PolylineButton.Checked == false)
            {
                PolylineButton.Checked = true;
                if (POIButton.Checked == true)
                    POIButton.Checked = false;
                if (PolygonButton.Checked == true)
                    PolygonButton.Checked = false;
            }
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            if (PolygonButton.Checked == false)
            {
                PolygonButton.Checked = true;
                if (POIButton.Checked == true)
                    POIButton.Checked = false;
                if (PolylineButton.Checked == true)
                    PolylineButton.Checked = false;
            }
        }

        private void Draw(Graphics g)
        {
            #region boucle dessin polygon
            foreach (Polygon tmp in listePolygon)
            {
                tmp.Draw(g);
            }
            #endregion

            #region boucle dessin polyline
            foreach (Polyline tmp in listePolyline)
            {
                tmp.Draw(g);
            }
            #endregion

            #region boucle dessin POI
            foreach (POI tmp in listePOI)
            {
                tmp.Draw(g);
            }
            #endregion
        }

        private void MainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            #region Creation Nouveau item
            if (CreationModeItem.Checked == true)
            {
                #region Nouveau POI
                if (POIButton.Checked == true)
                {
                    // nouveau POI
                    POI newPOI = new POI(e.X, e.Y, DescriptionTB.Text, ColorButtonToolStrip.BackColor, largeurGlobal);
                    listePOI.Add(newPOI);
                }
                #endregion

                #region Nouveau Polyline
                if (PolylineButton.Checked == true)
                {
                    // nouveau Polyline
                    int poiProche = 0;
                    foreach(POI tPOI in listePOI)
                    {
                        if(tPOI.IsPointClose(e.X, e.Y, precisionGlobal))
                        {

                        }
                    }
                }
                #endregion

                #region Nouveau Polygon
                if (PolygonButton.Checked == true)
                {
                    // nouveau Polygon
                    Polygon newPolygon = new Polygon();
                    listePolygon.Add(newPolygon);
                }
                #endregion
            }
            #endregion

            MainPictureBox.Invalidate();
        }
    }
}
