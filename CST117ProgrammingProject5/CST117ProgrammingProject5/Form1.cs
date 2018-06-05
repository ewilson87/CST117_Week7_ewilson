/**
 * Program: Lucky Number Generator
 * File: Form1.cs
 * Summary: Generates a random lucky number between 1-100 based on your date of birth
 * Author: Evan Wilson
 * Date: June 5th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117ProgrammingProject5
{
    public partial class Form1 : Form
    {

        private int dateOfBirth;

        public Form1()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            setDateOfBirth();
            calculateLuckyNumber();

            Form2 form2 = new Form2();

            form2.Show(this);
            Hide();
        }

        private void calculateLuckyNumber()
        {
            //sets LuckyNumber between 1-100 using the dateOfBirth as the seed, so each date will always display the same lucky number
            Random random = new Random(dateOfBirth);
            Program.LuckyNumber = random.Next(100) + 1;
        }

        private void setDateOfBirth()
        {
            //sets selected date from calender as an integer in the format ddMMyyyy
            dateOfBirth = int.Parse(monthCalendar1.SelectionStart.ToString("ddMMyyyy"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
