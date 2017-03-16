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
     * Créer une classe abstraite CartoObj qui décrit tout objet cartographique. Elle doit contenir :
 Un constructeur par défaut
 Une méthode abstraite Draw()
     */
    abstract public class CartoObj: INotifyPropertyChanged
    {
        #region VARIABLE MEMBRE
        protected int _id;
        protected string _description;
        protected Color _couleur;
        protected double _largeur = 1;
        static protected double _precision; // une precision pour toutes les classes Cartography 

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        [CategoryAttribute("Global Settings"),
        ReadOnlyAttribute(true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        static public double Precision
        {
            get { return _precision; }
            set { _precision = value; }
        }
        [CategoryAttribute("Global Settings")]
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }
        [CategoryAttribute("Global Settings")]
        public Color Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        [CategoryAttribute("Global Settings")]
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        #endregion //PROPRIETES

        #region CONSTRUCTEURS
        public CartoObj() { Precision = 0; }
        #endregion //CONSTRUCTEURS

        #region METHODES
        abstract public void Draw();
        #endregion //METHODES
    }
}


















