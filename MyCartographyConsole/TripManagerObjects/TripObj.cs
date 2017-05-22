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
        private static int NBRID =0;
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
        public TripObj()
        {
            Id = NBRID++;
        }
        #endregion
        #region Methodes
        #endregion
    }
}
