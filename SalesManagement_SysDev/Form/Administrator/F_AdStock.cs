using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace SalesManagement_SysDev
{
    public partial class F_AdStock : Form
    {
        F_AdMenu AdMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        StockDataAccess stockDataAccess = new StockDataAccess();
        private static List<T_Stock> Stock;

        ProductDataAccess productDataAccess = new ProductDataAccess();


        


        public F_AdStock(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "在庫管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;


            txbPrID.TabIndex = 1;
            txbQuantity.TabIndex = 2;
            txbHidden.TabIndex = 3;

            //↑テキストボックス
            cbxDisplay.TabIndex = 11;
            cbxHidden.TabIndex = 12;
            cbxState.TabIndex = 13;
            //↑メインのチェックボックス
            cmbHint.TabIndex = 14;
            cmbQuantity.TabIndex = 16;
            //↑条件のコンボボックス
            btnSort.TabIndex = 17;
            //↑その他機能
            btnDisplay.TabIndex = 20;
            btnClear.TabIndex = 21;
            btnUpdate.TabIndex = 22;
            //↑ボタン各種

            txbPageSize.TabIndex = 26;
            txbPageNo.TabIndex = 27;
            btnFirstPage.TabIndex = 28;
            btnPreviousPage.TabIndex = 29;
            btnNextPage.TabIndex = 30;
            btnLastPage.TabIndex = 31;
            //↑メイングリッドビューの諸々

            dataGridViewDsp.TabIndex = 38;
            //↑グリッドビュー

            btnClose.TabIndex = 40;
            //パネルの数値をいじるのを忘れずに！
            //↑閉じる

            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("更新");
            cmbHint.SelectedIndex = 0;

            cmbQuantity.Items.Add("完全一致");
            cmbQuantity.Items.Add("以上");
            cmbQuantity.Items.Add("以下");
            cmbQuantity.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Stock_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            fncButtonEnable(8);
        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                case 8:
                    btnUpdate.Enabled = false;
                    break;
                case 9:
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.Red;
                    break;

                    //01確定　23非表示　45登録　67詳細登録　89更新
            }
        }



        private void fncTextColor(string Item)
        {


            switch (Item)
            {
                case "一覧表示":
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    lblState.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxState.ForeColor = Color.Blue;
                    break;
                case "検索":
                    lblPrID.ForeColor = Color.Blue;
                    lblQuantity.ForeColor = Color.Blue;
                    lblState.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxState.ForeColor = Color.Blue;
                    break;
                case "更新":
                    lblPrID.ForeColor = Color.Red;
                    lblQuantity.ForeColor = Color.Blue;
                    lblState.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxState.ForeColor = Color.Black;
                    break;
            }
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 20);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Stock = stockDataAccess.GetStockData();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Stock.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Stock.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Stock.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);


            dataGridViewDsp.Columns[1].Width = 200;
            dataGridViewDsp.Columns[2].Width = 300;
            dataGridViewDsp.Columns[3].Width = 300;
            dataGridViewDsp.Columns[4].Width = 250;
            dataGridViewDsp.Columns[5].Width = 827;



            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewDsp.Columns[1].HeaderText = "商品ID";
            dataGridViewDsp.Columns[2].HeaderText = "在庫数";
            dataGridViewDsp.Columns[3].HeaderText = "在庫管理フラグ";
            dataGridViewDsp.Columns[4].HeaderText = "在庫状況";
            dataGridViewDsp.Columns[5].HeaderText = "非表示理由";

            dataGridViewDsp.Columns[0].Visible = false;
            dataGridViewDsp.Columns[6].Visible = false;


            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            //グリッドビューが空の際に処理しない
            txbPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbQuantity.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbState.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            else
                txbHidden.Text = String.Empty;
            //Null値のif
        }

        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 20);
            //空白の時に数値を入力
            SetSelectData();

        }

        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageNo, 1);
            //空白の時に数値を入力
            SetDataGridView();
            //SetSelectDataとSetDataGridViewを間違えずに！
        }

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 3, 2);
            commonModule.CellFormatting(e, 4, 3);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示 3在庫充分不足)
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
            //項目情報の色設定
        }

        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxDisplay.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
        }

        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbFlag, 2);
            commonModule.FlagTextChanged(txbState, 3);
            //フラグ数値_日本語化　(1確定未確定 2表示非表示 3在庫充分不足)
        }

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 20);
            //下限値上限値設定
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
            //下限値設定
        }



        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(8);
                txbState.Text = String.Empty;
                txbFlag.Text = String.Empty;
                //リンクしている場合、全件表示に戻す。
            }
            else
            {
                stockDataAccess.GetStockFlagData(sender, txbFlag, txbState);　//2つのテキストボックス
                if(stockDataAccess.CheckStIDExistence(int.Parse(txbPrID.Text)))
                { 
                    fncButtonEnable(9);
                }
            }
            productDataAccess.GetSafetyStockData(sender, lblSafetyStockValue); //安全在庫
            productDataAccess.GetProductNameData(sender, lblPrName); //名前
        }
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.ValueKeyPress(e);
            //数値のみ入力可
        }

        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
            //10文字以下の数値のみ入力可
        }
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
            //6文字以下の数値のみ入力可
        }
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 4);
            //4文字以下の数値のみ入力可
        }
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Stock), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Stock), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Stock), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Stock), btnSort);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetSelectData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbPrID.Text = String.Empty;
            txbQuantity.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbState.Text = String.Empty;
            txbHidden.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            GenerateDataAdDisplay();
            SetDataGridView();

        }
        private void GenerateDataAdDisplay()
        {
            int Flag = 0;

            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;
            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示


            int state = 3;
            if (!cbxState.Checked)
                state = 1;

            T_Stock selectCondition = new T_Stock()
            {
                StID = 0,
                PrID = 0,
                StQuantity = -1,
                StState = state,
                StFlag = Flag,
                StHidden = null
            };
            Stock = stockDataAccess.GetStockData(selectCondition,0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //顧客情報抽出
            GenerateDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }

        private void GenerateDataAdSelect()
        {
            int Flag = 0;

            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;
            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示

            int state = 3;
            if (!cbxState.Checked)
                state = 1;


            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbQuantity.Text, out int Quantity))
                Quantity = -1;

            T_Stock selectCondition = new T_Stock()
            {
                StID = 0,
                PrID = prID,
                StQuantity = Quantity,
                StState = state,
                StFlag = Flag,
                StHidden = null
            };
            int QuantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            Stock = stockDataAccess.GetStockData(selectCondition, QuantityCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Stock.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Stock.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Stock.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updSt = GenerateDataAtUpdate();
            UpdateStock(updSt);
        }

        private T_Stock GenerateDataAtUpdate()
        {
            int Flag = 0;
            if (!String.IsNullOrEmpty(txbHidden.Text))
                Flag = 2;

            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbQuantity.Text, out int Quantity))
                Quantity = -1;

            int state = productDataAccess.GetSafetyStockCheck(txbPrID,Quantity);

            return new T_Stock
            {
                StID = 0,
                PrID = prID,
                StQuantity = Quantity,
                StState = state,
                StFlag = Flag,
                StHidden = txbHidden.Text
            };
        }
        private void UpdateStock(T_Stock updSt)
        {
            string MsgCode = "M1";
            if (!String.IsNullOrEmpty(txbHidden.Text))
                MsgCode = "M2";

            DialogResult result = messageDsp.MsgDspQ(MsgCode + "001", lblPrID, txbPrID);
            //●●ID:00の情報を更新しますか？
            //●●ID:00を非表示にしますか？

            if (result != DialogResult.OK)
                return;

            bool flg = stockDataAccess.UpdateStockData(updSt);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);


                    result = messageDsp.MsgDsp(MsgCode + "002", lblPrID, txbPrID);
                //●●ID:00の情報を更新しました。
                //●●ID:00を非表示にしました。

            }
            else
            {
                    result = messageDsp.MsgDsp(MsgCode + "003", lblPrID, txbPrID);
                //●●ID:00の情報を更新に失敗しました。
                //●●ID:00を非表示に失敗しました。
                return;
            }

            ClearInput();
            txbPrID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            //全件表示
        }
    }
}
