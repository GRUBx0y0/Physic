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
    public partial class FreeFall : Form
    {

        bool isDefault;
        double v0, v, s, t;
        bool v0b, vb, sb, tb;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        double g;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                g = 9.870;
            }

            else
            {
                g = 10;
            }
        }

       

        private void switcher(object sender, EventArgs e)
        {
                radioButton1.Checked = !isDefault;
                isDefault = !isDefault;

                if (isDefault)
                {
                    v0text.Text = "0";
                    def_lab.Show();
                }

                else
                {
                    v0text.Text = "";
                    def_lab.Hide();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (v0text.Text.Length != 0)
            {
                try
                {
                    v0 = Double.Parse(v0text.Text);
                    v0b = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }

            if (vtext.Text.Length != 0)
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

            if (stext.Text.Length != 0)
            {
                try
                {
                    s = Double.Parse(stext.Text);
                    sb = true;
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
                    t = Double.Parse(ttext.Text);
                    tb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }




            if(!vb)
            {
                if(v0b)
                {
                    if(sb)
                    {
                        v = Math.Sqrt(2 * g * s + Math.Pow(v0, 2));
                        vb = true;
                        if(!tb)
                        {
                            t = (v - v0) / g;
                            tb = true;
                           
                        }
                    }

                    else if(tb)
                    {
                        v = v0 + g * t;
                        vb = true;

                        s = (Math.Pow(v, 2) - Math.Pow(v0, 2)) / (2 * g);
                        sb = true;
                    }
                }

            }

            if(!v0b)
            {
                if(vb)
                {
                    if(sb)
                    {
                        v0 = Math.Sqrt(Math.Pow(v, 2) - 2 * g * s);
                        if(!tb)
                        {
                            t = (v - v0) / g;
                            
                            tb = true;
                        }
                        v0b = true;
                    }

                    else if (tb)
                    {
                        v0 = v + g * t;
                        vb = true;

                        s = (Math.Pow(v, 2) - Math.Pow(v0, 2)) / (2 * g);
                        sb = true;
                    }
                }
            }

            if(!tb)
            {
                if(v0b)
                {
                    if(vb)
                    {
                        t = (v = v0) / g;
                        tb = true;

                    }
                }
            }

            if(!sb)
            {
                if(v0b)
                {
                    if(tb)
                    {
                        s = v0 * t + g * Math.Pow(t, 2) / 2;
                        sb = true;
                    }
                }
            }

            //if(t < 0)
            //{
            //    t *= -1;
            //}
          

            if (tb)
            {
                tres.Text = t.ToString();
            }

            else
            {
                tres.Text = "Нет данных";
            }

            if (vb)
            {
                vres.Text = v.ToString();
            }

            else
            {
                vres.Text = "Нет данных";
            }

            if (v0b)
            {
                v0res.Text = v0.ToString();
            }

            else
            {
                v0res.Text = "Нет данных";
            }

            if (sb)
            {
                sres.Text = s.ToString();
            }

            else
            {
                sres.Text = "Нет данных";
            }


            vtext.Text = "";
            ttext.Text = "";
            stext.Text = "";

            if (isDefault)
            {
                v0text.Text = "0";
            }

            else
            {
                v0text.Text = "";
            }

            v0b = vb = sb = tb = false;

        }

        public FreeFall()
        {
            InitializeComponent();
            isDefault = true;
            g = 10;
        }

        private void label13_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
