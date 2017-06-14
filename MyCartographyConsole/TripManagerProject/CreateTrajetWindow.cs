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
    public partial class CreateTrajetWindow : Form
    {
        public bool modif = false;
        public Trajet trajettemp;
        public CreateTrajetWindow()
        {
            InitializeComponent();
        }

        public CreateTrajetWindow(Trajet t)
        {
            InitializeComponent();
            DescriptionTB.Text = t.Description;
            DateCalendar.SetDate(t.Date);
            trajettemp = t;
            modif = true;
        }

        private void DateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(modif == false)
                formPrincipale.tmpTrajet.Date = e.Start;
            else
            {
                trajettemp.Date = e.Start;
            }     
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (modif == false)
            {
                formPrincipale.tmpTrajet.Description = DescriptionTB.Text;
                formPrincipale.VoyageEnCours.LTrajet.Add(formPrincipale.tmpTrajet);
                formPrincipale.tmpTrajet = null;
                formPrincipale.mode = formPrincipale.MODENORMAL;
                formPrincipale.writeDebug("Nouveau Trajet");
            }
            else
            {
                trajettemp.Description = DescriptionTB.Text;
            }
            this.Close();
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
