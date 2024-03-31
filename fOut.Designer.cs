namespace MoneyBook
{
    partial class fOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "등록일";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "분류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "비고";
            // 
            // tbType
            // 
            this.tbType.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbType.Location = new System.Drawing.Point(98, 97);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(257, 21);
            this.tbType.TabIndex = 2;
            // 
            // tbAmt
            // 
            this.tbAmt.Location = new System.Drawing.Point(98, 143);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(257, 21);
            this.tbAmt.TabIndex = 3;
            // 
            // tbMemo
            // 
            this.tbMemo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMemo.Location = new System.Drawing.Point(98, 184);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(257, 169);
            this.tbMemo.TabIndex = 4;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(98, 46);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(257, 21);
            this.dtDate.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(98, 376);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(257, 26);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "확인";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // fOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 472);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "출금";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOK;
        public System.Windows.Forms.TextBox tbType;
        public System.Windows.Forms.TextBox tbAmt;
        public System.Windows.Forms.TextBox tbMemo;
        public System.Windows.Forms.DateTimePicker dtDate;
    }
}