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
    public partial class lineCommon : Form
    {
        double v = 0, t = 0, s = 0;
        bool vb = false, tb = false, sb = false;

        private void vres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public lineCommon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                catch(FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
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
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
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
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }

            }


            int counter = 0;

            if (vb == false)
            {
                counter++;
            }

            if (sb == false)
            {
                counter++;
            }

            if(tb == false)
            {
                counter++;
            }

            if(counter > 1)
            {

            }


            else
            {
                if(sb == false)
                {
                    s = v * t;
                    sb = true;
                }

                if (vb == false)
                {
               
                        v = s / t;

                    vb = true;
                }

                if (tb == false)
                {

                      t = s / v;

                    tb = true;
                }


                if (vb)
                {
                    vres.Text = v.ToString();
                }

                else
                {
                    vres.Text = "Нет данных";
                }

                if (sb)
                {
                    sres.Text = s.ToString();
                }

                else
                {
                    sres.Text = "Нет данных";
                }

                if (tb)
                {
                    tres.Text = t.ToString();
                }

                else
                {
                    tres.Text = "Нет данных";
                }


                vtext.Text = "";
                stext.Text = "";
                ttext.Text = "";

                tb = false;
                sb = false;
                vb = false;
            }


        }
    }
}
