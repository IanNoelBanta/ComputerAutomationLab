using Microsoft.Win32;
using System.Security.Cryptography.Xml;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CAL_Exercise2
{
    public partial class Form1 : Form
    {
        string name = null;
        string dateOfBirth = DateTime.Now.ToString("dd/MM/yyyy");
        string preferences = null;
        Regex regex = new Regex("^[a-zA-Z]+$|^$");
        DialogResult dialogResult;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (name == null && preferences == null)
            {
                MessageBox.Show("NAME: None" + "\n" + "DOB: " + dateOfBirth + "\n" + "LIKES: None", "Summary of your application", MessageBoxButtons.OK);
            }
            else if (name == null || preferences == null)
            {
                if (name == null)
                {
                    MessageBox.Show("NAME: None" + "\n" + "DOB: " + dateOfBirth + "\n" + "LIKES: " + preferences, "Summary of your application", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("NAME: " + name + "\n" + "DOB: " + dateOfBirth + "\n" + "LIKES: None", "Summary of your application", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("NAME: " + name + "\n" + "DOB: " + dateOfBirth + "\n" + "LIKES: " + preferences, "Summary of your application", MessageBoxButtons.OK);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirth = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            preferences = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name != null || preferences != null)
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
    }
}