namespace SalesManagement_SysDev
{
    partial class F_Seals
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClID = new System.Windows.Forms.TextBox();
            this.SoID = new System.Windows.Forms.TextBox();
            this.EmID = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SaDate = new System.Windows.Forms.TextBox();
            this.SaFlag = new System.Windows.Forms.TextBox();
            this.SaHidden = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPageSize = new System.Windows.Forms.TextBox();
            this.buttonPageSizeChange = new System.Windows.Forms.Button();
            this.textBoxPageNo = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelLoginName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(301, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 28);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(772, 30);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(94, 28);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "一覧表示";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            // 
            // buttonHidden
            // 
            this.buttonHidden.Location = new System.Drawing.Point(509, 30);
            this.buttonHidden.Name = "buttonHidden";
            this.buttonHidden.Size = new System.Drawing.Size(94, 28);
            this.buttonHidden.TabIndex = 2;
            this.buttonHidden.Text = "非表示";
            this.buttonHidden.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(892, 30);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 28);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "入力クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1003, 30);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 28);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1214, 98);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 28);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "ログアウト";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // SaID
            // 
            this.SaID.Location = new System.Drawing.Point(183, 142);
            this.SaID.Name = "SaID";
            this.SaID.Size = new System.Drawing.Size(159, 25);
            this.SaID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "売上ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "顧客ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "営業所ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "社員ID";
            // 
            // ChID
            // 
            this.ChID.AutoSize = true;
            this.ChID.Location = new System.Drawing.Point(83, 228);
            this.ChID.Name = "ChID";
            this.ChID.Size = new System.Drawing.Size(60, 18);
            this.ChID.TabIndex = 11;
            this.ChID.Text = "受注ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "売上日時";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "売上管理フラグ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "非表示理由";
            // 
            // ClID
            // 
            this.ClID.Location = new System.Drawing.Point(559, 135);
            this.ClID.Name = "ClID";
            this.ClID.Size = new System.Drawing.Size(146, 25);
            this.ClID.TabIndex = 15;
            // 
            // SoID
            // 
            this.SoID.Location = new System.Drawing.Point(183, 181);
            this.SoID.Name = "SoID";
            this.SoID.Size = new System.Drawing.Size(141, 25);
            this.SoID.TabIndex = 16;
            // 
            // EmID
            // 
            this.EmID.Location = new System.Drawing.Point(559, 172);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(136, 25);
            this.EmID.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 228);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 25);
            this.textBox5.TabIndex = 18;
            // 
            // SaDate
            // 
            this.SaDate.Location = new System.Drawing.Point(559, 210);
            this.SaDate.Name = "SaDate";
            this.SaDate.Size = new System.Drawing.Size(164, 25);
            this.SaDate.TabIndex = 19;
            // 
            // SaFlag
            // 
            this.SaFlag.Location = new System.Drawing.Point(183, 268);
            this.SaFlag.Name = "SaFlag";
            this.SaFlag.Size = new System.Drawing.Size(176, 25);
            this.SaFlag.TabIndex = 20;
            this.SaFlag.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // SaHidden
            // 
            this.SaHidden.Location = new System.Drawing.Point(163, 308);
            this.SaHidden.Name = "SaHidden";
            this.SaHidden.Size = new System.Drawing.Size(161, 25);
            this.SaHidden.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 427);
            this.dataGridView1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 838);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "1ページ行数";
            // 
            // textBoxPageSize
            // 
            this.textBoxPageSize.Location = new System.Drawing.Point(176, 831);
            this.textBoxPageSize.Name = "textBoxPageSize";
            this.textBoxPageSize.Size = new System.Drawing.Size(196, 25);
            this.textBoxPageSize.TabIndex = 24;
            // 
            // buttonPageSizeChange
            // 
            this.buttonPageSizeChange.Location = new System.Drawing.Point(393, 824);
            this.buttonPageSizeChange.Name = "buttonPageSizeChange";
            this.buttonPageSizeChange.Size = new System.Drawing.Size(126, 32);
            this.buttonPageSizeChange.TabIndex = 25;
            this.buttonPageSizeChange.Text = "行数変更";
            this.buttonPageSizeChange.UseVisualStyleBackColor = true;
            // 
            // textBoxPageNo
            // 
            this.textBoxPageNo.Location = new System.Drawing.Point(722, 831);
            this.textBoxPageNo.Name = "textBoxPageNo";
            this.textBoxPageNo.Size = new System.Drawing.Size(130, 25);
            this.textBoxPageNo.TabIndex = 26;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(878, 834);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(53, 18);
            this.labelPage.TabIndex = 27;
            this.labelPage.Text = "ページ";
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Location = new System.Drawing.Point(956, 831);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(56, 26);
            this.buttonFirstPage.TabIndex = 28;
            this.buttonFirstPage.Text = "|◀";
            this.buttonFirstPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(1030, 829);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(56, 28);
            this.buttonPreviousPage.TabIndex = 29;
            this.buttonPreviousPage.Text = "◀";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(1113, 826);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(37, 34);
            this.buttonNextPage.TabIndex = 30;
            this.buttonNextPage.Text = "▶";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.Location = new System.Drawing.Point(1191, 824);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(47, 36);
            this.buttonLastPage.TabIndex = 31;
            this.buttonLastPage.Text = "▶|";
            this.buttonLastPage.UseVisualStyleBackColor = true;
            this.buttonLastPage.Click += new System.EventHandler(this.button10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(922, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "ログイン情報";
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(1027, 104);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(97, 18);
            this.labelLoginName.TabIndex = 33;
            this.labelLoginName.Text = "ログイン情報";
            // 
            // F_Seals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 904);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonLastPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonFirstPage);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.textBoxPageNo);
            this.Controls.Add(this.buttonPageSizeChange);
            this.Controls.Add(this.textBoxPageSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaHidden);
            this.Controls.Add(this.SaFlag);
            this.Controls.Add(this.SaDate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.SoID);
            this.Controls.Add(this.ClID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaID);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHidden);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonSearch);
            this.Name = "F_Seals";
            this.Text = "売上管理";
            this.Load += new System.EventHandler(this.F_Seals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonHidden;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox SaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ChID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClID;
        private System.Windows.Forms.TextBox SoID;
        private System.Windows.Forms.TextBox EmID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox SaDate;
        private System.Windows.Forms.TextBox SaFlag;
        private System.Windows.Forms.TextBox SaHidden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPageSize;
        private System.Windows.Forms.Button buttonPageSizeChange;
        private System.Windows.Forms.TextBox textBoxPageNo;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelLoginName;
    }
}