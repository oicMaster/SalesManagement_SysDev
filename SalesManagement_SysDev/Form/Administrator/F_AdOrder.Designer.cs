﻿namespace SalesManagement_SysDev
{
    partial class F_AdOrder
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
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.txbFlag = new System.Windows.Forms.TextBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.txbStateFlag = new System.Windows.Forms.TextBox();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.txbSoID = new System.Windows.Forms.TextBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblStateFlag = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmID = new System.Windows.Forms.Label();
            this.lblOrID = new System.Windows.Forms.Label();
            this.lblSoID = new System.Windows.Forms.Label();
            this.lblClID = new System.Windows.Forms.Label();
            this.txbOrID = new System.Windows.Forms.TextBox();
            this.txbClID = new System.Windows.Forms.TextBox();
            this.txbOrDetailID = new System.Windows.Forms.TextBox();
            this.lblOrDetailID = new System.Windows.Forms.Label();
            this.dataGridViewDetailDsp = new System.Windows.Forms.DataGridView();
            this.btnDetailSearch = new System.Windows.Forms.Button();
            this.txbPrID = new System.Windows.Forms.TextBox();
            this.lblPrID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbOrIDsub = new System.Windows.Forms.TextBox();
            this.lblOrIDsub = new System.Windows.Forms.Label();
            this.lblDetailPageNo = new System.Windows.Forms.Label();
            this.txbDetailPageNo = new System.Windows.Forms.TextBox();
            this.btnDetailLastPage = new System.Windows.Forms.Button();
            this.btnDetailNextPage = new System.Windows.Forms.Button();
            this.btnDetailPreviousPage = new System.Windows.Forms.Button();
            this.btnDetailFirstPage = new System.Windows.Forms.Button();
            this.txbDetailPageSize = new System.Windows.Forms.TextBox();
            this.lblDetailPageSize = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginIDData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.cbxConfirm = new System.Windows.Forms.CheckBox();
            this.cbxHidden = new System.Windows.Forms.CheckBox();
            this.pnlDetailDataGridView = new System.Windows.Forms.Panel();
            this.lblPrName = new System.Windows.Forms.Label();
            this.lblSoName = new System.Windows.Forms.Label();
            this.lblEmName = new System.Windows.Forms.Label();
            this.lblClName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txbCharge = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.pnlCondition = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.cbxDisplay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTotalPrice = new System.Windows.Forms.ComboBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnDetailRegist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDsp)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            this.pnlDetailDataGridView.SuspendLayout();
            this.pnlCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(1700, 175);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 45);
            this.btnConfirm.TabIndex = 92;
            this.btnConfirm.Text = "発注確定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(1300, 140);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(135, 45);
            this.btnDisplay.TabIndex = 91;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(1000, 327);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 40);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1790, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.lblPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageNo.Location = new System.Drawing.Point(1780, 335);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblPageNo.TabIndex = 84;
            this.lblPageNo.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageNo.Location = new System.Drawing.Point(1710, 332);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageNo.Multiline = true;
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(65, 30);
            this.txbPageNo.TabIndex = 83;
            this.txbPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPageNo.TextChanged += new System.EventHandler(this.txbPageNo_TextChanged);
            this.txbPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.Location = new System.Drawing.Point(1570, 330);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 82;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            this.btnLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.Location = new System.Drawing.Point(1510, 330);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnNextPage.TabIndex = 81;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            this.btnNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.Location = new System.Drawing.Point(1420, 330);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnPreviousPage.TabIndex = 80;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            this.btnPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.Location = new System.Drawing.Point(1360, 330);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 79;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            this.btnFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbPageSize.Location = new System.Drawing.Point(140, 332);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPageSize.Multiline = true;
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(50, 30);
            this.txbPageSize.TabIndex = 78;
            this.txbPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPageSize.TextChanged += new System.EventHandler(this.txbPageSize_TextChanged);
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // llblPageSize
            // 
            this.llblPageSize.AutoSize = true;
            this.llblPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.llblPageSize.Location = new System.Drawing.Point(15, 335);
            this.llblPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblPageSize.Name = "llblPageSize";
            this.llblPageSize.Size = new System.Drawing.Size(125, 22);
            this.llblPageSize.TabIndex = 77;
            this.llblPageSize.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(1880, 314);
            this.dataGridViewDsp.TabIndex = 76;
            this.dataGridViewDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsp_CellClick);
            // 
            // txbFlag
            // 
            this.txbFlag.Enabled = false;
            this.txbFlag.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbFlag.Location = new System.Drawing.Point(1155, 195);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbFlag.Multiline = true;
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.Size = new System.Drawing.Size(90, 25);
            this.txbFlag.TabIndex = 75;
            // 
            // txbHidden
            // 
            this.txbHidden.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbHidden.Location = new System.Drawing.Point(180, 245);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbHidden.Multiline = true;
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(1065, 25);
            this.txbHidden.TabIndex = 74;
            this.txbHidden.TextChanged += new System.EventHandler(this.txbHidden_TextChanged);
            // 
            // txbStateFlag
            // 
            this.txbStateFlag.Enabled = false;
            this.txbStateFlag.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbStateFlag.Location = new System.Drawing.Point(880, 195);
            this.txbStateFlag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbStateFlag.Multiline = true;
            this.txbStateFlag.Name = "txbStateFlag";
            this.txbStateFlag.Size = new System.Drawing.Size(90, 25);
            this.txbStateFlag.TabIndex = 73;
            // 
            // txbEmID
            // 
            this.txbEmID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbEmID.Location = new System.Drawing.Point(640, 145);
            this.txbEmID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbEmID.Multiline = true;
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(115, 25);
            this.txbEmID.TabIndex = 71;
            this.txbEmID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbSoID
            // 
            this.txbSoID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbSoID.Location = new System.Drawing.Point(400, 145);
            this.txbSoID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbSoID.Multiline = true;
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(115, 25);
            this.txbSoID.TabIndex = 70;
            this.txbSoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblFlag.Location = new System.Drawing.Point(1000, 195);
            this.lblFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(152, 22);
            this.lblFlag.TabIndex = 68;
            this.lblFlag.Text = "入荷管理フラグ";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblHidden.Location = new System.Drawing.Point(50, 245);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(125, 22);
            this.lblHidden.TabIndex = 67;
            this.lblHidden.Text = "非表示理由";
            // 
            // lblStateFlag
            // 
            this.lblStateFlag.AutoSize = true;
            this.lblStateFlag.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblStateFlag.Location = new System.Drawing.Point(725, 195);
            this.lblStateFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStateFlag.Name = "lblStateFlag";
            this.lblStateFlag.Size = new System.Drawing.Size(152, 22);
            this.lblStateFlag.TabIndex = 66;
            this.lblStateFlag.Text = "入荷状態フラグ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(350, 195);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 22);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "受注年月日";
            // 
            // lblEmID
            // 
            this.lblEmID.AutoSize = true;
            this.lblEmID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblEmID.Location = new System.Drawing.Point(560, 145);
            this.lblEmID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmID.Name = "lblEmID";
            this.lblEmID.Size = new System.Drawing.Size(77, 22);
            this.lblEmID.TabIndex = 64;
            this.lblEmID.Text = "社員ID";
            // 
            // lblOrID
            // 
            this.lblOrID.AutoSize = true;
            this.lblOrID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblOrID.Location = new System.Drawing.Point(50, 145);
            this.lblOrID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrID.Name = "lblOrID";
            this.lblOrID.Size = new System.Drawing.Size(77, 22);
            this.lblOrID.TabIndex = 63;
            this.lblOrID.Text = "受注ID";
            // 
            // lblSoID
            // 
            this.lblSoID.AutoSize = true;
            this.lblSoID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoID.Location = new System.Drawing.Point(300, 145);
            this.lblSoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoID.Name = "lblSoID";
            this.lblSoID.Size = new System.Drawing.Size(100, 22);
            this.lblSoID.TabIndex = 93;
            this.lblSoID.Text = "営業所ID";
            // 
            // lblClID
            // 
            this.lblClID.AutoSize = true;
            this.lblClID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblClID.Location = new System.Drawing.Point(810, 145);
            this.lblClID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClID.Name = "lblClID";
            this.lblClID.Size = new System.Drawing.Size(77, 22);
            this.lblClID.TabIndex = 94;
            this.lblClID.Text = "顧客ID";
            // 
            // txbOrID
            // 
            this.txbOrID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbOrID.Location = new System.Drawing.Point(130, 145);
            this.txbOrID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbOrID.Multiline = true;
            this.txbOrID.Name = "txbOrID";
            this.txbOrID.Size = new System.Drawing.Size(115, 25);
            this.txbOrID.TabIndex = 95;
            this.txbOrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbClID
            // 
            this.txbClID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbClID.Location = new System.Drawing.Point(890, 145);
            this.txbClID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbClID.Multiline = true;
            this.txbClID.Name = "txbClID";
            this.txbClID.Size = new System.Drawing.Size(115, 25);
            this.txbClID.TabIndex = 96;
            this.txbClID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbOrDetailID
            // 
            this.txbOrDetailID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbOrDetailID.Location = new System.Drawing.Point(180, 705);
            this.txbOrDetailID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbOrDetailID.Multiline = true;
            this.txbOrDetailID.Name = "txbOrDetailID";
            this.txbOrDetailID.Size = new System.Drawing.Size(115, 25);
            this.txbOrDetailID.TabIndex = 99;
            this.txbOrDetailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lblOrDetailID
            // 
            this.lblOrDetailID.AutoSize = true;
            this.lblOrDetailID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblOrDetailID.Location = new System.Drawing.Point(55, 705);
            this.lblOrDetailID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrDetailID.Name = "lblOrDetailID";
            this.lblOrDetailID.Size = new System.Drawing.Size(123, 22);
            this.lblOrDetailID.TabIndex = 98;
            this.lblOrDetailID.Text = "売上詳細ID";
            // 
            // dataGridViewDetailDsp
            // 
            this.dataGridViewDetailDsp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDetailDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailDsp.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewDetailDsp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewDetailDsp.Name = "dataGridViewDetailDsp";
            this.dataGridViewDetailDsp.RowHeadersWidth = 51;
            this.dataGridViewDetailDsp.RowTemplate.Height = 24;
            this.dataGridViewDetailDsp.Size = new System.Drawing.Size(990, 314);
            this.dataGridViewDetailDsp.TabIndex = 97;
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailSearch.Location = new System.Drawing.Point(300, 330);
            this.btnDetailSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(135, 40);
            this.btnDetailSearch.TabIndex = 100;
            this.btnDetailSearch.Text = "詳細検索";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // txbPrID
            // 
            this.txbPrID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbPrID.Location = new System.Drawing.Point(180, 825);
            this.txbPrID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbPrID.Multiline = true;
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(115, 25);
            this.txbPrID.TabIndex = 102;
            this.txbPrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lblPrID
            // 
            this.lblPrID.AutoSize = true;
            this.lblPrID.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrID.Location = new System.Drawing.Point(55, 825);
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
            this.btnClear.Location = new System.Drawing.Point(1300, 210);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 45);
            this.btnClear.TabIndex = 103;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(1700, 115);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 45);
            this.btnUpdate.TabIndex = 104;
            this.btnUpdate.Text = "非表示更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbQuantity.Location = new System.Drawing.Point(180, 885);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbQuantity.Multiline = true;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(100, 25);
            this.txbQuantity.TabIndex = 109;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(55, 885);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 22);
            this.lblQuantity.TabIndex = 108;
            this.lblQuantity.Text = "個数";
            // 
            // txbOrIDsub
            // 
            this.txbOrIDsub.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbOrIDsub.Location = new System.Drawing.Point(180, 765);
            this.txbOrIDsub.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbOrIDsub.Multiline = true;
            this.txbOrIDsub.Name = "txbOrIDsub";
            this.txbOrIDsub.Size = new System.Drawing.Size(115, 25);
            this.txbOrIDsub.TabIndex = 111;
            this.txbOrIDsub.TextChanged += new System.EventHandler(this.txbKeyIDsub_TextChanged);
            this.txbOrIDsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lblOrIDsub
            // 
            this.lblOrIDsub.AutoSize = true;
            this.lblOrIDsub.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblOrIDsub.Location = new System.Drawing.Point(55, 765);
            this.lblOrIDsub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrIDsub.Name = "lblOrIDsub";
            this.lblOrIDsub.Size = new System.Drawing.Size(77, 22);
            this.lblOrIDsub.TabIndex = 110;
            this.lblOrIDsub.Text = "売上ID";
            // 
            // lblDetailPageNo
            // 
            this.lblDetailPageNo.AutoSize = true;
            this.lblDetailPageNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblDetailPageNo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblDetailPageNo.Location = new System.Drawing.Point(890, 335);
            this.lblDetailPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailPageNo.Name = "lblDetailPageNo";
            this.lblDetailPageNo.Size = new System.Drawing.Size(67, 22);
            this.lblDetailPageNo.TabIndex = 120;
            this.lblDetailPageNo.Text = "ページ";
            // 
            // txbDetailPageNo
            // 
            this.txbDetailPageNo.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbDetailPageNo.Location = new System.Drawing.Point(820, 332);
            this.txbDetailPageNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbDetailPageNo.Multiline = true;
            this.txbDetailPageNo.Name = "txbDetailPageNo";
            this.txbDetailPageNo.Size = new System.Drawing.Size(65, 30);
            this.txbDetailPageNo.TabIndex = 119;
            this.txbDetailPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDetailPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailLastPage
            // 
            this.btnDetailLastPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailLastPage.Location = new System.Drawing.Point(700, 330);
            this.btnDetailLastPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailLastPage.Name = "btnDetailLastPage";
            this.btnDetailLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnDetailLastPage.TabIndex = 118;
            this.btnDetailLastPage.Text = "▶|";
            this.btnDetailLastPage.UseVisualStyleBackColor = true;
            this.btnDetailLastPage.Click += new System.EventHandler(this.btnDetailLastPage_Click);
            this.btnDetailLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailNextPage
            // 
            this.btnDetailNextPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailNextPage.Location = new System.Drawing.Point(640, 330);
            this.btnDetailNextPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailNextPage.Name = "btnDetailNextPage";
            this.btnDetailNextPage.Size = new System.Drawing.Size(54, 32);
            this.btnDetailNextPage.TabIndex = 117;
            this.btnDetailNextPage.Text = "▶";
            this.btnDetailNextPage.UseVisualStyleBackColor = true;
            this.btnDetailNextPage.Click += new System.EventHandler(this.btnDetailNextPage_Click);
            this.btnDetailNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailPreviousPage
            // 
            this.btnDetailPreviousPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailPreviousPage.Location = new System.Drawing.Point(560, 330);
            this.btnDetailPreviousPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailPreviousPage.Name = "btnDetailPreviousPage";
            this.btnDetailPreviousPage.Size = new System.Drawing.Size(54, 32);
            this.btnDetailPreviousPage.TabIndex = 116;
            this.btnDetailPreviousPage.Text = "◀";
            this.btnDetailPreviousPage.UseVisualStyleBackColor = true;
            this.btnDetailPreviousPage.Click += new System.EventHandler(this.btnDetailPreviousPage_Click);
            this.btnDetailPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailFirstPage
            // 
            this.btnDetailFirstPage.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailFirstPage.Location = new System.Drawing.Point(500, 330);
            this.btnDetailFirstPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailFirstPage.Name = "btnDetailFirstPage";
            this.btnDetailFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnDetailFirstPage.TabIndex = 115;
            this.btnDetailFirstPage.Text = "|◀";
            this.btnDetailFirstPage.UseVisualStyleBackColor = true;
            this.btnDetailFirstPage.Click += new System.EventHandler(this.btnDetailFirstPage_Click);
            this.btnDetailFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbDetailPageSize
            // 
            this.txbDetailPageSize.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txbDetailPageSize.Location = new System.Drawing.Point(140, 332);
            this.txbDetailPageSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbDetailPageSize.Multiline = true;
            this.txbDetailPageSize.Name = "txbDetailPageSize";
            this.txbDetailPageSize.Size = new System.Drawing.Size(50, 30);
            this.txbDetailPageSize.TabIndex = 114;
            this.txbDetailPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDetailPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // lblDetailPageSize
            // 
            this.lblDetailPageSize.AutoSize = true;
            this.lblDetailPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.lblDetailPageSize.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblDetailPageSize.Location = new System.Drawing.Point(15, 335);
            this.lblDetailPageSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailPageSize.Name = "lblDetailPageSize";
            this.lblDetailPageSize.Size = new System.Drawing.Size(125, 22);
            this.lblDetailPageSize.TabIndex = 113;
            this.lblDetailPageSize.Text = "1ページ行数";
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
            this.pnlTitle.TabIndex = 122;
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
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(500, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 54);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "受注管理";
            // 
            // cmbHint
            // 
            this.cmbHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHint.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1500, 130);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(140, 28);
            this.cmbHint.TabIndex = 125;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pnlDataGridView.Controls.Add(this.cbxDisplay);
            this.pnlDataGridView.Controls.Add(this.cbxConfirm);
            this.pnlDataGridView.Controls.Add(this.cbxHidden);
            this.pnlDataGridView.Controls.Add(this.txbPageNo);
            this.pnlDataGridView.Controls.Add(this.llblPageSize);
            this.pnlDataGridView.Controls.Add(this.txbPageSize);
            this.pnlDataGridView.Controls.Add(this.btnFirstPage);
            this.pnlDataGridView.Controls.Add(this.btnPreviousPage);
            this.pnlDataGridView.Controls.Add(this.btnNextPage);
            this.pnlDataGridView.Controls.Add(this.btnLastPage);
            this.pnlDataGridView.Controls.Add(this.lblPageNo);
            this.pnlDataGridView.Controls.Add(this.dataGridViewDsp);
            this.pnlDataGridView.Controls.Add(this.btnSearch);
            this.pnlDataGridView.Location = new System.Drawing.Point(10, 285);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(1900, 370);
            this.pnlDataGridView.TabIndex = 123;
            // 
            // cbxConfirm
            // 
            this.cbxConfirm.AutoSize = true;
            this.cbxConfirm.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxConfirm.Location = new System.Drawing.Point(750, 335);
            this.cbxConfirm.Name = "cbxConfirm";
            this.cbxConfirm.Size = new System.Drawing.Size(98, 26);
            this.cbxConfirm.TabIndex = 91;
            this.cbxConfirm.Text = "確定済";
            this.cbxConfirm.UseVisualStyleBackColor = true;
            // 
            // cbxHidden
            // 
            this.cbxHidden.AutoSize = true;
            this.cbxHidden.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxHidden.Location = new System.Drawing.Point(860, 335);
            this.cbxHidden.Name = "cbxHidden";
            this.cbxHidden.Size = new System.Drawing.Size(121, 26);
            this.cbxHidden.TabIndex = 90;
            this.cbxHidden.Text = "非表示済";
            this.cbxHidden.UseVisualStyleBackColor = true;
            // 
            // pnlDetailDataGridView
            // 
            this.pnlDetailDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pnlDetailDataGridView.Controls.Add(this.btnDetailLastPage);
            this.pnlDetailDataGridView.Controls.Add(this.lblDetailPageNo);
            this.pnlDetailDataGridView.Controls.Add(this.txbDetailPageNo);
            this.pnlDetailDataGridView.Controls.Add(this.btnDetailSearch);
            this.pnlDetailDataGridView.Controls.Add(this.btnDetailNextPage);
            this.pnlDetailDataGridView.Controls.Add(this.txbDetailPageSize);
            this.pnlDetailDataGridView.Controls.Add(this.lblDetailPageSize);
            this.pnlDetailDataGridView.Controls.Add(this.btnDetailPreviousPage);
            this.pnlDetailDataGridView.Controls.Add(this.btnDetailFirstPage);
            this.pnlDetailDataGridView.Controls.Add(this.dataGridViewDetailDsp);
            this.pnlDetailDataGridView.Location = new System.Drawing.Point(400, 670);
            this.pnlDetailDataGridView.Name = "pnlDetailDataGridView";
            this.pnlDetailDataGridView.Size = new System.Drawing.Size(1010, 370);
            this.pnlDetailDataGridView.TabIndex = 124;
            // 
            // lblPrName
            // 
            this.lblPrName.AutoSize = true;
            this.lblPrName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrName.Location = new System.Drawing.Point(180, 805);
            this.lblPrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrName.Name = "lblPrName";
            this.lblPrName.Size = new System.Drawing.Size(43, 16);
            this.lblPrName.TabIndex = 157;
            this.lblPrName.Text = "----";
            // 
            // lblSoName
            // 
            this.lblSoName.AutoSize = true;
            this.lblSoName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoName.Location = new System.Drawing.Point(400, 125);
            this.lblSoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoName.Name = "lblSoName";
            this.lblSoName.Size = new System.Drawing.Size(43, 16);
            this.lblSoName.TabIndex = 125;
            this.lblSoName.Text = "----";
            // 
            // lblEmName
            // 
            this.lblEmName.AutoSize = true;
            this.lblEmName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmName.Location = new System.Drawing.Point(640, 125);
            this.lblEmName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmName.Name = "lblEmName";
            this.lblEmName.Size = new System.Drawing.Size(43, 16);
            this.lblEmName.TabIndex = 126;
            this.lblEmName.Text = "----";
            // 
            // lblClName
            // 
            this.lblClName.AutoSize = true;
            this.lblClName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblClName.Location = new System.Drawing.Point(890, 125);
            this.lblClName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClName.Name = "lblClName";
            this.lblClName.Size = new System.Drawing.Size(43, 16);
            this.lblClName.TabIndex = 127;
            this.lblClName.Text = "----";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Location = new System.Drawing.Point(480, 193);
            this.dtpDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(210, 29);
            this.dtpDate.TabIndex = 158;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbTotalPrice.Location = new System.Drawing.Point(180, 945);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(170, 25);
            this.txbTotalPrice.TabIndex = 163;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(55, 945);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(102, 22);
            this.lblTotalPrice.TabIndex = 162;
            this.lblTotalPrice.Text = "合計金額";
            // 
            // txbCharge
            // 
            this.txbCharge.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbCharge.Location = new System.Drawing.Point(200, 195);
            this.txbCharge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbCharge.Multiline = true;
            this.txbCharge.Name = "txbCharge";
            this.txbCharge.Size = new System.Drawing.Size(115, 25);
            this.txbCharge.TabIndex = 165;
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblCharge.Location = new System.Drawing.Point(50, 197);
            this.lblCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(148, 22);
            this.lblCharge.TabIndex = 164;
            this.lblCharge.Text = "顧客担当者名";
            // 
            // pnlCondition
            // 
            this.pnlCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.pnlCondition.Controls.Add(this.label3);
            this.pnlCondition.Controls.Add(this.cmbTotalPrice);
            this.pnlCondition.Controls.Add(this.label2);
            this.pnlCondition.Controls.Add(this.label1);
            this.pnlCondition.Controls.Add(this.label4);
            this.pnlCondition.Controls.Add(this.cmbQuantity);
            this.pnlCondition.Controls.Add(this.cmbDate);
            this.pnlCondition.Location = new System.Drawing.Point(1480, 670);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.Size = new System.Drawing.Size(380, 370);
            this.pnlCondition.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 162;
            this.label2.Text = "数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 161;
            this.label1.Text = "受注年月日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(130, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "検索条件";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.BackColor = System.Drawing.Color.White;
            this.cmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantity.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(200, 178);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(121, 28);
            this.cmbQuantity.TabIndex = 160;
            // 
            // cmbDate
            // 
            this.cmbDate.BackColor = System.Drawing.Color.White;
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(200, 98);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 28);
            this.cmbDate.TabIndex = 159;
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.AutoSize = true;
            this.cbxDisplay.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.cbxDisplay.Location = new System.Drawing.Point(640, 335);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(98, 26);
            this.cbxDisplay.TabIndex = 93;
            this.cbxDisplay.Text = "未処理";
            this.cbxDisplay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 164;
            this.label3.Text = "合計金額";
            // 
            // cmbTotalPrice
            // 
            this.cmbTotalPrice.BackColor = System.Drawing.Color.White;
            this.cmbTotalPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTotalPrice.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.cmbTotalPrice.FormattingEnabled = true;
            this.cmbTotalPrice.Location = new System.Drawing.Point(200, 260);
            this.cmbTotalPrice.Name = "cmbTotalPrice";
            this.cmbTotalPrice.Size = new System.Drawing.Size(121, 28);
            this.cmbTotalPrice.TabIndex = 163;
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnRegist.Location = new System.Drawing.Point(1700, 235);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(135, 45);
            this.btnRegist.TabIndex = 167;
            this.btnRegist.Text = "発注登録";
            this.btnRegist.UseVisualStyleBackColor = false;
            // 
            // btnDetailRegist
            // 
            this.btnDetailRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDetailRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnDetailRegist.Location = new System.Drawing.Point(230, 990);
            this.btnDetailRegist.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetailRegist.Name = "btnDetailRegist";
            this.btnDetailRegist.Size = new System.Drawing.Size(121, 60);
            this.btnDetailRegist.TabIndex = 168;
            this.btnDetailRegist.Text = "発注詳細\r\n登録";
            this.btnDetailRegist.UseVisualStyleBackColor = false;
            // 
            // F_AdOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnDetailRegist);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.pnlCondition);
            this.Controls.Add(this.txbCharge);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblPrName);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.lblOrIDsub);
            this.Controls.Add(this.lblClName);
            this.Controls.Add(this.lblOrDetailID);
            this.Controls.Add(this.lblEmName);
            this.Controls.Add(this.txbOrDetailID);
            this.Controls.Add(this.lblSoName);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbClID);
            this.Controls.Add(this.txbOrID);
            this.Controls.Add(this.lblClID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSoID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPrID);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.txbFlag);
            this.Controls.Add(this.txbOrIDsub);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.txbStateFlag);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.txbSoID);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblStateFlag);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEmID);
            this.Controls.Add(this.lblOrID);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlDetailDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "F_AdOrder";
            this.Text = "受注管理";
            this.Load += new System.EventHandler(this.F_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDsp)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            this.pnlDetailDataGridView.ResumeLayout(false);
            this.pnlDetailDataGridView.PerformLayout();
            this.pnlCondition.ResumeLayout(false);
            this.pnlCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
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
        private System.Windows.Forms.TextBox txbFlag;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.TextBox txbStateFlag;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.TextBox txbSoID;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblStateFlag;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmID;
        private System.Windows.Forms.Label lblOrID;
        private System.Windows.Forms.Label lblSoID;
        private System.Windows.Forms.Label lblClID;
        private System.Windows.Forms.TextBox txbOrID;
        private System.Windows.Forms.TextBox txbClID;
        private System.Windows.Forms.TextBox txbOrDetailID;
        private System.Windows.Forms.Label lblOrDetailID;
        private System.Windows.Forms.DataGridView dataGridViewDetailDsp;
        private System.Windows.Forms.Button btnDetailSearch;
        private System.Windows.Forms.TextBox txbPrID;
        private System.Windows.Forms.Label lblPrID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbOrIDsub;
        private System.Windows.Forms.Label lblOrIDsub;
        private System.Windows.Forms.Label lblDetailPageNo;
        private System.Windows.Forms.TextBox txbDetailPageNo;
        private System.Windows.Forms.Button btnDetailLastPage;
        private System.Windows.Forms.Button btnDetailNextPage;
        private System.Windows.Forms.Button btnDetailPreviousPage;
        private System.Windows.Forms.Button btnDetailFirstPage;
        private System.Windows.Forms.TextBox txbDetailPageSize;
        private System.Windows.Forms.Label lblDetailPageSize;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Panel pnlDetailDataGridView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbHint;
        private System.Windows.Forms.Label lblSoName;
        private System.Windows.Forms.Label lblEmName;
        private System.Windows.Forms.Label lblClName;
        private System.Windows.Forms.Label lblPrName;
        private System.Windows.Forms.CheckBox cbxConfirm;
        private System.Windows.Forms.CheckBox cbxHidden;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLoginIDData;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txbCharge;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Panel pnlCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.CheckBox cbxDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTotalPrice;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnDetailRegist;
    }
}
