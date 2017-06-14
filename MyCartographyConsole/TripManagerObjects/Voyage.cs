using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TripManagerObjects
{
    [Serializable]
    public class Voyage: TripObj
    {
        #region Variables
        [XmlAttribute]
        private string _libelle;
        [XmlAttribute]
        private DateTime _dateDebut;
        [XmlAttribute]
        private DateTime _dateFin;
        [XmlAttribute]
        private List<Trajet> _lTrajet;
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
        public List<Trajet> LTrajet { get { return _lTrajet; } set { _lTrajet = value; } }
        #endregion
        #region Constructeur
        public Voyage(): base()
        {
           LTrajet = new List<Trajet>();
        }
        public Voyage(string pDescription, string pLibelle, DateTime pDateDebut, DateTime pDateFin) : base()
        {
            Description = pDescription;
            Libelle = pLibelle;
            DateDebut = pDateDebut;
            DateFin = pDateFin;
            LTrajet = new List<Trajet>();
        }
        #endregion
        #region Methodes

        public override string ToString()
        {
            return Id + "  "+ Libelle + ", " + DateDebut.ToString("dd/MM/yy") + " -> " + DateFin.ToString("dd/MM/yy");
        }
        #endregion
    }
}
