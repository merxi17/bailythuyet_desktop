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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        private void ReSet()
        {
            this.txtUser.Text = "";
            this.txtPassword.Text = "";
            this.txtDescription.Text = "";
            
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
