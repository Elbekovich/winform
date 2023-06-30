using Jumakulov777.oyna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumakulov777
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\Public\\login.txt";

            FileInfo fileInfo = new FileInfo(path);
            {

                {
                    if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox1.Text.ToString().EndsWith("@gmail.com") && textBox2.TextLength >= 8 && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
                    {
                        using (StreamWriter sw = fileInfo.CreateText())
                        {
                            sw.WriteLine(textBox1.Text);
                            sw.WriteLine(textBox2.Text);
                            sw.WriteLine(textBox3.Text);
                            sw.WriteLine(textBox4.Text);
                            using (Turkish_food d = new Turkish_food())
                            {
                                this.Hide();
                                d.ShowDialog();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("To'g'ri kiriting", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign s = new sign();
            s.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 15;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 15;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 16;
        }
    }
}
