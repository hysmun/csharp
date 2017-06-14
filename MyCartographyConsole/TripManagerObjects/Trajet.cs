using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TripManagerObjects
{
    [Serializable]
    public class Trajet : TripObj, IComparable
    {
        #region Variable
        [XmlAttribute]
        private DateTime _date;
        [XmlAttribute]
        private Polyline _polyline;
        [XmlAttribute]
        private BindingList<Site> _lSite;
        #endregion
        #region Proprietes
        public BindingList<Site> LSite
        {
            get
            {
                return _lSite;
            }

            set
            {
                _lSite = value;
            }
        }

        public Polyline Polyline
        {
            get
            {
                return _polyline;
            }

            set
            {
                _polyline = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }
        #endregion
        #region Constructeur
        public Trajet()
        {
            Polyline = new Polyline();
            LSite = new BindingList<Site>();
        }
        #endregion
        #region Methodes
        public override string ToString()
        {
            return Id + " " + Description + " " + Date.Day + "/" + Date.Month;
        }
        public int CompareTo(Trajet t)
        {
            return Date.CompareTo(t.Date);
        }
        public int CompareTo(Object t)
        {
            return this.CompareTo(t as Trajet);
        } 
        #endregion
    }
}
