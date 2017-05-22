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
    public partial class CreateTrajetWindow : Form
    {
        public CreateTrajetWindow()
        {
            InitializeComponent();
        }

        private void DateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            formPrincipale.tmpTrajet.Date = e.Start;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            formPrincipale.lTrajet.Add(formPrincipale.tmpTrajet);
            formPrincipale.tmpTrajet = null;
            formPrincipale.mode = formPrincipale.MODENORMAL;
            this.Close();
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
