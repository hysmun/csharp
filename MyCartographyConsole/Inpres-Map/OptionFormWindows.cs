using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inpres_Map
{
    public partial class OptionFormWindow : Form
    {
        //string textAide = "Option ";
        WindowPrincipale winPrincipale;

        public OptionFormWindow()
        {
            InitializeComponent();
            winPrincipale = (WindowPrincipale)Tag;
            ColorButtonTool.BackColor = WindowPrincipale.couleurGlobal;
        }

        private void ColorButtonTool_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDial = new ColorDialog();
            ColorDial.AllowFullOpen = false;
            ColorDial.ShowHelp = true;
            ColorDial.Color = ColorButtonTool.BackColor;
            if (ColorDial.ShowDialog() == DialogResult.OK)
                ColorButtonTool.BackColor = ColorDial.Color;
        }

        private void OKButtonOption_Click(object sender, EventArgs e)
        {
            winPrincipale.majListeBox();
            this.Close();
        }

        private void AppliquerButtonOption_Click(object sender, EventArgs e)
        {
            WindowPrincipale.couleurGlobal = ColorButtonTool.BackColor;
            WindowPrincipale.precisionGlobal = (double)numericOption.Value;
        }

        private void CancelButtonOption_Click(object sender, EventArgs e)
        {

        }
    }
}
