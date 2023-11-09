﻿namespace SalesManagement_SysDev
{
    partial class F_AdSale
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
            this.txbClID = new System.Windows.Forms.TextBox();
            this.txbChID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.txbPageNo = new System.Windows.Forms.TextBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.txbPageSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewDsp = new System.Windows.Forms.DataGridView();
            this.txbSaFlag = new System.Windows.Forms.TextBox();
            this.txbSaHidden = new System.Windows.Forms.TextBox();
            this.txbSaDate = new System.Windows.Forms.TextBox();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.txbSoID = new System.Windows.Forms.TextBox();
            this.txbSaID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDetailSearch = new System.Windows.Forms.Button();
            this.txbSaDetailID = new System.Windows.Forms.TextBox();
            this.labal1 = new System.Windows.Forms.Label();
            this.dataGridViewSubDsp = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbSaQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSaIDsub = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbSaTotalPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.txbPageNoSub = new System.Windows.Forms.TextBox();
            this.btnLastPageSub = new System.Windows.Forms.Button();
            this.btnNextPageSub = new System.Windows.Forms.Button();
            this.btnPreviousPageSub = new System.Windows.Forms.Button();
            this.btnFirstPageSub = new System.Windows.Forms.Button();
            this.txbPageSizeSub = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // txbClID
            // 
            this.txbClID.Location = new System.Drawing.Point(278, 193);
            this.txbClID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClID.Name = "txbClID";
            this.txbClID.Size = new System.Drawing.Size(124, 25);
            this.txbClID.TabIndex = 131;
            // 
            // txbChID
            // 
            this.txbChID.Location = new System.Drawing.Point(708, 193);
            this.txbChID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbChID.Name = "txbChID";
            this.txbChID.Size = new System.Drawing.Size(124, 25);
            this.txbChID.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 129;
            this.label10.Text = "顧客ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 128;
            this.label9.Text = "営業所ID";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(706, 32);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 28);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1401, 55);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 28);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(1296, 112);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(80, 18);
            this.lblLoginName.TabIndex = 122;
            this.lblLoginName.Text = "千田真隆";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1172, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 121;
            this.label8.Text = "ログイン情報";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(662, 858);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(53, 18);
            this.lblPage.TabIndex = 119;
            this.lblPage.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Location = new System.Drawing.Point(510, 856);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(124, 25);
            this.txbPageNo.TabIndex = 118;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(399, 856);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(94, 28);
            this.btnLastPage.TabIndex = 117;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(298, 856);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(94, 28);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(196, 856);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(94, 28);
            this.btnPreviousPage.TabIndex = 115;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(95, 856);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(94, 28);
            this.btnFirstPage.TabIndex = 114;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // txbPageSize
            // 
            this.txbPageSize.Location = new System.Drawing.Point(202, 818);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(124, 25);
            this.txbPageSize.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 822);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 112;
            this.label11.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(98, 350);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(916, 379);
            this.dataGridViewDsp.TabIndex = 111;
            // 
            // txbSaFlag
            // 
            this.txbSaFlag.Location = new System.Drawing.Point(111, 306);
            this.txbSaFlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaFlag.Name = "txbSaFlag";
            this.txbSaFlag.Size = new System.Drawing.Size(124, 25);
            this.txbSaFlag.TabIndex = 110;
            // 
            // txbSaHidden
            // 
            this.txbSaHidden.Location = new System.Drawing.Point(269, 306);
            this.txbSaHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaHidden.Name = "txbSaHidden";
            this.txbSaHidden.Size = new System.Drawing.Size(124, 25);
            this.txbSaHidden.TabIndex = 109;
            this.txbSaHidden.TextChanged += new System.EventHandler(this.txbSaHidden_TextChanged);
            // 
            // txbSaDate
            // 
            this.txbSaDate.Location = new System.Drawing.Point(866, 193);
            this.txbSaDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaDate.Name = "txbSaDate";
            this.txbSaDate.Size = new System.Drawing.Size(124, 25);
            this.txbSaDate.TabIndex = 107;
            // 
            // txbEmID
            // 
            this.txbEmID.Location = new System.Drawing.Point(575, 193);
            this.txbEmID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(124, 25);
            this.txbEmID.TabIndex = 106;
            // 
            // txbSoID
            // 
            this.txbSoID.Location = new System.Drawing.Point(418, 193);
            this.txbSoID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(124, 25);
            this.txbSoID.TabIndex = 105;
            // 
            // txbSaID
            // 
            this.txbSaID.Location = new System.Drawing.Point(111, 193);
            this.txbSaID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaID.Name = "txbSaID";
            this.txbSaID.Size = new System.Drawing.Size(124, 25);
            this.txbSaID.TabIndex = 104;
            this.txbSaID.TextChanged += new System.EventHandler(this.txbSaID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "売上管理フラグ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 102;
            this.label6.Text = "非表示理由";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(862, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "売上日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "注文ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "売上ID";
            // 
            // txbPrID
            // 
            this.txbPrID.Location = new System.Drawing.Point(1206, 366);
            this.txbPrID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(124, 25);
            this.txbPrID.TabIndex = 137;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1202, 334);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 136;
            this.label12.Text = "商品ID";
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Location = new System.Drawing.Point(1395, 366);
            this.btnDetailSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(94, 28);
            this.btnDetailSearch.TabIndex = 135;
            this.btnDetailSearch.Text = "詳細検索";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // txbSaDetailID
            // 
            this.txbSaDetailID.Location = new System.Drawing.Point(1070, 367);
            this.txbSaDetailID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaDetailID.Name = "txbSaDetailID";
            this.txbSaDetailID.Size = new System.Drawing.Size(124, 25);
            this.txbSaDetailID.TabIndex = 134;
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(1066, 335);
            this.labal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(96, 18);
            this.labal1.TabIndex = 133;
            this.labal1.Text = "売上詳細ID";
            // 
            // dataGridViewSubDsp
            // 
            this.dataGridViewSubDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubDsp.Location = new System.Drawing.Point(1060, 431);
            this.dataGridViewSubDsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSubDsp.Name = "dataGridViewSubDsp";
            this.dataGridViewSubDsp.RowHeadersWidth = 51;
            this.dataGridViewSubDsp.RowTemplate.Height = 24;
            this.dataGridViewSubDsp.Size = new System.Drawing.Size(471, 299);
            this.dataGridViewSubDsp.TabIndex = 132;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(555, 32);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 28);
            this.btnUpdate.TabIndex = 138;
            this.btnUpdate.Text = "非表示更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txbSaQuantity
            // 
            this.txbSaQuantity.Location = new System.Drawing.Point(1206, 277);
            this.txbSaQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaQuantity.Name = "txbSaQuantity";
            this.txbSaQuantity.Size = new System.Drawing.Size(124, 25);
            this.txbSaQuantity.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1202, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 139;
            this.label5.Text = "個数";
            // 
            // txbSaIDsub
            // 
            this.txbSaIDsub.Location = new System.Drawing.Point(1060, 277);
            this.txbSaIDsub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaIDsub.Name = "txbSaIDsub";
            this.txbSaIDsub.Size = new System.Drawing.Size(124, 25);
            this.txbSaIDsub.TabIndex = 142;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1056, 256);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 141;
            this.label13.Text = "売上ID";
            // 
            // txbSaTotalPrice
            // 
            this.txbSaTotalPrice.Location = new System.Drawing.Point(1370, 277);
            this.txbSaTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaTotalPrice.Name = "txbSaTotalPrice";
            this.txbSaTotalPrice.Size = new System.Drawing.Size(124, 25);
            this.txbSaTotalPrice.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1366, 256);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 143;
            this.label14.Text = "合計金額";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Location = new System.Drawing.Point(1478, 739);
            this.lblPageSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(53, 18);
            this.lblPageSub.TabIndex = 159;
            this.lblPageSub.Text = "ページ";
            // 
            // txbPageNoSub
            // 
            this.txbPageNoSub.Location = new System.Drawing.Point(1325, 737);
            this.txbPageNoSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPageNoSub.Name = "txbPageNoSub";
            this.txbPageNoSub.Size = new System.Drawing.Size(124, 25);
            this.txbPageNoSub.TabIndex = 158;
            // 
            // btnLastPageSub
            // 
            this.btnLastPageSub.Location = new System.Drawing.Point(1401, 787);
            this.btnLastPageSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastPageSub.Name = "btnLastPageSub";
            this.btnLastPageSub.Size = new System.Drawing.Size(94, 28);
            this.btnLastPageSub.TabIndex = 157;
            this.btnLastPageSub.Text = "▶|";
            this.btnLastPageSub.UseVisualStyleBackColor = true;
            // 
            // btnNextPageSub
            // 
            this.btnNextPageSub.Location = new System.Drawing.Point(1300, 787);
            this.btnNextPageSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextPageSub.Name = "btnNextPageSub";
            this.btnNextPageSub.Size = new System.Drawing.Size(94, 28);
            this.btnNextPageSub.TabIndex = 156;
            this.btnNextPageSub.Text = "▶";
            this.btnNextPageSub.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPageSub
            // 
            this.btnPreviousPageSub.Location = new System.Drawing.Point(1199, 787);
            this.btnPreviousPageSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousPageSub.Name = "btnPreviousPageSub";
            this.btnPreviousPageSub.Size = new System.Drawing.Size(94, 28);
            this.btnPreviousPageSub.TabIndex = 155;
            this.btnPreviousPageSub.Text = "◀";
            this.btnPreviousPageSub.UseVisualStyleBackColor = true;
            // 
            // btnFirstPageSub
            // 
            this.btnFirstPageSub.Location = new System.Drawing.Point(1098, 787);
            this.btnFirstPageSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstPageSub.Name = "btnFirstPageSub";
            this.btnFirstPageSub.Size = new System.Drawing.Size(94, 28);
            this.btnFirstPageSub.TabIndex = 154;
            this.btnFirstPageSub.Text = "|◀";
            this.btnFirstPageSub.UseVisualStyleBackColor = true;
            // 
            // txbPageSizeSub
            // 
            this.txbPageSizeSub.Location = new System.Drawing.Point(1150, 739);
            this.txbPageSizeSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPageSizeSub.Name = "txbPageSizeSub";
            this.txbPageSizeSub.Size = new System.Drawing.Size(124, 25);
            this.txbPageSizeSub.TabIndex = 153;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1041, 743);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 18);
            this.label16.TabIndex = 152;
            this.label16.Text = "1ページ行数";
            // 
            // F_AdSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 886);
            this.Controls.Add(this.lblPageSub);
            this.Controls.Add(this.txbPageNoSub);
            this.Controls.Add(this.btnLastPageSub);
            this.Controls.Add(this.btnNextPageSub);
            this.Controls.Add(this.btnPreviousPageSub);
            this.Controls.Add(this.btnFirstPageSub);
            this.Controls.Add(this.txbPageSizeSub);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbSaTotalPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbSaIDsub);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbSaQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetailSearch);
            this.Controls.Add(this.txbSaDetailID);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.dataGridViewSubDsp);
            this.Controls.Add(this.txbClID);
            this.Controls.Add(this.txbChID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.txbPageNo);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewDsp);
            this.Controls.Add(this.txbSaFlag);
            this.Controls.Add(this.txbSaHidden);
            this.Controls.Add(this.txbSaDate);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.txbSoID);
            this.Controls.Add(this.txbSaID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_AdSale";
            this.Text = "売上管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbClID;
        private System.Windows.Forms.TextBox txbChID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txbPageNo;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txbPageSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewDsp;
        private System.Windows.Forms.TextBox txbSaFlag;
        private System.Windows.Forms.TextBox txbSaHidden;
        private System.Windows.Forms.TextBox txbSaDate;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.TextBox txbSoID;
        private System.Windows.Forms.TextBox txbSaID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDetailSearch;
        private System.Windows.Forms.TextBox txbSaDetailID;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.DataGridView dataGridViewSubDsp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbSaQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSaIDsub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbSaTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.TextBox txbPageNoSub;
        private System.Windows.Forms.Button btnLastPageSub;
        private System.Windows.Forms.Button btnNextPageSub;
        private System.Windows.Forms.Button btnPreviousPageSub;
        private System.Windows.Forms.Button btnFirstPageSub;
        private System.Windows.Forms.TextBox txbPageSizeSub;
        private System.Windows.Forms.Label label16;
    }
}