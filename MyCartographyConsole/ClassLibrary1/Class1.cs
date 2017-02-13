using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyobjects
{
    abstract public class CartoObj
    {
        #region VARIABLE MEMBRE
        #endregion //VARIABLE MEMBRE
        #region PROPRIETES
        #endregion //PROPRIETES
        #region CONSTRUCTEURS
        public CartoObj() { }
        #endregion //CONSTRUCTEURS
        #region METHODES
        abstract public void Draw();
        #endregion //METHODES
    }

    public class POI : CartoObj
    {
        #region VARIABLE MEMBRE
        protected int _id;
        protected double _lat;
        protected double _long;
        #endregion //VARIABLE MEMBRE
        #region PROPRIETES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        public double Long
        {
            get { return _long; }
            set { _long = value; }
        }

        #endregion //PROPRIETES
        #region CONSTRUCTEURS
        public POI() { }
        public POI(int pLat, int pLong)
        {
            Lat = pLat;
            Long = pLong;
        }
        public POI(double pLat, double pLong)
        {
            Lat = pLat;
            Long = pLong;
        }
        #endregion //CONSTRUCTEURS
        #region METHODES
        override public void Draw()
        {

        }
        public override string ToString()
        {
            return Lat.ToString("F2") + " " + Long.ToString("F2");
        }
        #endregion //METHODES
    }

    /*
     Créer une classe Polyline qui hérite de CartoObj et décrite par
 Un nom, identifiant unique noté « id » (généré automatiquement à 
partir d’un compteur « static » du nombre d’instances de chaque sorte d’objet),

 Une collection de points d’intérêts (références d’objets POI),
 Un constructeur par défaut
 Un constructeur d’initialisation
 La surcharge de la méthode ToString()
 La redéfinition de la méthode Draw() qui affiche les informations
concernant la polyline dans la console
     */
    public class Polyline : CartoObj
    {
        #region VARIABLE MEMBRE
        protected int _id; //identifiant unique généré automatiquement  compteur « static » nombre instances de chaque sorte d’objet
        protected POI[] _tPOI;
        #endregion //VARIABLE MEMBRE
        #region PROPRIETES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public POI[] TPOI
        {
            get { return _tPOI; }
            set { _tPOI = value; }
        }
        #endregion //PROPRIETES
        #region CONSTRUCTEURS
        public Polyline()
        { }
        #endregion //CONSTRUCTEURS
        #region METHODES
        public override void Draw()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion //METHODES
    }

    public class Polygon
    {
        #region VARIABLE MEMBRE
        #endregion //VARIABLE MEMBRE
        #region PROPRIETES
        #endregion //PROPRIETES
        #region CONSTRUCTEURS
        #endregion //CONSTRUCTEURS
        #region METHODES
        #endregion //METHODES
    }
}
