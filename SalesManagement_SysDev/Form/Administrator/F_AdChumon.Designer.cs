namespace SalesManagement_SysDev
{
    partial class F_AdChumon
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
            this.txbChID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDetailSearch = new System.Windows.Forms.Button();
            this.txbChDetailID = new System.Windows.Forms.TextBox();
            this.labal1 = new System.Windows.Forms.Label();
            this.dataGridViewDetailDsp = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbChIDsub = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDetailPage = new System.Windows.Forms.Label();
            this.txbDetailPageNo = new System.Windows.Forms.TextBox();
            this.btnDetailLastPage = new System.Windows.Forms.Button();
            this.btnDetailNextPage = new System.Windows.Forms.Button();
            this.btnDetailPreviousPage = new System.Windows.Forms.Button();
            this.btnDetailFirstPage = new System.Windows.Forms.Button();
            this.txbDetailPageSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // txbClID
            // 
            this.txbClID.Location = new System.Drawing.Point(624, 208);
            this.txbClID.Margin = new System.Windows.Forms.Padding(4);
            this.txbClID.Name = "txbClID";
            this.txbClID.Size = new System.Drawing.Size(124, 25);
            this.txbClID.TabIndex = 131;
            this.txbClID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbOrID
            // 
            this.txbOrID.Location = new System.Drawing.Point(764, 208);
            this.txbOrID.Margin = new System.Windows.Forms.Padding(4);
            this.txbOrID.Name = "txbOrID";
            this.txbOrID.Size = new System.Drawing.Size(124, 25);
            this.txbOrID.TabIndex = 130;
            this.txbOrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 129;
            this.label10.Text = "顧客ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 128;
            this.label9.Text = "営業所ID";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(576, 47);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 28);
            this.btnConfirm.TabIndex = 127;
            this.btnConfirm.Text = "注文確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(1185, 47);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 28);
            this.btnDisplay.TabIndex = 126;
            this.btnDisplay.Text = "一覧表示";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(795, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1445, 70);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 28);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(1340, 126);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(80, 18);
            this.lblLoginName.TabIndex = 122;
            this.lblLoginName.Text = "千田真隆";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1216, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 121;
            this.label8.Text = "ログイン情報";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(248, 883);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(53, 18);
            this.lblPage.TabIndex = 119;
            this.lblPage.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Location = new System.Drawing.Point(95, 881);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(124, 25);
            this.txbPageNo.TabIndex = 118;
            this.txbPageNo.TextChanged += new System.EventHandler(this.txbPageNo_TextChanged);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(666, 874);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(94, 28);
            this.btnLastPage.TabIndex = 117;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            this.btnLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(565, 874);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(94, 28);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            this.btnNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(464, 874);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(94, 28);
            this.btnPreviousPage.TabIndex = 115;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            this.btnPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(362, 874);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(94, 28);
            this.btnFirstPage.TabIndex = 114;
            this.btnFirstPage.Text = "|◀";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.txbPageSize_TextChanged);
            this.btnFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbPageSize
            // 
            this.txbPageSize.Location = new System.Drawing.Point(246, 833);
            this.txbPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.Size = new System.Drawing.Size(124, 25);
            this.txbPageSize.TabIndex = 113;
            this.txbPageSize.TextChanged += new System.EventHandler(this.txbPageSize_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 836);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 112;
            this.label11.Text = "1ページ行数";
            // 
            // dataGridViewDsp
            // 
            this.dataGridViewDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsp.Location = new System.Drawing.Point(141, 365);
            this.dataGridViewDsp.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDsp.Name = "dataGridViewDsp";
            this.dataGridViewDsp.RowHeadersWidth = 51;
            this.dataGridViewDsp.RowTemplate.Height = 24;
            this.dataGridViewDsp.Size = new System.Drawing.Size(925, 379);
            this.dataGridViewDsp.TabIndex = 111;
            // 
            // txbFlag
            // 
            this.txbFlag.Location = new System.Drawing.Point(155, 320);
            this.txbFlag.Margin = new System.Windows.Forms.Padding(4);
            this.txbFlag.Name = "txbFlag";
            this.txbFlag.Size = new System.Drawing.Size(124, 25);
            this.txbFlag.TabIndex = 110;
            // 
            // txbHidden
            // 
            this.txbHidden.Location = new System.Drawing.Point(312, 320);
            this.txbHidden.Margin = new System.Windows.Forms.Padding(4);
            this.txbHidden.Name = "txbHidden";
            this.txbHidden.Size = new System.Drawing.Size(124, 25);
            this.txbHidden.TabIndex = 109;
            // 
            // txbStateFlag
            // 
            this.txbStateFlag.Location = new System.Drawing.Point(1090, 208);
            this.txbStateFlag.Margin = new System.Windows.Forms.Padding(4);
            this.txbStateFlag.Name = "txbStateFlag";
            this.txbStateFlag.Size = new System.Drawing.Size(124, 25);
            this.txbStateFlag.TabIndex = 108;
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(941, 208);
            this.txbDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(124, 25);
            this.txbDate.TabIndex = 107;
            // 
            // txbEmID
            // 
            this.txbEmID.Location = new System.Drawing.Point(461, 208);
            this.txbEmID.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmID.Name = "txbEmID";
            this.txbEmID.Size = new System.Drawing.Size(124, 25);
            this.txbEmID.TabIndex = 106;
            this.txbEmID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbSoID
            // 
            this.txbSoID.Location = new System.Drawing.Point(312, 208);
            this.txbSoID.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoID.Name = "txbSoID";
            this.txbSoID.Size = new System.Drawing.Size(124, 25);
            this.txbSoID.TabIndex = 105;
            this.txbSoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbChID
            // 
            this.txbChID.Location = new System.Drawing.Point(155, 208);
            this.txbChID.Margin = new System.Windows.Forms.Padding(4);
            this.txbChID.Name = "txbChID";
            this.txbChID.Size = new System.Drawing.Size(124, 25);
            this.txbChID.TabIndex = 104;
            this.txbChID.TextChanged += new System.EventHandler(this.txbKeyID_TextChanged);
            this.txbChID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "注文管理フラグ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 102;
            this.label6.Text = "非表示理由";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 101;
            this.label5.Text = "注文状態フラグ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "注文年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "受注ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "注文ID";
            // 
            // txbPrID
            // 
            this.txbPrID.Location = new System.Drawing.Point(1250, 380);
            this.txbPrID.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrID.Name = "txbPrID";
            this.txbPrID.Size = new System.Drawing.Size(124, 25);
            this.txbPrID.TabIndex = 137;
            this.txbPrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1246, 348);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 136;
            this.label12.Text = "商品ID";
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Location = new System.Drawing.Point(1439, 380);
            this.btnDetailSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(94, 28);
            this.btnDetailSearch.TabIndex = 135;
            this.btnDetailSearch.Text = "詳細検索";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // txbChDetailID
            // 
            this.txbChDetailID.Location = new System.Drawing.Point(1114, 382);
            this.txbChDetailID.Margin = new System.Windows.Forms.Padding(4);
            this.txbChDetailID.Name = "txbChDetailID";
            this.txbChDetailID.Size = new System.Drawing.Size(124, 25);
            this.txbChDetailID.TabIndex = 134;
            this.txbChDetailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(1110, 349);
            this.labal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(96, 18);
            this.labal1.TabIndex = 133;
            this.labal1.Text = "注文詳細ID";
            // 
            // dataGridViewDetailDsp
            // 
            this.dataGridViewDetailDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailDsp.Location = new System.Drawing.Point(1104, 445);
            this.dataGridViewDetailDsp.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDetailDsp.Name = "dataGridViewDetailDsp";
            this.dataGridViewDetailDsp.RowHeadersWidth = 51;
            this.dataGridViewDetailDsp.RowTemplate.Height = 24;
            this.dataGridViewDetailDsp.Size = new System.Drawing.Size(471, 299);
            this.dataGridViewDetailDsp.TabIndex = 132;
            this.dataGridViewDetailDsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetailDsp_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1066, 47);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 28);
            this.btnClear.TabIndex = 138;
            this.btnClear.Text = "入力クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(442, 47);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 28);
            this.btnUpdate.TabIndex = 139;
            this.btnUpdate.Text = "非表示更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(1248, 318);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(124, 25);
            this.txbQuantity.TabIndex = 141;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1244, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 140;
            this.label13.Text = "数量";
            // 
            // txbChIDsub
            // 
            this.txbChIDsub.Location = new System.Drawing.Point(1114, 318);
            this.txbChIDsub.Margin = new System.Windows.Forms.Padding(4);
            this.txbChIDsub.Name = "txbChIDsub";
            this.txbChIDsub.Size = new System.Drawing.Size(124, 25);
            this.txbChIDsub.TabIndex = 143;
            this.txbChIDsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1151, 277);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 142;
            this.label14.Text = "注文ID";
            // 
            // lblDetailPage
            // 
            this.lblDetailPage.AutoSize = true;
            this.lblDetailPage.Location = new System.Drawing.Point(1532, 775);
            this.lblDetailPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailPage.Name = "lblDetailPage";
            this.lblDetailPage.Size = new System.Drawing.Size(53, 18);
            this.lblDetailPage.TabIndex = 151;
            this.lblDetailPage.Text = "ページ";
            // 
            // txbDetailPageNo
            // 
            this.txbDetailPageNo.Location = new System.Drawing.Point(1380, 773);
            this.txbDetailPageNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetailPageNo.Name = "txbDetailPageNo";
            this.txbDetailPageNo.Size = new System.Drawing.Size(124, 25);
            this.txbDetailPageNo.TabIndex = 150;
            // 
            // btnDetailLastPage
            // 
            this.btnDetailLastPage.Location = new System.Drawing.Point(1462, 827);
            this.btnDetailLastPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailLastPage.Name = "btnDetailLastPage";
            this.btnDetailLastPage.Size = new System.Drawing.Size(94, 28);
            this.btnDetailLastPage.TabIndex = 149;
            this.btnDetailLastPage.Text = "▶|";
            this.btnDetailLastPage.UseVisualStyleBackColor = true;
            this.btnDetailLastPage.Click += new System.EventHandler(this.btnDetailLastPage_Click);
            this.btnDetailLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailNextPage
            // 
            this.btnDetailNextPage.Location = new System.Drawing.Point(1361, 827);
            this.btnDetailNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailNextPage.Name = "btnDetailNextPage";
            this.btnDetailNextPage.Size = new System.Drawing.Size(94, 28);
            this.btnDetailNextPage.TabIndex = 148;
            this.btnDetailNextPage.Text = "▶";
            this.btnDetailNextPage.UseVisualStyleBackColor = true;
            this.btnDetailNextPage.Click += new System.EventHandler(this.btnDetailNextPage_Click);
            this.btnDetailNextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailPreviousPage
            // 
            this.btnDetailPreviousPage.Location = new System.Drawing.Point(1260, 827);
            this.btnDetailPreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailPreviousPage.Name = "btnDetailPreviousPage";
            this.btnDetailPreviousPage.Size = new System.Drawing.Size(94, 28);
            this.btnDetailPreviousPage.TabIndex = 147;
            this.btnDetailPreviousPage.Text = "◀";
            this.btnDetailPreviousPage.UseVisualStyleBackColor = true;
            this.btnDetailPreviousPage.Click += new System.EventHandler(this.btnDetailPreviousPage_Click);
            this.btnDetailPreviousPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // btnDetailFirstPage
            // 
            this.btnDetailFirstPage.Location = new System.Drawing.Point(1159, 827);
            this.btnDetailFirstPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailFirstPage.Name = "btnDetailFirstPage";
            this.btnDetailFirstPage.Size = new System.Drawing.Size(94, 28);
            this.btnDetailFirstPage.TabIndex = 146;
            this.btnDetailFirstPage.Text = "|◀";
            this.btnDetailFirstPage.UseVisualStyleBackColor = true;
            this.btnDetailFirstPage.Click += new System.EventHandler(this.btnDetailFirstPage_Click);
            this.btnDetailFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPage_KeyPress);
            // 
            // txbDetailPageSize
            // 
            this.txbDetailPageSize.Location = new System.Drawing.Point(1199, 772);
            this.txbDetailPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetailPageSize.Name = "txbDetailPageSize";
            this.txbDetailPageSize.Size = new System.Drawing.Size(124, 25);
            this.txbDetailPageSize.TabIndex = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1090, 775);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 18);
            this.label16.TabIndex = 144;
            this.label16.Text = "1ページ行数";
            // 
            // F_AdChumon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 916);
            this.Controls.Add(this.lblDetailPage);
            this.Controls.Add(this.txbDetailPageNo);
            this.Controls.Add(this.btnDetailLastPage);
            this.Controls.Add(this.btnDetailNextPage);
            this.Controls.Add(this.btnDetailPreviousPage);
            this.Controls.Add(this.btnDetailFirstPage);
            this.Controls.Add(this.txbDetailPageSize);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbChIDsub);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetailSearch);
            this.Controls.Add(this.txbChDetailID);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.dataGridViewDetailDsp);
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
            this.Controls.Add(this.txbChID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_AdChumon";
            this.Text = "注文管理";
            this.Load += new System.EventHandler(this.F_Chumon_Load);
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
        private System.Windows.Forms.TextBox txbChID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDetailSearch;
        private System.Windows.Forms.TextBox txbChDetailID;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.DataGridView dataGridViewDetailDsp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbChIDsub;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDetailPage;
        private System.Windows.Forms.TextBox txbDetailPageNo;
        private System.Windows.Forms.Button btnDetailLastPage;
        private System.Windows.Forms.Button btnDetailNextPage;
        private System.Windows.Forms.Button btnDetailPreviousPage;
        private System.Windows.Forms.Button btnDetailFirstPage;
        private System.Windows.Forms.TextBox txbDetailPageSize;
        private System.Windows.Forms.Label label16;
    }
}