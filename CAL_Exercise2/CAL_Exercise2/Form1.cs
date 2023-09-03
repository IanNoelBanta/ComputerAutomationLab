using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace CAL_Exercise2
{
    public partial class Form1 : Form
    {
        string name = null;
        DateTime dateOfBirth;
        DateTimePicker DOB;
        string preferences = null;
        Regex regex = new Regex("^[a-zA-Z]+$|^$");

        public Form1()
        {
            InitializeComponent();
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
                    name = null;
                }
                else
                {
                    name = textBox1.Text;
                }
            }
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                preferences = "None";
            }
            else
            {
                if (textBox1.Text == "")
                {
                    name = "None";
                }
                else
                {
                    preferences = comboBox1.SelectedItem.ToString()!;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("Star sign: None" + "\n" + "Characteristics: None", "Star sign");
            }
            else
            {
                MessageBox.Show("NAME: " + name + "\n" + "DOB: " + dateOfBirth + "\n" + "Likes: " + preferences, "Summary of your application", MessageBoxButtons.OK);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DOB = new DateTime((DateTimePicker)dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }
    }
}