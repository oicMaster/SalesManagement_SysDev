namespace SalesManagement_SysDev
{
    partial class F_Order
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonHidden = new System.Windows.Forms.Button();
            this.buttondecision = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.buttonPageSizeChange = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.SoID = new System.Windows.Forms.TextBox();
            this.ClID = new System.Windows.Forms.TextBox();
            this.ChDate = new System.Windows.Forms.TextBox();
            this.ChHidden = new System.Windows.Forms.TextBox();
            this.ChFlag = new System.Windows.Forms.TextBox();
            this.ChStateFlag = new System.Windows.Forms.TextBox();
            this.ChID = new System.Windows.Forms.TextBox();
            this.EmID = new System.Windows.Forms.TextBox();
            this.CrID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(218, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 28);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "履歴検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(741, 35);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(94, 28);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "一覧表示";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            // 
            // buttonHidden
            // 
            this.buttonHidden.Location = new System.Drawing.Point(500, 35);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(94, 28);
            this.buttonHidden.TabIndex = 2;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = true;
            // 
            // buttondecision
            // 
            this.buttondecision.Location = new System.Drawing.Point(368, 35);
            this.buttondecision.Name = "buttondecision";
            this.buttondecision.Size = new System.Drawing.Size(94, 28);
            this.buttondecision.TabIndex = 3;
            this.buttondecision.Text = "確定";
            this.buttondecision.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(852, 35);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 28);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(983, 39);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 28);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1209, 106);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 28);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "ログアウト";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ログイン情報";
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(1089, 111);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(97, 18);
            this.labelLoginName.TabIndex = 8;
            this.labelLoginName.Text = "ログイン情報";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "注文ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "営業所ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "社員ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "顧客ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "受注ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "注文年月日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "注文状態フラグ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "注文管理フラグ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "非表示理由";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 427);
            this.dataGridView1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 805);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "1ページ行数";
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Location = new System.Drawing.Point(205, 797);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(100, 25);
            this.textBoxPageSize.TabIndex = 20;
            // 
            // buttonPageSizeChange
            // 
            this.buttonPageSizeChange.Location = new System.Drawing.Point(311, 799);
            this.buttonPageSizeChange.Name = "buttonPageSizeChange";
            this.buttonPageSizeChange.Size = new System.Drawing.Size(105, 28);
            this.buttonPageSizeChange.TabIndex = 21;
            this.buttonPageSizeChange.Text = "行数変更";
            this.buttonPageSizeChange.UseVisualStyleBackColor = true;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(635, 804);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(53, 18);
            this.labelPage.TabIndex = 22;
            this.labelPage.Text = "ページ";
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Location = new System.Drawing.Point(524, 802);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(100, 25);
            this.textBoxPageNo.TabIndex = 23;
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Location = new System.Drawing.Point(803, 799);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(75, 23);
            this.buttonFirstPage.TabIndex = 24;
            this.buttonFirstPage.Text = "|◀";
            this.buttonFirstPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(900, 802);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousPage.TabIndex = 25;
            this.buttonPreviousPage.Text = "◀";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(998, 799);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 26;
            this.buttonNextPage.Text = "▶";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.Location = new System.Drawing.Point(1106, 799);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(75, 23);
            this.buttonLastPage.TabIndex = 27;
            this.buttonLastPage.Text = "▶|";
            this.buttonLastPage.UseVisualStyleBackColor = true;
            // 
            // SoID
            // 
            this.SoID.Location = new System.Drawing.Point(433, 104);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(129, 25);
            this.SoID.TabIndex = 28;
            // 
            // ClID
            // 
            this.ClID.Location = new System.Drawing.Point(437, 152);
            this.ClID.Name = "ClID";
            this.ClID.Size = new System.Drawing.Size(112, 25);
            this.ClID.TabIndex = 29;
            // 
            // ChDate
            // 
            this.ChDate.Location = new System.Drawing.Point(437, 202);
            this.ChDate.Name = "ChDate";
            this.ChDate.Size = new System.Drawing.Size(101, 25);
            this.ChDate.TabIndex = 30;
            // 
            // ChHidden
            // 
            this.ChHidden.Location = new System.Drawing.Point(228, 307);
            this.ChHidden.Name = "ChHidden";
            this.ChHidden.Size = new System.Drawing.Size(111, 25);
            this.ChHidden.TabIndex = 31;
            // 
            // ChFlag
            // 
            this.ChFlag.Location = new System.Drawing.Point(228, 275);
            this.ChFlag.Name = "ChFlag";
            this.ChFlag.Size = new System.Drawing.Size(101, 25);
            this.ChFlag.TabIndex = 32;
            // 
            // ChStateFlag
            // 
            this.ChStateFlag.Location = new System.Drawing.Point(228, 239);
            this.ChStateFlag.Name = "ChStateFlag";
            this.ChStateFlag.Size = new System.Drawing.Size(85, 25);
            this.ChStateFlag.TabIndex = 33;
            // 
            // ChID
            // 
            this.ChID.Location = new System.Drawing.Point(196, 111);
            this.ChID.Name = "ChID";
            this.ChID.Size = new System.Drawing.Size(91, 25);
            this.ChID.TabIndex = 34;
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(196, 155);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(77, 25);
            this.EmID.TabIndex = 35;
            // 
            // CrID
            // 
            this.CrID.Location = new System.Drawing.Point(196, 199);
            this.CrID.Name = "CrID";
            this.CrID.Size = new System.Drawing.Size(94, 25);
            this.CrID.TabIndex = 36;
            // 
            // F_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 904);
            this.Controls.Add(this.CrID);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.ChID);
            this.Controls.Add(this.ChStateFlag);
            this.Controls.Add(this.ChFlag);
            this.Controls.Add(this.ChHidden);
            this.Controls.Add(this.ChDate);
            this.Controls.Add(this.ClID);
            this.Controls.Add(this.SoID);
            this.Controls.Add(this.buttonLastPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonFirstPage);
            this.Controls.Add(this.textBoxPageNo);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.buttonPageSizeChange);
            this.Controls.Add(this.textBoxPageSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttondecision);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonSearch);
            this.Name = "F_Order";
            this.Text = "受注管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttondecision;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.Button buttonPageSizeChange;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.TextBox SoID;
        private System.Windows.Forms.TextBox ClID;
        private System.Windows.Forms.TextBox ChDate;
        private System.Windows.Forms.TextBox ChHidden;
        private System.Windows.Forms.TextBox ChFlag;
        private System.Windows.Forms.TextBox ChStateFlag;
        private System.Windows.Forms.TextBox ChID;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.TextBox CrID;
    }
}