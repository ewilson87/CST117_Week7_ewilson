namespace CST117_InventoryManagementProgram
{
    partial class ReOrderScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReOrderScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.orderDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowInventoryDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySlider = new Bunifu.Framework.UI.BunifuSlider();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.removeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowInventoryDataGrid)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label1.Location = new System.Drawing.Point(52, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "ITEMS WITH QUANTITY LESS THAN";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderLabel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.orderLabel.Location = new System.Drawing.Point(626, 129);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(244, 21);
            this.orderLabel.TabIndex = 44;
            this.orderLabel.Text = "ITEMS TO BE ORDERED";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(109, 25);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(799, 48);
            this.companyLabel.TabIndex = 53;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS ORDER FORM";
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.AllowUserToAddRows = false;
            this.orderDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.orderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.orderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.quantityColumn,
            this.priceColumn,
            this.InventoryItem2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDataGrid.DoubleBuffered = true;
            this.orderDataGrid.EnableHeadersVisualStyles = false;
            this.orderDataGrid.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.orderDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.orderDataGrid.Location = new System.Drawing.Point(569, 161);
            this.orderDataGrid.MultiSelect = false;
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDataGrid.RowHeadersVisible = false;
            this.orderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGrid.Size = new System.Drawing.Size(335, 264);
            this.orderDataGrid.TabIndex = 54;
            this.orderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 86;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 61;
            // 
            // InventoryItem2
            // 
            this.InventoryItem2.HeaderText = "InventoryItem";
            this.InventoryItem2.Name = "InventoryItem2";
            this.InventoryItem2.Visible = false;
            // 
            // lowInventoryDataGrid
            // 
            this.lowInventoryDataGrid.AllowUserToAddRows = false;
            this.lowInventoryDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lowInventoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.lowInventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lowInventoryDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.lowInventoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowInventoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lowInventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.lowInventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowInventoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.InventoryItem});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lowInventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.lowInventoryDataGrid.DoubleBuffered = true;
            this.lowInventoryDataGrid.EnableHeadersVisualStyles = false;
            this.lowInventoryDataGrid.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.lowInventoryDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.lowInventoryDataGrid.Location = new System.Drawing.Point(12, 161);
            this.lowInventoryDataGrid.MultiSelect = false;
            this.lowInventoryDataGrid.Name = "lowInventoryDataGrid";
            this.lowInventoryDataGrid.ReadOnly = true;
            this.lowInventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.lowInventoryDataGrid.RowHeadersVisible = false;
            this.lowInventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lowInventoryDataGrid.Size = new System.Drawing.Size(551, 264);
            this.lowInventoryDataGrid.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 86;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "MSRP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 61;
            // 
            // InventoryItem
            // 
            this.InventoryItem.HeaderText = "InventoryItem";
            this.InventoryItem.Name = "InventoryItem";
            this.InventoryItem.ReadOnly = true;
            this.InventoryItem.Visible = false;
            // 
            // quantitySlider
            // 
            this.quantitySlider.BackColor = System.Drawing.Color.Transparent;
            this.quantitySlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.quantitySlider.BorderRadius = 0;
            this.quantitySlider.IndicatorColor = System.Drawing.Color.SteelBlue;
            this.quantitySlider.Location = new System.Drawing.Point(54, 96);
            this.quantitySlider.MaximumValue = 100;
            this.quantitySlider.Name = "quantitySlider";
            this.quantitySlider.Size = new System.Drawing.Size(399, 30);
            this.quantitySlider.TabIndex = 56;
            this.quantitySlider.Value = 10;
            this.quantitySlider.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemQuantityLabel.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityLabel.Location = new System.Drawing.Point(417, 127);
            this.itemQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(36, 24);
            this.itemQuantityLabel.TabIndex = 57;
            this.itemQuantityLabel.Text = "10";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.quantityUpDown);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.totalLabel);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.orderButton);
            this.bunifuGradientPanel1.Controls.Add(this.removeButton);
            this.bunifuGradientPanel1.Controls.Add(this.addButton);
            this.bunifuGradientPanel1.Controls.Add(this.searchButton);
            this.bunifuGradientPanel1.Controls.Add(this.homeButton);
            this.bunifuGradientPanel1.Controls.Add(this.logoutButton);
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.itemQuantityLabel);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.quantitySlider);
            this.bunifuGradientPanel1.Controls.Add(this.lowInventoryDataGrid);
            this.bunifuGradientPanel1.Controls.Add(this.orderDataGrid);
            this.bunifuGradientPanel1.Controls.Add(this.companyLabel);
            this.bunifuGradientPanel1.Controls.Add(this.orderLabel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(920, 550);
            this.bunifuGradientPanel1.TabIndex = 59;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityUpDown.Location = new System.Drawing.Point(208, 431);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(120, 26);
            this.quantityUpDown.TabIndex = 95;
            this.quantityUpDown.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.Location = new System.Drawing.Point(11, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "QUANTITY TO ORDER: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.totalLabel.Location = new System.Drawing.Point(791, 434);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 19);
            this.totalLabel.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.Location = new System.Drawing.Point(568, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "TOTAL PRICE OF ORDER:";
            // 
            // orderButton
            // 
            this.orderButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.orderButton.AllowDrop = true;
            this.orderButton.BackColor = System.Drawing.Color.SkyBlue;
            this.orderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderButton.BorderRadius = 0;
            this.orderButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderButton.ButtonText = "ORDER";
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderButton.DisabledColor = System.Drawing.Color.Gray;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.orderButton.Iconcolor = System.Drawing.Color.Transparent;
            this.orderButton.Iconimage = null;
            this.orderButton.Iconimage_right = null;
            this.orderButton.Iconimage_right_Selected = null;
            this.orderButton.Iconimage_Selected = null;
            this.orderButton.IconMarginLeft = 0;
            this.orderButton.IconMarginRight = 0;
            this.orderButton.IconRightVisible = true;
            this.orderButton.IconRightZoom = 0D;
            this.orderButton.IconVisible = true;
            this.orderButton.IconZoom = 90D;
            this.orderButton.IsTab = false;
            this.orderButton.Location = new System.Drawing.Point(443, 481);
            this.orderButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.orderButton.Name = "orderButton";
            this.orderButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.orderButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.orderButton.OnHoverTextColor = System.Drawing.Color.White;
            this.orderButton.selected = false;
            this.orderButton.Size = new System.Drawing.Size(130, 48);
            this.orderButton.TabIndex = 91;
            this.orderButton.Text = "ORDER";
            this.orderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderButton.Textcolor = System.Drawing.Color.Black;
            this.orderButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.removeButton.AllowDrop = true;
            this.removeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeButton.BorderRadius = 0;
            this.removeButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.removeButton.ButtonText = "REMOVE";
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.removeButton.DisabledColor = System.Drawing.Color.Gray;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.removeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.removeButton.Iconimage = null;
            this.removeButton.Iconimage_right = null;
            this.removeButton.Iconimage_right_Selected = null;
            this.removeButton.Iconimage_Selected = null;
            this.removeButton.IconMarginLeft = 0;
            this.removeButton.IconMarginRight = 0;
            this.removeButton.IconRightVisible = true;
            this.removeButton.IconRightZoom = 0D;
            this.removeButton.IconVisible = true;
            this.removeButton.IconZoom = 90D;
            this.removeButton.IsTab = false;
            this.removeButton.Location = new System.Drawing.Point(299, 481);
            this.removeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.removeButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.removeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.removeButton.selected = false;
            this.removeButton.Size = new System.Drawing.Size(130, 48);
            this.removeButton.TabIndex = 90;
            this.removeButton.Text = "REMOVE";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeButton.Textcolor = System.Drawing.Color.Black;
            this.removeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButton.AllowDrop = true;
            this.addButton.BackColor = System.Drawing.Color.SkyBlue;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.BorderRadius = 0;
            this.addButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addButton.ButtonText = "ADD";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addButton.DisabledColor = System.Drawing.Color.Gray;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.addButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addButton.Iconimage = null;
            this.addButton.Iconimage_right = null;
            this.addButton.Iconimage_right_Selected = null;
            this.addButton.Iconimage_Selected = null;
            this.addButton.IconMarginLeft = 0;
            this.addButton.IconMarginRight = 0;
            this.addButton.IconRightVisible = true;
            this.addButton.IconRightZoom = 0D;
            this.addButton.IconVisible = true;
            this.addButton.IconZoom = 90D;
            this.addButton.IsTab = false;
            this.addButton.Location = new System.Drawing.Point(155, 481);
            this.addButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.addButton.Name = "addButton";
            this.addButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.addButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.addButton.OnHoverTextColor = System.Drawing.Color.White;
            this.addButton.selected = false;
            this.addButton.Size = new System.Drawing.Size(130, 48);
            this.addButton.TabIndex = 89;
            this.addButton.Text = "ADD";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.Textcolor = System.Drawing.Color.Black;
            this.addButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.searchButton.AllowDrop = true;
            this.searchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.BorderRadius = 0;
            this.searchButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchButton.ButtonText = "SEARCH";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.DisabledColor = System.Drawing.Color.Gray;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.searchButton.Iconimage = null;
            this.searchButton.Iconimage_right = null;
            this.searchButton.Iconimage_right_Selected = null;
            this.searchButton.Iconimage_Selected = null;
            this.searchButton.IconMarginLeft = 0;
            this.searchButton.IconMarginRight = 0;
            this.searchButton.IconRightVisible = true;
            this.searchButton.IconRightZoom = 0D;
            this.searchButton.IconVisible = true;
            this.searchButton.IconZoom = 90D;
            this.searchButton.IsTab = false;
            this.searchButton.Location = new System.Drawing.Point(11, 481);
            this.searchButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.searchButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(130, 48);
            this.searchButton.TabIndex = 88;
            this.searchButton.Text = "SEARCH";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Textcolor = System.Drawing.Color.Black;
            this.searchButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.homeButton.Location = new System.Drawing.Point(774, 78);
            this.homeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.homeButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(130, 48);
            this.homeButton.TabIndex = 87;
            this.homeButton.Text = "HOME";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeButton.Textcolor = System.Drawing.Color.Black;
            this.homeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
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
            this.logoutButton.Location = new System.Drawing.Point(630, 481);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.logoutButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(130, 48);
            this.logoutButton.TabIndex = 86;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.Black;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(774, 481);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.exitButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(130, 48);
            this.exitButton.TabIndex = 85;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Textcolor = System.Drawing.Color.Black;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CST117_InventoryManagementProgram.Properties.Resources.w2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // ReOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReOrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReOrderScreen";
            this.Load += new System.EventHandler(this.ReOrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowInventoryDataGrid)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label companyLabel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid orderDataGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid lowInventoryDataGrid;
        private Bunifu.Framework.UI.BunifuSlider quantitySlider;
        private System.Windows.Forms.Label itemQuantityLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuFlatButton orderButton;
        private Bunifu.Framework.UI.BunifuFlatButton removeButton;
        private Bunifu.Framework.UI.BunifuFlatButton addButton;
        private Bunifu.Framework.UI.BunifuFlatButton searchButton;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItem2;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label label3;
    }
}