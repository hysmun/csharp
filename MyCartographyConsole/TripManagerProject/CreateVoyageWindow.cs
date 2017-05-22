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
    public partial class CreateVoyageWindow : Form
    {

        private DateTime DateDebut;
        private  DateTime DateFin;

        public CreateVoyageWindow()
        {
            InitializeComponent();
            DateDebut = new DateTime();
            DateFin = new DateTime();
        }

        private void CreateVoyageWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formPrincipale.tmpVoyage = new Voyage(DescriptionTextBox.Text, LibelleTextBox.Text, DateDebut, DateFin);
            try
            {
                formPrincipale.lVoyage.Add(new Voyage(DescriptionTextBox.Text, LibelleTextBox.Text, DateDebut, DateFin));
            }
            catch(Exception ex)
            {
             //
            }
        }

        private void calendarFin_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateFin = e.Start;
        }

        private void calendarDebut_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateDebut = e.Start;
        }
    }
}
