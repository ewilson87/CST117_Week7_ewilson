/**
 * Program: Inventory Management Program
 * File: HomeScreen.cs
 * Summary: Multi form inventory management application - Milestone 5
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class HomeScreen : Form
    {
        InventoryScreen inventoryScreen = new InventoryScreen();
        SearchScreen searchScreen = new SearchScreen();
        NewItemScreen newItemScreen = new NewItemScreen();
        ReOrderScreen reOrderScreen = new ReOrderScreen();

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchInventoryButton_Click_1(object sender, EventArgs e)
        {
            searchScreen.Show(this);
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            loginScreen.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            changeButtonOnEnter(searchInventoryButton);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            changeButtonOnExit(searchInventoryButton);
        }

        private void viewInventoryButton_Click_1(object sender, EventArgs e)
        {
            inventoryScreen.Show(this);
            this.Hide();
        }

        //changes color on mouse enter
        private void changeButtonOnEnter(Button button)
        {
            button.BackColor = Color.SteelBlue;
            button.ForeColor = Color.White;
        }

        //changes color on mouse exit
        private void changeButtonOnExit(Button button)
        {
            button.BackColor = Color.SkyBlue;
            button.ForeColor = Color.Black;
        }

        private void viewInventoryButton_MouseEnter(object sender, EventArgs e)
        {
            changeButtonOnEnter(viewInventoryButton);
        }

        private void viewInventoryButton_MouseLeave(object sender, EventArgs e)
        {
            changeButtonOnExit(viewInventoryButton);
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            Program.fromHomeScreen = true;
            newItemScreen.Show(this);
            this.Hide();          
        }

        private void addNewItemButton_MouseEnter(object sender, EventArgs e)
        {
            changeButtonOnEnter(addNewItemButton);
        }

        private void addNewItemButton_MouseLeave(object sender, EventArgs e)
        {
            changeButtonOnExit(addNewItemButton);
        }

        private void orderInventoryButton_Click_1(object sender, EventArgs e)
        {
            reOrderScreen.Show(this);
            this.Hide();           
        }

        private void orderInventoryButton_MouseEnter(object sender, EventArgs e)
        {
            changeButtonOnEnter(orderInventoryButton);
        }

        private void orderInventoryButton_MouseLeave(object sender, EventArgs e)
        {
            changeButtonOnExit(orderInventoryButton);
        }
    }
}
