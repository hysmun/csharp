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
                int ret = 0;
                ret = LPOI.Count();
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
            throw new NotImplementedException("Polyline : IsPointClose pas implémenté ! ");
            return true;
        }
        public int CompareTo(Polyline pPoly)
        {
            if (this.Id == pPoly.Id)
                return 0;
            double long1 = 0, long2 = 0, diff = 0; ;

            //calcule longueur de this
            for(int i=0; i<this.LPOI.Count()-1; i++)
            {
                long1 += MathUtils.Distance(this.LPOI[i].Lat, this.LPOI[i].Longitude, this.LPOI[i+1].Lat, this.LPOI[i+1].Longitude);
            }

            //calcule longueur de pPoly
            for (int i = 0; i<pPoly.LPOI.Count()-1; i++)
            {
                long2 += MathUtils.Distance(pPoly.LPOI[i].Lat, pPoly.LPOI[i].Longitude, pPoly.LPOI[i + 1].Lat, pPoly.LPOI[i + 1].Longitude);
            }
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
            double long1 = 0, long2 = 0, diff = 0; ;

            //calcule longueur de this
            for (int i = 0; i < this.LPOI.Count() - 1; i++)
            {
                long1 += MathUtils.Distance(this.LPOI[i].Lat, this.LPOI[i].Longitude, this.LPOI[i + 1].Lat, this.LPOI[i + 1].Longitude);
            }

            //calcule longueur de pPoly
            for (int i = 0; i < pPoly.LPOI.Count() - 1; i++)
            {
                long2 += MathUtils.Distance(pPoly.LPOI[i].Lat, pPoly.LPOI[i].Longitude, pPoly.LPOI[i + 1].Lat, pPoly.LPOI[i + 1].Longitude);
            }
            diff = long2 - long1;
            if (diff < Precision)
                return true;
            else
                return false;

        }
        #endregion //METHODES
    }
}












