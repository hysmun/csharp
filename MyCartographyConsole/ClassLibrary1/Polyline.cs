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
    public class Polyline : CartoObj, IIsPointClose, IPointy, IComparable<Polyline>, IEquatable<Polyline>, IDrawable
    {
        #region VARIABLE MEMBRE
        private List<POI> _lPOI;
        static private int _NBRINS = 0;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        [BrowsableAttribute(false)]
        public List<POI> LPOI
        {
            get { return _lPOI; }
            set { _lPOI = value; }
        }
        [BrowsableAttribute(false)]
        public int NBRINS
        {
            get { return _NBRINS; }
            set { _NBRINS = value; }
        }
        [CategoryAttribute("Info"),
        ReadOnlyAttribute(true)]
        public int NbPoints
        {
            get
            {
                return LPOI.Count();
            }
        }
        [CategoryAttribute("Info"),
        ReadOnlyAttribute(true)]
        public double Longueur
        {
            // donne la longueur de la polyline 
            // fait la somme les longueur de chaque segment 
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
        [CategoryAttribute("Info"),
        ReadOnlyAttribute(true)]
        public double BoudingBox
        {
            // donne l'aire de la boudingBox de la polyline
            get
            {
                // si 0 ou 1 point alors aire = 0
                if (LPOI.Count < 2)
                    return 0;
                // initialisation des min et max verticaux et horizontal
                double gauche = LPOI[0].Longitude;// min vertical
                double droite = LPOI[0].Longitude;// max vertical
                double haut = LPOI[0].Lat;// min horizontal
                double bas = LPOI[0].Lat;// max horizontal
                 
                // premier tour de boucle de ne sert a rien vu l'initialisation du dessus 
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
                //on a les min et max verticau et horizontal

                // on fait distance point haut-gauche et haut-droite  multiplié par distance point haut-droite et bas-droite
                return MathUtils.Distance(haut, gauche, haut, droite) * MathUtils.Distance(haut, droite, bas, droite);
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
        public Polyline(string pDesciption, Color pCouleur, double pLargeur)
        {
            NextId();
            LPOI = new List<POI>();
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
            // si 0 point alors le point n'est pas proche ! donc false
            if (LPOI.Count < 1)
                return false;
            //si 1 seul point alors on fait IsPointClose de ce POI
            if (LPOI.Count < 2)
                return LPOI[0].IsPointClose(pLat, pLong, pPreci);
            double ret = 0;
            double distanceAB, distanceAC, distanceBC;
            for(int i=0; i< LPOI.Count-1; i++)
            {
                // on construit le triangle ABC  et on calcule les 3 longueur de coté
                // A est le premier POI (i)
                // B est le POI suivant (i+1)
                // C est le point donner en paramètre
                distanceAB = MathUtils.Distance(LPOI[i].Longitude, LPOI[i].Lat, LPOI[i + 1].Longitude, LPOI[i + 1].Lat);
                distanceAC = MathUtils.Distance(LPOI[i].Longitude, LPOI[i].Lat, pLong, pLat);
                distanceBC = MathUtils.Distance(LPOI[i+1].Longitude, LPOI[i+1].Lat, pLong, pLat);

                // la formule ne marche que avec le coté AC ou BC le plus grand
                // sqrt(BC² - ((BC/(BC+AC))*AB)²)
                // BC est l'hypothenuse
                // ((BC/(BC+AC))*AB)² est la proportion de BC sur AB pour avoir la longueur du coté AB qu'il faut pour le triangle rectangle BCX
                // X etant sur le segment AB et est le point d'intersection entre la perpendiculaire a AB passant par C et AB 
                if (distanceBC > distanceAC)
                    ret = Math.Sqrt(distanceBC*distanceBC - Math.Pow((distanceBC/(distanceBC+distanceAC))*distanceAB,2));
                else
                    ret = Math.Sqrt(distanceAC*distanceAC - Math.Pow((distanceAC / (distanceBC + distanceAC)) * distanceAB, 2));
                if (ret < pPreci)
                    return true;
            }
            return false;
        }
        public int CompareTo(Polyline pPoly)
        {   
            // id les mêmes ce sont les mêmes point
            if (this.Id == pPoly.Id)
                return 0;
            // on calcule les longueur des deux polyline
            double diff = 0;

            diff = pPoly.Longueur - Longueur;
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
            // id les mêmes ce sont les mêmes point
            if (this.Id == pPoly.Id)
                return true;
            // on calcule les longueur des deux polyline
            double diff = 0; ;

            //on calcule difference entre les longueurs
            diff = pPoly.Longueur - Longueur;
            if (diff < Precision)
                return true;
            else
                return false;

        }
        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(Couleur, (float)Largeur);
            for (int i = 0; i < LPOI.Count - 1; i++)
            {
                g.DrawLine(myPen, (float)LPOI[i].Lat, (float)LPOI[i].Longitude, (float)LPOI[i + 1].Lat, (float)LPOI[i + 1].Longitude);
            }
        }
        #endregion //METHODES
    }
}












