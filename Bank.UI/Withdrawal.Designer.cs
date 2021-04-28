
namespace Bank.UI
{
    partial class Withdrawal
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
            this.AccountComBo = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountComBo
            // 
            this.AccountComBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountComBo.FormattingEnabled = true;
            this.AccountComBo.Location = new System.Drawing.Point(72, 150);
            this.AccountComBo.Name = "AccountComBo";
            this.AccountComBo.Size = new System.Drawing.Size(357, 36);
            this.AccountComBo.TabIndex = 2;
            this.AccountComBo.Text = "Select Account";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(144, 67);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(221, 28);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Withdraw from Account";
            // 
            // AmountBox
            // 
            this.AmountBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountBox.Location = new System.Drawing.Point(72, 244);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(357, 34);
            this.AmountBox.TabIndex = 5;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amountlabel.Location = new System.Drawing.Point(72, 213);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(83, 28);
            this.Amountlabel.TabIndex = 4;
            this.Amountlabel.Text = "Amount";
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.WithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WithdrawBtn.Location = new System.Drawing.Point(163, 380);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(141, 58);
            this.WithdrawBtn.TabIndex = 6;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteBox.Location = new System.Drawing.Point(72, 321);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(357, 34);
            this.NoteBox.TabIndex = 14;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.Location = new System.Drawing.Point(67, 290);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(56, 28);
            this.Note.TabIndex = 13;
            this.Note.Text = "Note";
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(500, 483);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.AccountComBo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.Withdrawal_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountComBo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label Note;
    }
}