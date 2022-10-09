using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avgValues
{
    public partial class Form1 : Form
    {
        double average;
        double num;
        double runningTotal;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void numInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                num = Convert.ToDouble(numInput.Text);

                if (num >= 1)
                {
                    runningTotal += num;
                    count++;
                }

                average = runningTotal / count;

                numInput.Text = "";

                outputLabel.Text = $"{num} was added to the sum";

                if (num == 0)
                {
                    string.Format("{0:0.00}", average);
                    outputLabel.Text = $"The average of all numbers entered is: {average}";
                    
                }

                
            }
            catch (Exception ex) 
            { 
                numInput.Visible = false;
                outputLabel.Visible = false;
                addButton.Visible = false;
                titleLabel.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numInput.Text = "";
            outputLabel.Text = "";
            numInput.Visible = true;
            outputLabel.Visible = true;
            addButton.Visible = true;
            titleLabel.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            num = 0;
            runningTotal = 0;
            count = 0;

            //addButton_Click(sender, e);

        }
    }
}