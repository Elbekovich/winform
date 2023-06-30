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
namespace Jumakulov777.oyna
{
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\\Users\\Public\\login.txt";
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        List<string> myArray = new List<string>();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            myArray.Add(line);
                        }
                        if (myArray[0] == textBox1.Text.ToString() && myArray[1] == textBox2.Text.ToString())
                        {
                            this.Hide();
                            Turkish_food turk = new Turkish_food();
                            turk.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Parol yoki loginni xato kiritdingiz!","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                            
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ro'yhatdan o'tmagansiz");

            }
        }

        private void sign_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 15;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
