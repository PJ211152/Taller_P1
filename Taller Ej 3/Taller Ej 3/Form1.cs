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
            int num1, num2, num3, num4,sumar,mayor,menor,mayortotal,menortotal;
            try
            {
                num1 = Convert.ToInt32(txtnum1.Text);
                num2 = Convert.ToInt32(txtnum2.Text);
                num3 = Convert.ToInt32(txtnum3.Text);
                num4 = Convert.ToInt32(txtnum4.Text);
                if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0)
                {
                    sumar = num1 + num2 + num3 + num4;
                    txtsumar.Text = Convert.ToString(sumar);
                    if (sumar < 200)
                    {



                        //1
                        //mayor num1
                        if (num1 > num2 && num1 > num3 && num1 > num4)
                        {

                            //menor num2,num3,num4
                            //menor mum2

                            if (num2 < num1 && num2 < num3 && num2 < num4)
                            {
                                menor = num2;
                                mayor = num1;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }

                            }





                            //num3 menor

                            else if (num3 < num1 && num3 < num2 && num3 < num4)
                            {

                                menor = num3;
                                mayor = num1;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }

                            }
                            //menor num4

                            else if (num4 < num1 && num4 < num2 && num4 < num3)
                            {
                                menor = num4;
                                mayor = num1;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }




                        }
                        //mayor num2

                        else if (num2 > num1 && num2 > num3 && num2 > num4)
                        {
                            //menor  num1,num3,num4
                            //menor num1
                            if (num1 < num2 && num1 < num3 && num1 < num4)
                            {
                                menor = num1;
                                mayor = num2;

                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //codiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }


                            }
                            //menor num3
                            else if (num3 < num1 && num3 < num2 && num3 < num4)
                            {
                                menor = num3;
                                mayor = num2;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condicones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }
                            //menor num4
                            else if (num4 < num1 && num4 < num2 && num4 < num3)
                            {
                                menor = num4;
                                mayor = num2;

                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }


                        }
                        //mayor num3
                        else if (num3 > num1 && num3 > num2 && num3 > num4)
                        {
                            //menor num1,num2,num4
                            //menor num1
                            if (num1 < num2 && num1 < num3 && num1 < num4)
                            {
                                menor = num1;
                                mayor = num3;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }

                            }
                            //menor num2
                            else if (num2 < num1 && num2 < num3 && num2 < num4)
                            {
                                menor = num2;
                                mayor = num3;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }
                            //menor num4
                            else if (num4 < num1 && num4 < num2 && num4 < num3)
                            {
                                menor = num4;
                                mayor = num3;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }


                        }
                        //mayornum4
                        else if (num4 > num1 && num4 > num2 && num4 > num3)
                        {
                            //menor num1,num2,num3
                            //menor num1
                            if (num1 < num2 && num1 < num3 && num1 < num4)
                            {
                                menor = num1;
                                mayor = num4;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }

                            }
                            //menor num2
                            else if (num2 < num1 && num2 < num3 && num2 < num4)
                            {
                                menor = num2;
                                mayor = num4;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }
                            //menor num3
                            else if (num3 < num1 && num3 < num2 && num3 < num4)
                            {
                                menor = num4;
                                mayor = num4;
                                txtmayor.Text = Convert.ToString(mayor);
                                txtmenor.Text = Convert.ToString(menor);
                                //condiciones
                                if (menor > 10 && mayor < 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor > 10 && mayor >= 50)
                                {
                                    mayortotal = mayor + 10;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor < 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor - 5;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                                else if (menor <= 10 && mayor >= 50)
                                {
                                    mayortotal = mayor;
                                    menortotal = menor;
                                    txtmayortotal.Text = Convert.ToString(mayortotal);
                                    txtmenortotal.Text = Convert.ToString(menortotal);
                                }
                            }


                        }



                    }
                }

                else
                {
                    MessageBox.Show("Has ingresado un numero negativo o igual a 0, porfavor ingrese solo numeros positivos");
                    txtnum1.Clear();
                    txtnum2.Clear();
                    txtnum3.Clear();
                    txtnum4.Clear();

                }



            }
            catch (FormatException)
            {
                MessageBox.Show("Has ingresado alguna letra o caracter incorrecto");
                txtnum1.Clear();
                txtnum2.Clear();
                txtnum3.Clear();
                txtnum4.Clear();

            }

            

            


        }
    }
}
