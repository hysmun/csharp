using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripManagerObjects
{
    public class Site: TripObj
    {
        #region Variables
        private POI _position;
        //photo
        #endregion
        #region Proprietes
        public POI Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }
        #endregion
        #region Constructeur
        #endregion
        #region Methodes
        #endregion
    }
}
