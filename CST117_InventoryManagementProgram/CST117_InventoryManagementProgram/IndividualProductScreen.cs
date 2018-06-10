/**
 * Program: Inventory Management Program
 * File: IndividualProductScreen.cs
 * Summary: Multi form inventory management application - Milestone 5
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class IndividualProductScreen : Form
    {

        public IndividualProductScreen()
        {
            InitializeComponent();
        }

        private void IndividualProductScreen_Load(object sender, EventArgs e)
        {
            //loads values for current selected item
            nameTextBox.Text = Program.thisInventoryItem.Name;
            modelTextBox.Text = Program.thisInventoryItem.Model;
            typeTextBox.Text = Program.thisInventoryItem.Type;
            quantityUpDown.Value = Program.thisInventoryItem.Quantity;
            msrpUpDown.Value = Program.thisInventoryItem.Msrp;
            priceUpDown.Value = Program.thisInventoryItem.SalePrice;
        }

        private void confirmChanges()
        {
            //confirm box for changes. Sets program wide savedChanges bool to true so InventoryScreen knows to look for changes and update as necessary
            if (MessageBox.Show("Confirm changes?", "Edit item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Program.savedChanges = true;

                InventoryItem inventoryItem = new InventoryItem();

                inventoryItem.Name = nameTextBox.Text.ToUpper();
                inventoryItem.Model = modelTextBox.Text.ToUpper();
                inventoryItem.Type = typeTextBox.Text.ToUpper();
                inventoryItem.Quantity = (int)quantityUpDown.Value;
                inventoryItem.Msrp = msrpUpDown.Value;
                inventoryItem.SalePrice = priceUpDown.Value;

                Program.thisInventoryItem = inventoryItem;

                InventoryScreen inventoryScreen = new InventoryScreen();

                inventoryScreen.Show();
                this.Hide();
            }
        }

        private void cancelChanges()
        {
            //cancels any changes done prior to a save and resets textboxes
            nameTextBox.Enabled = false;
            priceUpDown.Enabled = false;
            quantityUpDown.Enabled = false;
            typeTextBox.Enabled = false;
            msrpUpDown.Enabled = false;
            modelTextBox.Enabled = false;

            nameTextBox.Text = Program.thisInventoryItem.Name;
            modelTextBox.Text = Program.thisInventoryItem.Model;
            typeTextBox.Text = Program.thisInventoryItem.Type;
            quantityUpDown.Value = Program.thisInventoryItem.Quantity;
            msrpUpDown.Value = Program.thisInventoryItem.Msrp;
            priceUpDown.Value = Program.thisInventoryItem.SalePrice;
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            //InventoryScreen inventoryScreen = new InventoryScreen();

            Owner.Show();
            this.Hide();
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            homeScreen.Show();
            this.Hide();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            //enables user to edit items
            nameTextBox.Enabled = true;
            priceUpDown.Enabled = true;
            quantityUpDown.Enabled = true;
            typeTextBox.Enabled = true;
            msrpUpDown.Enabled = true;
            modelTextBox.Enabled = true;
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            cancelChanges();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            confirmChanges();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            loginScreen.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
