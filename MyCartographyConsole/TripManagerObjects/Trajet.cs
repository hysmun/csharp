﻿using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripManagerObjects
{
    public class Trajet : TripObj
    {
        #region Variable
        private DateTime _date;
        private Polyline _polyline;
        private List<Site> _lSite;
        #endregion
        #region Proprietes
        internal List<Site> LSite
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
        #endregion
        #region Methodes
        #endregion
    }
}
