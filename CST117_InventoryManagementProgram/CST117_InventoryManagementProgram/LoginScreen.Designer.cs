namespace CST117_InventoryManagementProgram
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameTextBox.Location = new System.Drawing.Point(125, 79);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(172, 32);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordTextBox.Location = new System.Drawing.Point(125, 115);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(172, 32);
            this.passwordTextBox.TabIndex = 5;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.passwordTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.loginButton);
            this.bunifuGradientPanel1.Controls.Add(this.checkBox1);
            this.bunifuGradientPanel1.Controls.Add(this.companyLabel);
            this.bunifuGradientPanel1.Controls.Add(this.passwordLabel);
            this.bunifuGradientPanel1.Controls.Add(this.usernameLabel);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(409, 273);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.AllowDrop = true;
            this.loginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(125, 195);
            this.loginButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.loginButton.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(172, 48);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.Black;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(125, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember Login";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(88, 25);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(319, 28);
            this.companyLabel.TabIndex = 11;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordLabel.Location = new System.Drawing.Point(11, 118);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(114, 26);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameLabel.Location = new System.Drawing.Point(6, 82);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(119, 26);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username:";
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 273);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginScreen_FormClosed);
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
    }
}

