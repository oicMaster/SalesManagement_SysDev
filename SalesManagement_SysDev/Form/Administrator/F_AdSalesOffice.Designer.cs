namespace SalesManagement_SysDev
{
    partial class F_AdSalesOffice
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.txbFlag = new System.Windows.Forms.TextBox();
            this.txbSoID = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblSoID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginNameData = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txbFAX = new System.Windows.Forms.TextBox();
            this.lblFAX = new System.Windows.Forms.Label();
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
            this.cbxHidden = new System.Windows.Forms.CheckBox();
            this.cbxDisplay = new System.Windows.Forms.CheckBox();
            this.txbPostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(410, 148);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(860, 28);
            this.txbName.TabIndex = 131;
            this.txbName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(300, 150);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 22);
            this.lblName.TabIndex = 129;
            this.lblName.Text = "営業所名";
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegist.Enabled = false;
            this.btnRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegist.Location = new System.Drawing.Point(1668, 364);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(135, 50);
            this.btnRegist.TabIndex = 127;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(1315, 150);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(135, 50);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbHidden.Location = new System.Drawing.Point(180, 377);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1090, 28);
            this.txbHidden.TabIndex = 109;
            // 
            // txbFlag
            // 
            this.txbFlag.Enabled = false;
            this.txbFlag.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFlag.Location = new System.Drawing.Point(1100, 291);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(2);
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.Size = new System.Drawing.Size(90, 28);
            this.txbFlag.TabIndex = 108;
            this.txbFlag.TextChanged += new System.EventHandler(this.txbFlag_TextChanged);
            // 
            // txbSoID
            // 
            this.txbSoID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbSoID.Location = new System.Drawing.Point(155, 148);
            this.txbSoID.Margin = new System.Windows.Forms.Padding(2);
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(115, 28);
            this.txbSoID.TabIndex = 106;
            this.txbSoID.TextChanged += new System.EventHandler(this.txbKeyID_TextChanged);
            this.txbSoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbAddress.Location = new System.Drawing.Point(110, 217);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(860, 28);
            this.txbAddress.TabIndex = 104;
            this.txbAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblHidden.Location = new System.Drawing.Point(50, 379);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(125, 22);
            this.lblHidden.TabIndex = 102;
            this.lblHidden.Text = "非表示理由";
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblFlag.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFlag.Location = new System.Drawing.Point(920, 293);
            this.lblFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(175, 22);
            this.lblFlag.TabIndex = 101;
            this.lblFlag.Text = "営業所管理フラグ";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPostal.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPostal.Location = new System.Drawing.Point(50, 293);
            this.lblPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(102, 22);
            this.lblPostal.TabIndex = 100;
            this.lblPostal.Text = "郵便番号";
            // 
            // lblSoID
            // 
            this.lblSoID.AutoSize = true;
            this.lblSoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblSoID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoID.Location = new System.Drawing.Point(50, 150);
            this.lblSoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoID.Name = "lblSoID";
            this.lblSoID.Size = new System.Drawing.Size(100, 22);
            this.lblSoID.TabIndex = 99;
            this.lblSoID.Text = "営業所ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(50, 220);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 22);
            this.lblAddress.TabIndex = 97;
            this.lblAddress.Text = "住所";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(1668, 147);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 132;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPhone.Location = new System.Drawing.Point(430, 291);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(172, 28);
            this.txbPhone.TabIndex = 134;
            this.txbPhone.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPhone.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(320, 293);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 22);
            this.lblPhone.TabIndex = 133;
            this.lblPhone.Text = "電話番号";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(1316, 253);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 50);
            this.btnClear.TabIndex = 135;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbHint
            // 
            this.cmbHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHint.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1490, 172);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(140, 28);
            this.cmbHint.TabIndex = 158;
            this.cmbHint.SelectedIndexChanged += new System.EventHandler(this.cmbHint_SelectedIndexChanged);
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
            this.lblTitle.Size = new System.Drawing.Size(298, 53);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "営業所管理";
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
            // txbFAX
            // 
            this.txbFAX.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFAX.Location = new System.Drawing.Point(700, 291);
            this.txbFAX.Margin = new System.Windows.Forms.Padding(2);
            this.txbFAX.Name = "txbFAX";
            this.txbFAX.Size = new System.Drawing.Size(173, 28);
            this.txbFAX.TabIndex = 162;
            this.txbFAX.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblFAX
            // 
            this.lblFAX.AutoSize = true;
            this.lblFAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblFAX.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFAX.Location = new System.Drawing.Point(640, 293);
            this.lblFAX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFAX.Name = "lblFAX";
            this.lblFAX.Size = new System.Drawing.Size(52, 22);
            this.lblFAX.TabIndex = 163;
            this.lblFAX.Text = "FAX";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(20, 468);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1880, 538);
            this.dataGridViewDsp.TabIndex = 76;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            this.dataGridViewDsp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDsp_CellFormatting);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(1316, 364);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 50);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageNo.Location = new System.Drawing.Point(1736, 1012);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblPageNo.TabIndex = 84;
            this.lblPageNo.Text = "ページ";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.Location = new System.Drawing.Point(1456, 1007);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 82;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.Location = new System.Drawing.Point(1396, 1007);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnNextPage.TabIndex = 81;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.Location = new System.Drawing.Point(1316, 1007);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnPreviousPage.TabIndex = 80;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.Location = new System.Drawing.Point(1256, 1007);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 79;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageSize.Location = new System.Drawing.Point(176, 1010);
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
            // llblPageSize
            // 
            this.llblPageSize.AutoSize = true;
            this.llblPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.llblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.llblPageSize.Location = new System.Drawing.Point(46, 1012);
            this.llblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblPageSize.Name = "llblPageSize";
            this.llblPageSize.Size = new System.Drawing.Size(125, 22);
            this.llblPageSize.TabIndex = 77;
            this.llblPageSize.Text = "1ページ行数";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageNo.Location = new System.Drawing.Point(1596, 1009);
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
            // cbxHidden
            // 
            this.cbxHidden.AutoSize = true;
            this.cbxHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxHidden.ForeColor = System.Drawing.Color.Blue;
            this.cbxHidden.Location = new System.Drawing.Point(736, 1012);
            this.cbxHidden.Name = "cbxHidden";
            this.cbxHidden.Size = new System.Drawing.Size(121, 26);
            this.cbxHidden.TabIndex = 90;
            this.cbxHidden.Text = "非表示済";
            this.cbxHidden.UseVisualStyleBackColor = false;
            this.cbxHidden.CheckedChanged += new System.EventHandler(this.cbxFlag_CheckedChanged);
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.AutoSize = true;
            this.cbxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxDisplay.Checked = true;
            this.cbxDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxDisplay.ForeColor = System.Drawing.Color.Blue;
            this.cbxDisplay.Location = new System.Drawing.Point(617, 1012);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(98, 26);
            this.cbxDisplay.TabIndex = 165;
            this.cbxDisplay.Text = "未処理";
            this.cbxDisplay.UseVisualStyleBackColor = false;
            this.cbxDisplay.CheckedChanged += new System.EventHandler(this.cbxFlag_CheckedChanged);
            // 
            // txbPostal
            // 
            this.txbPostal.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPostal.Location = new System.Drawing.Point(160, 291);
            this.txbPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txbPostal.Name = "txbPostal";
            this.txbPostal.Size = new System.Drawing.Size(115, 28);
            this.txbPostal.TabIndex = 167;
            this.txbPostal.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1486, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 168;
            this.label1.Text = "項目情報";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1900, 925);
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(979, 1006);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(69, 32);
            this.btnSort.TabIndex = 172;
            this.btnSort.Text = "昇順";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // F_AdSalesOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDisplay);
            this.Controls.Add(this.cbxHidden);
            this.Controls.Add(this.txbPageNo);
            this.Controls.Add(this.llblPageSize);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.txbPostal);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.lblFAX);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txbFAX);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.txbFlag);
            this.Controls.Add(this.txbSoID);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblSoID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_AdSalesOffice";
            this.Text = "営業所管理";
            this.Load += new System.EventHandler(this.F_SalesOffice_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.TextBox txbFlag;
        private System.Windows.Forms.TextBox txbSoID;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblSoID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbHint;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginNameData;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbFAX;
        private System.Windows.Forms.Label lblFAX;
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
        private System.Windows.Forms.CheckBox cbxHidden;
        private System.Windows.Forms.CheckBox cbxDisplay;
        private System.Windows.Forms.TextBox txbPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSort;
    }
}

