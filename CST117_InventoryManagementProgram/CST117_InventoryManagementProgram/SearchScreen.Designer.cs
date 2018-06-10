namespace CST117_InventoryManagementProgram
{
    partial class SearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.msrpRadioButton = new System.Windows.Forms.RadioButton();
            this.modelRadioButton = new System.Windows.Forms.RadioButton();
            this.quantityRadioButton = new System.Windows.Forms.RadioButton();
            this.typeRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGroupBox.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.searchGroupBox.Controls.Add(this.msrpRadioButton);
            this.searchGroupBox.Controls.Add(this.modelRadioButton);
            this.searchGroupBox.Controls.Add(this.quantityRadioButton);
            this.searchGroupBox.Controls.Add(this.typeRadioButton);
            this.searchGroupBox.Controls.Add(this.priceRadioButton);
            this.searchGroupBox.Controls.Add(this.nameRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(38, 142);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Size = new System.Drawing.Size(848, 65);
            this.searchGroupBox.TabIndex = 12;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By";
            this.searchGroupBox.Enter += new System.EventHandler(this.searchGroupBox_Enter);
            // 
            // msrpRadioButton
            // 
            this.msrpRadioButton.AutoSize = true;
            this.msrpRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msrpRadioButton.Location = new System.Drawing.Point(428, 26);
            this.msrpRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.msrpRadioButton.Name = "msrpRadioButton";
            this.msrpRadioButton.Size = new System.Drawing.Size(91, 28);
            this.msrpRadioButton.TabIndex = 5;
            this.msrpRadioButton.TabStop = true;
            this.msrpRadioButton.Text = "MSRP";
            this.msrpRadioButton.UseVisualStyleBackColor = true;
            // 
            // modelRadioButton
            // 
            this.modelRadioButton.AutoSize = true;
            this.modelRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelRadioButton.Location = new System.Drawing.Point(158, 26);
            this.modelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.modelRadioButton.Name = "modelRadioButton";
            this.modelRadioButton.Size = new System.Drawing.Size(108, 28);
            this.modelRadioButton.TabIndex = 4;
            this.modelRadioButton.TabStop = true;
            this.modelRadioButton.Text = "MODEL";
            this.modelRadioButton.UseVisualStyleBackColor = true;
            // 
            // quantityRadioButton
            // 
            this.quantityRadioButton.AutoSize = true;
            this.quantityRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityRadioButton.Location = new System.Drawing.Point(690, 26);
            this.quantityRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.quantityRadioButton.Name = "quantityRadioButton";
            this.quantityRadioButton.Size = new System.Drawing.Size(150, 28);
            this.quantityRadioButton.TabIndex = 3;
            this.quantityRadioButton.TabStop = true;
            this.quantityRadioButton.Text = "QUANTITY";
            this.quantityRadioButton.UseVisualStyleBackColor = true;
            this.quantityRadioButton.CheckedChanged += new System.EventHandler(this.quantityRadioButton_CheckedChanged);
            // 
            // typeRadioButton
            // 
            this.typeRadioButton.AutoSize = true;
            this.typeRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRadioButton.Location = new System.Drawing.Point(303, 26);
            this.typeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.typeRadioButton.Name = "typeRadioButton";
            this.typeRadioButton.Size = new System.Drawing.Size(88, 28);
            this.typeRadioButton.TabIndex = 2;
            this.typeRadioButton.TabStop = true;
            this.typeRadioButton.Text = "TYPE";
            this.typeRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRadioButton.Location = new System.Drawing.Point(556, 26);
            this.priceRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(97, 28);
            this.priceRadioButton.TabIndex = 1;
            this.priceRadioButton.TabStop = true;
            this.priceRadioButton.Text = "PRICE";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRadioButton.Location = new System.Drawing.Point(25, 26);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(96, 28);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "NAME";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(34, 215);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(116, 24);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Keyword:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchTextBox.Location = new System.Drawing.Point(154, 211);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(732, 32);
            this.searchTextBox.TabIndex = 0;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(96, 24);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(679, 48);
            this.companyLabel.TabIndex = 53;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS SEARCH";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.searchButton);
            this.bunifuGradientPanel1.Controls.Add(this.viewButton);
            this.bunifuGradientPanel1.Controls.Add(this.homeButton);
            this.bunifuGradientPanel1.Controls.Add(this.logoutButton);
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.searchGroupBox);
            this.bunifuGradientPanel1.Controls.Add(this.searchTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.searchLabel);
            this.bunifuGradientPanel1.Controls.Add(this.companyLabel);
            this.bunifuGradientPanel1.Controls.Add(this.searchDataGrid);
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
            this.bunifuGradientPanel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CST117_InventoryManagementProgram.Properties.Resources.w2;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.AllowUserToAddRows = false;
            this.searchDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.searchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.searchDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.searchDataGrid.DoubleBuffered = true;
            this.searchDataGrid.EnableHeadersVisualStyles = false;
            this.searchDataGrid.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.searchDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.searchDataGrid.Location = new System.Drawing.Point(38, 253);
            this.searchDataGrid.MultiSelect = false;
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.ReadOnly = true;
            this.searchDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchDataGrid.RowHeadersVisible = false;
            this.searchDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGrid.Size = new System.Drawing.Size(848, 219);
            this.searchDataGrid.TabIndex = 61;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "InventoryItem";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
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
            this.viewButton.Location = new System.Drawing.Point(182, 482);
            this.viewButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.viewButton.Name = "viewButton";
            this.viewButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.viewButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.viewButton.OnHoverTextColor = System.Drawing.Color.White;
            this.viewButton.selected = false;
            this.viewButton.Size = new System.Drawing.Size(130, 48);
            this.viewButton.TabIndex = 94;
            this.viewButton.Text = "VIEW";
            this.viewButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewButton.Textcolor = System.Drawing.Color.Black;
            this.viewButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
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
            this.homeButton.Location = new System.Drawing.Point(777, 74);
            this.homeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.homeButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(130, 48);
            this.homeButton.TabIndex = 92;
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
            this.logoutButton.Location = new System.Drawing.Point(612, 482);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.logoutButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(130, 48);
            this.logoutButton.TabIndex = 91;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.Black;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoutButton.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
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
            this.exitButton.Location = new System.Drawing.Point(756, 482);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.exitButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(130, 48);
            this.exitButton.TabIndex = 90;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Textcolor = System.Drawing.Color.Black;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(38, 482);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 48);
            this.searchButton.TabIndex = 95;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.viewInventoryButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // SearchScreen
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Screen";
            this.Load += new System.EventHandler(this.SearchScreen_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.RadioButton quantityRadioButton;
        private System.Windows.Forms.RadioButton typeRadioButton;
        private System.Windows.Forms.RadioButton priceRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.RadioButton modelRadioButton;
        private System.Windows.Forms.RadioButton msrpRadioButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Bunifu.Framework.UI.BunifuFlatButton viewButton;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private System.Windows.Forms.Button searchButton;
    }
}