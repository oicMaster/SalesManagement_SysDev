namespace SalesManagement_SysDev
{
    partial class F_Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVisible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.BackColor = System.Drawing.Color.White;
            this.lblLoginID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblLoginID.Location = new System.Drawing.Point(779, 469);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(77, 22);
            this.lblLoginID.TabIndex = 1;
            this.lblLoginID.Text = "社員ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(755, 562);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "パスワード";
            // 
            // txbEmID
            // 
            this.txbEmID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbEmID.Location = new System.Drawing.Point(873, 466);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(168, 29);
            this.txbEmID.TabIndex = 3;
            this.txbEmID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmID_KeyPress);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txbPassword.Location = new System.Drawing.Point(873, 559);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(265, 29);
            this.txbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(614, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "販売管理在庫システム2023";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(858, 659);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 74);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(460, 736);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 74);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.BackColor = System.Drawing.Color.White;
            this.lblVisible.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVisible.Location = new System.Drawing.Point(1144, 562);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(64, 24);
            this.lblVisible.TabIndex = 8;
            this.lblVisible.Text = "(-꒫-)";
            this.lblVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseDown);
            this.lblVisible.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseUp);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblVisible);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLoginID);
            this.Name = "F_Login";
            this.Text = "販売管理システムログイン画面";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVisible;
    }
}

