using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "";
        }
        int a = 0;
        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("確定將此檔關閉，另開新檔?","確認關閉",MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                Form f = new Form2();
                this.Close();
                f.Show();
            }

        }

        private void 新增視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            toolStripStatusLabel2.Text = "開新視窗";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            a++;
            toolStripStatusLabel1.Text = "字數:" + a + "";
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            openFileDialog1.Filter = "純文字檔案(.rtf/.txt)|*.rtf;*txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = Path.GetExtension(openFileDialog1.FileName);
                if (a == ".rtf" || a == ".txt")
                {
                    FileInfo f = new FileInfo(openFileDialog1.FileName);
                    StreamReader sr = f.OpenText();
                    while (sr.Peek() >= 0)
                    {
                        richTextBox1.Text += sr.ReadLine() + '\n';
                    }
                    sr.Close();
                }
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "純文字檔案(.rtf)|*.rtf*|純文字檔案(.txt)|*.txt";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileInfo f = new FileInfo(saveFileDialog1.FileName);
            StreamWriter sw = f.AppendText();
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 其他字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r= fontDialog1.ShowDialog();
            if(r==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 微軟正黑體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f = int.Parse(richTextBox1.SelectionFont.Size.ToString());
            richTextBox1.SelectionFont = new Font("微軟正黑體",f);
        }

        private void 新細明體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f = int.Parse(richTextBox1.SelectionFont.Size.ToString());
            richTextBox1.SelectionFont = new Font("新細明體", f);
        }

        private void 標楷體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f = int.Parse(richTextBox1.SelectionFont.Size.ToString());
            richTextBox1.SelectionFont = new Font("標楷體", f);
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void 其他色彩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string f = richTextBox1.SelectionFont.FontFamily.ToString();
            richTextBox1.SelectionFont = new Font(f,8);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string f = richTextBox1.SelectionFont.FontFamily.ToString();
            richTextBox1.SelectionFont = new Font(f, 12);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string f = richTextBox1.SelectionFont.FontFamily.ToString();
            richTextBox1.SelectionFont = new Font(f, 16);
        }

        private void 其他大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 深色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.DarkBlue;
        }

        private void 淺色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.LightYellow;
        }

        private void 明亮色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Aqua;
        }

        private void 其他色彩ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void 全部清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        
    }
}
