using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    /*
     * Créer une classe abstraite CartoObj qui décrit tout objet cartographique. Elle doit contenir :
 Un constructeur par défaut
 Une méthode abstraite Draw()
     */
    abstract public class CartoObj
    {
        #region VARIABLE MEMBRE
        protected int _id;
        #endregion //VARIABLE MEMBRE

        #region PROPRIETES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion //PROPRIETES

        #region CONSTRUCTEURS
        public CartoObj() { }
        #endregion //CONSTRUCTEURS

        #region METHODES
        abstract public void Draw();
        #endregion //METHODES
    }
}
