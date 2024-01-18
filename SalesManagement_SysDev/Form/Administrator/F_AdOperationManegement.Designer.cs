namespace SalesManagement_SysDev
{
    partial class F_AdOperationManegement
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
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblSecondUpdatePassword = new System.Windows.Forms.Label();
            this.lblEmID = new System.Windows.Forms.Label();
            this.txbCurrentPassword = new System.Windows.Forms.TextBox();
            this.txbUpdatePassword = new System.Windows.Forms.TextBox();
            this.txbSecondUpdatePassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVisible = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginNameData = new System.Windows.Forms.Label();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblCurrentPassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(687, 412);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(193, 27);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "現在のパスワード";
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblUpdatePassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUpdatePassword.Location = new System.Drawing.Point(700, 489);
            this.lblUpdatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(171, 27);
            this.lblUpdatePassword.TabIndex = 1;
            this.lblUpdatePassword.Text = "更新パスワード";
            // 
            // lblSecondUpdatePassword
            // 
            this.lblSecondUpdatePassword.AutoSize = true;
            this.lblSecondUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblSecondUpdatePassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSecondUpdatePassword.Location = new System.Drawing.Point(667, 567);
            this.lblSecondUpdatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondUpdatePassword.Name = "lblSecondUpdatePassword";
            this.lblSecondUpdatePassword.Size = new System.Drawing.Size(241, 27);
            this.lblSecondUpdatePassword.TabIndex = 2;
            this.lblSecondUpdatePassword.Text = "更新パスワード(確認)";
            // 
            // lblEmID
            // 
            this.lblEmID.AutoSize = true;
            this.lblEmID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblEmID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmID.Location = new System.Drawing.Point(794, 339);
            this.lblEmID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmID.Name = "lblEmID";
            this.lblEmID.Size = new System.Drawing.Size(114, 27);
            this.lblEmID.TabIndex = 3;
            this.lblEmID.Text = "社員ID　:";
            // 
            // txbCurrentPassword
            // 
            this.txbCurrentPassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbCurrentPassword.Location = new System.Drawing.Point(912, 409);
            this.txbCurrentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbCurrentPassword.Name = "txbCurrentPassword";
            this.txbCurrentPassword.Size = new System.Drawing.Size(226, 34);
            this.txbCurrentPassword.TabIndex = 5;
            this.txbCurrentPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbUpdatePassword
            // 
            this.txbUpdatePassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbUpdatePassword.Location = new System.Drawing.Point(912, 486);
            this.txbUpdatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbUpdatePassword.Name = "txbUpdatePassword";
            this.txbUpdatePassword.Size = new System.Drawing.Size(226, 34);
            this.txbUpdatePassword.TabIndex = 6;
            this.txbUpdatePassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbSecondUpdatePassword
            // 
            this.txbSecondUpdatePassword.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbSecondUpdatePassword.Location = new System.Drawing.Point(912, 564);
            this.txbSecondUpdatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbSecondUpdatePassword.Name = "txbSecondUpdatePassword";
            this.txbSecondUpdatePassword.Size = new System.Drawing.Size(226, 34);
            this.txbSecondUpdatePassword.TabIndex = 7;
            this.txbSecondUpdatePassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdate.Location = new System.Drawing.Point(868, 643);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(458, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 450);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblVisible.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVisible.Location = new System.Drawing.Point(1158, 569);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(64, 24);
            this.lblVisible.TabIndex = 12;
            this.lblVisible.Text = "(-꒫-)";
            this.lblVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseDown);
            this.lblVisible.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseUp);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.lblLoginNameData);
            this.pnlTitle.Controls.Add(this.lblLoginID);
            this.pnlTitle.Controls.Add(this.lblLoginIDData);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblLoginName);
            this.pnlTitle.Controls.Add(this.lblLogin);
            this.pnlTitle.Location = new System.Drawing.Point(0, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1920, 100);
            this.pnlTitle.TabIndex = 163;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1770, 25);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginNameData
            // 
            this.lblLoginNameData.AutoSize = true;
            this.lblLoginNameData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginNameData.Location = new System.Drawing.Point(1392, 70);
            this.lblLoginNameData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginNameData.Name = "lblLoginNameData";
            this.lblLoginNameData.Size = new System.Drawing.Size(98, 21);
            this.lblLoginNameData.TabIndex = 92;
            this.lblLoginNameData.Text = "＿＿＿＿";
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginID.Location = new System.Drawing.Point(1300, 40);
            this.lblLoginID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(87, 21);
            this.lblLoginID.TabIndex = 91;
            this.lblLoginID.Text = "社員ID：";
            // 
            // lblLoginIDData
            // 
            this.lblLoginIDData.AutoSize = true;
            this.lblLoginIDData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginIDData.Location = new System.Drawing.Point(1390, 40);
            this.lblLoginIDData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginIDData.Name = "lblLoginIDData";
            this.lblLoginIDData.Size = new System.Drawing.Size(82, 21);
            this.lblLoginIDData.TabIndex = 90;
            this.lblLoginIDData.Text = "000000";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(500, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 53);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "パスワード更新";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginName.Location = new System.Drawing.Point(1300, 70);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(88, 21);
            this.lblLoginName.TabIndex = 87;
            this.lblLoginName.Text = "管理者：";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(1350, 10);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(120, 21);
            this.lblLogin.TabIndex = 86;
            this.lblLogin.Text = "ログイン情報";
            // 
            // txbEmID
            // 
            this.txbEmID.Enabled = false;
            this.txbEmID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbEmID.Location = new System.Drawing.Point(912, 336);
            this.txbEmID.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(117, 34);
            this.txbEmID.TabIndex = 164;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(1243, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 50);
            this.btnClear.TabIndex = 165;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // F_AdOperationManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.lblVisible);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbSecondUpdatePassword);
            this.Controls.Add(this.txbUpdatePassword);
            this.Controls.Add(this.txbCurrentPassword);
            this.Controls.Add(this.lblEmID);
            this.Controls.Add(this.lblSecondUpdatePassword);
            this.Controls.Add(this.lblUpdatePassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_AdOperationManegement";
            this.Text = "パスワード更新";
            this.Load += new System.EventHandler(this.F_OperationManegement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblSecondUpdatePassword;
        private System.Windows.Forms.Label lblEmID;
        private System.Windows.Forms.TextBox txbCurrentPassword;
        private System.Windows.Forms.TextBox txbUpdatePassword;
        private System.Windows.Forms.TextBox txbSecondUpdatePassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblLoginNameData;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.Button btnClear;
    }
}