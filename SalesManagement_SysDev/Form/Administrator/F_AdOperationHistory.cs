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

namespace SalesManagement_SysDev
{
    public partial class F_AdOperationHistory : Form
    {
        F_AdMenu AdMenu;

        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        private static List<T_OperationHistory> OperationHistory;
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();


        public F_AdOperationHistory(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "ログ管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            cmbForm.TabIndex = 0;
            cmbButton.TabIndex = 1;
            dtpDate.TabIndex = 5;
            cbxDisplay.TabIndex = 11;
            cbxAccount.TabIndex = 13;
            //↑メインのチェックボックス
            cmbHint.TabIndex = 14;
            cmbDate.TabIndex = 15;
            //↑条件のコンボボックス
            btnSort.TabIndex = 17;
            //↑その他機能
            btnDisplay.TabIndex = 20;
            btnSearch.TabIndex = 24;
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


            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("検索");
            cmbHint.SelectedIndex = 0;

            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;

            cmbButton.Items.Add("条件なし");
            cmbButton.Items.Add("登録");
            cmbButton.Items.Add("更新");
            cmbButton.SelectedIndex = 0;

            cmbForm.Items.Add("条件なし");
            cmbForm.Items.Add("顧客管理");
            cmbForm.Items.Add("商品管理");
            cmbForm.Items.Add("社員管理");
            cmbForm.Items.Add("在庫管理");
            cmbForm.Items.Add("受注管理");
            cmbForm.Items.Add("注文管理");
            cmbForm.Items.Add("出庫管理");
            cmbForm.Items.Add("入荷管理");
            cmbForm.Items.Add("出荷管理");
            cmbForm.Items.Add("売上管理");
            cmbForm.Items.Add("発注管理");
            cmbForm.Items.Add("入庫管理");
            cmbForm.Items.Add("メーカ管理");
            cmbForm.Items.Add("営業所管理");
            cmbForm.Items.Add("パスワード管理");
            cmbForm.SelectedIndex = 0;


            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_AdOperationHistory_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
        }

        private void fncTextColor(string Item)
        {


            switch (Item)
            { case "一覧表示":
                    lblForm.ForeColor = Color.Black;
                    lblButton.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxAccount.ForeColor = Color.Blue;
                    break;

                case "検索":
                    lblForm.ForeColor = Color.Blue;
                    lblButton.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblDateCondition.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxAccount.ForeColor = Color.Blue;
                    break; 
            }
            
        }

        private void ComboBoxRegistCheck()
        {
            if ((cmbForm.Text == "在庫管理"
                || cmbForm.Text == "注文管理"
                || cmbForm.Text == "出庫管理"
                || cmbForm.Text == "入荷管理"
                || cmbForm.Text == "出荷管理"
                || cmbForm.Text == "売上管理"
                || cmbForm.Text == "入庫管理"
                || cmbForm.Text == "パスワード管理"
                ) && cmbButton.Text == "登録")
                cmbButton.SelectedIndex = 0;

            if(cmbForm.Text == "パスワード管理")
                cmbButton.SelectedIndex = 2;

            if (!cbxDisplay.Checked)
            {
                cmbButton.SelectedIndex = 0;
                cmbForm.SelectedIndex = 0;
            }

        }
        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 30);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDataGridView();
        }

        private void GetDataGridView()
        {
           OperationHistory  = operationHistoryDataAccess.GetOperationHistoryData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource =OperationHistory.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = OperationHistory.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(OperationHistory.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);


            dataGridViewDsp.Columns[0].Width = 377;
            dataGridViewDsp.Columns[1].Width = 300;
            dataGridViewDsp.Columns[2].Width = 400;
            dataGridViewDsp.Columns[3].Width = 400;
            dataGridViewDsp.Columns[4].Width = 400;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewDsp.Columns[0].HeaderText = "ログID";
            dataGridViewDsp.Columns[1].HeaderText = "社員ID";
            dataGridViewDsp.Columns[2].HeaderText = "操作画面";
            dataGridViewDsp.Columns[3].HeaderText = "操作ボタン";
            dataGridViewDsp.Columns[4].HeaderText = "操作時刻";

            dataGridViewDsp.Columns[5].Visible = false;

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;

            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            cmbButton.SelectedIndex = 0;
            cmbForm.SelectedIndex = 0;
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
        }

        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 30);
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
        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
            //項目情報の色設定
        }
        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxDisplay.Checked && !cbxAccount.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
            ComboBoxRegistCheck();
       }
        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 30);
            //下限値上限値設定
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
            //下限値設定
        }
        private void txbEmID_TextChanged(object sender, EventArgs e)
        {
            employeeDataAccess.GetEmployeeNameData(txbEmID.Text, lblEmName);
        }

        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.ValueKeyPress(e);
            //数値のみ入力可
        }

        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 30);
            //10文字以下の数値のみ入力可
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
            //6文字以下の数値のみ入力可
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(OperationHistory), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(OperationHistory), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(OperationHistory), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(OperationHistory), btnSort);
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
            txbEmID.Text = String.Empty;
            cmbForm.SelectedIndex = 0;
            cmbButton.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            GenerateDataAdDisplay();
            //チェックボックスの要素のみ検索条件に
            SetDataGridView();
        }

        private void GenerateDataAdDisplay()
        {
            T_OperationHistory selectCondition = new T_OperationHistory()
            {
                EmID = 0,
                OpID = 0,
                OpForm = "条件なし",
                OpButton = "条件なし",
                OpTime = null
            };

            OperationHistory= operationHistoryDataAccess.GetOperationHistoryData(selectCondition, 0,0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenereteDataAdSelect();
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        { 


            string form = "条件なし";
            string button = "条件なし";
            int displayCondition = 0;

            if (cbxDisplay.Checked) 
            {
                displayCondition = 1;
                if (cmbForm.Text != "条件なし")
                    form = cmbForm.Text;

                if (cmbButton.Text != "条件なし")
                    button = cmbButton.Text;
            }
            else 
            {
                button = "ログ";
            }

            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;


                DateTime? date = null;
                if (dtpDate.Checked)
                date = dtpDate.Value;
            //DTPにチェックが入っている場合、検索条件に含める


            T_OperationHistory selectCondition = new T_OperationHistory()
            {
                OpID = 0,
                EmID = emID,
                OpForm = form,
                OpButton = button,
                OpTime = date
            };

            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            //検索条件を取り出す
            OperationHistory = operationHistoryDataAccess.GetOperationHistoryData(selectCondition, dateCondition,displayCondition);

        }
        private void SetSelectData()
        {

            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = OperationHistory.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = OperationHistory.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(OperationHistory.Count / (double)pageSize)) + "ページ";
        }
        private void CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxRegistCheck();
        }
    }
}
