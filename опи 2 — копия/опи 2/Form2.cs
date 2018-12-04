using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace опи_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = Form1.getInstance();
            f.MdiParent = this;
            f.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                Form1.countWindows--;
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach(Form f in form)
            {
                f.Close();
                Form1.countWindows = 0;
            }
        }
    }
}
