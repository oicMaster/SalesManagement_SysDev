namespace SalesManagement_SysDev
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
            this.txbClID = new System.Windows.Forms.TextBox();
            this.txbOrID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.txbOrFlag = new System.Windows.Forms.TextBox();
            this.txbOrHidden = new System.Windows.Forms.TextBox();
            this.txbOrStateFlag = new System.Windows.Forms.TextBox();
            this.txbOrDate = new System.Windows.Forms.TextBox();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.txbSoID = new System.Windows.Forms.TextBox();
            this.txbClCharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.txbPrID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDetailSearch = new System.Windows.Forms.Button();
            this.txbOrDetailID = new System.Windows.Forms.TextBox();
            this.labal1 = new System.Windows.Forms.Label();
            this.dataGridViewSubDsp = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDetailRegist = new System.Windows.Forms.Button();
            this.txbOrQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbOrIDsub = new System.Windows.Forms.TextBox();
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
            this.txbClID.Location = new System.Drawing.Point(483, 176);
            this.txbClID.Name = "txbClID";
            this.txbClID.Size = new System.Drawing.Size(100, 22);
            this.txbClID.TabIndex = 131;
            // 
            // txbOrID
            // 
            this.txbOrID.Location = new System.Drawing.Point(112, 176);
            this.txbOrID.Name = "txbOrID";
            this.txbOrID.Size = new System.Drawing.Size(100, 22);
            this.txbOrID.TabIndex = 130;
            this.txbOrID.TextChanged += new System.EventHandler(this.txbOrID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 129;
            this.label10.Text = "顧客ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 128;
            this.label9.Text = "営業所ID";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(695, 42);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 127;
            this.btnConfirm.Text = "受注確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(584, 42);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1140, 61);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(1056, 108);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(67, 15);
            this.lblLoginName.TabIndex = 122;
            this.lblLoginName.Text = "千田真隆";
            this.lblLoginName.Click += new System.EventHandler(this.lblLoginName_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(957, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 121;
            this.label8.Text = "ログイン情報";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(205, 728);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(43, 15);
            this.lblPage.TabIndex = 119;
            this.lblPage.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Location = new System.Drawing.Point(83, 726);
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(100, 22);
            this.txbPageNo.TabIndex = 118;
            this.txbPageNo.TextChanged += new System.EventHandler(this.txbPageNo_TextChanged);
            this.txbPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPageNo_KeyPress);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(540, 720);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 117;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(459, 720);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(378, 720);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPage.TabIndex = 115;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(297, 720);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPage.TabIndex = 114;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // txbPageSize
            // 
            this.txbPageSize.Location = new System.Drawing.Point(181, 697);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(100, 22);
            this.txbPageSize.TabIndex = 113;
            this.txbPageSize.TextChanged += new System.EventHandler(this.txbPageSize_TextChanged);
            this.txbPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPageSize_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 700);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 112;
            this.label11.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(97, 307);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(780, 316);
            this.dataGridViewDsp.TabIndex = 111;
            // 
            // txbOrFlag
            // 
            this.txbOrFlag.Location = new System.Drawing.Point(108, 270);
            this.txbOrFlag.Name = "txbOrFlag";
            this.txbOrFlag.Size = new System.Drawing.Size(100, 22);
            this.txbOrFlag.TabIndex = 110;
            // 
            // txbOrHidden
            // 
            this.txbOrHidden.Location = new System.Drawing.Point(234, 270);
            this.txbOrHidden.Name = "txbOrHidden";
            this.txbOrHidden.Size = new System.Drawing.Size(100, 22);
            this.txbOrHidden.TabIndex = 109;
            this.txbOrHidden.TextChanged += new System.EventHandler(this.txbOrHidden_TextChanged);
            // 
            // txbOrStateFlag
            // 
            this.txbOrStateFlag.Location = new System.Drawing.Point(856, 176);
            this.txbOrStateFlag.Name = "txbOrStateFlag";
            this.txbOrStateFlag.Size = new System.Drawing.Size(100, 22);
            this.txbOrStateFlag.TabIndex = 108;
            // 
            // txbOrDate
            // 
            this.txbOrDate.Location = new System.Drawing.Point(737, 176);
            this.txbOrDate.Name = "txbOrDate";
            this.txbOrDate.Size = new System.Drawing.Size(100, 22);
            this.txbOrDate.TabIndex = 107;
            // 
            // txbEmID
            // 
            this.txbEmID.Location = new System.Drawing.Point(353, 176);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(100, 22);
            this.txbEmID.TabIndex = 106;
            // 
            // txbSoID
            // 
            this.txbSoID.Location = new System.Drawing.Point(234, 176);
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(100, 22);
            this.txbSoID.TabIndex = 105;
            // 
            // txbClCharge
            // 
            this.txbClCharge.Location = new System.Drawing.Point(608, 176);
            this.txbClCharge.Name = "txbClCharge";
            this.txbClCharge.Size = new System.Drawing.Size(100, 22);
            this.txbClCharge.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "受注管理フラグ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = "非表示理由";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "受注状態フラグ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "受注年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "受注ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 97;
            this.label1.Text = "顧客担当名";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(243, 42);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 132;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // txbPrID
            // 
            this.txbPrID.Location = new System.Drawing.Point(1067, 320);
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(100, 22);
            this.txbPrID.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1064, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 137;
            this.label12.Text = "商品ID";
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Location = new System.Drawing.Point(1218, 320);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDetailSearch.TabIndex = 136;
            this.btnDetailSearch.Text = "詳細検索";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            // 
            // txbOrDetailID
            // 
            this.txbOrDetailID.Location = new System.Drawing.Point(958, 321);
            this.txbOrDetailID.Name = "txbOrDetailID";
            this.txbOrDetailID.Size = new System.Drawing.Size(100, 22);
            this.txbOrDetailID.TabIndex = 135;
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(955, 294);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(81, 15);
            this.labal1.TabIndex = 134;
            this.labal1.Text = "受注詳細ID";
            // 
            // dataGridViewSubDsp
            // 
            this.dataGridViewSubDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubDsp.Location = new System.Drawing.Point(950, 374);
            this.dataGridViewSubDsp.Name = "dataGridViewSubDsp";
            this.dataGridViewSubDsp.RowHeadersWidth = 51;
            this.dataGridViewSubDsp.RowTemplate.Height = 24;
            this.dataGridViewSubDsp.Size = new System.Drawing.Size(377, 249);
            this.dataGridViewSubDsp.TabIndex = 133;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(793, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 139;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(466, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 140;
            this.btnUpdate.Text = "非表示更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDetailRegist
            // 
            this.btnDetailRegist.Location = new System.Drawing.Point(1218, 285);
            this.btnDetailRegist.Name = "btnDetailRegist";
            this.btnDetailRegist.Size = new System.Drawing.Size(75, 23);
            this.btnDetailRegist.TabIndex = 141;
            this.btnDetailRegist.Text = "詳細登録";
            this.btnDetailRegist.UseVisualStyleBackColor = true;
            // 
            // txbOrQuantity
            // 
            this.txbOrQuantity.Location = new System.Drawing.Point(1063, 270);
            this.txbOrQuantity.Name = "txbOrQuantity";
            this.txbOrQuantity.Size = new System.Drawing.Size(100, 22);
            this.txbOrQuantity.TabIndex = 143;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1064, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 142;
            this.label13.Text = "数量";
            // 
            // txbOrIDsub
            // 
            this.txbOrIDsub.Location = new System.Drawing.Point(957, 269);
            this.txbOrIDsub.Name = "txbOrIDsub";
            this.txbOrIDsub.Size = new System.Drawing.Size(100, 22);
            this.txbOrIDsub.TabIndex = 145;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(955, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 144;
            this.label14.Text = "受注ID";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Location = new System.Drawing.Point(1296, 649);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(43, 15);
            this.lblPageSub.TabIndex = 159;
            this.lblPageSub.Text = "ページ";
            // 
            // txbPageNoSub
            // 
            this.txbPageNoSub.Location = new System.Drawing.Point(1174, 647);
            this.txbPageNoSub.Name = "txbPageNoSub";
            this.txbPageNoSub.Size = new System.Drawing.Size(100, 22);
            this.txbPageNoSub.TabIndex = 158;
            // 
            // btnLastPageSub
            // 
            this.btnLastPageSub.Location = new System.Drawing.Point(1235, 689);
            this.btnLastPageSub.Name = "btnLastPageSub";
            this.btnLastPageSub.Size = new System.Drawing.Size(75, 23);
            this.btnLastPageSub.TabIndex = 157;
            this.btnLastPageSub.Text = "▶|";
            this.btnLastPageSub.UseVisualStyleBackColor = true;
            // 
            // btnNextPageSub
            // 
            this.btnNextPageSub.Location = new System.Drawing.Point(1154, 689);
            this.btnNextPageSub.Name = "btnNextPageSub";
            this.btnNextPageSub.Size = new System.Drawing.Size(75, 23);
            this.btnNextPageSub.TabIndex = 156;
            this.btnNextPageSub.Text = "▶";
            this.btnNextPageSub.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPageSub
            // 
            this.btnPreviousPageSub.Location = new System.Drawing.Point(1073, 689);
            this.btnPreviousPageSub.Name = "btnPreviousPageSub";
            this.btnPreviousPageSub.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPageSub.TabIndex = 155;
            this.btnPreviousPageSub.Text = "◀";
            this.btnPreviousPageSub.UseVisualStyleBackColor = true;
            // 
            // btnFirstPageSub
            // 
            this.btnFirstPageSub.Location = new System.Drawing.Point(992, 689);
            this.btnFirstPageSub.Name = "btnFirstPageSub";
            this.btnFirstPageSub.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPageSub.TabIndex = 154;
            this.btnFirstPageSub.Text = "|◀";
            this.btnFirstPageSub.UseVisualStyleBackColor = true;
            // 
            // txbPageSizeSub
            // 
            this.txbPageSizeSub.Location = new System.Drawing.Point(1034, 649);
            this.txbPageSizeSub.Name = "txbPageSizeSub";
            this.txbPageSizeSub.Size = new System.Drawing.Size(100, 22);
            this.txbPageSizeSub.TabIndex = 153;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(947, 652);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 15);
            this.label16.TabIndex = 152;
            this.label16.Text = "1ページ行数";
            // 
            // F_AdOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 769);
            this.Controls.Add(this.lblPageSub);
            this.Controls.Add(this.txbPageNoSub);
            this.Controls.Add(this.btnLastPageSub);
            this.Controls.Add(this.btnNextPageSub);
            this.Controls.Add(this.btnPreviousPageSub);
            this.Controls.Add(this.btnFirstPageSub);
            this.Controls.Add(this.txbPageSizeSub);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbOrIDsub);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbOrQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDetailRegist);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetailSearch);
            this.Controls.Add(this.txbOrDetailID);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.dataGridViewSubDsp);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txbClID);
            this.Controls.Add(this.txbOrID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConfirm);
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
            this.Controls.Add(this.txbOrFlag);
            this.Controls.Add(this.txbOrHidden);
            this.Controls.Add(this.txbOrStateFlag);
            this.Controls.Add(this.txbOrDate);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.txbSoID);
            this.Controls.Add(this.txbClCharge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_AdOrder";
            this.Text = "受注管理";
            this.Load += new System.EventHandler(this.F_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbClID;
        private System.Windows.Forms.TextBox txbOrID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirm;
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
        private System.Windows.Forms.TextBox txbOrFlag;
        private System.Windows.Forms.TextBox txbOrHidden;
        private System.Windows.Forms.TextBox txbOrStateFlag;
        private System.Windows.Forms.TextBox txbOrDate;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.TextBox txbSoID;
        private System.Windows.Forms.TextBox txbClCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.TextBox txbPrID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDetailSearch;
        private System.Windows.Forms.TextBox txbOrDetailID;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.DataGridView dataGridViewSubDsp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetailRegist;
        private System.Windows.Forms.TextBox txbOrQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbOrIDsub;
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