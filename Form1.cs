using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//I messed up the name of this project when I initially created it.  I could not get the file name to change back so this is illproperly named project.
//CST - 117 - Exercise5
// Created By: Ray Ketcham
//Date 7/14/2018
//Class: CST-117

namespace Ray_Ketcham_CST_117_ProgrammingProject03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Closes Application
            this.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int piterms;

            //Textbox1 will only accept numbers, characters do nothing and no error output
            if (int.TryParse(textBox1.Text, out piterms))
            {

                //Here lies the variables
                int pi2 = 0;

                double formula;
                double pipi = 0.0;
                double a = 4;
                double b = 1;

                // THe while loops each integer input to  the textbox
                while (++pi2 < piterms - 1)
                {
                    //The value for pi can be approximated with the following sequence 4 – 4 / 3 + 4 / 5 – 4 / 7 + 4 / 9 - … 
                    formula = a / b;
                    a = (a > 0) ? -4.0 : 4.0;
                    b = b + 2;
                    pipi = pipi + formula;
                }

                //Label3 provides the Output # on terms
                //Label2 provides the calulation
                label2.Text = "= " + pipi.ToString();
                label3.Text = "The Approximate value of PI after " + textBox1.Text + " terms";
                }
        }
                //Misclicked this, now the item shows up in the form
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
