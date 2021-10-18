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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 bForm = new Form1();
            bForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            bForm.Show();
            this.Hide();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 bForm = new Form2();
            bForm.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            bForm.Show();
            this.Hide();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 bForm = new Form3();
            bForm.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
            bForm.Show();
            this.Hide();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 bForm = new Form4();
            bForm.FormClosed += new FormClosedEventHandler(Form4_FormClosed);
            bForm.Show();
            this.Hide();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = MessageBox.Show("確認要關閉視窗嗎?", "關閉視窗", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                MessageBox.Show("See ya~");
                e.Cancel = false;
            }
            else if(a == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
