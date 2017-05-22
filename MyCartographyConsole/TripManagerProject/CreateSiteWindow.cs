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
        public int modif = 0;
        public CreateSiteWindow()
        {
            InitializeComponent();
        }

        private void CreateSiteWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formPrincipale.lSite.Add(new Site(DescriptionTextBox.Text, DescriptionLongueTextBox.Text, (double)latitudeNumeric.Value,(double)LongitudeNumeric.Value));
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            { 
                formPrincipale.lSite.Add(new Site(DescriptionTextBox.Text, DescriptionLongueTextBox.Text, Convert.ToDouble(latitudeNumeric.Value), Convert.ToDouble(LongitudeNumeric.Value)));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message + DescriptionTextBox.Text + " "+ DescriptionLongueTextBox.Text);
            }
            this.Close();
        }
    }
}
