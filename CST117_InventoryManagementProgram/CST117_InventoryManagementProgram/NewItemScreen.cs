/**
 * Program: Inventory Management Program
 * File: NewItemScreen.cs
 * Summary: Multi form inventory management application - Milestone 5
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class NewItemScreen : Form
    {
        InventoryManager inventoryManager = new InventoryManager();

        public NewItemScreen()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Hide();
            homeScreen.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewItemScreen_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            inventoryManager.AddItem(CreateInventoryItem());
        }

        private InventoryItem CreateInventoryItem()
        {
            //creates a new inventoryItem based on whats entered, and returns it
            InventoryItem inventoryItem = new InventoryItem();

            if (MessageBox.Show("Confirm save new item?", "New Item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //InventoryItem inventoryItem = new InventoryItem();

                inventoryItem.Name = nameTextBox.Text.ToUpper();
                inventoryItem.Model = modelTextBox.Text.ToUpper();
                inventoryItem.Type = typeTextBox.Text.ToUpper();
                inventoryItem.Quantity = (int)quantityUpDown.Value;
                inventoryItem.Msrp = msrpUpDown.Value;
                inventoryItem.SalePrice = priceUpDown.Value;

                nameTextBox.Text = "";
                modelTextBox.Text = "";
                typeTextBox.Text = "";
                quantityUpDown.Value = 0;
                msrpUpDown.Value = 0;
                priceUpDown.Value = 0;

                MessageBox.Show("Item successfully added.");

                return inventoryItem;

            }
            return default(InventoryItem);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            this.Hide();
            loginScreen.Show();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            returnToPrevious();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            returnToPrevious();
        }

        private void returnToPrevious()
        {
            if (Program.fromHomeScreen)
            {
                //resets bool
                Program.fromHomeScreen = false;

                HomeScreen homeScreen = new HomeScreen();

                homeScreen.Show();
                this.Hide();
            }
            else
            {
                InventoryScreen inventoryScreen = new InventoryScreen();

                this.Hide();
                inventoryScreen.Show();
            }
        }
    }
}
