using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public int Letter_exception()
        {

            
            for (int i = 0; i < first.TextLength; i++)
            {
                if (char.IsLetter(first.Text[i]))
                {
                    MessageBox.Show("Invalid Input!!!");
                    first.Clear(); second.Clear(); first.Focus();
                    return 0;
                    
                }
                


            }
            for (int i = 0;i < second.TextLength; i++)
            {
                if (char.IsLetter(second.Text[i]))
                {
                    MessageBox.Show("Invalid Input!!!");
                    first.Clear(); second.Clear(); first.Focus();
                    return 0;

                }
            }
            
            return 1;
        }


            private void button1_Click_1(object sender, EventArgs e) 
        {
            first.Focus();

            if (String.IsNullOrEmpty(first.Text) || String.IsNullOrWhiteSpace(first.Text) || String.IsNullOrEmpty(second.Text) || String.IsNullOrWhiteSpace(second.Text))
            {
                MessageBox.Show("One of the value is empty or both are empty.");
                first.Clear(); second.Clear(); first.Focus();

            }
            if(Letter_exception() == 0) 
            {
                
            }
            else if(!String.IsNullOrEmpty(first.Text) && !String.IsNullOrEmpty(second.Text))
            {
                double c = Convert.ToDouble(first.Text.Trim()) + Convert.ToDouble(second.Text.Trim());
                c.ToString();
                MessageBox.Show("The Addition is :-  " + c);
                first.Clear();
                second.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            first.Focus();
            if (String.IsNullOrEmpty(first.Text) || String.IsNullOrWhiteSpace(first.Text)|| String.IsNullOrEmpty(second.Text) || String.IsNullOrWhiteSpace(second.Text))
            {
                MessageBox.Show("One of the value is empty or both are empty.");
                first.Clear(); second.Clear(); first.Focus();

            }
            if (Letter_exception() == 0)
            { 

            }
            else if(!String.IsNullOrEmpty(first.Text) && !String.IsNullOrEmpty(second.Text))
            { 

                    double c = Convert.ToDouble(first.Text.Trim()) - Convert.ToDouble(second.Text.Trim());
                    c.ToString();
                    MessageBox.Show("The Substraction is :-  " + c);
                    first.Clear();
                    second.Clear();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first.Focus();

            if (String.IsNullOrEmpty(first.Text) || String.IsNullOrWhiteSpace(first.Text) || String.IsNullOrEmpty(second.Text) || String.IsNullOrWhiteSpace(second.Text))
            {
                MessageBox.Show("One of the value is empty or both are empty.");
                first.Clear(); second.Clear(); first.Focus();

            }
            if (Letter_exception() == 0) 
            {

            }
            else if(!String.IsNullOrEmpty(first.Text) && !String.IsNullOrEmpty(second.Text))
            {

                double c = Convert.ToDouble(first.Text.Trim()) * Convert.ToDouble(second.Text.Trim());
                c.ToString();
                MessageBox.Show("The Multiplication is :-  " + c);
                first.Clear();
                second.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first.Focus();
            
            if (String.IsNullOrEmpty(first.Text) || String.IsNullOrWhiteSpace(first.Text) || String.IsNullOrEmpty(second.Text) || String.IsNullOrWhiteSpace(second.Text))
            {
                MessageBox.Show("One of the value is empty or both are empty.");
                first.Clear(); second.Clear(); first.Focus();

            }
            if (Letter_exception() == 0) 
            {
                
            }
            
            else if(!String.IsNullOrEmpty(first.Text) && !String.IsNullOrEmpty(second.Text))
            {
                 
                double c = Convert.ToDouble(first.Text.Trim()) / Convert.ToDouble(second.Text.Trim());
                c.ToString();
                MessageBox.Show("The Division is :-  " + c);
                first.Clear();
                second.Clear();
            };
        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
