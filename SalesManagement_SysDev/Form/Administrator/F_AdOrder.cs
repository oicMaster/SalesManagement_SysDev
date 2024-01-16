using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    public partial class F_AdOrder : Form
    {
        F_AdMenu AdMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        OrderDataAccess orderDataAccess = new OrderDataAccess();
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        private static List<T_Order> Order;
        private static List<T_OrderDetail> OrderDetail;
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();

        StockDataAccess stockDataAccess = new StockDataAccess();

        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
      

        public F_AdOrder(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "受注管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            txbCharge.MaxLength = 50;

            txbOrID.TabIndex = 0;
            txbSoID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            txbClID.TabIndex = 3;
            txbCharge.TabIndex = 4;
            dtpDate.TabIndex = 5;
            txbHidden.TabIndex = 6;

            txbOrDetailID.TabIndex = 7;
            txbOrIDsub.TabIndex = 8;
            txbPrID.TabIndex = 9;
            txbQuantity.TabIndex = 10;
            txbTotalPrice.TabIndex = 11;

            cbxDisplay.TabIndex = 12;
            cbxConfirm.TabIndex = 13;
            cbxHidden.TabIndex = 14;

            cmbHint.TabIndex = 15;
            cmbDate.TabIndex = 16;
            cmbQuantity.TabIndex = 17;
            cmbTotalPrice.TabIndex = 18;

            btnSort.TabIndex = 19;
            btnDetailSort.TabIndex = 20;
            cbxLink.TabIndex = 21;

            btnDisplay.TabIndex = 22;
            btnClear.TabIndex = 23;
            btnUpdate.TabIndex = 24;
            btnConfirm.TabIndex = 25;
            btnSearch.TabIndex = 26;
            btnDetailSearch.TabIndex = 27;
            btnDetailRegist.TabIndex = 28;

            txbPageSize.TabIndex = 29;
            txbPageNo.TabIndex = 30;
            btnFirstPage.TabIndex = 31;
            btnPreviousPage.TabIndex = 32;
            btnNextPage.TabIndex = 33;
            btnLastPage.TabIndex = 34;

            txbDetailPageSize.TabIndex = 35;
            txbDetailPageNo.TabIndex = 36;
            btnDetailFirstPage.TabIndex = 37;
            btnDetailPreviousPage.TabIndex = 38;
            btnDetailNextPage.TabIndex = 39;
            btnDetailLastPage.TabIndex = 40;

            dataGridViewDsp.TabIndex = 41;
            dataGridViewDetailDsp.TabIndex = 42;

            btnClose.TabIndex = 43;


            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("非表示更新");
            cmbHint.Items.Add("確定");
            cmbHint.Items.Add("詳細検索");
            cmbHint.Items.Add("詳細登録");
            cmbHint.SelectedIndex = 0;

            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;

            cmbQuantity.Items.Add("完全一致");
            cmbQuantity.Items.Add("以上");
            cmbQuantity.Items.Add("以下");
            cmbQuantity.SelectedIndex = 0;

            cmbTotalPrice.Items.Add("完全一致");
            cmbTotalPrice.Items.Add("以上");
            cmbTotalPrice.Items.Add("以下");
            cmbTotalPrice.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void F_Order_Load(object sender, EventArgs e)
        {

            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            //グリッドビューの設定
            fncButtonEnable(0);
            fncButtonEnable(2);
            fncButtonEnable(4);
            fncButtonEnable(6);
            //ボタンの設定

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                case 0:
                    btnConfirm.Enabled = false;
                    break;
                case 1:
                    btnConfirm.Enabled = true;
                    btnConfirm.ForeColor = Color.Red;
                    break;
                case 2:
                    btnUpdate.Enabled = false;
                    break;
                case 3:
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.Red;
                    break;
                case 4:
                    btnRegist.Enabled = false;
                    break;
                case 5:
                    btnRegist.Enabled = true;
                    btnRegist.ForeColor = Color.Red;
                    break;
                case 6:
                    btnDetailRegist.Enabled = false;
                    break;
                case 7:
                    btnDetailRegist.Enabled = true;
                    btnDetailRegist.ForeColor = Color.Red;
                    break;
            }
        }
        private bool RegistrationCondition(int chk)
        {
            if (chk == 0)
            {
                if (lblSoName.Text == "----"||lblClName.Text == "----")
                    return false;
                if (String.IsNullOrEmpty(txbCharge.Text.Trim()))
                    return false;
            }
            if (chk == 1)
            {
                if (txbFlag.Text != "表示" || txbStateFlag.Text != "未確定")
                    return false;
                if (String.IsNullOrEmpty(txbOrIDsub.Text))
                    return false;
            }
            if (lblPrName.Text == "----")
                return false;
            if (String.IsNullOrEmpty(txbQuantity.Text) || int.Parse(txbQuantity.Text) == 0)
                return false;

            return true;
        }
        private void fncTextColor(string Item)
        {


            switch (Item)
            {
                case "一覧表示":
                    lblOrID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblCharge.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "登録":
                    lblOrID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Fuchsia;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Fuchsia;
                    lblCharge.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Fuchsia;
                    lblQuantity.ForeColor = Color.Fuchsia;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "検索":
                    lblOrID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblClID.ForeColor = Color.Blue;
                    lblCharge.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "非表示更新":
                    lblOrID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblCharge.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Red;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "確定":
                    lblOrID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblCharge.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "詳細登録":
                    lblOrID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblCharge.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Black;
                    lblOrIDsub.ForeColor = Color.Red;
                    lblPrID.ForeColor = Color.Fuchsia;
                    lblQuantity.ForeColor = Color.Fuchsia;
                    lblTotalPrice.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    lblTotalPriceCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "詳細検索":
                    lblOrID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblCharge.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblOrDetailID.ForeColor = Color.Blue;
                    lblOrIDsub.ForeColor = Color.Blue;
                    lblPrID.ForeColor = Color.Blue;
                    lblQuantity.ForeColor = Color.Blue;
                    lblTotalPrice.ForeColor = Color.Blue;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Blue;
                    lblTotalPriceCondition.ForeColor = Color.Blue;
                    //検索条件
                    break;

            }
        }

        private void GenerateDetailLinkData()
        {
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            T_OrderDetail selectCondition = new T_OrderDetail()
            {
                OrDetailID = 0,
                OrID = orID,
                PrID = 0,
                OrQuantity = 0,
                OrTotalPrice = 0,
            };
            OrderDetail = orderDetailDataAccess.GetOrderDetailData(selectCondition, 0,0);
            //IDで検索した結果をリンク表示させる
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Order = orderDataAccess.GetOrderData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;

            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Order.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Order.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDsp.Columns[0].Width = 140;
            dataGridViewDsp.Columns[1].Width = 140;
            dataGridViewDsp.Columns[2].Width = 140;
            dataGridViewDsp.Columns[3].Width = 140;
            dataGridViewDsp.Columns[4].Width = 220;
            dataGridViewDsp.Columns[5].Width = 200;
            dataGridViewDsp.Columns[6].Width = 200;
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[8].Width = 497;


            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "受注ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "顧客担当者名";
            dataGridViewDsp.Columns[5].HeaderText = "受注年月日";
            dataGridViewDsp.Columns[6].HeaderText = "受注状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "受注管理フラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";

            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;
            dataGridViewDsp.Columns[15].Visible = false;
            dataGridViewDsp.Columns[16].Visible = false;

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbHidden.Text = String.Empty;

        }

        private void SetFormDetailDataGridView()
        {
            commonModule.SetFormDataGridView(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, 10);
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            OrderDetail = orderDetailDataAccess.GetOrderDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = OrderDetail.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(OrderDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDetailDsp.RowHeadersVisible = false;
            dataGridViewDetailDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDetailDsp.Columns[0].Width = 170;
            dataGridViewDetailDsp.Columns[1].Width = 170;
            dataGridViewDetailDsp.Columns[2].Width = 170;
            dataGridViewDetailDsp.Columns[3].Width = 240;
            dataGridViewDetailDsp.Columns[4].Width = 377;

            dataGridViewDetailDsp.Columns[4].DefaultCellStyle.Format = "#,0";

            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "受注詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "受注ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";
            dataGridViewDetailDsp.Columns[4].HeaderText = "合計金額";

            dataGridViewDetailDsp.Columns[5].Visible = false;
            dataGridViewDetailDsp.Columns[6].Visible = false;


            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDetailDsp.SelectedCells.Count == 0)
                return;
            txbOrDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbOrIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbTotalPrice.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[4].Value.ToString();
        }
        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 10);
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

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize, 10);
            //空白の時に数値を入力
            SetSelectDetailData();
        }
        private void txbDetailPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageNo, 1);
            //空白の時に数値を入力
            SetDetailDataGridView();
            //SetSelectDetailDataとSetDetailDataGridViewを間違えずに！
        }
        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 6, 1);
            commonModule.CellFormatting(e, 7, 2);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示)
        }
        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
        }
        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxConfirm.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
       　}

        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbStateFlag, 1);
            commonModule.FlagTextChanged(txbFlag, 2);
            //フラグ数値_日本語化　(1確定未確定 2表示非表示)
        }
        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 10);
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
                fncButtonEnable(0);
                fncButtonEnable(2);
                txbStateFlag.Text = String.Empty;
                txbFlag.Text = String.Empty;
                //↑初期状態
                if (cbxLink.Checked)
                    GetDetailDataGridView();
                //リンクしている場合、全件表示に戻す。
            }
            else
            {
                orderDataAccess.GetOrderFlagData(sender, txbStateFlag, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                {//表示、未確定の場合
                    if (orderDetailDataAccess.CheckStock(int.Parse(txbOrID.Text)))//受注数が実在庫を超えているかどうか
                        fncButtonEnable(1); //確定可能
                    else
                        fncButtonEnable(0);
                   
                    if (!String.IsNullOrEmpty(txbHidden.Text))
                        //非表示理由が入力されている場合
                        fncButtonEnable(3);
                   　//非表示可能
                }
                else
                    fncButtonEnable(0);
                //どちらかが非表示、確定済の場合　確定不可

                if (cbxLink.Checked)
                {
                    GenerateDetailLinkData();
                    //↑リンク用検索メソッド
                    SetDetailDataGridView();
                }
                //リンクしている場合、IDで詳細検索した結果を渡す。
            }
            if (RegistrationCondition(1))
            {
                if (orderDetailDataAccess.CheckDuplicateOrderDetail(int.Parse(txbOrID.Text), int.Parse(txbPrID.Text)))
                    fncButtonEnable(7);
            }
            else
                fncButtonEnable(6);
            commonModule.KeyIDKeyPress(sender, txbOrIDsub);
            //詳細側のテキストボックスと連動
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbHidden.Text))
            {
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                    fncButtonEnable(3);
                //非表示理由が空白でない、フラグが表示・未確定である場合に非表示可能
                //フラグに文字が表示されてる=IDのテキストボックスに何かしら入力されている状態
            }
            else
                fncButtonEnable(2);
            //非表示理由が空白の場合、非表示不可

        }

        //メイングリッドビュー,サブグリッドビューで使用する主キーのテキストボックスの文字を連動させる。
        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbOrID);
            //メイン側のテキストボックスと連動
        }
        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            stockDataAccess.GetStockValueData(txbPrID, txbQuantity, lblStockValue,0);
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
            if (RegistrationCondition(1))
            {
                if (orderDetailDataAccess.CheckDuplicateOrderDetail(int.Parse(txbOrID.Text), int.Parse(txbPrID.Text)))
                    fncButtonEnable(7);
            }
            else
                fncButtonEnable(6);
        }
        private void txbCharge_TextChanged(object sender, EventArgs e)
        {
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);

        }


        private void txbPrID_TextChanged(object sender, EventArgs e)
        {
            productDataAccess.GetProductNameData(sender, lblPrName);
            stockDataAccess.GetStockValueData(txbPrID, txbQuantity, lblStockValue,0);

            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
            if (RegistrationCondition(1))
            {
                if (orderDetailDataAccess.CheckDuplicateOrderDetail(int.Parse(txbOrID.Text), int.Parse(txbPrID.Text)))
                    fncButtonEnable(7);
            }
            else
                fncButtonEnable(6);
        }

        private void txbClID_TextChanged(object sender, EventArgs e)
        {
            clientDataAccess.GetClientNameData(sender, lblClName);
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
        }

        private void txbEmID_TextChanged(object sender, EventArgs e)
        {
            employeeDataAccess.GetEmployeeNameData(txbEmID.Text, lblEmName);
        }

        private void txbSoID_TextChanged(object sender, EventArgs e)
        {
            salesOfficeDataAccess.GetSalesOfficeNameData(sender, lblSoName);
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {
            commonModule.PriceTextChanged(sender);
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

        
        private void txbTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
            //10文字以下の数値のみ入力可
        }



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Order), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Order), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Order), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Order), btnSort);
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(OrderDetail), btnDetailSort);
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(OrderDetail), btnDetailSort);
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(OrderDetail), btnDetailSort);
        }
        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(OrderDetail), btnDetailSort);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetSelectData();
        }

        private void btnDetailSort_Click(object sender, EventArgs e)
        {
            txbDetailPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetDetailDataGridView();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbOrID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbCharge.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
            //↑メイン↓詳細のテキストボックス、DTPの初期化(IDsubは勝手に初期化される)
            txbOrDetailID.Text = String.Empty;
            txbPrID.Text = String.Empty;
            txbQuantity.Text = String.Empty;
            txbTotalPrice.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            txbDetailPageNo.Text = "1";
            GenerateDataAdDisplay();
            //チェックボックスの要素のみ検索条件に
            SetDataGridView();
            SetDetailDataGridView();
        }

        private void GenerateDataAdDisplay()
        {
            int Flag = 0;
            int StateFlag = 0;


            if (cbxConfirm.Checked && !cbxDisplay.Checked)
                StateFlag = 1;
            if (cbxConfirm.Checked && cbxDisplay.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示

            T_Order selectCondition = new T_Order()
            {
                OrID = 0,
                SoID = 0,
                EmID = 0,
                ClID = 0,
                ClCharge = String.Empty,
                OrDate = null,
                OrFlag = Flag,
                OrStateFlag = StateFlag,
                OrHidden = null
            };

            Order = orderDataAccess.GetOrderData(selectCondition, 0);
            OrderDetail = orderDetailDataAccess.GetOrderDetailData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Or情報抽出
            GenereteDataAdSelect();
            //Or情報抽出結果
            SetSelectData();
            if (cbxLink.Checked)
            {
                GenerateDetailLinkData();
                //↑リンク用検索メソッド
                SetDetailDataGridView();
            }
        }

        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime? date = null;
            string clCharge = String.Empty;

            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            //IDが空白の場合は0として(0=検索条件に含まず)

            if (!String.IsNullOrEmpty(txbCharge.Text.Trim()))
                clCharge = txbCharge.Text.Trim();

            if (dtpDate.Checked)
                date = dtpDate.Value;
            //DTPにチェックが入っている場合、検索条件に含める

            if (cbxConfirm.Checked && !cbxDisplay.Checked)
                StateFlag = 1;
            if (cbxConfirm.Checked && cbxDisplay.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示

            T_Order selectCondition = new T_Order()
            {
                OrID = orID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                ClCharge = clCharge,
                OrDate = date,
                OrFlag = Flag,
                OrStateFlag = StateFlag,
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            //検索条件を取り出す
            Order = orderDataAccess.GetOrderData(selectCondition, dateCondition);

        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Order.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Order.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var regOr = GenereteDataAdRegistration();
            RegistrationOrder(regOr);
        }

        private T_Order GenereteDataAdRegistration()
        {
            return new T_Order
            {
                SoID = int.Parse(txbSoID.Text),
                ClID = int.Parse(txbClID.Text),
                EmID = int.Parse(lblLoginIDData.Text),
                ClCharge = txbCharge.Text.Trim(),
                OrDate = DateTime.Now,
                OrStateFlag = 0,
                OrFlag = 0,
                OrHidden = null
            };
        }
        private void RegistrationOrder(T_Order regOr)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = orderDataAccess.AddOrderData(regOr);
            if (flg)
            {
                var regOrD = GenerateDetailDataAdRegistrationPlus();
                RegistrationOrderDetailPlus(regOrD);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
        }

        private T_OrderDetail GenerateDetailDataAdRegistrationPlus()
        {
            return new T_OrderDetail()
            {
                OrID = orderDataAccess.GetOrderIDData(),
                PrID = int.Parse(txbPrID.Text),
                OrQuantity = int.Parse(txbQuantity.Text),
                OrTotalPrice = productDataAccess.GetProductTotalPriceData(txbPrID,txbQuantity)
            };
        }
        private void RegistrationOrderDetailPlus(T_OrderDetail regOrD)
        {
            bool flg = orderDetailDataAccess.AddOrderDetailData(regOrD);
            if (flg)
            {
                messageDsp.MsgDsp("M0002");
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
            }
            else
            {
                var updOr = orderDataAccess.GenerateDataAdError();
                orderDataAccess.UpdateOrderData(updOr);
                messageDsp.MsgDsp("M0003");
                GenerateDataAdDisplay();
                SetSelectData();
                return;
            }
            txbOrID.Focus();
            ClearInput();
            GenerateDataAdDisplay();
            SetSelectData();
            GetDetailDataGridView();
        }










        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updOr = GenerateDataAtUpdate();
            UpdateOrder(updOr);
        }



        private T_Order GenerateDataAtUpdate()
        {
            return new T_Order
            {
                OrID = int.Parse(txbOrID.Text),
                SoID = 0,
                EmID = 0,
                ClID = 0,
                ClCharge = String.Empty,
                OrDate = null,
                OrStateFlag = 0,
                OrFlag = 2,
                OrHidden = txbHidden.Text
            };
            //非表示は　ID Flag=2 Hiddenを使用　Dateはnull
        }

        private void UpdateOrder(T_Order updOr)
        {
            DialogResult result = messageDsp.MsgDspQ("M2001", lblOrID, txbOrID);
            //●●ID:00を非表示にしますか？
            if (result != DialogResult.OK)
                return;

            bool flg = orderDataAccess.UpdateOrderData(updOr);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M2002", lblOrID, txbOrID);
                //●●ID:00を非表示にしました。
            }
            else
            {
                messageDsp.MsgDsp("M2003", lblOrID, txbOrID);
                //●●ID:00の非表示に失敗しました。
                return;
            }


            ClearInput();
            txbOrID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var updOr = GenerateDataAtConfirm();
            ConfirmOrder(updOr);
        }

        private T_Order GenerateDataAtConfirm()
        {
            return new T_Order
            {
                OrID = int.Parse(txbOrID.Text),
                SoID = 0,
                EmID = int.Parse(lblLoginIDData.Text),
                ClID = 0,
                ClCharge = String.Empty,
                OrDate = DateTime.Now,
                OrStateFlag = 1,
                OrFlag = 0,
                OrHidden = null
            };
            //確定は　ID ログインID 現在時刻 StateFlag=1
        }

        private void ConfirmOrder(T_Order updOr)
        {
            DialogResult result = messageDsp.MsgDspQ("M3001", lblOrID, txbOrID);
            //●●ID:00の処理を確定しますか？
            if (result != DialogResult.OK)
                return;


            bool Mflg = orderDataAccess.ConfirmOrderToChumon(int.Parse(txbOrID.Text), int.Parse(lblLoginIDData.Text));
            bool Sflag = false;
            if (Mflg)
            {
                Sflag = orderDetailDataAccess.ConfirmOrderDetailToChumonDetail(int.Parse(txbOrID.Text))
                     && orderDataAccess.UpdateOrderData(updOr)
                     && orderDetailDataAccess.ConfirmOrderAndUpdateStock(int.Parse(txbOrID.Text));
                if (!Sflag)
                {
                    var updCh = chumonDataAccess.GenerateDataAdError();
                    chumonDataAccess.UpdateChumonData(updCh);
                }
            }
            //メインの登録、詳細の複数登録、更新の順番

            if (Mflg&&Sflag)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnConfirm.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M3002", lblOrID, txbOrID);
                //●●ID:00の処理を確定しました。
            }
            else
            {
                messageDsp.MsgDsp("M3003", lblOrID, txbOrID);
                //●●ID:00の確定に失敗しました。
                return;
            }

            ClearInput();
            txbOrID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }


        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenerateDetailDataAdSelect();
            SetSelectDetailData();
        }
        private void GenerateDetailDataAdSelect()
        {
            if (!int.TryParse(txbOrDetailID.Text, out int orDetailID))
                orDetailID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbQuantity.Text, out int orQuantity))
                orQuantity = 0;
            if (!int.TryParse(txbTotalPrice.Text, out int orTotalPrice))
                orTotalPrice = 0;

            //検索に使用するデータ
            T_OrderDetail selectCondition = new T_OrderDetail()
            {//検索に使用するデータ　全て変数で行う
                OrDetailID = orDetailID,
                OrID = orID,
                PrID = prID,               
                OrQuantity = orQuantity,
                OrTotalPrice = orTotalPrice
            };
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            int totalPriceCondition = commonModule.ComboBoxCondition(cmbTotalPrice.Text);
            OrderDetail = orderDetailDataAccess.GetOrderDetailData(selectCondition,quantityCondition,totalPriceCondition);
        }
        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = OrderDetail.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = OrderDetail.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(OrderDetail.Count / (double)pageSize)) + "ページ";
        }





        private void btnDetailRegist_Click(object sender, EventArgs e)
        {
            var regOrD = GenerateDetailDataAdRegistration();
            RegistrationOrderDetail(regOrD);
        }

        private T_OrderDetail GenerateDetailDataAdRegistration()
        {
            return new T_OrderDetail()
            {
                OrID = int.Parse(txbOrIDsub.Text),
                PrID = int.Parse(txbPrID.Text),
                OrQuantity = int.Parse(txbQuantity.Text),
                OrTotalPrice = productDataAccess.GetProductTotalPriceData(txbPrID, txbQuantity)
            };
        }
        private void RegistrationOrderDetail(T_OrderDetail regOrD)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = orderDetailDataAccess.AddOrderDetailData(regOrD);
            if (flg)
            {
                messageDsp.MsgDsp("M0002");
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnDetailRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
            txbOrIDsub.Focus();
            ClearInput();
            GetDetailDataGridView();
        }

       
    }
}

