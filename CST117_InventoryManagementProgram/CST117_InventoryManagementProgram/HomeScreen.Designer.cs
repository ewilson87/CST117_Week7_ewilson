namespace CST117_InventoryManagementProgram
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.companyLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.orderInventoryButton = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(88, 18);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(774, 48);
            this.companyLabel.TabIndex = 8;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS HOME MENU";
            this.companyLabel.Click += new System.EventHandler(this.companyLabel_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.orderInventoryButton);
            this.bunifuGradientPanel1.Controls.Add(this.addNewItemButton);
            this.bunifuGradientPanel1.Controls.Add(this.viewInventoryButton);
            this.bunifuGradientPanel1.Controls.Add(this.searchInventoryButton);
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.logoutButton);
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
            this.bunifuGradientPanel1.TabIndex = 11;
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.BackColor = System.Drawing.Color.SkyBlue;
            this.viewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.Location = new System.Drawing.Point(12, 172);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.viewInventoryButton.TabIndex = 22;
            this.viewInventoryButton.Text = "View Current Inventory";
            this.viewInventoryButton.UseVisualStyleBackColor = false;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click_1);
            this.viewInventoryButton.MouseEnter += new System.EventHandler(this.viewInventoryButton_MouseEnter);
            this.viewInventoryButton.MouseLeave += new System.EventHandler(this.viewInventoryButton_MouseLeave);
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryButton.Location = new System.Drawing.Point(241, 172);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.searchInventoryButton.TabIndex = 21;
            this.searchInventoryButton.Text = "Search Current Inventory";
            this.searchInventoryButton.UseVisualStyleBackColor = false;
            this.searchInventoryButton.Click += new System.EventHandler(this.searchInventoryButton_Click_1);
            this.searchInventoryButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.searchInventoryButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
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
            this.exitButton.Location = new System.Drawing.Point(774, 487);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.exitButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(130, 48);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Textcolor = System.Drawing.Color.Black;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.logoutButton.Location = new System.Drawing.Point(630, 487);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.logoutButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(130, 48);
            this.logoutButton.TabIndex = 19;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.Black;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CST117_InventoryManagementProgram.Properties.Resources.w2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.BackColor = System.Drawing.Color.SkyBlue;
            this.addNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(470, 172);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(209, 177);
            this.addNewItemButton.TabIndex = 23;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = false;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            this.addNewItemButton.MouseEnter += new System.EventHandler(this.addNewItemButton_MouseEnter);
            this.addNewItemButton.MouseLeave += new System.EventHandler(this.addNewItemButton_MouseLeave);
            // 
            // orderInventoryButton
            // 
            this.orderInventoryButton.BackColor = System.Drawing.Color.SkyBlue;
            this.orderInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInventoryButton.Location = new System.Drawing.Point(699, 172);
            this.orderInventoryButton.Name = "orderInventoryButton";
            this.orderInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.orderInventoryButton.TabIndex = 24;
            this.orderInventoryButton.Text = "Order Inventory";
            this.orderInventoryButton.UseVisualStyleBackColor = false;
            this.orderInventoryButton.Click += new System.EventHandler(this.orderInventoryButton_Click_1);
            this.orderInventoryButton.MouseEnter += new System.EventHandler(this.orderInventoryButton_MouseEnter);
            this.orderInventoryButton.MouseLeave += new System.EventHandler(this.orderInventoryButton_MouseLeave);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label companyLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private System.Windows.Forms.Button searchInventoryButton;
        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button orderInventoryButton;
    }
}