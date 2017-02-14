using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Polyline : CartoObj, IIsPointClose, IPointy
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
            get { return 1; }
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

            return true;
        }
        #endregion //METHODES
    }
}
