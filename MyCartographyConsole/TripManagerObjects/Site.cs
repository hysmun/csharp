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
    public class Site: TripObj, INotifyPropertyChanged
    {
        #region Variables
        [XmlAttribute]
        private POI _position;
        [XmlAttribute]
        private string _image;
        //photo
        public event PropertyChangedEventHandler PropertyChanged;
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
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public string Image { get { return _image; } set { _image = value; } } 
        #endregion
        #region Constructeur
        public Site() :base()
        {
            Position = new POI();
        }
        public Site(string pDescription, string pDescriptionLongue, double pLat, double pLong): base()
        {
            Position = new POI();
            Description = pDescriptionLongue;
            Position.Lat = pLat;
            Position.Longitude = pLong;
            Position.Description = pDescription;
        }
        #endregion
        #region Methodes
        public override string ToString()
        {
            return Id + " " + Position.Description + "   " + Position.Lat.ToString("N5") + " ,  " + Position.Longitude.ToString("N5");
        }
        #endregion
    }
}
