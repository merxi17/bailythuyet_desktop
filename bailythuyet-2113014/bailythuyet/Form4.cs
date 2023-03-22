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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int itemselect = Lbdanhsach.SelectedItems.Count - 1;
            for(int i=itemselect;i>=0;i--)
            {
                Lbdanhsachchon.Items.Add(Lbdanhsach.SelectedItems[i]);
                Lbdanhsach.Items.RemoveAt(Lbdanhsach.SelectedIndices[i]);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = Lbdanhsachchon.SelectedItems.Count - 1;
            while (i >= 0)
                Lbdanhsachchon.Items.RemoveAt(Lbdanhsachchon.SelectedIndices[i]);
            i--;
        }
    }
}
