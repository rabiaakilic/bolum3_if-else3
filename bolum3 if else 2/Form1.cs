using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum3_if_else_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbKirmizi_Click(object sender, EventArgs e)
        {
            if (cbKirmizi.Checked)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }

            
           
            

        }

        private void cbSari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSari.Checked)
            {
                this.BackColor= Color.Yellow;
            }
            else
            {
                this.BackColor =Color.White;
            }
        }

        private void cbSiyah_Click(object sender, EventArgs e)
        {
            if (cbSiyah.Checked)
            {
                this.BackColor =Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbMavi_Click(object sender, EventArgs e)
        {
            if (cbMavi.Checked)
            {
                this.BackColor=Color.Blue;

            }
            else
            {
                this.BackColor=Color.White;
            }
        }

        private void cbPembe_Click(object sender, EventArgs e)
        {
            if (cbPembe.Checked)
            {
                this.BackColor=Color.Pink;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
