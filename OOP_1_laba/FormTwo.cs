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
    public partial class FormTwo : Form
    {
        public FormTwo()
        {
            InitializeComponent();
        }

        private void FormTwo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();

                ((System.ComponentModel.ISupportInitialize)(pic)).BeginInit();

                pic.BackColor = System.Drawing.Color.Transparent;
                pic.ImageLocation = "C:\\Миля\\4 семестр\\ООП\\OOP_1_laba\\photo\\snowchik.png";
                pic.Location = new System.Drawing.Point(e.X - pic.Size.Width / 2, e.Y - pic.Size.Height / 2);
                pic.Size = new System.Drawing.Size(50, 50);
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pic.TabIndex = 3;
                pic.WaitOnLoad = true;
                pic.Click += new System.EventHandler(pic_Click);

                ((System.ComponentModel.ISupportInitialize)(pic)).EndInit();
                this.Controls.Add(pic);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as PictureBox);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDate.Checked == true)
            {
                lbDate.Visible = true;
            }
            else
            {
                lbDate.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString();
        }
    }
}
