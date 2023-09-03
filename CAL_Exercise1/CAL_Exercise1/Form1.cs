using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;

namespace CAL_Exercise1
{
    public partial class Form1 : Form
    {
        string textBox1Content = null;
        string textBox2Content = null;
        DialogResult dialogResult;
        Regex regex = new Regex("^[a-zA-Z]+$|^$");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Invalid Input. Please try again.", "Invalid Input", MessageBoxButtons.OK);
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1Content = null;
                }
                else
                {
                    textBox1Content = textBox1.Text;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2Content = null;
            }
            else
            {
                textBox2Content = textBox2.Text;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            checkKeyDown(sender, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            checkKeyDown(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1Content == null && textBox2Content == null)
            {
                MessageBox.Show("Star sign: None" + "\n" + "Characteristics: None", "Star sign");
            }
            else if (textBox1Content == null || textBox2Content == null)
            {
                if (textBox1Content == null)
                {
                    MessageBox.Show("Star sign: None" + "\n" + "Characteristics: " + textBox2Content, "Star sign");
                }
                else
                {
                    MessageBox.Show("Star sign: " + textBox1Content + "\n" + "Characteristics: None", "Star sign");
                }

            }
            else
            {
                MessageBox.Show("Star sign: " + textBox1Content + "\n" + "Characteristics: " + textBox2Content, "Star sign");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1Content != null || textBox2Content != null)
            {
                dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exiting", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Dispose();
                }
            }
            else
            {
                Dispose();
            }

            
        }

        public void checkKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                button2.Focus();
            }
        }
        // wala lang hehe try lang hehe
    }
}