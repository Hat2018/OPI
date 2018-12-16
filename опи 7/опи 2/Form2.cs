using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace опи_2
{
    public partial class Form2 : Form
    {
        ImageDocument img = new ImageDocument();//abstract
        public Form2()
        {
            InitializeComponent();
            img.pBox = pictureBox1;
        }
        //int count = 0;
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

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationWithImage operations = new OpenImage();
            operations.operation(img);
            pictureBox1.Visible = true;
        }

        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationWithImage operations = new ClearImage();
            operations.operation(img);
            pictureBox1.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

