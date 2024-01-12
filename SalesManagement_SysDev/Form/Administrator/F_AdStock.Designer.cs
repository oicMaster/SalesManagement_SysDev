namespace SalesManagement_SysDev
{
    partial class F_AdStock
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginNameData = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.txbPageNo = new System.Windows.Forms.TextBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.llblPageSize = new System.Windows.Forms.Label();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.txbPrID = new System.Windows.Forms.TextBox();
            this.lblPrID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            this.cbxDisplay = new System.Windows.Forms.CheckBox();
            this.cbxHidden = new System.Windows.Forms.CheckBox();
            this.lblPrName = new System.Windows.Forms.Label();
            this.txbFlag = new System.Windows.Forms.TextBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.txbState = new System.Windows.Forms.TextBox();
            this.lblSafetyStock = new System.Windows.Forms.Label();
            this.lblSafetyStockValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantityCondition = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cbxState = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(1252, 161);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(135, 50);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(990, 367);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1790, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageNo.Location = new System.Drawing.Point(1714, 1001);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblPageNo.TabIndex = 84;
            this.lblPageNo.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageNo.Location = new System.Drawing.Point(1574, 998);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageNo.Multiline = true;
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(130, 30);
            this.txbPageNo.TabIndex = 83;
            this.txbPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.ForeColor = System.Drawing.Color.Black;
            this.btnLastPage.Location = new System.Drawing.Point(1412, 996);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 82;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.ForeColor = System.Drawing.Color.Black;
            this.btnNextPage.Location = new System.Drawing.Point(1354, 996);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnNextPage.TabIndex = 81;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.Black;
            this.btnPreviousPage.Location = new System.Drawing.Point(1294, 996);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnPreviousPage.TabIndex = 80;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.ForeColor = System.Drawing.Color.Black;
            this.btnFirstPage.Location = new System.Drawing.Point(1234, 996);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 79;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageSize.Location = new System.Drawing.Point(154, 998);
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
            this.llblPageSize.Location = new System.Drawing.Point(29, 1001);
            this.llblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblPageSize.Name = "llblPageSize";
            this.llblPageSize.Size = new System.Drawing.Size(125, 22);
            this.llblPageSize.TabIndex = 77;
            this.llblPageSize.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(20, 481);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1880, 514);
            this.dataGridViewDsp.TabIndex = 76;
            this.dataGridViewDsp.TabStop = false;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            this.dataGridViewDsp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDsp_CellFormatting);
            // 
            // txbPrID
            // 
            this.txbPrID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPrID.Location = new System.Drawing.Point(150, 185);
            this.txbPrID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPrID.Multiline = true;
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(115, 25);
            this.txbPrID.TabIndex = 10;
            this.txbPrID.TextChanged += new System.EventHandler(this.txbKeyID_TextChanged);
            this.txbPrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // lblPrID
            // 
            this.lblPrID.AutoSize = true;
            this.lblPrID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPrID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrID.Location = new System.Drawing.Point(67, 187);
            this.lblPrID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrID.Name = "lblPrID";
            this.lblPrID.Size = new System.Drawing.Size(77, 22);
            this.lblPrID.TabIndex = 101;
            this.lblPrID.Text = "商品ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1252, 271);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 50);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1660, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbQuantity.Location = new System.Drawing.Point(531, 186);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbQuantity.Multiline = true;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(100, 25);
            this.txbQuantity.TabIndex = 11;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblQuantity.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(443, 186);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 22);
            this.lblQuantity.TabIndex = 108;
            this.lblQuantity.Text = "在庫数";
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbHidden.Location = new System.Drawing.Point(196, 283);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Multiline = true;
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(982, 25);
            this.txbHidden.TabIndex = 9;
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblHidden.Location = new System.Drawing.Point(67, 282);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(125, 22);
            this.lblHidden.TabIndex = 110;
            this.lblHidden.Text = "非表示理由";
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
            this.lblTitle.Size = new System.Drawing.Size(243, 53);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "在庫管理";
            // 
            // cmbHint
            // 
            this.cmbHint.BackColor = System.Drawing.Color.White;
            this.cmbHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHint.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1460, 187);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(140, 28);
            this.cmbHint.TabIndex = 12;
            this.cmbHint.SelectedIndexChanged += new System.EventHandler(this.cmbHint_SelectedIndexChanged);
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.AutoSize = true;
            this.cbxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxDisplay.Checked = true;
            this.cbxDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxDisplay.ForeColor = System.Drawing.Color.Blue;
            this.cbxDisplay.Location = new System.Drawing.Point(459, 1001);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(98, 26);
            this.cbxDisplay.TabIndex = 92;
            this.cbxDisplay.Text = "未処理";
            this.cbxDisplay.UseVisualStyleBackColor = false;
            // 
            // cbxHidden
            // 
            this.cbxHidden.AutoSize = true;
            this.cbxHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxHidden.ForeColor = System.Drawing.Color.Blue;
            this.cbxHidden.Location = new System.Drawing.Point(560, 1001);
            this.cbxHidden.Name = "cbxHidden";
            this.cbxHidden.Size = new System.Drawing.Size(121, 26);
            this.cbxHidden.TabIndex = 90;
            this.cbxHidden.Text = "非表示済";
            this.cbxHidden.UseVisualStyleBackColor = false;
            // 
            // lblPrName
            // 
            this.lblPrName.AutoSize = true;
            this.lblPrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblPrName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrName.Location = new System.Drawing.Point(149, 165);
            this.lblPrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrName.Name = "lblPrName";
            this.lblPrName.Size = new System.Drawing.Size(43, 16);
            this.lblPrName.TabIndex = 157;
            this.lblPrName.Text = "----";
            // 
            // txbFlag
            // 
            this.txbFlag.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFlag.Location = new System.Drawing.Point(838, 185);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbFlag.Multiline = true;
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.ReadOnly = true;
            this.txbFlag.Size = new System.Drawing.Size(90, 25);
            this.txbFlag.TabIndex = 162;
            this.txbFlag.TextChanged += new System.EventHandler(this.txbFlag_TextChanged);
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblFlag.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFlag.Location = new System.Drawing.Point(682, 187);
            this.lblFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(152, 22);
            this.lblFlag.TabIndex = 163;
            this.lblFlag.Text = "在庫管理フラグ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1900, 918);
            this.pictureBox1.TabIndex = 164;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1456, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 168;
            this.label2.Text = "項目情報";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSort.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(980, 998);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(69, 32);
            this.btnSort.TabIndex = 173;
            this.btnSort.Text = "昇順";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblState.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblState.Location = new System.Drawing.Point(957, 183);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(102, 22);
            this.lblState.TabIndex = 175;
            this.lblState.Text = "在庫状況";
            // 
            // txbState
            // 
            this.txbState.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbState.Location = new System.Drawing.Point(1063, 183);
            this.txbState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbState.Multiline = true;
            this.txbState.Name = "txbState";
            this.txbState.ReadOnly = true;
            this.txbState.Size = new System.Drawing.Size(115, 25);
            this.txbState.TabIndex = 174;
            this.txbState.TextChanged += new System.EventHandler(this.txbFlag_TextChanged);
            // 
            // lblSafetyStock
            // 
            this.lblSafetyStock.AutoSize = true;
            this.lblSafetyStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblSafetyStock.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSafetyStock.Location = new System.Drawing.Point(269, 192);
            this.lblSafetyStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSafetyStock.Name = "lblSafetyStock";
            this.lblSafetyStock.Size = new System.Drawing.Size(101, 16);
            this.lblSafetyStock.TabIndex = 176;
            this.lblSafetyStock.Text = "安全在庫数：";
            // 
            // lblSafetyStockValue
            // 
            this.lblSafetyStockValue.AutoSize = true;
            this.lblSafetyStockValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblSafetyStockValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSafetyStockValue.Location = new System.Drawing.Point(374, 192);
            this.lblSafetyStockValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSafetyStockValue.Name = "lblSafetyStockValue";
            this.lblSafetyStockValue.Size = new System.Drawing.Size(43, 16);
            this.lblSafetyStockValue.TabIndex = 177;
            this.lblSafetyStockValue.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 406;
            this.label1.Text = "検索条件";
            // 
            // lblQuantityCondition
            // 
            this.lblQuantityCondition.AutoSize = true;
            this.lblQuantityCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblQuantityCondition.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuantityCondition.Location = new System.Drawing.Point(201, 383);
            this.lblQuantityCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantityCondition.Name = "lblQuantityCondition";
            this.lblQuantityCondition.Size = new System.Drawing.Size(56, 22);
            this.lblQuantityCondition.TabIndex = 405;
            this.lblQuantityCondition.Text = "数量";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.BackColor = System.Drawing.Color.White;
            this.cmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantity.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(263, 380);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(121, 28);
            this.cmbQuantity.TabIndex = 404;
            // 
            // cbxState
            // 
            this.cbxState.AutoSize = true;
            this.cbxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.cbxState.Checked = true;
            this.cbxState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxState.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxState.ForeColor = System.Drawing.Color.Blue;
            this.cbxState.Location = new System.Drawing.Point(737, 1001);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(121, 26);
            this.cbxState.TabIndex = 407;
            this.cbxState.Text = "在庫充分";
            this.cbxState.UseVisualStyleBackColor = false;
            // 
            // F_AdStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantityCondition);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.lblSafetyStockValue);
            this.Controls.Add(this.lblSafetyStock);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txbState);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDisplay);
            this.Controls.Add(this.txbFlag);
            this.Controls.Add(this.txbPageNo);
            this.Controls.Add(this.cbxHidden);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.llblPageSize);
            this.Controls.Add(this.lblPrName);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPrID);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "F_AdStock";
            this.Text = "在庫管理";
            this.Load += new System.EventHandler(this.F_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLoginNameData;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.TextBox txbPageNo;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label llblPageSize;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.TextBox txbPrID;
        private System.Windows.Forms.Label lblPrID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbHint;
        private System.Windows.Forms.Label lblPrName;
        private System.Windows.Forms.CheckBox cbxHidden;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.CheckBox cbxDisplay;
        private System.Windows.Forms.TextBox txbFlag;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Label lblSafetyStock;
        private System.Windows.Forms.Label lblSafetyStockValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantityCondition;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.CheckBox cbxState;
    }
}
