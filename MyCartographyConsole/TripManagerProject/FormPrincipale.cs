using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using TripManagerObjects;

namespace TripManagerProject
{
    public partial class formPrincipale : Form
    {
        public static TripParamManager tripParam;
        public static BindingList<Site> lSite = new BindingList<Site>();
        public static Voyage VoyageEnCours;
        public static Trajet tmpTrajet;
        public static Site tmpSite;

        public const int MODENORMAL = 0;
        public const int AJOUTSITE = 1;
        public const int AJOUTTRAJET = 2;
        public const int AJOUTVOYAGE = 3;
        public static int mode = 0;

        public static debugForm df;
        public static string localite = "Liège";

        public formPrincipale()
        {
            try
            {
                InitializeComponent();
                //gmapWinPrincipale.
                tripParam = new TripParamManager();
                siteLB.DataSource = lSite;
                MAJTreeView();
                df = new debugForm();
                df.Visible = true;
                SiteLoad();
                MAJgmap();
            }
            catch(Exception e)
            {
                formPrincipale.writeDebug(e.Message);
            }
        }        

        private void gmapWinPrincipale_Load(object sender, EventArgs e)
        {
            gmapWinPrincipale.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapWinPrincipale.SetPositionByKeywords(localite);
            gmapWinPrincipale.ShowCenter = false;
        }

        private void formPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            SiteSave();
            VoyageSave();
            tripParam.SaveRegistryParameter();
        }

        private void AjoutSiteMenuItem_Click(object sender, EventArgs e)
        {
            FinirButton.Visible = true;
            mode = AJOUTSITE;
            tmpSite = new Site();
            MAJTreeView();
            MAJgmap();
        }

        private void AjoutTrajetMenuItem_Click(object sender, EventArgs e)
        {
            if (formPrincipale.VoyageEnCours != null)
            {
                mode = AJOUTTRAJET;
                tmpTrajet = new Trajet();
                FinirButton.Visible = true;  
                MAJTreeView();
                MAJgmap();
            }
        }

        private void nouveauVoyMenuItem_Click(object sender, EventArgs e)
        {
            VoyageSave();
            CreateVoyageWindow newVoyageWin = new CreateVoyageWindow();
            //newVoyageWin.Show();
            newVoyageWin.ShowDialog();
            formPrincipale.writeDebug("Nouveau voyage");
            MAJTreeView();
            MAJgmap();
        }

        private void gmapWinPrincipale_MouseClick(object sender, MouseEventArgs e)
        {
            switch(mode)
            {
                case MODENORMAL:
                    break;
                case AJOUTTRAJET:
                    tmpTrajet.Polyline.LPOI.Add(new POI(gmapWinPrincipale.FromLocalToLatLng(e.X, e.Y).Lat, gmapWinPrincipale.FromLocalToLatLng(e.X, e.Y).Lng));
                    break;
                case AJOUTSITE:
                    tmpSite.Position.Lat = gmapWinPrincipale.FromLocalToLatLng(e.X, e.Y).Lat;
                    tmpSite.Position.Longitude = gmapWinPrincipale.FromLocalToLatLng(e.X, e.Y).Lng;
                    break;
            }
            MAJTreeView();
            MAJgmap();
        }

        private void FinirButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case AJOUTTRAJET:
                        CreateTrajetWindow newTrajetWin = new CreateTrajetWindow();
                        newTrajetWin.ShowDialog();
                        break;
                    case AJOUTSITE:
                        CreateSiteWindow newSiteWin = new CreateSiteWindow();
                        newSiteWin.ShowDialog();
                        break;
                }
                mode = MODENORMAL;
                FinirButton.Visible = false;
                SiteSave();
                MAJgmap();
                MAJTreeView();
            }
            catch (Exception ex)
            {
                formPrincipale.writeDebug("finirButton : " + ex.Message);
            }
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListForm lf = new ListForm();
            lf.ShowDialog();
        }

        private void ModifTrajetMenuItem_Click(object sender, EventArgs e)
        {
            if(trajetTV.SelectedNode.Tag is Trajet)
            {
                CreateTrajetWindow ctw = new CreateTrajetWindow(trajetTV.SelectedNode.Tag as Trajet);
                ctw.ShowDialog();
                MAJTreeView();
                MAJgmap();
            }
        }

        private void SupTrajetMenuItem_Click(object sender, EventArgs e)
        {
            if (trajetTV.SelectedNode.Tag is Trajet)
            {
                VoyageEnCours.LTrajet.Remove(trajetTV.SelectedNode.Tag as Trajet);
                formPrincipale.writeDebug("Suppresion Trajet");
                MAJTreeView();
                MAJgmap();
            }
        }

        private void ReordonnerTrajetMenuItem_Click(object sender, EventArgs e)
        {
            VoyageEnCours.LTrajet.Sort();
        }

        private void enreSiteMenuItem_Click(object sender, EventArgs e)
        {
            SiteSave();
        }

        private void ChargerSiteMenuItem_Click(object sender, EventArgs e)
        {
            lSite.Clear();
            SiteLoad();
            MAJgmap();
        }

        private void ModifSiteMenuItem_Click(object sender, EventArgs e)
        {
            CreateSiteWindow csw = new CreateSiteWindow(siteLB.SelectedItem as Site);
            csw.ShowDialog();
            MAJTreeView();
            MAJgmap();
        }

        private void SupSiteMenuItem_Click(object sender, EventArgs e)
        {
            if (siteLB.SelectedItem != null)
            {
                lSite.Remove(siteLB.SelectedItem as Site);
                formPrincipale.writeDebug("Suppression Site");
            }
            MAJTreeView();
            MAJgmap();
        }

        private void ChargerVoyMenuItem_Click(object sender, EventArgs e)
        {
            string filepath="";
            try
            {
                voyageOpen.InitialDirectory = tripParam.PathName + @"\Voyages";
                voyageOpen.ShowDialog();
                filepath = voyageOpen.FileName;
                XmlSerializer xmlformat = new XmlSerializer(typeof(Voyage));
                Stream st = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.None);

                VoyageEnCours = (xmlformat.Deserialize(st) as Voyage);
                formPrincipale.writeDebug("Voyage Charger");
                st.Close();
            }
            catch(Exception ex)
            {
                writeDebug("ChargerVoyageMenu : "+ex.Message +"   ---   " + tripParam.PathName + @"\Voyages\" + filepath);
            }
            MAJTreeView();
            MAJgmap();
        }

        private void EnregistrerVoyMenuItem_Click(object sender, EventArgs e)
        {
            VoyageSave();
        }

        private void AproposMenuItem_Click(object sender, EventArgs e)
        {
            AProposForm apf = new AProposForm();
            apf.ShowDialog();
        }

        public void MAJTreeView()
        {
            try
            {
                if (formPrincipale.VoyageEnCours != null)
                {
                    trajetTV.Nodes.Clear();
                    TreeNode mainnode = trajetTV.Nodes.Add("" + VoyageEnCours.Libelle + " du " + VoyageEnCours.DateDebut.ToString("dd/MM/yy") + " au " + VoyageEnCours.DateFin.ToString("dd/MM/yy"));
                    foreach (Trajet lt in VoyageEnCours.LTrajet)
                    {
                        TreeNode currentnode = mainnode.Nodes.Add(lt.ToString());
                        currentnode.Tag = lt;
                        foreach (Site st in lt.LSite)
                        {
                            TreeNode tn = currentnode.Nodes.Add(st.ToString());
                            tn.Tag = st;
                        }
                    }
                    trajetTV.ExpandAll();
                }
            }
            catch(Exception ex)
            {
                formPrincipale.writeDebug(" : " + ex.Message);
            }
}

        public void MAJgmap()
        {
            try
            {
                int i = 0;
                gmapWinPrincipale.Overlays.Clear();
                GMapOverlay markersOverlaySite = new GMapOverlay("Site");
                gmapWinPrincipale.Overlays.Add(markersOverlaySite);
                GMapOverlay markersOverlayRoute = new GMapOverlay("Route");
                gmapWinPrincipale.Overlays.Add(markersOverlayRoute);
                foreach (Site st in lSite)
                {
                    GMapMarker gMarker;
                    if (st.Image == null)
                        gMarker = new GMarkerGoogle(new PointLatLng(st.Position.Lat, st.Position.Longitude), tripParam.Couleur);
                    else
                    {
                        Bitmap tmpBt = new Bitmap(st.Image);
                        Bitmap bt = new Bitmap(tmpBt, new Size(50,50));
                        
                        gMarker = new GMarkerGoogle(new PointLatLng(st.Position.Lat, st.Position.Longitude), bt);
                    }
                    gMarker.IsVisible = true;

                    markersOverlaySite.Markers.Add(gMarker);
                }
                if (VoyageEnCours != null)
                {
                    foreach (Trajet ts in VoyageEnCours.LTrajet)
                    {
                        i++;
                        List<PointLatLng> tmpPoint = new List<PointLatLng>();
                        foreach (POI p in ts.Polyline.LPOI)
                        {
                            tmpPoint.Add(new PointLatLng(p.Lat, p.Longitude));
                        }
                        GMapRoute groute = new GMapRoute(tmpPoint, ts.Description);
                        groute.IsVisible = true;
                        markersOverlayRoute.Routes.Add(groute);
                    }
                }
            }
            catch(Exception ex)
            {
                formPrincipale.writeDebug(" : " + ex.Message);
            }
        }

        public void SiteSave()
        {
            try
            {
                XmlSerializer xmlformat = new XmlSerializer(typeof(Site));
                DirectoryInfo di = new DirectoryInfo(tripParam.PathName + @"\Sites");
                foreach(FileInfo fi in di.GetFiles())
                {
                    fi.Delete();
                }
                foreach (Site st in lSite)
                {
                    //writeDebug(tripParam.PathName + @"\Sites\" + st.Position.Description);
                    Stream fStream = new FileStream(tripParam.PathName + @"\Sites\"+st.Position.Description+".xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    xmlformat.Serialize(fStream, st);
                    fStream.Close();
                }
                formPrincipale.writeDebug("Sauvegarde Site");
            }
            catch (Exception e)
            {
                formPrincipale.writeDebug("SiteSave : " +e.Message);
            }
        }

        public void SiteLoad()
        {
            try
            {
                XmlSerializer xmlformat = new XmlSerializer(typeof(Site));
                DirectoryInfo di = new DirectoryInfo(tripParam.PathName + @"\Sites");
                
                foreach(FileInfo fi in di.GetFiles() )
                {
                    Stream fstream = new FileStream(tripParam.PathName + @"\Sites\" + fi.Name, FileMode.Open, FileAccess.Read, FileShare.None);
                    lSite.Add((xmlformat.Deserialize(fstream) as Site));
                    fstream.Close();
                }
                formPrincipale.writeDebug("Chargement Site");
                MAJgmap();
            }
            catch (Exception e)
            {
                formPrincipale.writeDebug("site load : " + e.Message);
            }
        }

        static public void VoyageSave()
        {
            try
            {
                if (VoyageEnCours != null)
                {
                    XmlSerializer xmlformat = new XmlSerializer(typeof(Voyage));

                    //writeDebug(tripParam.PathName + @"\Voyages\" + VoyageEnCours.Libelle);
                    Stream fStream = new FileStream(tripParam.PathName + @"\Voyages\" + VoyageEnCours.Libelle + ".xml", FileMode.Create, FileAccess.Write, FileShare.None);
                    xmlformat.Serialize(fStream, VoyageEnCours);
                    fStream.Close();
                }
                formPrincipale.writeDebug("Sauvegarde Voyage");
            }
            catch (Exception e)
            {
                formPrincipale.writeDebug("Save voyage : "+e.Message);
            }
        }

        static public void writeDebug(string s)
        {
            if(df.IsDisposed == false)
                df.debugTextBox.AppendText(s+"\n");
        }

        private void trajetTV_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if ((e.Item as TreeNode).Tag is Site)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void trajetTV_DragOver(object sender, DragEventArgs e)
        {
           if(e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode tns = e.Data.GetData(typeof(TreeNode)) as TreeNode;
                TreeNode tnd = trajetTV.GetNodeAt(trajetTV.PointToClient(new Point(e.X, e.Y))) as TreeNode;
                if(tns.Tag is Site && tnd != null && tnd.Tag is Trajet)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void trajetTV_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode tns = e.Data.GetData(typeof(TreeNode)) as TreeNode;
                TreeNode tnd = trajetTV.GetNodeAt(trajetTV.PointToClient(new Point(e.X, e.Y))) as TreeNode;
                if(tnd.Tag is Trajet && tns.Parent != tnd && (tnd.Tag as Trajet).LSite.Contains(tns.Tag as Site) == false)
                {
                    Site mtmp = (Site)tns.Tag;
                    TreeNode newone = tnd.Nodes.Add(mtmp.ToString());
                    (tnd.Tag as Trajet).LSite.Add(tns.Tag as Site);
                    newone.Tag = mtmp;
                    tns.Remove();
                    tnd.ExpandAll();
                }
            }
            MAJTreeView();
        }
                   
        private void siteLB_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                DoDragDrop(siteLB.SelectedItem, DragDropEffects.Move);
            }
            if(e.Button == MouseButtons.Right)
            {
                AddSiteMarker asm = new AddSiteMarker(this, siteLB.SelectedItem as Site );
                asm.ShowDialog(); 
                //siteLB.PointToClient(new Point(e.X, e.Y))
            }
            MAJTreeView();
        }  

        private void gmapWinPrincipale_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (VoyageEnCours != null)
            {
                Site site = null;
                if (e.Button == MouseButtons.Right)
                {
                    foreach (Site s in lSite)
                    {
                        writeDebug("" + s);
                        if (s.Position.Lat == item.Position.Lat && s.Position.Longitude == item.Position.Lng)
                        {
                            site = s;
                            writeDebug("Trouver");
                        }
                    }
                    AddSiteMarker asm = new AddSiteMarker(this, site);
                    asm.ShowDialog();
                }
                MAJTreeView();
            }
        } 

        private void trajetTV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TreeNode tn = trajetTV.SelectedNode;
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        if (tn.Tag is Trajet)
                        {                                 
                            (tn.Parent.Tag as Voyage).LTrajet.Remove(tn.Tag as Trajet);    
                        }
                        if (tn.Tag is Site)
                        {                             
                            (tn.Parent.Tag as Trajet).LSite.Remove(tn.Tag as Site); 
                        }
                        MAJTreeView();
                        break;
                }
            }
            catch(Exception ex)
            {
                writeDebug("key down : " + ex.Message);
            }
        }

        private void parametreGestionMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                ParamForm pf = new ParamForm();
                pf.ShowDialog();
                tripParam.SaveRegistryParameter();
                gmapWinPrincipale.SetPositionByKeywords(localite);
                MAJgmap();
            }
            catch (Exception ex)
            {
                formPrincipale.writeDebug(" : " + ex.Message);
            }
        }

        private void siteLB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (siteLB.SelectedItem != null)
                {
                    lSite.Remove(siteLB.SelectedItem as Site);
                }
                MAJgmap();
            }
            catch (Exception ex)
            {
                writeDebug("key down : " + ex.Message);
            }
        }

        private void siteLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(siteLB.SelectedItem != null && siteLB.SelectedItem is Site)
            {
                CreateSiteWindow csw = new CreateSiteWindow(siteLB.SelectedItem as Site);
                csw.ShowDialog();
            }
            MAJgmap();
            MAJTreeView();
        }
    }
}
