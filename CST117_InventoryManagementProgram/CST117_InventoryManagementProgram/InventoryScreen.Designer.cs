namespace CST117_InventoryManagementProgram
{
    partial class InventoryScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryScreen));
            this.inventoryDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msrpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.newButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.companyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDataGrid
            // 
            this.inventoryDataGrid.AllowUserToAddRows = false;
            this.inventoryDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inventoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.inventoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.modelColumn,
            this.typeColumn,
            this.quantityColumn,
            this.msrpColumn,
            this.priceColumn,
            this.InventoryItem});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.inventoryDataGrid.DoubleBuffered = true;
            this.inventoryDataGrid.EnableHeadersVisualStyles = false;
            this.inventoryDataGrid.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.inventoryDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.inventoryDataGrid.Location = new System.Drawing.Point(8, 129);
            this.inventoryDataGrid.MultiSelect = false;
            this.inventoryDataGrid.Name = "inventoryDataGrid";
            this.inventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventoryDataGrid.RowHeadersVisible = false;
            this.inventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGrid.Size = new System.Drawing.Size(900, 336);
            this.inventoryDataGrid.TabIndex = 56;
            this.inventoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGrid_CellContentClick);
            this.inventoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGrid_CellContentClick);
            this.inventoryDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGrid_CellContentClick);
            this.inventoryDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGrid_CellContentClick);
            this.inventoryDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGrid_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // modelColumn
            // 
            this.modelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelColumn.HeaderText = "Model";
            this.modelColumn.Name = "modelColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // msrpColumn
            // 
            this.msrpColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.msrpColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.msrpColumn.HeaderText = "MSRP";
            this.msrpColumn.Name = "msrpColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "C2";
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // InventoryItem
            // 
            this.InventoryItem.HeaderText = "InventoryItem";
            this.InventoryItem.Name = "InventoryItem";
            this.InventoryItem.Visible = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.newButton);
            this.bunifuGradientPanel1.Controls.Add(this.viewButton);
            this.bunifuGradientPanel1.Controls.Add(this.deleteButton);
            this.bunifuGradientPanel1.Controls.Add(this.homeButton);
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.logoutButton);
            this.bunifuGradientPanel1.Controls.Add(this.inventoryDataGrid);
            this.bunifuGradientPanel1.Controls.Add(this.companyLabel);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(920, 550);
            this.bunifuGradientPanel1.TabIndex = 60;
            // 
            // newButton
            // 
            this.newButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.newButton.AllowDrop = true;
            this.newButton.BackColor = System.Drawing.Color.SkyBlue;
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newButton.BorderRadius = 0;
            this.newButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newButton.ButtonText = "NEW";
            this.newButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.newButton.DisabledColor = System.Drawing.Color.Gray;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.newButton.Iconcolor = System.Drawing.Color.Transparent;
            this.newButton.Iconimage = null;
            this.newButton.Iconimage_right = null;
            this.newButton.Iconimage_right_Selected = null;
            this.newButton.Iconimage_Selected = null;
            this.newButton.IconMarginLeft = 0;
            this.newButton.IconMarginRight = 0;
            this.newButton.IconRightVisible = true;
            this.newButton.IconRightZoom = 0D;
            this.newButton.IconVisible = true;
            this.newButton.IconZoom = 90D;
            this.newButton.IsTab = false;
            this.newButton.Location = new System.Drawing.Point(11, 475);
            this.newButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.newButton.Name = "newButton";
            this.newButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.newButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.newButton.OnHoverTextColor = System.Drawing.Color.White;
            this.newButton.selected = false;
            this.newButton.Size = new System.Drawing.Size(130, 48);
            this.newButton.TabIndex = 66;
            this.newButton.Text = "NEW";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newButton.Textcolor = System.Drawing.Color.Black;
            this.newButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.newButton.Click += new System.EventHandler(this.newButton_Click_1);
            // 
            // viewButton
            // 
            this.viewButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.viewButton.AllowDrop = true;
            this.viewButton.BackColor = System.Drawing.Color.SkyBlue;
            this.viewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewButton.BorderRadius = 0;
            this.viewButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewButton.ButtonText = "VIEW";
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewButton.DisabledColor = System.Drawing.Color.Gray;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.viewButton.Iconcolor = System.Drawing.Color.Transparent;
            this.viewButton.Iconimage = null;
            this.viewButton.Iconimage_right = null;
            this.viewButton.Iconimage_right_Selected = null;
            this.viewButton.Iconimage_Selected = null;
            this.viewButton.IconMarginLeft = 0;
            this.viewButton.IconMarginRight = 0;
            this.viewButton.IconRightVisible = true;
            this.viewButton.IconRightZoom = 0D;
            this.viewButton.IconVisible = true;
            this.viewButton.IconZoom = 90D;
            this.viewButton.IsTab = false;
            this.viewButton.Location = new System.Drawing.Point(155, 475);
            this.viewButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.viewButton.Name = "viewButton";
            this.viewButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.viewButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.viewButton.OnHoverTextColor = System.Drawing.Color.White;
            this.viewButton.selected = false;
            this.viewButton.Size = new System.Drawing.Size(130, 48);
            this.viewButton.TabIndex = 65;
            this.viewButton.Text = "VIEW";
            this.viewButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewButton.Textcolor = System.Drawing.Color.Black;
            this.viewButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteButton.AllowDrop = true;
            this.deleteButton.BackColor = System.Drawing.Color.SkyBlue;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 0;
            this.deleteButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deleteButton.ButtonText = "DELETE";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = null;
            this.deleteButton.Iconimage_right = null;
            this.deleteButton.Iconimage_right_Selected = null;
            this.deleteButton.Iconimage_Selected = null;
            this.deleteButton.IconMarginLeft = 0;
            this.deleteButton.IconMarginRight = 0;
            this.deleteButton.IconRightVisible = true;
            this.deleteButton.IconRightZoom = 0D;
            this.deleteButton.IconVisible = true;
            this.deleteButton.IconZoom = 90D;
            this.deleteButton.IsTab = false;
            this.deleteButton.Location = new System.Drawing.Point(299, 475);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.deleteButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(130, 48);
            this.deleteButton.TabIndex = 64;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteButton.Textcolor = System.Drawing.Color.Black;
            this.deleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // homeButton
            // 
            this.homeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeButton.AllowDrop = true;
            this.homeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.BorderRadius = 0;
            this.homeButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeButton.ButtonText = "HOME";
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.homeButton.DisabledColor = System.Drawing.Color.Gray;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.homeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.homeButton.Iconimage = null;
            this.homeButton.Iconimage_right = null;
            this.homeButton.Iconimage_right_Selected = null;
            this.homeButton.Iconimage_Selected = null;
            this.homeButton.IconMarginLeft = 0;
            this.homeButton.IconMarginRight = 0;
            this.homeButton.IconRightVisible = true;
            this.homeButton.IconRightZoom = 0D;
            this.homeButton.IconVisible = true;
            this.homeButton.IconZoom = 90D;
            this.homeButton.IsTab = false;
            this.homeButton.Location = new System.Drawing.Point(774, 74);
            this.homeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.homeButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(130, 48);
            this.homeButton.TabIndex = 63;
            this.homeButton.Text = "HOME";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeButton.Textcolor = System.Drawing.Color.Black;
            this.homeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitButton.AllowDrop = true;
            this.exitButton.BackColor = System.Drawing.Color.SkyBlue;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitButton.ButtonText = "EXIT";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = null;
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = true;
            this.exitButton.IconZoom = 90D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(778, 475);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.exitButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(130, 48);
            this.exitButton.TabIndex = 62;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Textcolor = System.Drawing.Color.Black;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logoutButton.AllowDrop = true;
            this.logoutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoutButton.ButtonText = "LOGOUT";
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutButton.Iconimage = null;
            this.logoutButton.Iconimage_right = null;
            this.logoutButton.Iconimage_right_Selected = null;
            this.logoutButton.Iconimage_Selected = null;
            this.logoutButton.IconMarginLeft = 0;
            this.logoutButton.IconMarginRight = 0;
            this.logoutButton.IconRightVisible = true;
            this.logoutButton.IconRightZoom = 0D;
            this.logoutButton.IconVisible = true;
            this.logoutButton.IconZoom = 90D;
            this.logoutButton.IsTab = false;
            this.logoutButton.Location = new System.Drawing.Point(634, 475);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.logoutButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(130, 48);
            this.logoutButton.TabIndex = 61;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.Black;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(90, 19);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(757, 48);
            this.companyLabel.TabIndex = 61;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS INVENTORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CST117_InventoryManagementProgram.Properties.Resources.w2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "InventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Screen";
            this.Load += new System.EventHandler(this.InventoryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid inventoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msrpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label companyLabel;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
        private Bunifu.Framework.UI.BunifuFlatButton viewButton;
        private Bunifu.Framework.UI.BunifuFlatButton newButton;
    }
}