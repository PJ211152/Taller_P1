using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Ej_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4,sumar,mayor,menor;
            try
            {
                num1 = Convert.ToInt32(txtnum1.Text);
                num2 = Convert.ToInt32(txtnum2.Text);
                num3 = Convert.ToInt32(txtnum3.Text);
                num4 = Convert.ToInt32(txtnum4.Text);

                sumar = num1 + num2 + num3 + num4;
                txtsumar.Text = Convert.ToString(sumar);
                if (sumar < 200) { 

                         

                    //1
                    //mayor num1
                    if (num1 > num2 && num1 > num3 && num1 > num4)
                    {
                        //menor num2,num3,num4
                        
                        if (num2 < num1 && num2 < num3 && num2 < num4)
                        {
                            menor = num2;
                            mayor = num1;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);

                        }
                        else if (num3 < num1 && num3 < num2 && num3 < num4) 
                        {
                            menor = num3;
                            mayor = num1;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }
                        else if (num4 < num1 && num4 < num2 && num4 < num3)
                        {
                            menor = num4;
                            mayor = num1;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }

                      

                    }
                    //mayor num2
                    
                    else if (num2 > num1 && num2 > num3 && num2 > num4)
                    {
                        //menor  num1,num3,num4
                        if (num1 < num2 && num1 < num3 && num1 < num4)
                        {
                            menor = num1;
                            mayor = num2;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);

                        }
                        else if (num3 < num1 && num3 < num2 && num3 < num4)
                        {
                            menor = num3;
                            mayor = num2;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }
                        else if (num4 < num1 && num4 < num2 && num4 < num3)
                        {
                            menor = num4;
                            mayor = num2;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }

                        
                    }
                    //mayor num3
                    else if (num3 > num1 && num3 > num2 && num3 > num4)
                    {
                        //menor num1,num2,num4
                        if (num1 < num2 && num1 < num3 && num1 < num4)
                        {
                            menor = num1;
                            mayor = num3;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);

                        }
                        else if (num2 < num1 && num2 < num3 && num2 < num4)
                        {
                            menor = num2;
                            mayor = num3;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }
                        else if (num4 < num1 && num4 < num2 && num4 < num3)
                        {
                            menor = num4;
                            mayor = num3;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }

                        
                    }
                    //mayornum4
                    else if (num4 > num1 && num4 > num2 && num4 > num3)
                    {
                        //menor num1,num2,num3
                        if (num1 < num2 && num1 < num3 && num1 < num4)
                        {
                            menor = num1;
                            mayor = num4;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);

                        }
                        else if (num2 < num1 && num2 < num3 && num2 < num4)
                        {
                            menor = num2;
                            mayor = num4;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }
                        else if (num3 < num1 && num3 < num2 && num3 < num4)
                        {
                            menor = num4;
                            mayor = num4;
                            txtmayor.Text = Convert.ToString(mayor);
                            txtmenor.Text = Convert.ToString(menor);
                        }

                        
                    }

                    
                    
                }

                

                 
            }
            catch (FormatException)
            {
                MessageBox.Show("ha ingreado alguna letra o carcter incorrecto");
                txtnum1.Clear();
                txtnum2.Clear();
                txtnum3.Clear();
                txtnum4.Clear();

            }

            

            


        }
    }
}
