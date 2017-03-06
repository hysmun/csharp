using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtilsLib;

namespace MyCartographyObjects
{
    /*
     Créer une classe Polyline qui hérite de CartoObj et décrite par
 Un nom, identifiant unique noté « id » (généré automatiquement 
à partir d’un compteur « static » du nombre d’instances de chaque sorte d’objet),
 Une collection de points d’intérêts (références d’objets POI),
 Un constructeur par défaut
 Un constructeur d’initialisation
 La surcharge de la méthode ToString()
 La redéfinition de la méthode Draw() qui affiche les informations 
concernant la polyline dans la console
     */
    public class Polyline : CartoObj, IIsPointClose, IPointy, IComparable<Polyline>, IEquatable<Polyline>
    {
        #region VARIABLE MEMBRE
        private List<POI> _lPOI;
        static private int _NBRINS = 0;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        public List<POI> LPOI
        {
            get { return _lPOI; }
            set { _lPOI = value; }
        }
        public int NBRINS
        {
            get { return _NBRINS; }
            set { _NBRINS = value; }
        }
        public int NbPoints
        {
            get
            {
                return LPOI.Count();
            }
        }
        public double Longueur
        {
            get
            {
                double ret = 0;
                for (int i = 0; i < LPOI.Count() - 1; i++)
                {
                    ret += MathUtils.Distance(LPOI[i].Lat, LPOI[i].Longitude, LPOI[i + 1].Lat, LPOI[i + 1].Longitude);
                }
                return ret;
            }
        }
        public double BoudingBox
        {
            get
            {
                double ret = 0;
                if (LPOI.Count < 2)
                    return 0;
                double gauche = LPOI[0].Longitude;
                double droite = LPOI[0].Longitude;
                double haut = LPOI[0].Lat;
                double bas = LPOI[0].Lat;
                foreach (POI tmpPOI in LPOI)
                {
                    if (tmpPOI.Longitude > droite)
                        droite = tmpPOI.Longitude;
                    if (tmpPOI.Longitude < gauche)
                        gauche = tmpPOI.Longitude;
                    if (tmpPOI.Lat > bas)
                        bas = tmpPOI.Lat;
                    if (tmpPOI.Lat < haut)
                        haut = tmpPOI.Lat;
                }
                ret = MathUtils.Distance(haut, gauche, haut, droite) * MathUtils.Distance(haut, droite, bas, droite);
                return ret;
            }
        }
        #endregion //PROPRIETES

        #region CONSTRUCTEURS
        public Polyline()
        {
            NextId();
            LPOI = new List<POI>();
        }
        public Polyline(POI pPOI)
        {
            NextId();
            LPOI = new List<POI>();
            LPOI.Add(pPOI);
        }
        #endregion //CONSTRUCTEURS

        #region METHODES
        override public void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            string ret = "PL{ ";
            foreach(POI tPoi in LPOI)
            {
                ret += tPoi.ToString();
            }
            return ret +" }";
        }
        private void NextId()
        {
            Id = NBRINS++;
        }
        public bool IsPointClose(double pLat, double pLong, double pPreci)
        {
            if (LPOI.Count < 1)
                return false;
            if (LPOI.Count < 2)
                return LPOI[0].IsPointClose(pLat, pLong, pPreci);
            double ret = 0, min = 0 ;
            double distanceAB, distanceAC, distanceBC;
            for(int i=0; i< LPOI.Count-1; i++)
            {
                distanceAB = MathUtils.Distance(LPOI[i].Longitude, LPOI[i].Lat, LPOI[i + 1].Longitude, LPOI[i + 1].Lat);
                distanceAC = MathUtils.Distance(LPOI[i].Longitude, LPOI[i].Lat, pLong, pLat);
                distanceBC = MathUtils.Distance(LPOI[i+1].Longitude, LPOI[i+1].Lat, pLong, pLat);
                if(distanceBC > distanceAC)
                    ret = Math.Sqrt(distanceBC*distanceBC - Math.Pow((distanceBC/(distanceBC+distanceAC))*distanceAB,2));
                else
                    ret = Math.Sqrt(distanceAC*distanceAC - Math.Pow((distanceAC / (distanceBC + distanceAC)) * distanceAB, 2));
                if (ret < pPreci)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public int CompareTo(Polyline pPoly)
        {
            if (this.Id == pPoly.Id)
                return 0;
            double long1 = this.Longueur, long2 = pPoly.Longueur, diff = 0;

            diff = long2 - long1;
            if (Math.Abs(diff) < Precision)
                return 0;
            if (diff > 0)
                return -1;
            if (diff < 0)
                return 1;
            return 0;
        }
        public bool Equals(Polyline pPoly)
        {
            if (this.Id == pPoly.Id)
                return true;
            double long1 = this.Longueur, long2 = pPoly.Longueur, diff = 0; ;

            diff = long2 - long1;
            if (diff < Precision)
                return true;
            else
                return false;

        }
        #endregion //METHODES
    }
}












