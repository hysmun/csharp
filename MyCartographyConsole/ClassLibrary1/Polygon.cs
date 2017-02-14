using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Polygon : CartoObj, IIsPointClose, IPointy
    {
        #region VARIABLE MEMBRE
        static private int _NBRINS = 0;
        private List<Polyline> _lPolyline;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        public int NBRINS
        {
            get { return _NBRINS; }
            set { _NBRINS = value; }
        }
        public List<Polyline> LPolyline
        {
            get { return _lPolyline; }
            set { _lPolyline = value; }
        }
        public int NbPoints
        {
            get { return 1; }
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
        #endregion //CONSTRUCTEURS

        #region METHODES
        override public void Draw()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            string ret = "PG < ";
            foreach (Polyline tPolyline in LPolyline)
            {
                ret += tPolyline.ToString()+" ";
            }
            return ret +" >";
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
