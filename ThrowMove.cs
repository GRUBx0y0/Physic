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
    public partial class ThrowMove : Form
    {
        double g;
        bool rad;
        double v0, v, s, t, h, a, f, x, y, tmg;

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void xres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmgtext_TextChanged(object sender, EventArgs e)
        {
            if (tmgtext.Text.Length != 0)
            {
                try
                {
                    tmg = Double.Parse(tmgtext.Text);
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                    tmgtext.Text = "";
                }

            }

            if(tb)
            {
                if(tmg > t)
                {
                    norm_lab.Visible = false;
                    label16.Visible = true;

                    tmg = t;

                }

                else
                {
                    label16.Visible = false;
                    norm_lab.Visible = true;
                }
            }




            x = v0 * tmg * Math.Cos(a);
            y = v0 * Math.Sin(a) * tmg - g * Math.Pow(tmg, 2) / 2;




            xres.Text = x.ToString();
            yres.Text = y.ToString();

        }

        bool ab, v0b, vb, sb, tb, hb, fb;

        public ThrowMove()
        {
            InitializeComponent();
            g = 10;
            rad = false;

            ab = v0b = vb = sb = tb = hb = fb = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void gbutt_CheckedChanged(object sender, EventArgs e)
        {
            if (gbutt.Checked)
            {
                g = 10;
            }

            else
            {
                g = 9.870;
            }
        }

        private void grad_butt_CheckedChanged(object sender, EventArgs e)
        {
            if (grad_butt.Checked)
            {
                rad = false;
                grad_lab1.Text = "Градусы";

                if (atext.Text.Length != 0)
                {
                    try
                    {
                        atext.Text = (Double.Parse(atext.Text) * 180 / Math.PI).ToString();
                    }

                    catch (FormatException)
                    {
                       
                    }

                }

            }

            else
            {
                rad = true;
                grad_lab1.Text = "Радианы";

                if (atext.Text.Length != 0)
                {
                    try
                    {
                        atext.Text = (Double.Parse(atext.Text) * Math.PI / 180).ToString();
                    }

                    catch (FormatException)
                    {

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ab = v0b = vb = sb = tb = hb = fb = false;

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

            if (htext.Text.Length != 0)
            {
                try
                {
                    h = Double.Parse(htext.Text);
                    hb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Вы ввели символ. Для ввода дробей используйте: ,");
                }

            }


            if(!rad)
            {
                if(ab)
                {
                    a *= Math.PI / 180;
                }
               
            }



            if(!sb)
            {
                if(v0b)
                {
                    if(ab)
                    {
                        s = Math.Pow(v0, 2) * Math.Sin(2 * a) / g;
                        sb = true;

                        if(a == Math.PI / 2)
                        {
                            s = 0;
                        }

                        t = (2 * v0 * Math.Sin(a) / g);
                        tb = true;

                        if (!hb)
                        {
                            h = v0 * Math.Sin(a) * t / 2 - g * Math.Pow(t / 2, 2) / 2;
                            hb = true;
                        }

                        v = Math.Sqrt(Math.Pow(v0 * Math.Cos(a) * t, 2) + Math.Pow(v0 * Math.Sin(a) - g * t,2));
                        f = Math.Atan((v0 * Math.Cos(a) * t) / (v0 * Math.Sin(a) - g * t));
                        vb = true;
                        fb = true;

                    }
                }
            }

            else
            {
                if(!v0b)
                {
                    if(ab)
                    {
                        v0 = Math.Sqrt(s * g / (Math.Cos(a) * Math.Sin(a) * 2));
                        v0b = true;

                        t = (2 * v0 * Math.Sin(a) / g);
                        tb = true;

                        if (!hb)
                        {
                         

                            h = v0 * Math.Sin(a) * t / 2 - g * Math.Pow(t / 2, 2) / 2;
                            hb = true;
                        }

                        v = Math.Sqrt(Math.Pow(v0 * Math.Cos(a) * t, 2) + Math.Pow(v0 * Math.Sin(a) - g * t, 2));
                        f = Math.Atan((v0 * Math.Cos(a) * t) / (v0 * Math.Sin(a) - g * t));
                        vb = true;
                        fb = true;
                    }          
                }

                else if(!ab)
                {
                    a = (Math.Asin(s * g / Math.Pow(v0, 2))) / 2;
                    ab = true;

                    t = (2 * v0 * Math.Sin(a) / g);
                    tb = true;

                    if (!hb)
                    {
                        h = v0 * Math.Sin(a) * t / 2 - g * Math.Pow(t / 2, 2) / 2;
                        hb = true;
                    }

                    v = Math.Sqrt(Math.Pow(v0 * Math.Cos(a) * t, 2) + Math.Pow(v0 * Math.Sin(a) - g * t, 2));
                    f = Math.Atan((v0 * Math.Cos(a) * t) / (v0 * Math.Sin(a) - g * t));
                    vb = true;
                    fb = true;
                }

                else if(!hb)
                {
                    t = (2 * v0 * Math.Sin(a) / g);
                    tb = true;

                    h = v0 * Math.Sin(a) * t / 2 - g * Math.Pow(t / 2, 2) / 2;
                    hb = true;

                    v = Math.Sqrt(Math.Pow(v0 * Math.Cos(a) * t, 2) + Math.Pow(v0 * Math.Sin(a) - g * t, 2));
                    f = Math.Atan((v0 * Math.Cos(a) * t) / (v0 * Math.Sin(a) - g * t));
                    vb = true;
                    fb = true;
                }

                else if(!tb)
                {
                    t = (2 * v0 * Math.Sin(a) / g);
                    tb = true;

                    v = Math.Sqrt(Math.Pow(v0 * Math.Cos(a) * t, 2) + Math.Pow(v0 * Math.Sin(a) - g * t, 2));
                    f = Math.Atan((v0 * Math.Cos(a) * t) / (v0 * Math.Sin(a) - g * t));
                    vb = true;
                    fb = true;

                }
            }


            if(fb)
            {
                f *= -1;
            }



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
                vkres.Text = v.ToString();
            }

            else
            {
                vkres.Text = "Нет данных";
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

            if (hb)
            {
                hres.Text = h.ToString();
            }

            else
            {
                hres.Text = "Нет данных";
            }

            if (ab)
            {
                aresg.Text = (a * 180 / Math.PI).ToString();
                aresr.Text = (a * Math.PI / 180).ToString();
            }

            else
            {
                aresg.Text = "Нет данных";
                aresr.Text = "Нет данных";
            }

            if (fb)
            {
                fresg.Text = (f * 180 / Math.PI).ToString();
                fresr.Text = (f * Math.PI / 180).ToString();
            }

            else
            {
                fresg.Text = "Нет данных";
                fresr.Text = "Нет данных";
            }



            ttext.Text = "";
            stext.Text = "";
            atext.Text = "";
            v0text.Text = "";
            htext.Text = "";

            if(v0b && ab)
            {
                err_lab.Visible = false;
                norm_lab.Visible = true;
                tmgtext.ReadOnly = false;
            }

            else
            {
                err_lab.Visible = true;
                norm_lab.Visible = false;
                tmgtext.ReadOnly = true;
            }

           
            tmgtext.Text = "";
            xres.Text = "";
            yres.Text = "";
            label16.Visible = false;


        }
    }
}
