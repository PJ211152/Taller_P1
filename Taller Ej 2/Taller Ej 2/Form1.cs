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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs kea)
        {
            try
            {
                if (kea.KeyCode == Keys.Enter)
                {
                    if (txb_votos.Text.Length != 0)
                    {

                        string votos = txb_votos.Text;
                        string[] subs = votos.Split(' ', '.', ',', '-', '/', '#');

                        foreach (var sub in subs)
                        {
                            if (Convert.ToInt32(sub) > 0 && Convert.ToInt32(sub) <= 4)
                            {

                                lsb_Votos.Items.Add($"{sub}");

                            }

                            txb_votos.Clear();


                        }
                    }
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_votos.Text.Length != 0)
                {

                    
                    string votos = txb_votos.Text;
                    string[] subs = votos.Split(' ', '.', ',', '-', '/', '#');

                    foreach (var sub in subs)
                    {
                        if (Convert.ToInt32(sub) > 0 && Convert.ToInt32(sub) <= 4)
                        {

                            lsb_Votos.Items.Add($"{sub}");

                        }

                        txb_votos.Clear();
                        

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }

        private void lsb_Votos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_contar_Click(object sender, EventArgs e)
        {
            
                
            
        }

        public string[] conteo(string[] a)
        {
            return a;
        }
    }
}
