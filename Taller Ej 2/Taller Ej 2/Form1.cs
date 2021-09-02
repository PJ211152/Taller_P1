using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Ej_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsb_Recuento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_recuento_Click(object sender, EventArgs e)
        {

        }

        private void btb_limpiar_lista_Click(object sender, EventArgs e)
        {
            lsb_Votos.Items.Clear();
        }
    }
}
