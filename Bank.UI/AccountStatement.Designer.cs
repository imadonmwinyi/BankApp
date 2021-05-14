
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
            this.ViewStsBtn = new System.Windows.Forms.Button();
            this.Statementpanel = new System.Windows.Forms.Panel();
            this.StatementListView = new System.Windows.Forms.ListView();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.trasactType = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.note = new System.Windows.Forms.ColumnHeader();
            this.Statementpanel.SuspendLayout();
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
            // ViewStsBtn
            // 
            this.ViewStsBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ViewStsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewStsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewStsBtn.Location = new System.Drawing.Point(463, 99);
            this.ViewStsBtn.Name = "ViewStsBtn";
            this.ViewStsBtn.Size = new System.Drawing.Size(331, 41);
            this.ViewStsBtn.TabIndex = 7;
            this.ViewStsBtn.Text = "View Statement";
            this.ViewStsBtn.UseVisualStyleBackColor = false;
            this.ViewStsBtn.Click += new System.EventHandler(this.ViewStsBtn_Click);
            // 
            // Statementpanel
            // 
            this.Statementpanel.Controls.Add(this.StatementListView);
            this.Statementpanel.Location = new System.Drawing.Point(60, 181);
            this.Statementpanel.Name = "Statementpanel";
            this.Statementpanel.Size = new System.Drawing.Size(734, 341);
            this.Statementpanel.TabIndex = 8;
            // 
            // StatementListView
            // 
            this.StatementListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.trasactType,
            this.amount,
            this.note});
            this.StatementListView.GridLines = true;
            this.StatementListView.HideSelection = false;
            this.StatementListView.Location = new System.Drawing.Point(0, 16);
            this.StatementListView.Name = "StatementListView";
            this.StatementListView.Size = new System.Drawing.Size(734, 312);
            this.StatementListView.TabIndex = 0;
            this.StatementListView.UseCompatibleStateImageBehavior = false;
            this.StatementListView.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 200;
            // 
            // trasactType
            // 
            this.trasactType.Text = "Transaction Type";
            this.trasactType.Width = 200;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 200;
            // 
            // note
            // 
            this.note.Text = "Note";
            this.note.Width = 200;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 534);
            this.Controls.Add(this.Statementpanel);
            this.Controls.Add(this.ViewStsBtn);
            this.Controls.Add(this.AccountComBo);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.Load += new System.EventHandler(this.ViewStatement_Onload);
            this.Statementpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox AccountComBo;
        private System.Windows.Forms.Button ViewStsBtn;
        private System.Windows.Forms.Panel Statementpanel;
        private System.Windows.Forms.ListView StatementListView;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader trasactType;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader note;
    }
}