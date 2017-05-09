using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripManagerObjects
{
    public abstract class TripObj
    {
        #region Variables
        private int _id;
        private String _description;
        #endregion
        #region Proprietes
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        #endregion
        #region Constructeur
        #endregion
        #region Methodes
        #endregion
    }
}
