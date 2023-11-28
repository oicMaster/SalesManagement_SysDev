namespace SalesManagement_SysDev
{
    partial class F_OperationManegement
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
            this.lblBeforePassword = new System.Windows.Forms.Label();
            this.lblAfterPassword = new System.Windows.Forms.Label();
            this.lblAfterPasswordSecond = new System.Windows.Forms.Label();
            this.lblEmID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBeforePassword
            // 
            this.lblBeforePassword.AutoSize = true;
            this.lblBeforePassword.Location = new System.Drawing.Point(146, 154);
            this.lblBeforePassword.Name = "lblBeforePassword";
            this.lblBeforePassword.Size = new System.Drawing.Size(106, 15);
            this.lblBeforePassword.TabIndex = 0;
            this.lblBeforePassword.Text = "現在のパスワード";
            // 
            // lblAfterPassword
            // 
            this.lblAfterPassword.AutoSize = true;
            this.lblAfterPassword.Location = new System.Drawing.Point(146, 190);
            this.lblAfterPassword.Name = "lblAfterPassword";
            this.lblAfterPassword.Size = new System.Drawing.Size(94, 15);
            this.lblAfterPassword.TabIndex = 1;
            this.lblAfterPassword.Text = "更新パスワード";
            // 
            // lblAfterPasswordSecond
            // 
            this.lblAfterPasswordSecond.AutoSize = true;
            this.lblAfterPasswordSecond.Location = new System.Drawing.Point(146, 223);
            this.lblAfterPasswordSecond.Name = "lblAfterPasswordSecond";
            this.lblAfterPasswordSecond.Size = new System.Drawing.Size(94, 15);
            this.lblAfterPasswordSecond.TabIndex = 2;
            this.lblAfterPasswordSecond.Text = "更新パスワード";
            // 
            // lblEmID
            // 
            this.lblEmID.AutoSize = true;
            this.lblEmID.Location = new System.Drawing.Point(201, 114);
            this.lblEmID.Name = "lblEmID";
            this.lblEmID.Size = new System.Drawing.Size(51, 15);
            this.lblEmID.TabIndex = 3;
            this.lblEmID.Text = "社員ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(306, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(306, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // F_OperationManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmID);
            this.Controls.Add(this.lblAfterPasswordSecond);
            this.Controls.Add(this.lblAfterPassword);
            this.Controls.Add(this.lblBeforePassword);
            this.Name = "F_OperationManegement";
            this.Text = "パスワード更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeforePassword;
        private System.Windows.Forms.Label lblAfterPassword;
        private System.Windows.Forms.Label lblAfterPasswordSecond;
        private System.Windows.Forms.Label lblEmID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}