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
    public abstract class TripObj : INotifyPropertyChanged
    {
        #region Variables
        [XmlAttribute]
        private int _id;
        [XmlAttribute]
        private String _description;
        [XmlAttribute]
        private static int NBRID =0;

        public event PropertyChangedEventHandler PropertyChanged;
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
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
