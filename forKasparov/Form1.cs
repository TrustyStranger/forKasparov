using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox2.Text);
            float b = Convert.ToInt32(textBox3.Text);
            string c = (a / b).ToString();


            richTextBox1.AppendText(textBox1.Text + "\n");
            richTextBox2.AppendText(textBox2.Text + "\n");
            richTextBox3.AppendText(textBox3.Text + "\n");
            richTextBox4.AppendText(c + "\n");
            richTextBox5.AppendText(textBox4.Text + "\n");
            richTextBox6.AppendText(textBox7.Text + "\n");
            richTextBox7.AppendText(textBox8.Text + "\n");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nCount = Convert.ToInt32(textBox4.Text);
                int nACount = Convert.ToInt32(textBox6.Text);
                textBox7.Text = (nCount * nACount).ToString();
                float aNCount = nCount * nACount;
                float aATurn = Convert.ToInt32(textBox5.Text);
                aATurn += Convert.ToInt32(textBox9.Text);
                textBox8.Text = ((aNCount * 2) / aATurn).ToString();
            }
            catch
            {
                MessageBox.Show("Input for neutral territories must be a number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox11.Text);
            int b = Convert.ToInt32(textBox12.Text);
            int c = a +  b;
            textBox12.Text = c.ToString();
            richTextBox8.AppendText(textBox10.Text + "\n");
            richTextBox9.AppendText(textBox11.Text + "\n");
            textBox10.Clear();
            textBox11.Clear();

        }
    }
}
