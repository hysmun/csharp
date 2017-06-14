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
    public partial class AddSiteMarker : Form
    {
        formPrincipale parent;
        Site site;
        public AddSiteMarker(formPrincipale pparent, Site psite)
        {
            InitializeComponent();
            parent = pparent;
            site = psite;
        }

        private void ajoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (parent.trajetTV.SelectedNode.Tag is Trajet)
                {
                    (parent.trajetTV.SelectedNode.Tag as Trajet).LSite.Add(site);
                }
            }
            catch(Exception ex)
            {
                formPrincipale.writeDebug("Ajout click : " + ex.Message);
            }
            this.Close();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
