/**
 * Program: Lucky Number Generator
 * File: Program.cs
 * Summary: Generates a random lucky number between 1-100 based on your date of birth
 * Author: Evan Wilson
 * Date: June 5th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117ProgrammingProject5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //declares a static int that can be accessed from any form in this namespace
        public static int LuckyNumber;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
