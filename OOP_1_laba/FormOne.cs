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
            pbSmile.Image = Image.FromFile("C:\\Миля\\4 семестр\\ООП\\OOP_1_laba\\photo\\smileN.png");
        }

        private void rbSad_CheckedChanged(object sender, EventArgs e)
        {
            pbSmile.Image = Image.FromFile("C:\\Миля\\4 семестр\\ООП\\OOP_1_laba\\photo\\sadN.png");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbColor.SelectedIndex)
            {
                case 0:
                    pbSmile.BackColor = Color.Green;
                    break;
                case 1:
                    pbSmile.BackColor = Color.Blue;
                    break;
                case 2:
                    pbSmile.BackColor = Color.Red;
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
            rtbNumber.Text += lbNumber.SelectedItem;
        }



        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            rtbNumber.Text = "";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbColor.Text == "Green")
            {
                pbSmile.BackColor = Color.Green;
            }
            if (cbColor.Text == "Red")
            {
                pbSmile.BackColor = Color.Red;
            }
            if (cbColor.Text == "Blue")
            {
                pbSmile.BackColor = Color.Blue;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                pbSmile.BackColor = Color.HotPink;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTwo f = new FormTwo();
            f.Show();
        }

        int counterPaint = 0;
        private void FormOne_Paint(object sender, PaintEventArgs e)
        {
            lbPaint.Text = "Количество перерисовок: " + counterPaint.ToString();
            counterPaint++;
        }

        private void FormOne_SizeChanged(object sender, EventArgs e)
        {
            btnGo.Width = this.Width/4;
            sizeLabel.Text = "Размер окна: " + this.Height.ToString() + "x" + this.Width.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index  = clbAdd.SelectedIndex;
            int count = clbAdd.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                    clbAdd.SetItemChecked(x, false);
            }
            if (index != -1)
            {
                llbAdd.Text = clbAdd.Items[index].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAdd.Text != "")
            {
                clbAdd.Items.Add(tbAdd.Text);

            }
        }

        private void llbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbAdd.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ya.ru/?nr=1&redirect_ts=1677645185.85743&utm_referrer=https%3A%2F%2Fyandex.ru%2F");
        }

        private void pbSmile_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tbSearch.Text);
        }
    }
}
