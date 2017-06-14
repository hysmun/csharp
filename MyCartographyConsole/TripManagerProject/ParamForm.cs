using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripManagerProject
{
    public partial class ParamForm : Form
    {
        public ParamForm()
        {
            InitializeComponent();
            precisionNumeric.Value = Convert.ToDecimal(formPrincipale.tripParam.Precision);
            pathnameTB.Text = formPrincipale.tripParam.PathName;
            switch(formPrincipale.tripParam.Couleur)
            {
                case GMarkerGoogleType.blue://0
                    couleurComboBox.SelectedIndex = 0;
                    break;
                case GMarkerGoogleType.green://1
                    couleurComboBox.SelectedIndex = 1;
                    break;
                case GMarkerGoogleType.yellow://2
                    couleurComboBox.SelectedIndex = 2;
                    break;
                case GMarkerGoogleType.black_small://3
                    couleurComboBox.SelectedIndex = 3;
                    break;
                case GMarkerGoogleType.purple: //4
                    couleurComboBox.SelectedIndex = 4;
                    break;
                case GMarkerGoogleType.pink: //5
                    couleurComboBox.SelectedIndex = 5;
                    break;
            }
            localiteTB.Text = formPrincipale.localite;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                formPrincipale.tripParam.PathName = pathnameTB.Text;
                formPrincipale.tripParam.Precision = Convert.ToDouble(precisionNumeric.Value);
                switch (couleurComboBox.SelectedIndex)
                {
                    case 0://0
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.blue;
                        break;
                    case 1://1
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.green;
                        break;
                    case 2://2
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.yellow;
                        break;
                    case 3://3
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.black_small;
                        break;
                    case 4: //4
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.purple;
                        break;
                    case 5: //5
                        formPrincipale.tripParam.Couleur = GMarkerGoogleType.pink;
                        break;
                }
                formPrincipale.localite = localiteTB.Text;
                this.Close();
            }
            catch(Exception ex)
            {
                formPrincipale.writeDebug(ex.Message);
            }
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
