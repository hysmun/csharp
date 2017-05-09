using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripManagerObjects
{
    class Voyage: TripObj
    {
        #region Variables
        private string _libelle;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        #endregion
        #region Proprietes
        public DateTime DateFin
        {
            get
            {
                return _dateFin;
            }

            set
            {
                _dateFin = value;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return _dateDebut;
            }

            set
            {
                _dateDebut = value;
            }
        }

        public string Libelle
        {
            get
            {
                return _libelle;
            }

            set
            {
                _libelle = value;
            }
        }
        #endregion
        #region Constructeur
        #endregion
        #region Methodes
        #endregion
    }
}
