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
    public partial class common_move : Form
    {
        public common_move()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void Db(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            

            switch (index)
            {
                case 0:
                    lineCommon t = new lineCommon();
                   
                    t.ShowDialog();
                    
                    break;
                case 1:
                    CircleMove y = new CircleMove();
                    
                    y.ShowDialog();
                    
                    break;
            }
        }
    }
}
