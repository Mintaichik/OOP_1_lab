using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1_laba
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiForms_Click(object sender, EventArgs e)
        {

        }

        private void tsmFormOne_Click(object sender, EventArgs e)
        {
            FormOne f = new FormOne();
            f.Show();
        }

        private void tsmFormTwo_Click(object sender, EventArgs e)
        {
            FormTwo f = new FormTwo();
            f.Show();
        }

        private void tsmiAboutProgram_Click(object sender, EventArgs e)
        {
            FormAboutProgram f = new FormAboutProgram();
            f.Show();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //menuStrip1.Size++;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
