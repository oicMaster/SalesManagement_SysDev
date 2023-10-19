namespace SalesManagement_SysDev
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
            this.btnHidden = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPageSizeChange = new System.Windows.Forms.Button();
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
            this.txbSaHiddin = new System.Windows.Forms.TextBox();
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
            this.dataGridViewMiniDsp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiniDsp)).BeginInit();
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
            this.txbChID.TextChanged += new System.EventHandler(this.txbOrID_TextChanged);
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
            // btnHidden
            // 
            this.btnHidden.Location = new System.Drawing.Point(556, 31);
            this.btnHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(94, 28);
            this.btnHidden.TabIndex = 125;
            this.btnHidden.Text = "非表示";
            this.btnHidden.UseVisualStyleBackColor = true;
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
            // btnPageSizeChange
            // 
            this.btnPageSizeChange.Location = new System.Drawing.Point(335, 817);
            this.btnPageSizeChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPageSizeChange.Name = "btnPageSizeChange";
            this.btnPageSizeChange.Size = new System.Drawing.Size(94, 28);
            this.btnPageSizeChange.TabIndex = 120;
            this.btnPageSizeChange.Text = "行数変更";
            this.btnPageSizeChange.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(1019, 832);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(53, 18);
            this.lblPage.TabIndex = 119;
            this.lblPage.Text = "ページ";
            // 
            // txbPageNo
            // 
            this.txbPageNo.Location = new System.Drawing.Point(866, 829);
            this.txbPageNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPageNo.Name = "txbPageNo";
            this.txbPageNo.Size = new System.Drawing.Size(124, 25);
            this.txbPageNo.TabIndex = 118;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(1438, 822);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(94, 28);
            this.btnLastPage.TabIndex = 117;
            this.btnLastPage.Text = "▶|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(1336, 822);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(94, 28);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "▶";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(1235, 822);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(94, 28);
            this.btnPreviousPage.TabIndex = 115;
            this.btnPreviousPage.Text = "◀";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(1134, 822);
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
            // txbSaHiddin
            // 
            this.txbSaHiddin.Location = new System.Drawing.Point(269, 306);
            this.txbSaHiddin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaHiddin.Name = "txbSaHiddin";
            this.txbSaHiddin.Size = new System.Drawing.Size(124, 25);
            this.txbSaHiddin.TabIndex = 109;
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
            this.txbSoID.Location = new System.Drawing.Point(426, 193);
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
            this.label2.Text = "受注ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 145);
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
            // dataGridViewMiniDsp
            // 
            this.dataGridViewMiniDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMiniDsp.Location = new System.Drawing.Point(1060, 431);
            this.dataGridViewMiniDsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMiniDsp.Name = "dataGridViewMiniDsp";
            this.dataGridViewMiniDsp.RowHeadersWidth = 51;
            this.dataGridViewMiniDsp.RowTemplate.Height = 24;
            this.dataGridViewMiniDsp.Size = new System.Drawing.Size(471, 299);
            this.dataGridViewMiniDsp.TabIndex = 132;
            // 
            // F_AdSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 886);
            this.Controls.Add(this.txbPrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDetailSearch);
            this.Controls.Add(this.txbSaDetailID);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.dataGridViewMiniDsp);
            this.Controls.Add(this.txbClID);
            this.Controls.Add(this.txbChID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPageSizeChange);
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
            this.Controls.Add(this.txbSaHiddin);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiniDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbClID;
        private System.Windows.Forms.TextBox txbChID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnHidden;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPageSizeChange;
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
        private System.Windows.Forms.TextBox txbSaHiddin;
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
        private System.Windows.Forms.DataGridView dataGridViewMiniDsp;
    }
}