
namespace Bank.UI
{
    partial class AccountSummary
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ListView();
            this.AccountNumber = new System.Windows.Forms.ColumnHeader();
            this.AccountType = new System.Windows.Forms.ColumnHeader();
            this.AccountBalance = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(58, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Account Name";
            // 
            // AccountList
            // 
            this.AccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccountNumber,
            this.AccountType,
            this.AccountBalance});
            this.AccountList.GridLines = true;
            this.AccountList.HideSelection = false;
            this.AccountList.Location = new System.Drawing.Point(58, 122);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(718, 301);
            this.AccountList.TabIndex = 2;
            this.AccountList.UseCompatibleStateImageBehavior = false;
            this.AccountList.View = System.Windows.Forms.View.Details;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Tag = "";
            this.AccountNumber.Text = "Account Number";
            this.AccountNumber.Width = 250;
            // 
            // AccountType
            // 
            this.AccountType.Text = " Account Type";
            this.AccountType.Width = 200;
            // 
            // AccountBalance
            // 
            this.AccountBalance.Text = "Account Balance";
            this.AccountBalance.Width = 200;
            // 
            // AccountSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 534);
            this.Controls.Add(this.AccountList);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountSummary";
            this.Text = "AccountSummary";
            this.Load += new System.EventHandler(this.AccountSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListView AccountList;
        private System.Windows.Forms.ColumnHeader AccountNumber;
        private System.Windows.Forms.ColumnHeader AccountType;
        private System.Windows.Forms.ColumnHeader AccountBalance;
    }
}