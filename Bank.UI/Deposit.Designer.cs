
namespace Bank.UI
{
    partial class Deposit
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
            this.Amountlabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(153, 81);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Deposit to Account";
            // 
            // AccountComBo
            // 
            this.AccountComBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountComBo.FormattingEnabled = true;
            this.AccountComBo.Location = new System.Drawing.Point(78, 177);
            this.AccountComBo.Name = "AccountComBo";
            this.AccountComBo.Size = new System.Drawing.Size(357, 36);
            this.AccountComBo.TabIndex = 1;
            this.AccountComBo.Text = "Select Account";
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amountlabel.Location = new System.Drawing.Point(78, 231);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(83, 28);
            this.Amountlabel.TabIndex = 2;
            this.Amountlabel.Text = "Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountBox.Location = new System.Drawing.Point(78, 262);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(357, 34);
            this.AmountBox.TabIndex = 3;
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepositBtn.Location = new System.Drawing.Point(176, 402);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(141, 58);
            this.DepositBtn.TabIndex = 4;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteBox.Location = new System.Drawing.Point(78, 339);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(357, 34);
            this.NoteBox.TabIndex = 14;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.Location = new System.Drawing.Point(73, 308);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(56, 28);
            this.Note.TabIndex = 13;
            this.Note.Text = "Note";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(522, 539);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.AccountComBo);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox AccountComBo;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label Note;
    }
}