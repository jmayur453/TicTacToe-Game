using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//new **********************************************************************************       
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int count = 0;
        int[,] a = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            label8.Visible = false;
        }
        public void CheckWin(int [,]c)
        {
            if (c[0, 0] == 1 && c[0, 1] == 1 && c[0, 2] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 0] == 2 && c[0, 1] == 2 && c[0, 2] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[1, 0] == 1 && c[1, 1] == 1 && c[1, 2] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[1, 0] == 2 && c[1, 1] == 2 && c[1, 2] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[2, 0] == 1 && c[2, 1] == 1 && c[2, 2] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[2, 0] == 2 && c[2, 1] == 2 && c[2, 2] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[0, 0] == 1 && c[1, 0] == 1 && c[2, 0] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 0] == 2 && c[1, 0] == 2 && c[2, 0] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[0, 1] == 1 && c[1, 1] == 1 && c[2, 1] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 1] == 2 && c[1, 1] == 2 && c[2, 1] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[0, 2] == 1 && c[1, 2] == 1 && c[2, 2] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 2] == 2 && c[1, 2] == 2 && c[2, 2] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[0, 0] == 1 && c[1, 1] == 1 && c[2, 2] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 0] == 2 && c[1, 1] == 2 && c[2, 2] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (c[0, 2] == 1 && c[1, 1] == 1 && c[2, 0] == 1) MessageBox.Show(textBox1.Text + " is WINNER");
            else if (c[0, 2] == 2 && c[1, 1] == 2 && c[2, 0] == 2) MessageBox.Show(textBox2.Text + " is WINNER");

            else if (count == 9)
            {
                MessageBox.Show("Match Draw");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button12.Enabled = false;
            button10.Enabled = false;
            if (textBox1.Text == "") textBox1.Text = "Player 1";
            if (textBox2.Text == "") textBox2.Text = "Player 2";
            panel1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button10.Enabled = true;
            button12.Enabled = true;
            label8.Visible = false;
            panel1.Visible = false;
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
            count = 0;
            Array.Clear(a, 0, a.Length);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button1.BackgroundImage = Properties.Resources.oooo;
                a[0, 0] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.cross_png_25669;
                a[0, 0] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button2.BackgroundImage = Properties.Resources.oooo;
                a[0, 1] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button2.BackgroundImage = Properties.Resources.cross_png_25669;
                a[0, 1] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button3.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button3.BackgroundImage = Properties.Resources.oooo;
                a[0, 2] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.cross_png_25669;
                a[0, 2] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button4.BackgroundImage = Properties.Resources.oooo;
                a[1, 0] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button4.BackgroundImage = Properties.Resources.cross_png_25669;
                a[1, 0] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button5.BackgroundImage = Properties.Resources.oooo;
                a[1, 1] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.cross_png_25669;
                a[1, 1] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button6.BackgroundImage = Properties.Resources.oooo;
                a[1, 2] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button6.BackgroundImage = Properties.Resources.cross_png_25669;
                a[1, 2] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button7.BackgroundImage = Properties.Resources.oooo;
                a[2, 0] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.cross_png_25669;
                a[2, 0] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button8.BackgroundImage = Properties.Resources.oooo;
                a[2, 1] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button8.BackgroundImage = Properties.Resources.cross_png_25669;
                a[2, 1] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackgroundImage != null) return;
            if (count % 2 == 0)
            {
                button9.BackgroundImage = Properties.Resources.oooo;
                a[2, 2] = 1;
                count++;
                if (count >= 5) CheckWin(a);
            }
            else
            {
                button9.BackgroundImage = Properties.Resources.cross_png_25669;
                a[2, 2] = 2;
                count++;
                if (count >= 5) CheckWin(a);
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
