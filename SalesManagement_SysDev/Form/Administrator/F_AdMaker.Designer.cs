namespace SalesManagement_SysDev
{
    partial class F_AdMaker
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
            this.txbPostal = new System.Windows.Forms.TextBox();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.cbxDisplay = new System.Windows.Forms.CheckBox();
            this.cbxHidden = new System.Windows.Forms.CheckBox();
            this.txbPageNo = new System.Windows.Forms.TextBox();
            this.llblPageSize = new System.Windows.Forms.Label();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFAX = new System.Windows.Forms.Label();
            this.txbFAX = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLoginNameData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMaID = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbMaID = new System.Windows.Forms.TextBox();
            this.txbFlag = new System.Windows.Forms.TextBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPostal
            // 
            this.txbPostal.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPostal.Location = new System.Drawing.Point(164, 317);
            this.txbPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txbPostal.Name = "txbPostal";
            this.txbPostal.Size = new System.Drawing.Size(115, 28);
            this.txbPostal.TabIndex = 167;
            this.txbPostal.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(20, 491);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1880, 538);
            this.dataGridViewDsp.TabIndex = 76;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            this.dataGridViewDsp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDsp_CellFormatting);
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.AutoSize = true;
            this.cbxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxDisplay.Checked = true;
            this.cbxDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxDisplay.ForeColor = System.Drawing.Color.Blue;
            this.cbxDisplay.Location = new System.Drawing.Point(420, 1035);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(98, 26);
            this.cbxDisplay.TabIndex = 165;
            this.cbxDisplay.Text = "未処理";
            this.cbxDisplay.UseVisualStyleBackColor = false;
            this.cbxDisplay.CheckedChanged += new System.EventHandler(this.cbxFlag_CheckedChanged);
            // 
            // cbxHidden
            // 
            this.cbxHidden.AutoSize = true;
            this.cbxHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxHidden.ForeColor = System.Drawing.Color.Blue;
            this.cbxHidden.Location = new System.Drawing.Point(524, 1035);
            this.cbxHidden.Name = "cbxHidden";
            this.cbxHidden.Size = new System.Drawing.Size(121, 26);
            this.cbxHidden.TabIndex = 90;
            this.cbxHidden.Text = "非表示済";
            this.cbxHidden.UseVisualStyleBackColor = false;
            this.cbxHidden.CheckedChanged += new System.EventHandler(this.cbxFlag_CheckedChanged);
            // 
            // txbPageNo
            // 
            this.txbPageNo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageNo.Location = new System.Drawing.Point(1441, 1032);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageNo.Multiline = true;
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(130, 30);
            this.txbPageNo.TabIndex = 83;
            this.txbPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPageNo.TextChanged += new System.EventHandler(this.txbPageNo_TextChanged);
            this.txbPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPageNo_KeyPress);
            this.txbPageNo.Leave += new System.EventHandler(this.txbPageNo_Leave);
            // 
            // llblPageSize
            // 
            this.llblPageSize.AutoSize = true;
            this.llblPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.llblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.llblPageSize.Location = new System.Drawing.Point(58, 1035);
            this.llblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblPageSize.Name = "llblPageSize";
            this.llblPageSize.Size = new System.Drawing.Size(125, 22);
            this.llblPageSize.TabIndex = 77;
            this.llblPageSize.Text = "1ページ行数";
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbPageSize.Location = new System.Drawing.Point(187, 1032);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageSize.Multiline = true;
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 30);
            this.txbPageSize.TabIndex = 78;
            this.txbPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPageSize.TextChanged += new System.EventHandler(this.txbPageSize_TextChanged);
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            this.txbPageSize.Leave += new System.EventHandler(this.txbPageSize_Leave);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.Location = new System.Drawing.Point(1056, 1032);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 79;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.Location = new System.Drawing.Point(1114, 1032);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnPreviousPage.TabIndex = 80;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.Location = new System.Drawing.Point(1172, 1032);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnNextPage.TabIndex = 81;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.Location = new System.Drawing.Point(1230, 1032);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 82;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageNo.Location = new System.Drawing.Point(1575, 1035);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblPageNo.TabIndex = 84;
            this.lblPageNo.Text = "ページ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(1281, 380);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 50);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFAX
            // 
            this.lblFAX.AutoSize = true;
            this.lblFAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblFAX.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFAX.Location = new System.Drawing.Point(638, 317);
            this.lblFAX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFAX.Name = "lblFAX";
            this.lblFAX.Size = new System.Drawing.Size(52, 22);
            this.lblFAX.TabIndex = 163;
            this.lblFAX.Text = "FAX";
            // 
            // txbFAX
            // 
            this.txbFAX.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFAX.Location = new System.Drawing.Point(698, 315);
            this.txbFAX.Margin = new System.Windows.Forms.Padding(2);
            this.txbFAX.Name = "txbFAX";
            this.txbFAX.Size = new System.Drawing.Size(184, 28);
            this.txbFAX.TabIndex = 162;
            this.txbFAX.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(500, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 53);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "メーカ管理";
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
            this.pnlTitle.TabIndex = 2000;
            // 
            // cmbHint
            // 
            this.cmbHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHint.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1465, 189);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(140, 28);
            this.cmbHint.TabIndex = 158;
            this.cmbHint.SelectedIndexChanged += new System.EventHandler(this.cmbHint_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(1281, 271);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 50);
            this.btnClear.TabIndex = 135;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPhone.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(318, 317);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 22);
            this.lblPhone.TabIndex = 133;
            this.lblPhone.Text = "電話番号";
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPhone.Location = new System.Drawing.Point(428, 315);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(175, 28);
            this.txbPhone.TabIndex = 134;
            this.txbPhone.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(1659, 167);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 132;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(58, 241);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 22);
            this.lblAddress.TabIndex = 97;
            this.lblAddress.Text = "住所";
            // 
            // lblMaID
            // 
            this.lblMaID.AutoSize = true;
            this.lblMaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblMaID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblMaID.Location = new System.Drawing.Point(58, 167);
            this.lblMaID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaID.Name = "lblMaID";
            this.lblMaID.Size = new System.Drawing.Size(83, 22);
            this.lblMaID.TabIndex = 99;
            this.lblMaID.Text = "メーカID";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPostal.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPostal.Location = new System.Drawing.Point(58, 318);
            this.lblPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(102, 22);
            this.lblPostal.TabIndex = 100;
            this.lblPostal.Text = "郵便番号";
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblFlag.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFlag.Location = new System.Drawing.Point(918, 317);
            this.lblFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(158, 22);
            this.lblFlag.TabIndex = 101;
            this.lblFlag.Text = "メーカ管理フラグ";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblHidden.Location = new System.Drawing.Point(58, 408);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(125, 22);
            this.lblHidden.TabIndex = 102;
            this.lblHidden.Text = "非表示理由";
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbAddress.Location = new System.Drawing.Point(130, 238);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(860, 28);
            this.txbAddress.TabIndex = 104;
            this.txbAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(397, 167);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(606, 28);
            this.txbName.TabIndex = 105;
            this.txbName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txbMaID
            // 
            this.txbMaID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbMaID.Location = new System.Drawing.Point(143, 165);
            this.txbMaID.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaID.Name = "txbMaID";
            this.txbMaID.Size = new System.Drawing.Size(115, 28);
            this.txbMaID.TabIndex = 106;
            this.txbMaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbFlag
            // 
            this.txbFlag.Enabled = false;
            this.txbFlag.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFlag.Location = new System.Drawing.Point(1080, 315);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(2);
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.Size = new System.Drawing.Size(90, 28);
            this.txbFlag.TabIndex = 108;
            this.txbFlag.TextChanged += new System.EventHandler(this.txbFlag_TextChanged);
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbHidden.Location = new System.Drawing.Point(188, 406);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(985, 28);
            this.txbHidden.TabIndex = 109;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(1281, 167);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(135, 50);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegist.Enabled = false;
            this.btnRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegist.Location = new System.Drawing.Point(1659, 380);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(135, 50);
            this.btnRegist.TabIndex = 127;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(308, 167);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 22);
            this.lblName.TabIndex = 128;
            this.lblName.Text = "メーカ名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1900, 946);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1461, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 169;
            this.label1.Text = "項目情報";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(841, 1032);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(69, 32);
            this.btnSort.TabIndex = 173;
            this.btnSort.Text = "昇順";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // F_AdMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDisplay);
            this.Controls.Add(this.cbxHidden);
            this.Controls.Add(this.txbPostal);
            this.Controls.Add(this.txbPageNo);
            this.Controls.Add(this.llblPageSize);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblFAX);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txbFAX);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.txbFlag);
            this.Controls.Add(this.txbMaID);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblMaID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_AdMaker";
            this.Text = "メーカ管理";
            this.Load += new System.EventHandler(this.F_Maker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPostal;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.CheckBox cbxDisplay;
        private System.Windows.Forms.CheckBox cbxHidden;
        private System.Windows.Forms.TextBox txbPageNo;
        private System.Windows.Forms.Label llblPageSize;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFAX;
        private System.Windows.Forms.TextBox txbFAX;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLoginNameData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.ComboBox cmbHint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMaID;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbMaID;
        private System.Windows.Forms.TextBox txbFlag;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSort;
    }
}
