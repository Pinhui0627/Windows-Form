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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Hello" && textBox2.Text == "123")
            {
                MessageBox.Show("登入成功!");
                Menu bForm = new Menu();
                bForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登入失敗", "請確認帳號或密碼是否有誤", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text == "Hello" && textBox2.Text == "123")
                {
                    MessageBox.Show("登入成功!");
                    Menu bForm = new Menu();
                    bForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登入失敗", "請確認帳號或密碼是否有誤", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
    }
}
