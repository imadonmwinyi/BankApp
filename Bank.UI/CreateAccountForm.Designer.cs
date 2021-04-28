
namespace Bank.UI
{
    partial class CreateAccountForm
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
            this.OpenAccountLabel = new System.Windows.Forms.Label();
            this.SavingsRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InitialDepositBox = new System.Windows.Forms.TextBox();
            this.OpenAcctBtn = new System.Windows.Forms.Button();
            this.CurrentRBtn = new System.Windows.Forms.RadioButton();
            this.AccountType = new System.Windows.Forms.GroupBox();
            this.AccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenAccountLabel
            // 
            this.OpenAccountLabel.AutoSize = true;
            this.OpenAccountLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenAccountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAccountLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OpenAccountLabel.Location = new System.Drawing.Point(190, 62);
            this.OpenAccountLabel.Name = "OpenAccountLabel";
            this.OpenAccountLabel.Size = new System.Drawing.Size(157, 30);
            this.OpenAccountLabel.TabIndex = 0;
            this.OpenAccountLabel.Text = "Open Account ";
            // 
            // SavingsRbtn
            // 
            this.SavingsRbtn.AutoSize = true;
            this.SavingsRbtn.Checked = true;
            this.SavingsRbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavingsRbtn.Location = new System.Drawing.Point(23, 50);
            this.SavingsRbtn.Name = "SavingsRbtn";
            this.SavingsRbtn.Size = new System.Drawing.Size(104, 32);
            this.SavingsRbtn.TabIndex = 0;
            this.SavingsRbtn.TabStop = true;
            this.SavingsRbtn.Text = "Savings";
            this.SavingsRbtn.UseVisualStyleBackColor = true;
            this.SavingsRbtn.CheckedChanged += new System.EventHandler(this.Savings_Checked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Deposit";
            // 
            // InitialDepositBox
            // 
            this.InitialDepositBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialDepositBox.Location = new System.Drawing.Point(52, 332);
            this.InitialDepositBox.Name = "InitialDepositBox";
            this.InitialDepositBox.Size = new System.Drawing.Size(445, 34);
            this.InitialDepositBox.TabIndex = 3;
            // 
            // OpenAcctBtn
            // 
            this.OpenAcctBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenAcctBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAcctBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenAcctBtn.Location = new System.Drawing.Point(158, 400);
            this.OpenAcctBtn.Name = "OpenAcctBtn";
            this.OpenAcctBtn.Size = new System.Drawing.Size(189, 56);
            this.OpenAcctBtn.TabIndex = 4;
            this.OpenAcctBtn.Text = "Open Account";
            this.OpenAcctBtn.UseVisualStyleBackColor = false;
            this.OpenAcctBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // CurrentRBtn
            // 
            this.CurrentRBtn.AutoSize = true;
            this.CurrentRBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentRBtn.Location = new System.Drawing.Point(245, 50);
            this.CurrentRBtn.Name = "CurrentRBtn";
            this.CurrentRBtn.Size = new System.Drawing.Size(107, 32);
            this.CurrentRBtn.TabIndex = 0;
            this.CurrentRBtn.Text = "Current ";
            this.CurrentRBtn.UseVisualStyleBackColor = true;
            this.CurrentRBtn.CheckedChanged += new System.EventHandler(this.CurrentRBtn_CheckedChanged);
            // 
            // AccountType
            // 
            this.AccountType.Controls.Add(this.CurrentRBtn);
            this.AccountType.Controls.Add(this.SavingsRbtn);
            this.AccountType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountType.Location = new System.Drawing.Point(52, 150);
            this.AccountType.Name = "AccountType";
            this.AccountType.Size = new System.Drawing.Size(434, 104);
            this.AccountType.TabIndex = 1;
            this.AccountType.TabStop = false;
            this.AccountType.Text = "Select Account Type";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(544, 595);
            this.Controls.Add(this.OpenAcctBtn);
            this.Controls.Add(this.InitialDepositBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountType);
            this.Controls.Add(this.OpenAccountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account Form";
            this.AccountType.ResumeLayout(false);
            this.AccountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpenAccountLabel;
        private System.Windows.Forms.RadioButton SavingsRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InitialDepositBox;
        private System.Windows.Forms.Button OpenAcctBtn;
        private System.Windows.Forms.RadioButton CurrentRBtn;
        private System.Windows.Forms.GroupBox AccountType;
    }
}