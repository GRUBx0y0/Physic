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
    public partial class Classic_aceler : Form
    {

        double a, v0, v, s, t;
        bool isDefault;

        private void label16_Click(object sender, EventArgs e)
        {

        }



        private void swithcer(object sender, EventArgs e)
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

        bool ab, v0b, vb, sb, tb;

        public Classic_aceler()
        {
            InitializeComponent();
            isDefault = true;
            radioButton1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ab = v0b = vb = sb = tb = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(v0text.Text.Length != 0)
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
                    if(ab)
                    {
                        if(tb)
                        {
                            v = v0 + t * a;
                            s = v0 * t + a * Math.Pow(t, 2) / 2;
                            vb = true;
                            sb = true;
                        }

                        else if(sb)
                        {
                            v = Math.Sqrt(2 * a * s + Math.Pow(v0, 2));
                            t = (v - v0) / a;
                            vb = true;
                            tb = true;
                        }
                    }
                }
            }

            else
            {
                if(!v0b)
                {
                    if(tb)
                    {
                        if(ab)
                        {
                            v0 = v - a * t;
                            s = v0 * t + a * Math.Pow(t, 2) / 2;
                            v0b = sb = true;
                        }
                    }

                    else if(ab && sb)
                    {
                        v0 = Math.Sqrt(Math.Pow(v, 2) - 2 * a * s);
                        t = (v - v0) / a;
                    }
                }

                else
                {
                    if(!sb)
                    {
                        if(tb)
                        {
                            if(ab)
                            {
                                s = v0 * t + a * Math.Pow(t, 2) / 2;
                                sb = true;
                            }
                        }

                        else if(ab)
                        {
                            s = (Math.Pow(v, 2) - Math.Pow(v0, 2)) / (2 * a);
                            t = (v - v0) / a;
                            sb = tb = true;
                        }
                    }

                    else if(!ab)
                    {
                        if(tb)
                        {
                            a = (v - v0) / t;
                            ab = true;
                        }

                        else
                        {
                            a = (Math.Pow(v, 2) - Math.Pow(v0, 2)) / (2 * s);
                            ab = true;
                        }
                    }
                }
            }

            
            if(!tb)
            {
                if(v0b)
                {
                    if(vb)
                    {
                        if(ab)
                        {
                            t = (v - v0) / a;
                            tb = true;
                        }
                    }
                }
            }

            if (!ab)
            {
                if (v0b)
                {
                    if (vb)
                    {
                        if (tb)
                        {
                            a = (v - v0) / t;
                            ab = true;
                        }
                    }
                }
            }



            if(ab && tb && v0b)
            {
                s = v0 * t + a * t / 2;
                sb = true;
            }


            if(ab)
            {
                ares.Text = a.ToString();
            }

            else
            {
                ares.Text = "Нет данных";
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
            
            atext.Text = "";
            ttext.Text = "";
            stext.Text = "";

            if(isDefault)
            {
                v0text.Text = "0";
            }

            else
            {
                v0text.Text = "";
            }

            ab = v0b = vb = sb = tb = false;

        }
    }
}
