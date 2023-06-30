using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Jumakulov777.oyna
{
    public partial class Turkish_food : Form
    {
        public Turkish_food()
        {
            InitializeComponent();
        }
        public int jami_summa = 0;
        public int son1 = 0;
        public int son2 = 0;
        public int son3 = 0;
        public int son4 = 0;
        public int son5 = 0;
        public int son6 = 0;
        public int son7 = 0;
        public int son8 = 0;
        public int son9 = 0;
        public int son10 = 0;
        public int son11 = 0;
        public int son12 = 0;
        private void label29_Click(object sender, EventArgs e)
        {

        }
        private void label31_Click(object sender, EventArgs e)
        {

        }
        private void label32_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label28_Click(object sender, EventArgs e)
        {

        }
        private void label26_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label39_Click(object sender, EventArgs e)
        {

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void label40_Click(object sender, EventArgs e)
        {

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Turkish_food_Load(object sender, EventArgs e)
        {

        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            string path1 = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "ozodbek_dostavka777.txt";
            string path = Path.Combine(path1, filename);
            //string path = "C:\\Users\\Public\\buyurtma.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                    {
                        richTextBox1.Text = (temp.GetString(b, 0, readLen));
                    }
                }
            }
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void richTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar);
            e.Handled = !char.IsNumber(e.KeyChar);
            e.Handled = !char.IsSymbol(e.KeyChar);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "ozodbek_dostavka777.txt";
            string path = Path.Combine(path1, filename);
            //string path = "C:\\Users\\Public\\buyurtma.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                using (StreamWriter sw = fileInfo.AppendText())
                {       
                    string satr = textBox3.Text.ToString();
                    if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && satr.EndsWith("@gmail.com") && textBox4.TextLength == 12 && textBox4.Text.ToString().StartsWith("998") && textBox5.Text != string.Empty)
                    {
                        sw.WriteLine("Name = " + textBox1.Text);
                        sw.WriteLine("Surname = " + textBox2.Text);
                        sw.WriteLine("EMail = " + textBox3.Text);
                        sw.WriteLine("NUmber = " + textBox4.Text);
                        sw.WriteLine("Address = " + textBox5.Text);
                        
                        if (checkBox1.Checked)
                        {
                            sw.WriteLine("Koftening narxi = " + numericUpDown1.Value * 170);
                            son1 = Convert.ToInt32(numericUpDown1.Value*170);
                        }
                        if (checkBox2.Checked)
                        {
                            sw.WriteLine("Börek narxi = " + numericUpDown2.Value * 135);
                            son2 = Convert.ToInt32(numericUpDown2.Value*135);
                        }
                        if (checkBox3.Checked)
                        {
                            sw.WriteLine("Çöp şiş narxi = " + numericUpDown3.Value * 183);
                            son3 = Convert.ToInt32(numericUpDown3.Value * 183);
                        }
                        if (checkBox4.Checked)
                        {
                            sw.WriteLine("Kebab narxi = " + numericUpDown4.Value * 166);
                            son4 = Convert.ToInt32(numericUpDown4.Value * 166);
                        }
                        if (checkBox5.Checked)
                        {
                            sw.WriteLine("Turşu narxi = " + numericUpDown5.Value * 150);
                            son5 = Convert.ToInt32(numericUpDown5.Value * 150);
                        }
                        if (checkBox6.Checked)
                        {
                            sw.WriteLine("Donar narxi = " + numericUpDown6.Value * 95);
                            son6 = Convert.ToInt32(numericUpDown6.Value * 95);
                        }
                        if (checkBox7.Checked)
                        {
                            sw.WriteLine("Pide narxi = " + numericUpDown7.Value * 130);
                            son7 = Convert.ToInt32(numericUpDown7.Value * 130);
                        }
                        if (checkBox8.Checked)
                        {
                            sw.WriteLine("Simit narxi = " + numericUpDown8.Value * 110);
                            son8 = Convert.ToInt32(numericUpDown8.Value * 110);
                        }
                        if (checkBox9.Checked)
                        {
                            sw.WriteLine("Dolma narxi = " + numericUpDown9.Value * 200);
                            son9 = Convert.ToInt32(numericUpDown9.Value * 200);
                        }
                        if (checkBox10.Checked)
                        {
                            sw.WriteLine("Kumpir narxi = " + numericUpDown10.Value * 135);
                            son10 = Convert.ToInt32(numericUpDown10.Value * 135);
                        }
                        if (checkBox11.Checked)
                        {
                            sw.WriteLine("Ekmek narxi = " + numericUpDown11.Value * 190);
                            son11 = Convert.ToInt32(numericUpDown11.Value * 190);
                        }
                        if (checkBox12.Checked)
                        {
                            sw.WriteLine("Cig Kofte narxi = " + numericUpDown12.Value * 170);
                            son12 = Convert.ToInt32(numericUpDown12.Value * 170);
                        }
                        /////
                        Random rnd = new Random();
                        sw.WriteLine("Buyurtma raqami = " + rnd.Next(1000, 9999));
                        /////

                        jami_summa = son1 + son2 + son3 + son4 + son5 + son6 + son7+son8+son9+son10+son11+son12;
                        sw.WriteLine("Jami summa = " + jami_summa);
                        sw.WriteLine("--------------------------------------------------------------");
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        textBox4.Text = string.Empty;
                        textBox5.Text = string.Empty;
                        
                        checkBox1.Checked = false;
                        numericUpDown1.Value = 0;
                        
                        checkBox2.Checked = false;
                        numericUpDown2.Value = 0;

                        checkBox3.Checked = false;
                        numericUpDown3.Value = 0;

                        checkBox4.Checked = false;
                        numericUpDown4.Value = 0;

                        checkBox5.Checked = false;
                        numericUpDown5.Value = 0;

                        checkBox6.Checked = false;
                        numericUpDown6.Value = 0;

                        checkBox7.Checked = false;
                        numericUpDown7.Value = 0;

                        checkBox8.Checked = false;
                        numericUpDown8.Value = 0;

                        checkBox9.Checked = false;
                        numericUpDown9.Value = 0;

                        checkBox10.Checked = false;
                        numericUpDown10.Value = 0;

                        checkBox11.Checked = false;
                        numericUpDown11.Value = 0;

                        checkBox12.Checked = false;
                        numericUpDown12.Value = 0;
                    }

                    else
                    {
                        MessageBox.Show("Iltimos to'g'ri kiriting","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = fileInfo.CreateText())
                {
                    string satr = textBox3.Text.ToString();
                    if (textBox1.Text != string.Empty && textBox2.Text!=string.Empty && satr.EndsWith("@gmail.com") && textBox4.TextLength==12 && textBox4.Text.ToString().StartsWith("998") && textBox5.Text!=string.Empty)
                    {
                        sw.WriteLine("Name = " + textBox1.Text);
                        sw.WriteLine("Surname = " + textBox2.Text);
                        sw.WriteLine("EMail = " + textBox3.Text);
                        sw.WriteLine("NUmber = " + textBox4.Text);
                        sw.WriteLine("Address = " + textBox5.Text);
                        
                        if (checkBox1.Checked)
                        {
                            sw.WriteLine("Koftening narxi = " + numericUpDown1.Value * 170);
                            son1 = Convert.ToInt32(numericUpDown1.Value * 170);
                        }
                        if (checkBox2.Checked)
                        {
                            sw.WriteLine("Börek narxi = " + numericUpDown2.Value * 135);
                            son2 = Convert.ToInt32(numericUpDown2.Value * 135);
                        }
                        if (checkBox3.Checked)
                        {
                            sw.WriteLine("Çöp şiş narxi = " + numericUpDown3.Value * 183);
                            son3 = Convert.ToInt32(numericUpDown3.Value * 183);
                        }
                        if (checkBox4.Checked)
                        {
                            sw.WriteLine("Kebab narxi = " + numericUpDown4.Value * 166);
                            son4 = Convert.ToInt32(numericUpDown4.Value * 166);
                        }
                        if (checkBox5.Checked)
                        {
                            sw.WriteLine("Turşu narxi = " + numericUpDown5.Value * 150);
                            son5 = Convert.ToInt32(numericUpDown5.Value * 150);
                        }
                        if (checkBox6.Checked)
                        {
                            sw.WriteLine("Donar narxi = " + numericUpDown6.Value * 95);
                            son6 = Convert.ToInt32(numericUpDown6.Value * 95);
                        }
                        if (checkBox7.Checked)
                        {
                            sw.WriteLine("Pide narxi = " + numericUpDown7.Value * 130);
                            son7 = Convert.ToInt32(numericUpDown7.Value * 130);
                        }
                        if (checkBox8.Checked)
                        {
                            sw.WriteLine("Simit narxi = " + numericUpDown8.Value * 110);
                            son8 = Convert.ToInt32(numericUpDown8.Value * 110);
                        }
                        if (checkBox9.Checked)
                        {
                            sw.WriteLine("Dolma narxi = " + numericUpDown9.Value * 200);
                            son9 = Convert.ToInt32(numericUpDown9.Value * 200);
                        }
                        if (checkBox10.Checked)
                        {
                            sw.WriteLine("Kumpir narxi = " + numericUpDown10.Value * 135);
                            son10 = Convert.ToInt32(numericUpDown10.Value * 135);
                        }
                        if (checkBox11.Checked)
                        {
                            sw.WriteLine("Ekmek narxi = " + numericUpDown11.Value * 190);
                            son11 = Convert.ToInt32(numericUpDown11.Value * 190);
                        }
                        if (checkBox12.Checked)
                        {
                            sw.WriteLine("Cig Kofte narxi = " + numericUpDown12.Value * 170);
                            son12 = Convert.ToInt32(numericUpDown12.Value * 170);
                        }
                        /////
                        Random rnd = new Random();
                        sw.WriteLine("Buyurtma raqami = " + rnd.Next(1000, 9999));
                        /////

                        jami_summa = son1 + son2 + son3 + son4 + son5 + son6 + son7 + son8 + son9 + son10 + son11 + son12;
                        sw.WriteLine("Jami summa = " + jami_summa);
                        sw.WriteLine("--------------------------------------------------------------");
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        textBox4.Text = string.Empty;
                        textBox5.Text = string.Empty;

                        checkBox1.Checked = false;
                        numericUpDown1.Value = 0;

                        checkBox2.Checked = false;
                        numericUpDown2.Value = 0;

                        checkBox3.Checked = false;
                        numericUpDown3.Value = 0;

                        checkBox4.Checked = false;
                        numericUpDown4.Value = 0;

                        checkBox5.Checked = false;
                        numericUpDown5.Value = 0;

                        checkBox6.Checked = false;
                        numericUpDown6.Value = 0;

                        checkBox7.Checked = false;
                        numericUpDown7.Value = 0;

                        checkBox8.Checked = false;
                        numericUpDown8.Value = 0;

                        checkBox9.Checked = false;
                        numericUpDown9.Value = 0;

                        checkBox10.Checked = false;
                        numericUpDown10.Value = 0;

                        checkBox11.Checked = false;
                        numericUpDown11.Value = 0;

                        checkBox12.Checked = false;
                        numericUpDown12.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Iltimos to'g'ri kiriting ","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string path1 = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "ozodbek_dostavka777.txt";
            string path = Path.Combine(path1, filename);
            //string path = "C:\\Users\\Public\\buyurtma.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                    {
                        richTextBox1.Text = (temp.GetString(b, 0, readLen));
                    }
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            string path1 = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "ozodbek_dostavka777.txt";
            string path = Path.Combine(path1, filename);
            //string path = "C:\\Users\\Public\\buyurtma.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar);
            e.Handled = !char.IsNumber(e.KeyChar);
            e.Handled = !char.IsSymbol(e.KeyChar);
            e.Handled = !char.IsControl(e.KeyChar);
            e.Handled = !char.IsUpper(e.KeyChar);
            e.Handled = !char.IsLower(e.KeyChar);
            e.Handled = !char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsPunctuation(e.KeyChar);
            e.Handled = !char.IsSurrogate(e.KeyChar);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 15;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
