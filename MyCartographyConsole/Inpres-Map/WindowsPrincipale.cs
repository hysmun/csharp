﻿using System;
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
        #region Variable 
        //variable pour l'app
        static public double precisionGlobal = 50.00;
        static public double largeurGlobal = 2.00;
        static public Color couleurGlobal = Color.Blue;

        //variable temporaire pour creation de Polyline et Polygon
        Polyline tmpCreationPolyline=null;
        Polygon tmpCreationPolygon=null;

        //BidingList
        BindingList<POI> listePOI = new BindingList<POI>();
        BindingList<Polyline> listePolyline = new BindingList<Polyline>();
        BindingList<Polygon> listePolygon = new BindingList<Polygon>();

        //evenement
        #endregion

        public WindowPrincipale()
        {
            InitializeComponent();

            // ListeBox
            POILB.ForeColor = couleurGlobal;
            PolylineLB.ForeColor = couleurGlobal;
            PolygonLB.ForeColor = couleurGlobal;
            POILB.DataSource = listePOI;
            PolylineLB.DataSource = listePolyline;
            PolygonLB.DataSource = listePolygon;

            //
            CreationModeItem.Checked = true;
        }

        private void ClickOnButtonColor(object sender, EventArgs e)
        {
            ColorDialog ColorDial = new ColorDialog();
            ColorDial.AllowFullOpen = false;
            ColorDial.ShowHelp = true;
            ColorDial.Color = ColorButtonToolStrip.BackColor;
            if (ColorDial.ShowDialog() == DialogResult.OK)
                ColorButtonToolStrip.BackColor = ColorDial.Color;
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            string aboutText = "Application Crée par Antoine Brajkovic, 2221\nFait en 2017 !\n";
            MessageBox.Show(aboutText);

        }

        #region event boutton mode
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
        #endregion

        #region eventBouton POI Polyline Polygon
        private void POIButton_Click(object sender, EventArgs e)
        {
            if(POIButton.Checked == false)
            {
                DescriptionTB.Text = "";
                tmpCreationPolyline = null;
                tmpCreationPolygon = null;
                FiniToolStripButton.Visible = false;
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
                DescriptionTB.Text = "";
                tmpCreationPolyline = null;
                tmpCreationPolygon = null;
                FiniToolStripButton.Visible = true;
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
                DescriptionTB.Text = "";
                tmpCreationPolyline = null;
                tmpCreationPolygon = null;
                FiniToolStripButton.Visible = true;
                PolygonButton.Checked = true;
                if (POIButton.Checked == true)
                    POIButton.Checked = false;
                if (PolylineButton.Checked == true)
                    PolylineButton.Checked = false;
            }
        }
        #endregion

        private void Draw(Graphics g)
        {
            try
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
            catch(Exception e)
            {
                string errorText = "Erreur dessin !!!\n"+e.Message;
                MessageBox.Show(errorText);
            }
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
                    DescriptionTB.Text = "";
                }
                #endregion

                #region Nouveau Polyline
                if (PolylineButton.Checked == true)
                {
                    // nouveau Polyline
                    if (tmpCreationPolyline == null)
                    {
                        tmpCreationPolyline = new Polyline(DescriptionTB.Text, ColorButtonToolStrip.BackColor, largeurGlobal);
                    }
                    bool poiProche = false;
                    int i;
                    for (i = 0; i < listePOI.Count && poiProche == false; i++)
                    {
                        if (listePOI[i].IsPointClose(e.X, e.Y, precisionGlobal) == true)
                        {
                            poiProche = true;
                        }
                    }
                    if (poiProche == true)
                    {
                        //on rajoute le point a l'indice i -1
                        tmpCreationPolyline.LPOI.Add(listePOI[i - 1]);
                    }
                    else
                    {
                        //on cree un nouveau point
                        POI newPOI = new POI(e.X, e.Y, DescriptionTB.Text, ColorButtonToolStrip.BackColor, largeurGlobal);
                        tmpCreationPolyline.LPOI.Add(newPOI);
                        listePOI.Add(newPOI);
                    }
                }
                #endregion

                #region Nouveau Polygon
                if (PolygonButton.Checked == true)
                {
                    // nouveau Polygon
                    if (tmpCreationPolygon == null)
                    {
                        tmpCreationPolygon = new Polygon(DescriptionTB.Text, ColorButtonToolStrip.BackColor, largeurGlobal);
                    }
                    bool polylineProche = false;
                    int i;
                    for (i = 0; i < listePolyline.Count && polylineProche == false; i++)
                    {
                        if (listePolyline[i].IsPointClose(e.X, e.Y, precisionGlobal) == true)
                        {
                            polylineProche = true;
                        }
                    }
                    if (polylineProche == true)
                    {
                        //on rajoute la Polyline l'indice i-1
                        bool add = true;
                        foreach(Polyline tmpPolyline in tmpCreationPolygon.LPolyline)
                        {
                            if(tmpPolyline.Id == listePolyline[i - 1].Id)
                            {
                                add = false;
                            }
                        }
                        if(add == true)
                            tmpCreationPolygon.LPolyline.Add(listePolyline[i - 1]);
                    }
                    else
                    {
                        //on cree une nouvelle polyline
                    }
                    #endregion
                }
                #endregion 
            }
            MainPictureBox.Invalidate();
        }

        private void optionToolStripMenu_Click(object sender, EventArgs e)
        {
            OptionFormWindow optionForm = new OptionFormWindow();
            optionForm.Tag = this;
            optionForm.Show(this);
        }

        private void FiniToolStripButton_Click(object sender, EventArgs e)
        {
            if (PolylineButton.Checked == true && tmpCreationPolyline != null)
            {
                //on fini la polyline
                listePolyline.Add(tmpCreationPolyline);
                tmpCreationPolyline = null;
                DescriptionTB.Text = "";
            }
            if (PolygonButton.Checked == true && tmpCreationPolygon != null)
            {
                //on fini la polygon
                listePolygon.Add(tmpCreationPolygon);
                tmpCreationPolygon = null;
                DescriptionTB.Text = "";
            }
            MainPictureBox.Invalidate();
        }

        private void POILB_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = POILB.SelectedItem;
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            MainPictureBox.Invalidate();
        }

        private void PolylineLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = PolylineLB.SelectedItem;
        }

        private void PolygonLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = PolygonLB.SelectedItem;
        }
    }
}
