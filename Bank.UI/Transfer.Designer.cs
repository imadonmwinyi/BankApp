
namespace Bank.UI
{
    partial class Transfer
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
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.BenAcctBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(164, 67);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(128, 28);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Transfer Fund";
            // 
            // AccountComBo
            // 
            this.AccountComBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountComBo.FormattingEnabled = true;
            this.AccountComBo.Location = new System.Drawing.Point(63, 139);
            this.AccountComBo.Name = "AccountComBo";
            this.AccountComBo.Size = new System.Drawing.Size(357, 36);
            this.AccountComBo.TabIndex = 5;
            this.AccountComBo.Text = "Select Account";
            // 
            // AmountBox
            // 
            this.AmountBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountBox.Location = new System.Drawing.Point(63, 296);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(357, 34);
            this.AmountBox.TabIndex = 7;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amountlabel.Location = new System.Drawing.Point(63, 265);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(83, 28);
            this.Amountlabel.TabIndex = 6;
            this.Amountlabel.Text = "Amount";
            // 
            // BenAcctBox
            // 
            this.BenAcctBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BenAcctBox.Location = new System.Drawing.Point(63, 228);
            this.BenAcctBox.Name = "BenAcctBox";
            this.BenAcctBox.Size = new System.Drawing.Size(357, 34);
            this.BenAcctBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Beneficiary Account";
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.TransferBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransferBtn.Location = new System.Drawing.Point(149, 425);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(141, 58);
            this.TransferBtn.TabIndex = 10;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteBox.Location = new System.Drawing.Point(64, 373);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(357, 34);
            this.NoteBox.TabIndex = 12;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.Location = new System.Drawing.Point(59, 342);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(56, 28);
            this.Note.TabIndex = 11;
            this.Note.Text = "Note";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(475, 533);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.BenAcctBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.AccountComBo);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox AccountComBo;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.TextBox BenAcctBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label Note;
    }
}