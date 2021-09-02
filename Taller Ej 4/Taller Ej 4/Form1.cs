using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Ej_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_E1.Items.Clear();
            cmb_E2.Items.Clear();
            cmb_E3.Items.Clear();

            cmb_E1.Items.Add("Gerente");
            cmb_E1.Items.Add("Asistente");
            cmb_E1.Items.Add("Secretaria");

            cmb_E2.Items.Add("Gerente");
            cmb_E2.Items.Add("Asistente");
            cmb_E2.Items.Add("Secretaria");

            cmb_E3.Items.Add("Gerente");
            cmb_E3.Items.Add("Asistente");
            cmb_E3.Items.Add("Secretaria");

        }

        private void txb_AE1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
