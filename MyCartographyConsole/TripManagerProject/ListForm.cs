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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            siteList.DataSource = formPrincipale.lSite;
            if(formPrincipale.VoyageEnCours != null)
                trajetList.DataSource = formPrincipale.VoyageEnCours.LTrajet;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
