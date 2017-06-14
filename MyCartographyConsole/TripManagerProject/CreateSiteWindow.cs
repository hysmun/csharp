using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripManagerObjects;

namespace TripManagerProject
{
    public partial class CreateSiteWindow : Form
    {
        public bool modif = false;
        public Site sitetemp;
        public CreateSiteWindow()
        {
            InitializeComponent();
            latitudeNumeric.Value = Convert.ToDecimal(formPrincipale.tmpSite.Position.Lat);
            longitudeNumeric.Value = Convert.ToDecimal(formPrincipale.tmpSite.Position.Longitude);
            modif = false;
        }

        public CreateSiteWindow(Site s)
        {
            InitializeComponent();
            sitetemp = s;
            latitudeNumeric.Value = Convert.ToDecimal(s.Position.Lat);
            longitudeNumeric.Value = Convert.ToDecimal(s.Position.Longitude);
            DescriptionLongueTextBox.Text = s.Description;
            DescriptionTextBox.Text = s.Position.Description;
            imageBox.ImageLocation = s.Image;
            modif = true;
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            formPrincipale.tmpSite = null;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (modif == false)
                {
                    formPrincipale.tmpSite.Description = DescriptionLongueTextBox.Text;
                    formPrincipale.tmpSite.Position = new POI(Convert.ToDouble(latitudeNumeric.Value), Convert.ToDouble(longitudeNumeric.Value));
                    formPrincipale.tmpSite.Position.Description = DescriptionTextBox.Text;
                    formPrincipale.lSite.Add(formPrincipale.tmpSite);
                    formPrincipale.tmpSite = null;
                    formPrincipale.writeDebug("Nouveau Site");
                }
                else
                {
                    sitetemp.Position.Lat = Convert.ToDouble(latitudeNumeric.Value);
                    sitetemp.Position.Longitude = Convert.ToDouble(longitudeNumeric.Value);
                    sitetemp.Description = DescriptionLongueTextBox.Text;
                    sitetemp.Position.Description = DescriptionTextBox.Text;
                    sitetemp.Image = imageBox.ImageLocation;
                    modif = true;
                    formPrincipale.lSite.ResetBindings();
                }
            }
            catch(Exception ex)
            {
                formPrincipale.writeDebug(ex.Message);
            }
            this.Close();
        }

        private void imageBox_Click(object sender, EventArgs e)
        {

            imageOpen.InitialDirectory = formPrincipale.tripParam.PathName + @"\Images";
            imageOpen.ShowDialog();
            if (modif == false)
            {
                formPrincipale.tmpSite.Image = imageOpen.FileName.Remove(0, formPrincipale.tripParam.PathName.Length);
                imageBox.ImageLocation = formPrincipale.tmpSite.Image;
            }
            else
            {
                sitetemp.Image = imageOpen.FileName;
                imageBox.ImageLocation = sitetemp.Image;
            }
        }

        private void CreateSiteWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipale.tmpSite = null;
        }
    }
}
