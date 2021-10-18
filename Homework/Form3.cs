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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "理解";
            radioButton1.Text = "comprehension";
            radioButton2.Text = "conversation";

            groupBox2.Text = "cherish";
            radioButton3.Text = "懷念";
            radioButton4.Text = "櫻桃";

            groupBox3.Text = "initiative";
            radioButton5.Text = "主導權";
            radioButton6.Text = "創始";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string s = "";
            if (radioButton1.Checked && radioButton3.Checked && radioButton5.Checked)
            {
                sum = 100;
            }
            else if (radioButton1.Checked && radioButton3.Checked)
            {
                sum = 60;
                s = "initiative:主導權";
            }
            else if (radioButton3.Checked && radioButton5.Checked)
            {
                sum = 60;
                s = "理解:comprehension";
            }
            else if (radioButton1.Checked && radioButton5.Checked)
            {
                sum = 60;
                s = "cherish:懷念";
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton5.Checked)
            {
                if (radioButton1.Checked)
                {
                    s = "cherish:懷念" + '\n' +"initiative:主導權";
                }
                else if (radioButton3.Checked)
                {
                    s = "理解:comprehension"+ '\n' + "initiative:主導權";
                }
                else if (radioButton5.Checked)
                {
                    s = "理解:comprehension" + '\n' + "cherish:懷念";
                }
                sum = 30;
            }
            else
            {
                sum = 0;
                s = "理解:comprehension" + '\n' + "cherish:懷念" + '\n' + "initiative:主導權";
            }
            if (sum == 100)
            {
                MessageBox.Show("恭喜您獲得100分!");
            }
            else
            {
                MessageBox.Show("您的分數為" + sum + '\n' + s);
            }

            foreach (RadioButton r in groupBox1.Controls)
                r.Checked = false;
            foreach (RadioButton r in groupBox2.Controls)
                r.Checked = false;
            foreach (RadioButton r in groupBox3.Controls)
                r.Checked = false;
        }
    }
}
