using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bailythuyet
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdnam.Checked)
            {
                MessageBox.Show("Giới tính bạn là:"+rdnam.Text);
            }    
        }

        private void rdnu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdnu.Checked)
            {
                MessageBox.Show("Giới tính bạn là:" + rdnu.Text);
            }
        }
    }
}
