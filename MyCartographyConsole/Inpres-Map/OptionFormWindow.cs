using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCartographyObjects;

namespace Inpres_Map  
    
    
{
    public class ParamEventArgs
    {
        private double _precision;
        private Color _couleur;

        public double Precision
        {
            get
            {
                return _precision;
            }

            set
            {
                _precision = value;
            }
        }

        public Color Couleur
        {
            get
            {
                return _couleur;
            }

            set
            {
                _couleur = value;
            }
        }

        public ParamEventArgs(double pPrecision, Color pCouleur)
        {
            Precision = pPrecision;
            Couleur = pCouleur;
        }
    }

    public delegate void OptionChangedHandler(ParamEventArgs e);
    
    public partial class OptionFormWindow : Form
    {
        public event OptionChangedHandler OptionChanged;
           
        public OptionFormWindow()
        {
            InitializeComponent();
            ColorButtonTool.BackColor = WindowPrincipale.couleurGlobal;
            numericOption.Value = (decimal) WindowPrincipale.precisionGlobal;
        }

        private void ColorButtonTool_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDial = new ColorDialog();
            ColorDial.AllowFullOpen = false;
            ColorDial.ShowHelp = true;
            ColorDial.AnyColor = true;
            ColorDial.AllowFullOpen = true;
            ColorDial.Color = ColorButtonTool.BackColor;
            if (ColorDial.ShowDialog() == DialogResult.OK)
                ColorButtonTool.BackColor = ColorDial.Color;
        }

        private void OKButtonOption_Click(object sender, EventArgs e)
        {
            if (OptionChanged != null)
                OptionChanged( new ParamEventArgs((double)numericOption.Value, ColorButtonTool.BackColor));
            this.Close();
        }

        private void AppliquerButtonOption_Click(object sender, EventArgs e)
        {
            WindowPrincipale.couleurGlobal = ColorButtonTool.BackColor;
            WindowPrincipale.precisionGlobal = (double)numericOption.Value;
        }

        private void CancelButtonOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
