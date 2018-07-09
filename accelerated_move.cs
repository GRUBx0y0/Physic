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
    public partial class accelerated_move : Form
    {
        public accelerated_move()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CH_Theme(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            switch(index)
            {
                case 0:
                    Classic_aceler t = new Classic_aceler();
                    
                    t.ShowDialog();
                   
                    break;

                case 1:
                    FreeFall f0 = new FreeFall();
                    f0.ShowDialog();
                    break;

                case 2:
                    ThrowMove f1 = new ThrowMove();
                    f1.ShowDialog();
                    break;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
