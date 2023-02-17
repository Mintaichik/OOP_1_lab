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
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }
        

        private void rbHappy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Миля\\4 семестр\\ООП\\OOP_1_laba\\photo\\smileN.png");
        }

        private void rbSad_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Миля\\4 семестр\\ООП\\OOP_1_laba\\photo\\sadN.png");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.BackColor = Color.Green;
                    break;
                case 1:
                    pictureBox1.BackColor = Color.Blue;
                    break;
                case 2:
                    pictureBox1.BackColor = Color.Red;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = dateTimePicker1.Value;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = monthCalendar1.TodayDate;
            dateTimePicker1.Value = monthCalendar1.TodayDate;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += listBox1.SelectedItem;
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Green")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Red")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Blue")
            {
                pictureBox1.BackColor = Color.Blue;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                pictureBox1.BackColor = Color.HotPink;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTwo f = new FormTwo();
            f.Show();
        }

        private void FormOne_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
