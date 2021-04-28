
namespace Bank.UI
{
    partial class AccountStatement
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.AccountComBo = new System.Windows.Forms.ComboBox();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.Statementpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(283, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(248, 30);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "View Account Statement";
            // 
            // AccountComBo
            // 
            this.AccountComBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountComBo.FormattingEnabled = true;
            this.AccountComBo.Location = new System.Drawing.Point(60, 100);
            this.AccountComBo.Name = "AccountComBo";
            this.AccountComBo.Size = new System.Drawing.Size(357, 36);
            this.AccountComBo.TabIndex = 5;
            this.AccountComBo.Text = "Please Select Account";
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.WithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WithdrawBtn.Location = new System.Drawing.Point(463, 99);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(331, 41);
            this.WithdrawBtn.TabIndex = 7;
            this.WithdrawBtn.Text = "View Statement";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            // 
            // Statementpanel
            // 
            this.Statementpanel.Location = new System.Drawing.Point(60, 181);
            this.Statementpanel.Name = "Statementpanel";
            this.Statementpanel.Size = new System.Drawing.Size(734, 341);
            this.Statementpanel.TabIndex = 8;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 534);
            this.Controls.Add(this.Statementpanel);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.AccountComBo);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox AccountComBo;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Panel Statementpanel;
    }
}