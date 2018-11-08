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
        //declares the group amount variable, which counts how many groups there are
        int groupAmount;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                MessageBox.Show("Please enter a value");
            }
            else if (string.IsNullOrWhiteSpace(minutesInput.Text))
            {
                MessageBox.Show("Please enter a value");
            }

            else
            {
                groupAmount++;
                string totalGroups = groupAmount.ToString();
                int minutes = int.Parse(minutesInput.Text);
                int minutesOutput = ((minutes * 200) / 60);
                int average = ((minutesOutput) / 3);
                int total = minutesOutput * groupAmount;
                totalCharge.Text = total.ToString("C");
                averageCharge.Text = average.ToString("C");
                groupNumber.Text = totalGroups.ToString();
                singleCharge.Text = minutesOutput.ToString("C");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            minutesInput.Clear();
            nameInput.Clear();
        }
    }
}
