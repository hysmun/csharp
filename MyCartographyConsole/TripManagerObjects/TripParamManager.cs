using GMap.NET.WindowsForms.Markers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TripManagerObjects
{
    public class TripParamManager
    {
        #region Variables
        private double _precision;
        private GMarkerGoogleType _couleur;
        private string _pathName;
        #endregion
        #region Proprietes
        public double Precision
        {
            get
            {
                return _precision;
            }

            set
            {
                _precision = value;
            }
        }

        public GMarkerGoogleType Couleur
        {
            get
            {
                return _couleur;
            }

            set
            {
                _couleur = value;
            }
        }

        public string PathName
        {
            get
            {
                return _pathName;
            }

            set
            {
                _pathName = value;
            }
        }
        #endregion
        #region Constructeur
        public TripParamManager()
        {
            //on cree les SubKey
            RegistryKey softreg = Registry.CurrentUser.CreateSubKey("software");
            RegistryKey TripManagerreg = softreg.CreateSubKey("TripManager");
            RegistryKey Mapreg = TripManagerreg.CreateSubKey("Map");
            RegistryKey Tripreg = TripManagerreg.CreateSubKey("Trip");

            //creation des key si inexistante
            if(Tripreg.GetValue("Trip Pathname") == null)
                Tripreg.SetValue("Trip Pathname", System.IO.Directory.GetCurrentDirectory());
            if (Mapreg.GetValue("precision") == null)
                Mapreg.SetValue("Precision", 10.0);
            if (Mapreg.GetValue("Couleur") == null)
                Mapreg.SetValue("Couleur", GMarkerGoogleType.blue);

            //on recup les valeur pour variable
            LoadRegistryParameter();

            //on cree dossier image site et voyage si inexistant
            if (!System.IO.Directory.Exists(PathName + "\\Images"))
            {
                System.IO.Directory.CreateDirectory(PathName + "\\Images");
            }
            if (!System.IO.Directory.Exists(PathName + "\\Sites"))
            {
                System.IO.Directory.CreateDirectory(PathName + "\\Sites");
            }
            if (!System.IO.Directory.Exists(PathName + "\\Voyages"))
            {
                System.IO.Directory.CreateDirectory(PathName + "\\Voyages");
            }
        }
        #endregion
        #region Methodes
        public void LoadRegistryParameter()
        {
            RegistryKey softreg = Registry.CurrentUser.CreateSubKey("software");
            RegistryKey TripManagerreg = softreg.CreateSubKey("TripManager");
            RegistryKey Mapreg = TripManagerreg.CreateSubKey("Map");
            RegistryKey Tripreg = TripManagerreg.CreateSubKey("Trip");
            PathName = (string)Tripreg.GetValue("Trip Pathname");
            Precision = Convert.ToDouble(Mapreg.GetValue("Precision"));
            //Couleur = (GMarkerGoogleType) Mapreg.GetValue("Couleur");


            MemberInfo[] memberinfo = typeof(GMarkerGoogleType).GetMembers(BindingFlags.Public | BindingFlags.Static);
            Array enumnames = typeof(GMarkerGoogleType).GetEnumValues();
            int i = 0;  
            foreach (MemberInfo mi in memberinfo)
            {
                if (mi.Name == (string)Mapreg.GetValue("Couleur"))
                {
                    Couleur = (GMarkerGoogleType)enumnames.GetValue(i);
                    break;
                }
                i++;
            }

        }
        public void SaveRegistryParameter()
        {
            RegistryKey softreg = Registry.CurrentUser.CreateSubKey("software");
            RegistryKey TripManagerreg = softreg.CreateSubKey("TripManager");
            RegistryKey Mapreg = TripManagerreg.CreateSubKey("Map");
            RegistryKey Tripreg = TripManagerreg.CreateSubKey("Trip");
            Tripreg.SetValue("Trip Pathname", PathName);
            Mapreg.SetValue("Precision", Precision);
            Mapreg.SetValue("Couleur", Couleur);
        }
        #endregion
    }
}
