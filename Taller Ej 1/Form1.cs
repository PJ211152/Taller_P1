using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Ej_1
{
    public partial class Cuadratica : Form
    {
        public Cuadratica()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0, x1=0, x2=0;

            try
            {
                a = Convert.ToDouble(txb_a);
                b = Convert.ToDouble(txb_b);
                c = Convert.ToDouble(txb_c);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valores validos");
            }
        }
    }
}
