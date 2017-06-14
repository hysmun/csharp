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
    public partial class AProposForm : Form
    {
        public AProposForm()
        {
            InitializeComponent();
            dateLabel.Text = "" + (new DateTime()).ToString("dd/MM/yyyy");
            descripionLabel.Text = "Application de gestion de trajet dans le cadre de la fin d'année du cours de c# pour Madame Moitroux";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
