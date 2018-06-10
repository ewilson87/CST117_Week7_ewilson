/**
 * Program: Inventory Management Program
 * File: ReOrderScreen.cs
 * Summary: Multi form inventory management application - Milestone 5
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class ReOrderScreen : Form
    {
        List<InventoryItem> lowInventoryItems = new List<InventoryItem>();
        List<InventoryItem> orderItems = new List<InventoryItem>();
        private decimal total;

        public ReOrderScreen()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Hide();
            homeScreen.Show();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReOrderScreen_Load(object sender, EventArgs e)
        {
        }

        private void fillLowInventoryGrid()
        {
            //clears list and refreshes data grid before searching
            lowInventoryItems.Clear();
            lowInventoryDataGrid.Rows.Clear();
            lowInventoryDataGrid.Refresh();
            int row = 0;

            //searches inventoryList for any item with quantity less than selected value on quantity slider and adds to a lowInventoryItems list
            foreach (InventoryItem item in Program.inventoryList)
            {
                if (item.Quantity <= quantitySlider.Value)
                {
                    lowInventoryItems.Add(item);
                }
            }

            //loads low inventory item list into data grid
            foreach (InventoryItem lowInventoryItem in lowInventoryItems)
            {
                lowInventoryDataGrid.Rows.Insert(row);
                lowInventoryDataGrid[0, row].Value = lowInventoryItem.Name;
                lowInventoryDataGrid[1, row].Value = lowInventoryItem.Model;
                lowInventoryDataGrid[2, row].Value = lowInventoryItem.Type;
                lowInventoryDataGrid[3, row].Value = lowInventoryItem.Quantity;
                lowInventoryDataGrid[4, row].Value = lowInventoryItem.Msrp;
                lowInventoryDataGrid[5, row].Value = lowInventoryItem.SalePrice;
                lowInventoryDataGrid[6, row].Value = lowInventoryItem;

                row++;
            }

        }

        private void addToOrderGrid()
        {
            //adds item to order grid. Need to add additional way to maybe limit putting same object in twice, or setting how many to order...
            try
            {
                InventoryItem inventoryItem = new InventoryItem();

                inventoryItem.Name = lowInventoryDataGrid.SelectedCells[0].Value.ToString();
                inventoryItem.Model = lowInventoryDataGrid.SelectedCells[1].Value.ToString();
                inventoryItem.Quantity = (int)quantityUpDown.Value;
                inventoryItem.SalePrice = (decimal)lowInventoryDataGrid.SelectedCells[5].Value;
                orderItems.Add(inventoryItem);
                refreshOrderGrid();
            }
            catch
            {
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            itemQuantityLabel.Text = quantitySlider.Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!itemAlreadyInList())
            {
                if (quantityUpDown.Value <= 0)
                {
                    MessageBox.Show("Quantity to be ordered must be greater than 0.");
                }
                else
                {
                    addToOrderGrid();
                    updateTotal();
                }
            }
            else
            {
                MessageBox.Show("That item is already in the order list");
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //removes item from order list
            try
            {
                orderItems.Remove((InventoryItem)orderDataGrid.SelectedCells[3].Value);
                orderDataGrid.Rows.Remove(orderDataGrid.CurrentRow);
                updateTotal();
            }
            catch
            {
                totalLabel.Text = "";
            }
        }

        private void refreshOrderGrid()
        {
            //refreshed the order data grid
            orderDataGrid.Rows.Clear();
            orderDataGrid.Refresh();

            int row = 0;

            foreach (InventoryItem item in orderItems)
            {
                orderDataGrid.Rows.Insert(row);
                orderDataGrid[0, row].Value = item.Name;
                orderDataGrid[1, row].Value = item.Quantity;
                orderDataGrid[2, row].Value = item.SalePrice;
                orderDataGrid[3, row].Value = item;

                row++;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fillLowInventoryGrid();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            this.Hide();
            loginScreen.Show();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateTotal()
        {
            total = 0;
            try
            {
                for (int i = 0; i < orderDataGrid.Rows.Count; i++)
                {
                    total = total + (decimal.Parse(orderDataGrid[1, i].Value.ToString()) *
                                     decimal.Parse(orderDataGrid[2, i].Value.ToString()));
                }

                totalLabel.Text = total.ToString("C2");
            }
            catch
            {
                MessageBox.Show("You must enter a quantity for each item to be ordered");
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool itemAlreadyInList()
        {
            foreach (InventoryItem item in orderItems)
            {
                if (item.Name == lowInventoryDataGrid.SelectedCells[0].Value.ToString() && item.Model == lowInventoryDataGrid.SelectedCells[1].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            saveOrderForm();
        }

        //creates an "order form" using current date and time in file name
        private void saveOrderForm()
        {
            if (MessageBox.Show("Confirm order? Completed order form available in root directory.", "Submit order",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    FileStream fcreate = File.Open("Order " + DateTime.Now.Date.ToString("ddMMyy") + " " + DateTime.Now.TimeOfDay.ToString("hhmm") + ".txt", FileMode.Create);

                    StreamWriter streamWriter = new StreamWriter(fcreate);

                    streamWriter.WriteLine("Items to be ordered:");

                    foreach (InventoryItem inventoryItem in orderItems)
                    {
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Name: " + inventoryItem.Name + ", Model: " + inventoryItem.Model +
                                               ", Quantity: " + inventoryItem.Quantity + ", Item Price: "
                                               + inventoryItem.SalePrice.ToString("C") + ", Total: " +
                                               (inventoryItem.SalePrice * inventoryItem.Quantity).ToString("C"));
                    }

                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Total of this order: " + total.ToString("C"));
                    streamWriter.WriteLine(DateTime.Now);
                    streamWriter.Dispose();

                    MessageBox.Show("Order form successfully saved as:\n\r" + fcreate.Name);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}
