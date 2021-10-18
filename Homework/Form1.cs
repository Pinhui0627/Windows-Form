using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Restart()
        {
            label3.Text = "0";
            label4.Text = "0";
            label8.Text = "100";
            textBox1.Text = "10";
        }

        private void board_end()
        {
            int b = int.Parse(label8.Text);
            if (b <= 0)
            {
                MessageBox.Show("籌碼不足" + '\n' + "將重新開始遊戲");
                Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computer = random.Next(1, 100);
            int user = random.Next(1, 100);
            label4.Text = user.ToString();
            label3.Text = computer.ToString();

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(label8.Text);
            int c;
            if (user > computer)//如果使用者投擲出來的數字比電腦大
            {
                c = a + b;
                label8.Text = c.ToString();
                MessageBox.Show("你贏了");
            }
            else if (user == computer) { MessageBox.Show("平手"); }
            else
            {
                c = b - a;
                label8.Text = c.ToString();
                MessageBox.Show("你輸了");
            }
            board_end();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int computer = random.Next(1, 100);
            int user = random.Next(1, 100);
            label4.Text = user.ToString();
            label3.Text = computer.ToString();

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(label8.Text);
            int c;

            if (user < computer)
            {
                c = a + b;
                label8.Text = c.ToString();
                MessageBox.Show("你贏了");
            }
            else if (user == computer) { MessageBox.Show("平手"); }
            else
            {
                c = b - a;
                label8.Text = c.ToString();
                MessageBox.Show("你輸了");
            }
            board_end();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
