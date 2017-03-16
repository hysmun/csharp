using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtilsLib;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;

namespace MyCartographyObjects
{
    /*
     * Créer une classe Polygon qui hérite de CartoObj et décrite par
 Un nom, identifiant unique noté « id » (généré automatiquement à 
partir d’un compteur « static » du nombre d’instances de chaque sorte d’objet),
 Une collection de Polyline
 Un constructeur par défaut
 Un constructeur d’initialisation
 La surcharge de la méthode ToString()
 La redéfinition de la méthode Draw() qui affiche les informations 
concernant l’objet polygon dans la console
     */
    public class Polygon : CartoObj, IIsPointClose, IPointy, IDrawable
    {
        #region VARIABLE MEMBRE
        static private int _NBRINS = 0;
        private List<Polyline> _lPolyline;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        [BrowsableAttribute(false)]
        public int NBRINS
        {
            get { return _NBRINS; }
            set { _NBRINS = value; }
        }
        [BrowsableAttribute(false)]
        public List<Polyline> LPolyline
        {
            get { return _lPolyline; }
            set { _lPolyline = value; }
        }
        [CategoryAttribute("info"),
        BrowsableAttribute(true)]
        public int NbPoints
        {
            get
            {
                if (LPolyline.Count() < 1)
                    return 0;
                int ret = 0;
                int i = 0;
                ret = LPolyline[0].NbPoints;
                for(i = 0; i < LPolyline.Count()-1; i++)
                {
                    ret += LPolyline[i + 1].NbPoints;
                    if(LPolyline[i].LPOI[LPolyline[i].NbPoints - 1].Id == LPolyline[i+1].LPOI[0].Id)
                    {
                        ret -= 1;
                    }    
                }
                if(LPolyline.Count() > 1)
                {
                    if (LPolyline[i].LPOI[LPolyline[i].NbPoints - 1].Id == LPolyline[0].LPOI[0].Id)
                    {
                        ret -= 1;
                    }
                }
                return ret;
            }
        }
        #endregion //PROPRIETES

        #region CONSTRUCTEURS
        public Polygon()
        {
            NextId();
            LPolyline = new List<Polyline>();
        }
        public Polygon(Polyline pPolyline)
        {
            NextId();
            LPolyline = new List<Polyline>();
            LPolyline.Add(pPolyline);
        }
        public Polygon(string pDesciption, Color pCouleur, double pLargeur)
        {
            NextId();
            LPolyline = new List<Polyline>();
            Description = pDesciption;
            Couleur = pCouleur;
            Largeur = pLargeur;
        }
        #endregion //CONSTRUCTEURS

        #region METHODES
        override public void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return Description + " " + Id;
        }
        private void NextId()
        {
            Id = NBRINS++;
        }
        public bool IsPointClose(double pLat, double pLong, double pPreci)
        {
            //!!!!!!!!!!!!!!!!       A MODIFIER       !!!!!!!!!!!!!!!
            // on regarde jsute la distance entre le point et chaque polyline si une est proche la polygon est proche
            foreach (Polyline tmpPolyline in LPolyline)
            {
                if (tmpPolyline.IsPointClose(pLat, pLong, pPreci) == true)
                    return true;
            }
            return false;
        }
        public void Draw(Graphics g)
        {
            PointF[] pointArray = new PointF[NbPoints];
            int i = 0;
            foreach(Polyline tmpPolyline in LPolyline)
            {
                foreach(POI tmpPOI in tmpPolyline.LPOI)
                {
                    pointArray[i] = new PointF((float)tmpPOI.Lat, (float)tmpPOI.Longitude);
                    i++;
                }
            }
            if(pointArray.Count<PointF>() < 1)
            {
                throw new Exception("Impossible de dessiner la polyline id : "+Id+" !");
            }
            else
                g.FillPolygon(Brushes.Gray, pointArray, System.Drawing.Drawing2D.FillMode.Alternate);
        }
        #endregion //METHODES
    }
}











