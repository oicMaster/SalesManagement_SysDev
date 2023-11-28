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
            this.txbFlag = new System.Windows.Forms.TextBox();
            this.txbHidden = new System.Windows.Forms.TextBox();
            this.txbStateFlag = new System.Windows.Forms.TextBox();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.txbEmID = new System.Windows.Forms.TextBox();
            this.txbSoID = new System.Windows.Forms.TextBox();
            this.txbCharge = new System.Windows.Forms.TextBox();
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
            this.dataGridViewDetailDsp = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDetailRegist = new System.Windows.Forms.Button();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbOrIDsub = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDetailPage = new System.Windows.Forms.Label();
            this.txbDetailPageNo = new System.Windows.Forms.TextBox();
            this.btnDetailLastPage = new System.Windows.Forms.Button();
            this.btnDetailNextPage = new System.Windows.Forms.Button();
            this.btnDetailPreviousPage = new System.Windows.Forms.Button();
            this.btnDetailFirstPage = new System.Windows.Forms.Button();
            this.txbDetailPageSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblClName = new System.Windows.Forms.Label();
            this.lblEmName = new System.Windows.Forms.Label();
            this.lblSoName = new System.Windows.Forms.Label();
            this.lblPrName = new System.Windows.Forms.Label();
            this.cmbHint = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // txbClID
            // 
            this.txbClID.Location = new System.Drawing.Point(483, 176);
            this.txbClID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbClID.Name = "txbClID";
            this.txbClID.Size = new System.Drawing.Size(100, 22);
            this.txbClID.TabIndex = 131;
            this.txbClID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbOrID
            // 
            this.txbOrID.Location = new System.Drawing.Point(112, 176);
            this.txbOrID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbOrID.Name = "txbOrID";
            this.txbOrID.Size = new System.Drawing.Size(100, 22);
            this.txbOrID.TabIndex = 130;
            this.txbOrID.TextChanged += new System.EventHandler(this.txbKeyID_TextChanged);
            this.txbOrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
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
            this.btnConfirm.Location = new System.Drawing.Point(335, 41);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 24);
            this.btnConfirm.TabIndex = 127;
            this.btnConfirm.Text = "受注確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(873, 41);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 24);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(703, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1140, 61);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(1056, 109);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(67, 15);
            this.lblLoginName.TabIndex = 122;
            this.lblLoginName.Text = "千田真隆";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(957, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 121;
            this.label8.Text = "ログイン情報";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(205, 729);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(43, 15);
            this.lblPage.TabIndex = 119;
            this.lblPage.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Location = new System.Drawing.Point(83, 726);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(100, 22);
            this.txbPageNo.TabIndex = 118;
            this.txbPageNo.TextChanged += new System.EventHandler(this.txbPageNo_TextChanged);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(540, 720);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 24);
            this.btnLastPage.TabIndex = 117;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            this.btnLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(459, 720);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 24);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            this.btnNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(377, 720);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 24);
            this.btnPreviousPage.TabIndex = 115;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            this.btnPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(297, 720);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 24);
            this.btnFirstPage.TabIndex = 114;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            this.btnFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Location = new System.Drawing.Point(181, 696);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(100, 22);
            this.txbPageSize.TabIndex = 113;
            this.txbPageSize.TextChanged += new System.EventHandler(this.txbPageSize_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 700);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 112;
            this.label11.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(97, 306);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(780, 316);
            this.dataGridViewDsp.TabIndex = 111;
            // 
            // txbFlag
            // 
            this.txbFlag.Location = new System.Drawing.Point(108, 270);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.Size = new System.Drawing.Size(100, 22);
            this.txbFlag.TabIndex = 110;
            // 
            // txbHidden
            // 
            this.txbHidden.Location = new System.Drawing.Point(233, 270);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(100, 22);
            this.txbHidden.TabIndex = 109;
            // 
            // txbStateFlag
            // 
            this.txbStateFlag.Location = new System.Drawing.Point(856, 176);
            this.txbStateFlag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbStateFlag.Name = "txbStateFlag";
            this.txbStateFlag.Size = new System.Drawing.Size(100, 22);
            this.txbStateFlag.TabIndex = 108;
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(737, 176);
            this.txbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(100, 22);
            this.txbDate.TabIndex = 107;
            // 
            // txbEmID
            // 
            this.txbEmID.Location = new System.Drawing.Point(353, 176);
            this.txbEmID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(100, 22);
            this.txbEmID.TabIndex = 106;
            this.txbEmID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbSoID
            // 
            this.txbSoID.Location = new System.Drawing.Point(233, 176);
            this.txbSoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(100, 22);
            this.txbSoID.TabIndex = 105;
            this.txbSoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbCharge
            // 
            this.txbCharge.Location = new System.Drawing.Point(608, 176);
            this.txbCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCharge.Name = "txbCharge";
            this.txbCharge.Size = new System.Drawing.Size(100, 22);
            this.txbCharge.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "受注管理フラグ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 229);
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
            this.label4.Location = new System.Drawing.Point(735, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "受注年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 136);
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
            this.label1.Location = new System.Drawing.Point(626, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 97;
            this.label1.Text = "顧客担当名";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(243, 41);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 24);
            this.btnRegist.TabIndex = 132;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // txbPrID
            // 
            this.txbPrID.Location = new System.Drawing.Point(1067, 334);
            this.txbPrID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(100, 22);
            this.txbPrID.TabIndex = 138;
            this.txbPrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1064, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 137;
            this.label12.Text = "商品ID";
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Location = new System.Drawing.Point(1217, 320);
            this.btnDetailSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(75, 24);
            this.btnDetailSearch.TabIndex = 136;
            this.btnDetailSearch.Text = "詳細検索";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // txbOrDetailID
            // 
            this.txbOrDetailID.Location = new System.Drawing.Point(957, 334);
            this.txbOrDetailID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbOrDetailID.Name = "txbOrDetailID";
            this.txbOrDetailID.Size = new System.Drawing.Size(100, 22);
            this.txbOrDetailID.TabIndex = 135;
            this.txbOrDetailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(954, 306);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(81, 15);
            this.labal1.TabIndex = 134;
            this.labal1.Text = "受注詳細ID";
            // 
            // dataGridViewDetailDsp
            // 
            this.dataGridViewDetailDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailDsp.Location = new System.Drawing.Point(951, 374);
            this.dataGridViewDetailDsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDetailDsp.Name = "dataGridViewDetailDsp";
            this.dataGridViewDetailDsp.RowHeadersWidth = 51;
            this.dataGridViewDetailDsp.RowTemplate.Height = 24;
            this.dataGridViewDetailDsp.Size = new System.Drawing.Size(377, 249);
            this.dataGridViewDetailDsp.TabIndex = 133;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(793, 41);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 139;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(416, 41);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 24);
            this.btnUpdate.TabIndex = 140;
            this.btnUpdate.Text = "非表示更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDetailRegist
            // 
            this.btnDetailRegist.Location = new System.Drawing.Point(1217, 285);
            this.btnDetailRegist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailRegist.Name = "btnDetailRegist";
            this.btnDetailRegist.Size = new System.Drawing.Size(75, 24);
            this.btnDetailRegist.TabIndex = 141;
            this.btnDetailRegist.Text = "詳細登録";
            this.btnDetailRegist.UseVisualStyleBackColor = true;
            this.btnDetailRegist.Click += new System.EventHandler(this.btnDetailRegist_Click);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(1063, 270);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(100, 22);
            this.txbQuantity.TabIndex = 143;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
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
            this.txbOrIDsub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbOrIDsub.Name = "txbOrIDsub";
            this.txbOrIDsub.Size = new System.Drawing.Size(100, 22);
            this.txbOrIDsub.TabIndex = 145;
            this.txbOrIDsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
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
            // lblDetailPage
            // 
            this.lblDetailPage.AutoSize = true;
            this.lblDetailPage.Location = new System.Drawing.Point(1284, 644);
            this.lblDetailPage.Name = "lblDetailPage";
            this.lblDetailPage.Size = new System.Drawing.Size(43, 15);
            this.lblDetailPage.TabIndex = 153;
            this.lblDetailPage.Text = "ページ";
            // 
            // txbDetailPageNo
            // 
            this.txbDetailPageNo.Location = new System.Drawing.Point(1161, 641);
            this.txbDetailPageNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDetailPageNo.Name = "txbDetailPageNo";
            this.txbDetailPageNo.Size = new System.Drawing.Size(100, 22);
            this.txbDetailPageNo.TabIndex = 152;
            // 
            // btnDetailLastPage
            // 
            this.btnDetailLastPage.Location = new System.Drawing.Point(1228, 686);
            this.btnDetailLastPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailLastPage.Name = "btnDetailLastPage";
            this.btnDetailLastPage.Size = new System.Drawing.Size(75, 24);
            this.btnDetailLastPage.TabIndex = 151;
            this.btnDetailLastPage.Text = "▶|";
            this.btnDetailLastPage.UseVisualStyleBackColor = true;
            this.btnDetailLastPage.Click += new System.EventHandler(this.btnDetailLastPage_Click);
            this.btnDetailLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailNextPage
            // 
            this.btnDetailNextPage.Location = new System.Drawing.Point(1147, 686);
            this.btnDetailNextPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailNextPage.Name = "btnDetailNextPage";
            this.btnDetailNextPage.Size = new System.Drawing.Size(75, 24);
            this.btnDetailNextPage.TabIndex = 150;
            this.btnDetailNextPage.Text = "▶";
            this.btnDetailNextPage.UseVisualStyleBackColor = true;
            this.btnDetailNextPage.Click += new System.EventHandler(this.btnDetailNextPage_Click);
            this.btnDetailNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailPreviousPage
            // 
            this.btnDetailPreviousPage.Location = new System.Drawing.Point(1065, 686);
            this.btnDetailPreviousPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailPreviousPage.Name = "btnDetailPreviousPage";
            this.btnDetailPreviousPage.Size = new System.Drawing.Size(75, 24);
            this.btnDetailPreviousPage.TabIndex = 149;
            this.btnDetailPreviousPage.Text = "◀";
            this.btnDetailPreviousPage.UseVisualStyleBackColor = true;
            this.btnDetailPreviousPage.Click += new System.EventHandler(this.btnDetailPreviousPage_Click);
            this.btnDetailPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailFirstPage
            // 
            this.btnDetailFirstPage.Location = new System.Drawing.Point(985, 686);
            this.btnDetailFirstPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailFirstPage.Name = "btnDetailFirstPage";
            this.btnDetailFirstPage.Size = new System.Drawing.Size(75, 24);
            this.btnDetailFirstPage.TabIndex = 148;
            this.btnDetailFirstPage.Text = "|◀";
            this.btnDetailFirstPage.UseVisualStyleBackColor = true;
            this.btnDetailFirstPage.Click += new System.EventHandler(this.btnDetailFirstPage_Click);
            this.btnDetailFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbDetailPageSize
            // 
            this.txbDetailPageSize.Location = new System.Drawing.Point(1017, 641);
            this.txbDetailPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDetailPageSize.Name = "txbDetailPageSize";
            this.txbDetailPageSize.Size = new System.Drawing.Size(100, 22);
            this.txbDetailPageSize.TabIndex = 147;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(929, 644);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 15);
            this.label16.TabIndex = 146;
            this.label16.Text = "1ページ行数";
            // 
            // lblClName
            // 
            this.lblClName.AutoSize = true;
            this.lblClName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClName.Location = new System.Drawing.Point(479, 152);
            this.lblClName.Name = "lblClName";
            this.lblClName.Size = new System.Drawing.Size(49, 20);
            this.lblClName.TabIndex = 157;
            this.lblClName.Text = "----";
            // 
            // lblEmName
            // 
            this.lblEmName.AutoSize = true;
            this.lblEmName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmName.Location = new System.Drawing.Point(353, 152);
            this.lblEmName.Name = "lblEmName";
            this.lblEmName.Size = new System.Drawing.Size(49, 20);
            this.lblEmName.TabIndex = 156;
            this.lblEmName.Text = "----";
            // 
            // lblSoName
            // 
            this.lblSoName.AutoSize = true;
            this.lblSoName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSoName.Location = new System.Drawing.Point(232, 152);
            this.lblSoName.Name = "lblSoName";
            this.lblSoName.Size = new System.Drawing.Size(49, 20);
            this.lblSoName.TabIndex = 155;
            this.lblSoName.Text = "----";
            // 
            // lblPrName
            // 
            this.lblPrName.AutoSize = true;
            this.lblPrName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrName.Location = new System.Drawing.Point(1065, 310);
            this.lblPrName.Name = "lblPrName";
            this.lblPrName.Size = new System.Drawing.Size(49, 20);
            this.lblPrName.TabIndex = 158;
            this.lblPrName.Text = "----";
            // 
            // cmbHint
            // 
            this.cmbHint.FormattingEnabled = true;
            this.cmbHint.Location = new System.Drawing.Point(1062, 153);
            this.cmbHint.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHint.Name = "cmbHint";
            this.cmbHint.Size = new System.Drawing.Size(160, 23);
            this.cmbHint.TabIndex = 159;
            // 
            // F_AdOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 769);
            this.Controls.Add(this.cmbHint);
            this.Controls.Add(this.lblPrName);
            this.Controls.Add(this.lblClName);
            this.Controls.Add(this.lblEmName);
            this.Controls.Add(this.lblSoName);
            this.Controls.Add(this.lblDetailPage);
            this.Controls.Add(this.txbDetailPageNo);
            this.Controls.Add(this.btnDetailLastPage);
            this.Controls.Add(this.btnDetailNextPage);
            this.Controls.Add(this.btnDetailPreviousPage);
            this.Controls.Add(this.btnDetailFirstPage);
            this.Controls.Add(this.txbDetailPageSize);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbOrIDsub);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDetailRegist);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetailSearch);
            this.Controls.Add(this.txbOrDetailID);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.dataGridViewDetailDsp);
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
            this.Controls.Add(this.txbFlag);
            this.Controls.Add(this.txbHidden);
            this.Controls.Add(this.txbStateFlag);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.txbEmID);
            this.Controls.Add(this.txbSoID);
            this.Controls.Add(this.txbCharge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F_AdOrder";
            this.Text = "受注管理";
            this.Load += new System.EventHandler(this.F_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDsp)).EndInit();
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
        private System.Windows.Forms.TextBox txbFlag;
        private System.Windows.Forms.TextBox txbHidden;
        private System.Windows.Forms.TextBox txbStateFlag;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.TextBox txbEmID;
        private System.Windows.Forms.TextBox txbSoID;
        private System.Windows.Forms.TextBox txbCharge;
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
        private System.Windows.Forms.DataGridView dataGridViewDetailDsp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetailRegist;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbOrIDsub;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDetailPage;
        private System.Windows.Forms.TextBox txbDetailPageNo;
        private System.Windows.Forms.Button btnDetailLastPage;
        private System.Windows.Forms.Button btnDetailNextPage;
        private System.Windows.Forms.Button btnDetailPreviousPage;
        private System.Windows.Forms.Button btnDetailFirstPage;
        private System.Windows.Forms.TextBox txbDetailPageSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblClName;
        private System.Windows.Forms.Label lblEmName;
        private System.Windows.Forms.Label lblSoName;
        private System.Windows.Forms.Label lblPrName;
        private System.Windows.Forms.ComboBox cmbHint;
    }
}