using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalistaCalc
{

    
    public partial class CircleMove : Form
    {
        double v, n, T, R, a, om;
        bool vb, nb, Tb, Rb, ab, omb;

        double pi;


        public CircleMove()
        {
            InitializeComponent();
            vb = nb = Tb = Rb = ab = omb = false;
            pi = 3.14159265;

            vres.Text = "Нет Данных";
            ares.Text = "Нет Данных";
            nres.Text = "Нет Данных";
            rres.Text = "Нет Данных";
            tres.Text = "Нет Данных";
            omres.Text = "Нет Данных";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(vtext.Text.Length != 0)
            {
                try
                {
                    v = Double.Parse(vtext.Text);
                    vb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

                
            }

            if (atext.Text.Length != 0)
            {
                try
                {
                    a = Double.Parse(atext.Text);
                    ab = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }

            if (ntext.Text.Length != 0)
            {
                try
                {
                    n = Double.Parse(ntext.Text);
                    nb = true;

                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }         //Collect all Info

            if (rtext.Text.Length != 0)
            {

                try
                {
                    R = Double.Parse(rtext.Text);
                Rb = true;

                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }

            if (ttext.Text.Length != 0)
            {
                try
                {
                    T = Double.Parse(ttext.Text);
                Tb = true;

                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }


            }

            if (omtext.Text.Length != 0)
            {
                try
                {
                 om = Double.Parse(omtext.Text);
                 omb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }



            if(nb || Tb || omb)
            {
                if(Tb)
                {
                    om = 2 * pi / T;
                    n = 1 / T;
                }

                else if(nb)
                {
                    T = 1 / n;
                    om = 2 * pi * n;
                }

                else if(omb)
                {
                    T = 2 * pi / om;
                    n = 1 / T;
                }

                Tb = nb = omb = true;
            }        //First Block

            if((vb || ab || Rb) && Tb)
            {
                if(vb)
                {
                    R = v / om;
                    a = Math.Pow(om, 2) * R;
                }

                else if(ab)
                {
                    R = a / Math.Pow(om, 2);
                    v = 2 * pi * R / T;
                }

                else if(Rb)
                {
                    v = om * R;
                    a = Math.Pow(om, 2) * R;
                }

                vb = ab = Rb = true;
            }



                                              //Second Block

            else if((vb && Rb) || (ab && Rb))
            {
                if(vb && Rb)
                {
                    om = v / R;
                    a = Math.Pow(om, 2) * R;
                }

                else
                {
                    om = Math.Sqrt(a / R);
                    v = om * R;
                }

                
                omb = true;
                ab = true;
            }

            if (nb || Tb || omb)
            {
                if (Tb)
                {
                    om = 2 * pi / T;
                    n = 1 / T;
                }

                else if (nb)
                {
                    T = 1 / n;
                    om = 2 * pi * n;
                }

                else if (omb)
                {
                    T = 2 * pi / om;
                    n = 1 / T;
                }

                Tb = nb = omb = true;
            }


            if ((vb || ab || Rb) && Tb)
            {
                if (vb)
                {
                    R = v / om;
                    a = Math.Pow(om, 2) * R;
                }

                else if (ab)
                {
                    R = a / Math.Pow(om, 2);
                    v = 2 * pi * R / T;
                }

                else if (Rb)
                {
                    v = om * R;
                    a = Math.Pow(om, 2) * R;
                }

            }

                if (ab)
            {
                ares.Text = a.ToString();
            }

            else
            {
                ares.Text = "Нет Данных";
            }

            if (vb)
            {
                vres.Text = v.ToString();
            }

            else
            {
                vres.Text = "Нет Данных";
            }

            if (omb)
            {
                omres.Text = om.ToString();
            }

            else
            {
                omres.Text = "Нет Данных";
            }

            if (Rb)
            {
                rres.Text = R.ToString();
            }

            else
            {
                rres.Text = "Нет Данных";
            }

            if (Tb)
            {
                tres.Text = T.ToString();
            }

            else
            {
                tres.Text = "Нет Данных";
            }

            if (nb)
            {
                nres.Text = n.ToString();
            }

            else
            {
                nres.Text = "Нет Данных";
            }


            vtext.Text = "";
            atext.Text = "";
            ntext.Text = "";
            rtext.Text = "";
            ttext.Text = "";
            omtext.Text = "";
            vb = nb = Tb = Rb = ab = omb = false;
        }
    }
}
