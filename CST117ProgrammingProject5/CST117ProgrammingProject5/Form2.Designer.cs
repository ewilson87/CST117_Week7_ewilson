namespace CST117ProgrammingProject5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.luckyNumberLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.luckyNumberLabel2 = new System.Windows.Forms.Label();
            this.luckyNumberLabel3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LimeGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(276, 293);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.luckyNumberLabel3);
            this.panel1.Controls.Add(this.luckyNumberLabel2);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.luckyNumberLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 269);
            this.panel1.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SeaGreen;
            this.backButton.color = System.Drawing.Color.SeaGreen;
            this.backButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImagePosition = 27;
            this.backButton.ImageZoom = 50;
            this.backButton.LabelPosition = 39;
            this.backButton.LabelText = "GO BACK!";
            this.backButton.Location = new System.Drawing.Point(9, 202);
            this.backButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(224, 43);
            this.backButton.TabIndex = 2;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // luckyNumberLabel1
            // 
            this.luckyNumberLabel1.AutoSize = true;
            this.luckyNumberLabel1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel1.Location = new System.Drawing.Point(68, 61);
            this.luckyNumberLabel1.Name = "luckyNumberLabel1";
            this.luckyNumberLabel1.Size = new System.Drawing.Size(0, 112);
            this.luckyNumberLabel1.TabIndex = 1;
            this.luckyNumberLabel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR LUCKY NUMBER IS:";
            // 
            // luckyNumberLabel2
            // 
            this.luckyNumberLabel2.AutoSize = true;
            this.luckyNumberLabel2.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel2.Location = new System.Drawing.Point(40, 61);
            this.luckyNumberLabel2.Name = "luckyNumberLabel2";
            this.luckyNumberLabel2.Size = new System.Drawing.Size(0, 112);
            this.luckyNumberLabel2.TabIndex = 3;
            this.luckyNumberLabel2.Visible = false;
            // 
            // luckyNumberLabel3
            // 
            this.luckyNumberLabel3.AutoSize = true;
            this.luckyNumberLabel3.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel3.Location = new System.Drawing.Point(13, 61);
            this.luckyNumberLabel3.Name = "luckyNumberLabel3";
            this.luckyNumberLabel3.Size = new System.Drawing.Size(0, 112);
            this.luckyNumberLabel3.TabIndex = 4;
            this.luckyNumberLabel3.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 293);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton backButton;
        private System.Windows.Forms.Label luckyNumberLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label luckyNumberLabel3;
        private System.Windows.Forms.Label luckyNumberLabel2;
    }
}