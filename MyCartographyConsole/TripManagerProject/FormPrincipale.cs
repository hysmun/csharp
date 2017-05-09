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
    public partial class formPrincipale : Form
    {
        public TripParamManager tripParam;

        public formPrincipale()
        {
            try
            {
                InitializeComponent();
                //gmapWinPrincipale.
                tripParam = new TripParamManager();
            }
            catch(Exception e)
            {
                MessageBox.Show("init Fenetre principale\n" + e.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gmapWinPrincipale_Load(object sender, EventArgs e)
        {
            gmapWinPrincipale.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapWinPrincipale.SetPositionByKeywords("Liege");
            gmapWinPrincipale.ShowCenter = false;
        }

        private void formPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            tripParam.SaveRegistryParameter();
        }
    }
}
