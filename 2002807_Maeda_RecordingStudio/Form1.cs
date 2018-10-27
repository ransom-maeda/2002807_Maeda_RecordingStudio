using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_RecordingStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput1.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(nameInput2.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(nameInput3.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(minutesInput1.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(minutesInput2.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(minutesInput3.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                int minutes1 = Int32.Parse(minutesInput1.Text);
                int minutes1Output = ((minutes1 * 200) / 60);
                int minutes2 = Int32.Parse(minutesInput2.Text);
                int minutes2Output = ((minutes2 * 200) / 60);
                int minutes3 = Int32.Parse(minutesInput3.Text);
                int minutes3Output = ((minutes3 * 200) / 60);
                output.Text = "Group Name 1 - " + nameInput1.Text + "          Group 1 Charge - " + minutes1Output +
                    Environment.NewLine + "Group Name 2 - " + nameInput2.Text + "          Group 2 Charge - " + minutes2Output + Environment.NewLine +
                    "Group Name 3 - " + nameInput3.Text + "          Group 3 Charge - " + minutes3Output;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Clear();
            minutesInput1.Clear();
            minutesInput2.Clear();
            minutesInput3.Clear();
            nameInput1.Clear();
            nameInput2.Clear();
            nameInput3.Clear();
        }
    }
}
