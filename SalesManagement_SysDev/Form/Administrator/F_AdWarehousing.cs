using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    public partial class F_AdWarehousing : Form
    {

        private F_AdMenu AdMenu;
        //戻り値

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        //共通モジュール
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();
        //ログ管理、パスワード管理以外


        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        WarehousingDetailDataAccess warehousingDetailDataAccess = new WarehousingDetailDataAccess();
        private static List<T_Warehousing> Warehousing;
        private static List<T_WarehousingDetail> WarehousingDetail;
        StockDataAccess stockDataAccess = new StockDataAccess();


        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();





        public F_AdWarehousing(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();

            AdMenu = adMenu;
            Text = "入庫管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            txbWaID.TabIndex = 0;
            txbHaID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            dtpDate.TabIndex = 5;
            txbHidden.TabIndex = 6;

            txbWaDetailID.TabIndex = 7;
            txbWaIDsub.TabIndex = 8;
            txbPrID.TabIndex = 9;
            txbQuantity.TabIndex = 10;

            cbxDisplay.TabIndex = 12;
            cbxConfirm.TabIndex = 13;
            cbxHidden.TabIndex = 14;

            cmbHint.TabIndex = 15;
            cmbDate.TabIndex = 16;
            cmbQuantity.TabIndex = 17;

            btnSort.TabIndex = 19;
            btnDetailSort.TabIndex = 20;
            cbxLink.TabIndex = 21;

            btnDisplay.TabIndex = 22;
            btnClear.TabIndex = 23;
            btnUpdate.TabIndex = 24;
            btnConfirm.TabIndex = 25;
            btnSearch.TabIndex = 26;
            btnDetailSearch.TabIndex = 27;

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
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("非表示更新");
            cmbHint.Items.Add("確定");
            cmbHint.Items.Add("詳細検索");
            cmbHint.SelectedIndex = 0;


            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;

            cmbQuantity.Items.Add("完全一致");
            cmbQuantity.Items.Add("以上");
            cmbQuantity.Items.Add("以下");
            cmbQuantity.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Warehousing_Load(object sender, EventArgs e)
        {

            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            //グリッドビューの設定
            fncButtonEnable(0);
            fncButtonEnable(2);
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
            }
        }

        private void fncTextColor(string Item)
        {


            switch (Item)
            {
                case "一覧表示":
                    lblWaID.ForeColor = Color.Black;
                    lblHaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblWaDetailID.ForeColor = Color.Black;
                    lblWaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "検索":
                    lblWaID.ForeColor = Color.Blue;
                    lblHaID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblWaDetailID.ForeColor = Color.Black;
                    lblWaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "非表示更新":
                    lblWaID.ForeColor = Color.Red;
                    lblHaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Red;
                    //↑メイン↓詳細
                    lblWaDetailID.ForeColor = Color.Black;
                    lblWaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "確定":
                    lblWaID.ForeColor = Color.Red;
                    lblHaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    //↑メイン↓詳細
                    lblWaDetailID.ForeColor = Color.Black;
                    lblWaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "詳細検索":
                    lblWaID.ForeColor = Color.Black;
                    lblHaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Red;
                    //↑メイン↓詳細
                    lblWaDetailID.ForeColor = Color.Blue;
                    lblWaIDsub.ForeColor = Color.Blue;
                    lblPrID.ForeColor = Color.Blue;
                    lblQuantity.ForeColor = Color.Blue;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Blue;
                    break;

            }
        }

        private void GenerateDetailLinkData()
        {
            if (!int.TryParse(txbWaID.Text, out int waID))
                waID = 0;
            T_WarehousingDetail selectCondition = new T_WarehousingDetail()
            {
                WaDetailID = 0,
                WaID = waID,
                PrID = 0,
                WaQuantity = 0,
            };
            WarehousingDetail = warehousingDetailDataAccess.GetWarehousingDetailData(selectCondition, 0);
            //IDで検索した結果をリンク表示させる
        }




        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Warehousing = warehousingDataAccess.GetWarehousingData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;

            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Warehousing.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Warehousing.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Warehousing.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            //列幅の指定
            dataGridViewDsp.Columns[0].Width = 220;
            dataGridViewDsp.Columns[1].Width = 220;
            dataGridViewDsp.Columns[2].Width = 220;
            dataGridViewDsp.Columns[3].Width = 260;
            dataGridViewDsp.Columns[4].Width = 200;
            dataGridViewDsp.Columns[5].Width = 487;
            dataGridViewDsp.Columns[6].Width = 270;

            //列の文字の位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "入庫ID";
            dataGridViewDsp.Columns[1].HeaderText = "発注ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "入庫年月日";
            dataGridViewDsp.Columns[4].HeaderText = "入庫状態フラグ";
            dataGridViewDsp.Columns[5].HeaderText = "非表示理由";
            dataGridViewDsp.Columns[6].HeaderText = "入庫管理フラグ";


            dataGridViewDsp.Columns[7].Visible = false;
            dataGridViewDsp.Columns[8].Visible = false;
            dataGridViewDsp.Columns[9].Visible = false;


            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            txbWaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            else
                txbHidden.Text = String.Empty;
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
           
        }

        private void SetFormDetailDataGridView()
        {
            commonModule.SetFormDataGridView(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, 10);
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            WarehousingDetail = warehousingDetailDataAccess.GetWarehousingDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = WarehousingDetail.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = WarehousingDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(WarehousingDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDetailDsp.RowHeadersVisible = false;
            dataGridViewDetailDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDetailDsp.Columns[0].Width = 270;
            dataGridViewDetailDsp.Columns[1].Width = 270;
            dataGridViewDetailDsp.Columns[2].Width = 270;
            dataGridViewDetailDsp.Columns[3].Width = 317;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "入庫詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "入庫ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;



            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDetailDsp.SelectedCells.Count == 0)
                return;
            txbWaDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbWaIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
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
            commonModule.CellFormatting(e, 4, 1);
            commonModule.CellFormatting(e, 6, 2);
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
                warehousingDataAccess.GetWarehousingFlagData(sender, txbStateFlag, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                {//表示、未確定の場合
                    fncButtonEnable(1);
                    //確定可能
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
            commonModule.KeyIDKeyPress(sender, txbWaIDsub);
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


        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbWaID);
            //メイン側のテキストボックスと連動
        }

        //名前欄があるもののみ
        private void txbPrID_TextChanged(object sender, EventArgs e)
        {
            productDataAccess.GetProductNameData(sender, lblPrName);
            warehousingDetailDataAccess.GetWaQuantityData(sender, lblWaQuantityValue);
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




        //サイズ_ナンバー_グリッドビュー_テーブル_ソート情報
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Warehousing), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Warehousing), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Warehousing), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Warehousing), btnSort);
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(WarehousingDetail), btnDetailSort);
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(WarehousingDetail), btnDetailSort);
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(WarehousingDetail), btnDetailSort);
        }
        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(WarehousingDetail), btnDetailSort);
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
        {
            //全てのテキストボックスを空白にする
            txbWaID.Text = String.Empty;
            txbHaID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
            //↑メイン↓詳細のテキストボックス、DTPの初期化(IDsubは勝手に初期化される)
            txbWaDetailID.Text = String.Empty;
            txbPrID.Text = String.Empty;
            txbQuantity.Text = String.Empty;
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

            T_Warehousing selectCondition = new T_Warehousing()
            {
                WaID = 0,
                HaID = 0,
                EmID = 0,
                WaDate = null,
                WaFlag = Flag,
                WaShelfFlag = StateFlag,
                WaHidden = null
            };

            Warehousing = warehousingDataAccess.GetWarehousingData(selectCondition, 0);
            WarehousingDetail = warehousingDetailDataAccess.GetWarehousingDetailData();
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
            if (cbxLink.Checked)
            {
                GenerateDetailLinkData();
                //↑リンク用検索メソッド
                SetDetailDataGridView();
            }
            //リンクしている場合、IDで詳細検索した結果を渡す。
        }


        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime? date = null;

            if (!int.TryParse(txbWaID.Text, out int waID))
                waID = 0;
            if (!int.TryParse(txbHaID.Text, out int haID))
                haID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;

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


            T_Warehousing selectCondition = new T_Warehousing()
            {//検索に使用するデータ
                WaID = waID,
                HaID = haID,
                EmID = emID,
                WaDate = date,
                WaFlag = Flag,
                WaShelfFlag = StateFlag
            };
            //入庫データの抽出
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Warehousing = warehousingDataAccess.GetWarehousingData(selectCondition, dateCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Warehousing.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Warehousing.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Warehousing.Count / (double)pageSize)) + "ページ";
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updWa = GenerateDataAtUpdate();
            UpdateWarehousing(updWa);
        }


        private T_Warehousing GenerateDataAtUpdate()
        {
            return new T_Warehousing
            {
                WaID = int.Parse(txbWaID.Text.Trim()),
                HaID = 0,
                EmID = 0,
                WaDate = null,
                WaShelfFlag = 0,
                WaFlag = 2,
                WaHidden = txbHidden.Text
            };
        }

        private void UpdateWarehousing(T_Warehousing updWa)
        {
            DialogResult result = messageDsp.MsgDspQ("M2001", lblWaID, txbWaID);
            //●●ID:00を非表示にしますか？
            if (result != DialogResult.OK)
                return;

            bool flg = warehousingDataAccess.UpdateWarehousingData(updWa);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M2002", lblWaID, txbWaID);
                //●●ID:00を非表示にしました。
            }
            else
            {
                messageDsp.MsgDsp("M2003", lblWaID, txbWaID);
                //●●ID:00の非表示に失敗しました。
                return;
            }


            ClearInput();
            txbWaID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var updWa = GenerateDataAtConfirm();
            ConfirmWarehousing(updWa);
        }

        private T_Warehousing GenerateDataAtConfirm()
        {

            return new T_Warehousing
            {
                WaID = int.Parse(txbWaID.Text),
                HaID = 0,
                EmID = int.Parse(lblLoginIDData.Text),
                WaDate = DateTime.Now,
                WaShelfFlag = 1,
                WaFlag = 0,
                WaHidden = null
            };
            //確定は　ID ログインID 現在時刻 StateFlag=1
        }
        private void ConfirmWarehousing(T_Warehousing updWa)
        {
            DialogResult result = messageDsp.MsgDspQ("M3001", lblWaID, txbWaID);
            //●●ID:00の処理を確定しますか？
            if (result != DialogResult.OK)
                return;


            bool flg = warehousingDetailDataAccess.ConfirmWarehousingDetailToStock(int.Parse(txbWaID.Text))&& warehousingDataAccess.UpdateWarehousingData(updWa);
            if (flg)
            {
             
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnConfirm.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M3002", lblWaID, txbWaID);
                //●●ID:00の処理を確定しました。
            }
            else
            {
                messageDsp.MsgDsp("M3003", lblWaID, txbWaID);
                //●●ID:00の確定に失敗しました。
                return;
            }

            ClearInput();
            txbWaID.Focus();
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
            if (!int.TryParse(txbWaDetailID.Text, out int waDetailID))
                waDetailID = 0;
            if (!int.TryParse(txbWaIDsub.Text, out int waID))
                waID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbQuantity.Text, out int waQuantity))
                waQuantity = 0;

            T_WarehousingDetail selectCondition = new T_WarehousingDetail()
            {
                WaDetailID = waDetailID,
                WaID = waID,
                PrID = prID,
                WaQuantity = waQuantity,
            };
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            //検索条件を取り出す
            WarehousingDetail = warehousingDetailDataAccess.GetWarehousingDetailData(selectCondition, quantityCondition);
        }

        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = WarehousingDetail.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = WarehousingDetail.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(WarehousingDetail.Count / (double)pageSize)) + "ページ";
        }
    }
}
