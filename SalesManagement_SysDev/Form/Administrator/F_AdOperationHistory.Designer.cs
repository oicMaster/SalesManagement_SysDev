namespace SalesManagement_SysDev
{
    partial class F_AdOperationHistory
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
            this.lblButton = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblForm = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginNameData = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDateCondition = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.llblPageSize = new System.Windows.Forms.Label();
            this.txbPageNo = new System.Windows.Forms.TextBox();
            this.cbxAccount = new System.Windows.Forms.CheckBox();
            this.cbxDisplay = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblButton.Location = new System.Drawing.Point(331, 150);
            this.lblButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(108, 22);
            this.lblButton.TabIndex = 129;
            this.lblButton.Text = "操作ボタン";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(1281, 147);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(135, 50);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblForm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblForm.Location = new System.Drawing.Point(50, 150);
            this.lblForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(79, 22);
            this.lblForm.TabIndex = 97;
            this.lblForm.Text = "管理名";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.lblLoginID);
            this.pnlTitle.Controls.Add(this.lblLoginIDData);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblLoginNameData);
            this.pnlTitle.Controls.Add(this.lblLogin);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Location = new System.Drawing.Point(0, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1920, 100);
            this.pnlTitle.TabIndex = 161;
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
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(500, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 53);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "ログ管理";
            // 
            // lblLoginNameData
            // 
            this.lblLoginNameData.AutoSize = true;
            this.lblLoginNameData.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginNameData.Location = new System.Drawing.Point(1300, 70);
            this.lblLoginNameData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginNameData.Name = "lblLoginNameData";
            this.lblLoginNameData.Size = new System.Drawing.Size(116, 21);
            this.lblLoginNameData.TabIndex = 87;
            this.lblLoginNameData.Text = "管理者：____";
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1770, 25);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDateCondition
            // 
            this.lblDateCondition.AutoSize = true;
            this.lblDateCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblDateCondition.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblDateCondition.Location = new System.Drawing.Point(173, 212);
            this.lblDateCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCondition.Name = "lblDateCondition";
            this.lblDateCondition.Size = new System.Drawing.Size(79, 22);
            this.lblDateCondition.TabIndex = 161;
            this.lblDateCondition.Text = "操作日";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblCondition.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblCondition.Location = new System.Drawing.Point(50, 210);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(110, 24);
            this.lblCondition.TabIndex = 87;
            this.lblCondition.Text = "検索条件";
            // 
            // cmbDate
            // 
            this.cmbDate.BackColor = System.Drawing.Color.White;
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(257, 210);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 28);
            this.cmbDate.TabIndex = 1;
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(20, 285);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1880, 731);
            this.dataGridViewDsp.TabIndex = 76;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(1007, 210);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 50);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageNo.Location = new System.Drawing.Point(1583, 1025);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblPageNo.TabIndex = 84;
            this.lblPageNo.Text = "ページ";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.Location = new System.Drawing.Point(1302, 1019);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 82;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.Location = new System.Drawing.Point(1244, 1019);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnNextPage.TabIndex = 81;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.Location = new System.Drawing.Point(1186, 1019);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnPreviousPage.TabIndex = 80;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.Location = new System.Drawing.Point(1128, 1019);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 79;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txbPageSize.Location = new System.Drawing.Point(169, 1021);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageSize.Multiline = true;
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 30);
            this.txbPageSize.TabIndex = 78;
            this.txbPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // llblPageSize
            // 
            this.llblPageSize.AutoSize = true;
            this.llblPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.llblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.llblPageSize.Location = new System.Drawing.Point(40, 1025);
            this.llblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblPageSize.Name = "llblPageSize";
            this.llblPageSize.Size = new System.Drawing.Size(125, 22);
            this.llblPageSize.TabIndex = 77;
            this.llblPageSize.Text = "1ページ行数";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txbPageNo.Location = new System.Drawing.Point(1449, 1021);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageNo.Multiline = true;
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(130, 30);
            this.txbPageNo.TabIndex = 83;
            this.txbPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxAccount
            // 
            this.cbxAccount.AutoSize = true;
            this.cbxAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxAccount.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxAccount.Location = new System.Drawing.Point(551, 1023);
            this.cbxAccount.Name = "cbxAccount";
            this.cbxAccount.Size = new System.Drawing.Size(197, 26);
            this.cbxAccount.TabIndex = 90;
            this.cbxAccount.Text = "ログイン・ログアウト";
            this.cbxAccount.UseVisualStyleBackColor = false;
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.AutoSize = true;
            this.cbxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxDisplay.Checked = true;
            this.cbxDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxDisplay.Location = new System.Drawing.Point(424, 1023);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(121, 26);
            this.cbxDisplay.TabIndex = 165;
            this.cbxDisplay.Text = "管理操作";
            this.cbxDisplay.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(660, 150);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 22);
            this.lblDate.TabIndex = 100;
            this.lblDate.Text = "操作日";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Location = new System.Drawing.Point(750, 147);
            this.dtpDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(186, 29);
            this.dtpDate.TabIndex = 160;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 29);
            this.comboBox1.TabIndex = 166;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(444, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 29);
            this.comboBox2.TabIndex = 167;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(861, 1019);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(69, 32);
            this.btnSort.TabIndex = 173;
            this.btnSort.Text = "降順";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1900, 941);
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1475, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 176;
            this.label1.Text = "項目情報";
            // 
            // cmbHint
            // 
            this.cmbHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHint.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1479, 169);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(140, 28);
            this.cmbHint.TabIndex = 175;
            // 
            // F_AdOperationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.cbxDisplay);
            this.Controls.Add(this.lblDateCondition);
            this.Controls.Add(this.cbxAccount);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.txbPageNo);
            this.Controls.Add(this.llblPageSize);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_AdOperationHistory";
            this.Text = "ログ管理";
            this.Load += new System.EventHandler(this.F_AdOperationHistory_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginNameData;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label llblPageSize;
        private System.Windows.Forms.TextBox txbPageNo;
        private System.Windows.Forms.CheckBox cbxAccount;
        private System.Windows.Forms.CheckBox cbxDisplay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHint;
    }
}
