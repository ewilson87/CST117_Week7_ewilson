/**
 * Program: Lucky Number Generator
 * File: Form2.cs
 * Summary: Generates a random lucky number between 1-100 based on your date of birth
 * Author: Evan Wilson
 * Date: June 5th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117ProgrammingProject5
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            setLuckyNumberLabel();
        }

        private void setLuckyNumberLabel()
        {
            //sets label in a way that will always appear centered, regardless of if number is 1, 2, or 3 digits long
            if (Program.LuckyNumber.ToString().Length == 1)
            {
                luckyNumberLabel1.Visible = true;
                luckyNumberLabel1.Text = Program.LuckyNumber.ToString();
            }
            else if (Program.LuckyNumber.ToString().Length == 2)
            {
                luckyNumberLabel2.Visible = true;
                luckyNumberLabel2.Text = Program.LuckyNumber.ToString();
            }
            else if (Program.LuckyNumber.ToString().Length == 3)
            {
                luckyNumberLabel3.Visible = true;
                luckyNumberLabel3.Text = Program.LuckyNumber.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            Owner.Show();
            this.Close();
        }
    }
}
