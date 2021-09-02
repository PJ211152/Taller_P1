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
            cmb_E1.Items.Add("Otro");

            cmb_E2.Items.Add("Gerente");
            cmb_E2.Items.Add("Asistente");
            cmb_E2.Items.Add("Secretaria");
            cmb_E1.Items.Add("Otro");

            cmb_E3.Items.Add("Gerente");
            cmb_E3.Items.Add("Asistente");
            cmb_E3.Items.Add("Secretaria");
            cmb_E3.Items.Add("Otro");
            

        }

        private void txb_AE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int horas1 = Convert.ToInt32(txb_HE1.Text), horas2 = Convert.ToInt32(txb_HE2.Text), horas3 = Convert.ToInt32(txb_HE3.Text);
                double sb1=0, sb3 = 0, sb2 = 0, isss =0.00525, afp=0.00688, renta=0.01, sl1=0, sl2 = 0, sl3 = 0, bono1 =0, bono2=0, bono3=0;
                string Ne1 = txb_NE1.Text, Ne2 = txb_NE2.Text, Ne3 = txb_NE3.Text, Ae1 = txb_AE1.Text, Ae2 = txb_AE2.Text, Ae3 = txb_AE3.Text;

                if (cmb_E1.SelectedItem.ToString() == "Gerente" && cmb_E2.SelectedItem.ToString() == "Asistente" && cmb_E3.SelectedItem.ToString() == "Secretaria")
                {
                    if (Convert.ToInt32(txb_HE1.Text) > 0 && Convert.ToInt32(txb_HE2.Text) > 0 && Convert.ToInt32(txb_HE3.Text) > 0)
                    {
                        int i, o, p;
                        for (i = 1; i <= horas1; i++)
                        {
                            if (i <= 160)
                            {
                                sb1 = sb1 + 9.75;
                            }
                            if (i > 160)
                            {
                                sb1 = sb1 + 11.50;
                            }
                        }

                        for (o = 1; o <= horas2; o++)
                        {
                            if (o <= 160)
                            {
                                sb2 = sb2 + 9.75;
                            }
                            if (o > 160)
                            {
                                sb2 = sb2 + 11.50;
                            }
                        }

                        for (p = 1; p <= horas3; p++)
                        {
                            if (p <= 160)
                            {
                                sb3 = sb3 + 9.75;
                            }
                            if (p > 160)
                            {
                                sb3 = sb3 + 11.50;
                            }
                        }

                        bonon1(bono1);
                        bonon2(bono2);
                        bonon3(bono3);

                        sl1 = (-((isss * sb1) + (afp * sb1) + (renta * sl1)) + sb1);
                        

                        sl3 = (-((isss * sb3) + (afp * sb3) + (renta * sl3)) + sb3);
                        

                        sl2 = (-((isss * sb2) + (afp * sb2) + (renta * sl2)) + sb1);

                        MessageBox.Show("No hay bono");
                        MessageBox.Show("El empleado " + Ne1 + " " + Ae1 + " con sueldo bruto de $" + sb1 + " con descuento de afp $" + Math.Round(afp * sb1, 2) + " ISSS $" + Math.Round(isss * sb1, 2) + " y renta $" + Math.Round(renta * sl1, 2) + " tiene un sueldo liquido de $" + Math.Round(sl1, 2) + "");
                        MessageBox.Show("El empleado " + Ne2 + " " + Ae2 + " con sueldo bruto de $" + sb2 + " con descuento de afp $" + Math.Round(afp * sb2, 2) + " ISSS $" + Math.Round(isss * sb2, 2) + " y renta $" + Math.Round(renta * sl2, 2) + " tiene un sueldo liquido de $" + Math.Round(sl2, 2) + "");
                        MessageBox.Show("El empleado " + Ne3 + " " + Ae3 + " con sueldo bruto de $" + sb3 + " con descuento de afp $" + Math.Round(afp * sb3, 2) + " ISSS $" + Math.Round(isss * sb3, 2) + " y renta $" + Math.Round(renta * sl3, 2) + " tiene un sueldo liquido de $" + Math.Round(sl3, 2) + "");
                    }
                }
                else
                {
                    if (Convert.ToInt32(txb_HE1.Text) > 0 && Convert.ToInt32(txb_HE2.Text) > 0 && Convert.ToInt32(txb_HE3.Text) > 0)
                    {
                        int i,o,p;
                        for (i = 1; i<= horas1; i++)
                        {
                            if (i <= 160)
                            {
                                sb1 = sb1 + 9.75;
                            }
                            if (i > 160)
                            {
                                sb1 = sb1 + 11.50;
                            }
                        }

                        for (o = 1; o <= horas2; o++)
                        {
                            if (o <= 160)
                            {
                                sb2 = sb2 + 9.75;
                            }
                            if (o > 160)
                            {
                                sb2 = sb2 + 11.50;
                            }
                        }

                        for (p = 1; p <= horas3; p++)
                        {
                            if (p <= 160)
                            {
                                sb3 = sb3 + 9.75;
                            }
                            if (p > 160)
                            {
                                sb3 = sb3 + 11.50;
                            }
                        }

                        bonon1(bono1);
                        bonon2(bono2);
                        bonon3(bono3);

                        sl1 = (-((isss * sb1) + (afp * sb1) + (renta * sl1)) + sb1);
                        sl1 = Math.Round((sl1 * bono1) + sl1, 2);

                        sl3 = (-((isss * sb3) + (afp * sb3) + (renta * sl3)) + sb3);
                        sl3 = Math.Round((sl3 * bono1) + sl3, 2);

                        sl2 = (-((isss * sb2) + (afp * sb2) + (renta * sl2)) + sb1);
                        sl2 = Math.Round((sl2 * bono1) + sl2, 2);

                        MessageBox.Show("El empleado "+Ne1+" "+Ae1+" con sueldo bruto de $"+sb1+" con descuento de afp $"+ Math.Round(afp * sb1,2) + " ISSS $"+ Math.Round(isss * sb1,2) + " y renta $"+ Math.Round(renta * sl1,2) + " tiene un sueldo liquido de $"+ Math.Round(sl1,2) + "");
                        MessageBox.Show("El empleado " + Ne2 + " " + Ae2 + " con sueldo bruto de $" + sb2 + " con descuento de afp $" + Math.Round(afp * sb2, 2) + " ISSS $" + Math.Round(isss * sb2, 2) + " y renta $" + Math.Round(renta * sl2, 2) + " tiene un sueldo liquido de $" + Math.Round(sl2, 2) + "");
                        MessageBox.Show("El empleado " + Ne3 + " " + Ae3 + " con sueldo bruto de $" + sb3 + " con descuento de afp $" + Math.Round(afp * sb3, 2) + " ISSS $" + Math.Round(isss * sb3, 2) + " y renta $" + Math.Round(renta * sl3, 2) + " tiene un sueldo liquido de $" + Math.Round(sl3, 2) + "");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ingrese valores mas pequeños");
            }
        }

        public double bonon1(double bn1)
        {
            if(cmb_E1.SelectedItem.ToString() == "Gerente")
            {
                bn1 = 0.01;
            }
            if (cmb_E1.SelectedItem.ToString() == "Asistente")
            {
                bn1 = 0.005;
            }
            if (cmb_E1.SelectedItem.ToString() == "Secretaria")
            {
                bn1 = 0.003;
            }
            if (cmb_E1.SelectedItem.ToString() == "Otros")
            {
                bn1 = 0.002;
            }

            return bn1;
        }

        public double bonon2(double bn2)
        {
            if (cmb_E1.SelectedItem.ToString() == "Gerente")
            {
                bn2 = 0.01;
            }
            if (cmb_E1.SelectedItem.ToString() == "Asistente")
            {
                bn2 = 0.005;
            }
            if (cmb_E1.SelectedItem.ToString() == "Secretaria")
            {
                bn2 = 0.003;
            }
            if (cmb_E1.SelectedItem.ToString() == "Otros")
            {
                bn2 = 0.002;
            }

            return bn2;
        }

        public double bonon3(double bn3)
        {
            if (cmb_E1.SelectedItem.ToString() == "Gerente")
            {
                bn3 = 0.01;
            }
            if (cmb_E1.SelectedItem.ToString() == "Asistente")
            {
                bn3 = 0.005;
            }
            if (cmb_E1.SelectedItem.ToString() == "Secretaria")
            {
                bn3 = 0.003;
            }
            if (cmb_E1.SelectedItem.ToString() == "Otros")
            {
                bn3 = 0.002;
            }

            return bn3;
        }
    }
}
