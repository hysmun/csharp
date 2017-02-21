using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtilsLib;

namespace MyCartographyObjects
{
    /*
     * POI = abréviation de Point of Interest (point d’intérêt) qui hérite de CartoObj
Créer une structure POI décrite par

 Un nom, identifiant unique noté « id » (généré automatiquement à partir d’un 
compteur « static » du nombre d’instances de chaque sorte d’objet),

 Deux coordonnées de type double « lat » et « long ». Plus tard, ces variables 
représenteront des latitudes et longitudes, raison pour laquelle 
ces variables sont déjà prévues pour,

 Deux constructeurs d’initialisation qui reçoivent deux entiers ou deux double,

 La surcharge de la méthode ToString() qui construit une chaîne de caractères 
et affiche au maximum deux décimales.
     */
    public class POI : CartoObj, IIsPointClose
    {
        #region VARIABLE MEMBRE
        private double _lat;
        private double _long;
        static private int _NBRINS = 0;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        public double Longitude
        {
            get { return _long; }
            set { _long = value; }
        }
        public int NBRINS
        {
            get { return _NBRINS; }
            set { _NBRINS = value; }
        }
        #endregion //PROPRIETES

        #region CONSTRUCTEURS
        public POI()
        {
            NextId();
        }
        public POI(int pLat, int pLong)
        {
            NextId();
            Lat = pLat;
            Longitude = pLong;
        }
        public POI(double pLat, double pLong)
        {
            NextId();
            Lat = pLat;
            Longitude = pLong;
        }
        #endregion //CONSTRUCTEURS

        #region METHODES
        override public void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return "(" + Lat.ToString("F2") + ", " + Longitude.ToString("F2") + ")";
        }
        private void NextId()
        {
            Id = NBRINS++;
        }
        public bool IsPointClose(double pLat, double pLong, double pPreci)
        {
            double Hypothenuse = MathUtils.Distance(Lat, Longitude, pLat, pLong);
            if (Hypothenuse > pPreci)
                return false;
            else
                return true;
        }
        #endregion //METHODES
    }
}


















