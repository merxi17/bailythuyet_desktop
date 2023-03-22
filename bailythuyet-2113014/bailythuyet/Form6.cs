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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void chkMauchu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMauchu.Checked)
            {
                this.button1.ForeColor = Color.Red;
            }
            else
                this.button1.ForeColor = Color.Red;
        }

   

        private void rdpopup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdpopup.Checked)
                this.button2.FlatStyle = FlatStyle.Popup;
            else
                this.button2.FlatStyle = FlatStyle.Flat;
        }

        private void rdflat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdflat.Checked)
                this.button2.FlatStyle = FlatStyle.Flat;
            else
                this.button2.FlatStyle = FlatStyle.Popup;
        }

        private void chkMaunen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMaunen.Checked)
                this.button1.BackColor = Color.LightCyan;
            else
                this.button1.BackColor = this.button2.BackColor;
        }
    }
}
