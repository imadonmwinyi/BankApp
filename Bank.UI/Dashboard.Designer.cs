
namespace Bank.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.heading = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AccountStateBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.WithdrawalBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.OpenAccountBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heading.Controls.Add(this.welcome);
            this.heading.Controls.Add(this.bankName);
            this.heading.Controls.Add(this.pictureBox1);
            this.heading.Location = new System.Drawing.Point(4, -1);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1097, 80);
            this.heading.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(716, 28);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(93, 28);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "Welcome";
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bankName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bankName.Location = new System.Drawing.Point(163, 28);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(113, 28);
            this.bankName.TabIndex = 1;
            this.bankName.Text = "ACMB Bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.AccountStateBtn);
            this.panel1.Controls.Add(this.TransferBtn);
            this.panel1.Controls.Add(this.WithdrawalBtn);
            this.panel1.Controls.Add(this.DepositBtn);
            this.panel1.Controls.Add(this.OpenAccountBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 590);
            this.panel1.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 419);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(245, 75);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AccountStateBtn
            // 
            this.AccountStateBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AccountStateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountStateBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.AccountStateBtn.Location = new System.Drawing.Point(0, 349);
            this.AccountStateBtn.Name = "AccountStateBtn";
            this.AccountStateBtn.Size = new System.Drawing.Size(245, 75);
            this.AccountStateBtn.TabIndex = 1;
            this.AccountStateBtn.Text = "Account Statement";
            this.AccountStateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountStateBtn.UseVisualStyleBackColor = false;
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TransferBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.TransferBtn.Location = new System.Drawing.Point(0, 281);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(245, 75);
            this.TransferBtn.TabIndex = 1;
            this.TransferBtn.Text = "Transfer Fund";
            this.TransferBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // WithdrawalBtn
            // 
            this.WithdrawalBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WithdrawalBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawalBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.WithdrawalBtn.Location = new System.Drawing.Point(0, 211);
            this.WithdrawalBtn.Name = "WithdrawalBtn";
            this.WithdrawalBtn.Size = new System.Drawing.Size(245, 75);
            this.WithdrawalBtn.TabIndex = 1;
            this.WithdrawalBtn.Text = "Make Withdrawal";
            this.WithdrawalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WithdrawalBtn.UseVisualStyleBackColor = false;
            this.WithdrawalBtn.Click += new System.EventHandler(this.WithdrawalBtn_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.DepositBtn.Location = new System.Drawing.Point(0, 143);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(245, 75);
            this.DepositBtn.TabIndex = 1;
            this.DepositBtn.Text = "Make Deposit";
            this.DepositBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // OpenAccountBtn
            // 
            this.OpenAccountBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OpenAccountBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAccountBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.OpenAccountBtn.Location = new System.Drawing.Point(0, 76);
            this.OpenAccountBtn.Name = "OpenAccountBtn";
            this.OpenAccountBtn.Size = new System.Drawing.Size(245, 75);
            this.OpenAccountBtn.TabIndex = 1;
            this.OpenAccountBtn.Text = "Open Account";
            this.OpenAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenAccountBtn.UseVisualStyleBackColor = false;
            this.OpenAccountBtn.Click += new System.EventHandler(this.OpenAccountBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 586);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Location = new System.Drawing.Point(246, 81);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(855, 590);
            this.MainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.heading);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACMB Bank Dashboard";
            this.Load += new System.EventHandler(this.DashBoard_OnLoad);
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button AccountStateBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Button WithdrawalBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button OpenAccountBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel MainPanel;
    }
}