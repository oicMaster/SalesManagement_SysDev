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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    public partial class F_AdChumon : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ChumonDataAccess chumonDataAccess = new ChumonDataAccess();
        ChumonDetailDataAccess chumonDetailDataAccess = new ChumonDetailDataAccess();
        SalesOfficeDataAccess salesOfficeIDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeelDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        CommonModule commonModule = new CommonModule();

        private static List<T_Chumon> Chumon;
        private static List<T_ChumonDetail> ChumonDetail;

        public F_AdChumon()
        {
            InitializeComponent();
        }
        private void F_Chumon_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            txbFlag.ReadOnly = true;
            txbStateFlag.ReadOnly = true;

            //※
        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnConfirm.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                case 1:
                    btnConfirm.Enabled = true;
                    break;
                //非表示理由とIDが入力されているか
                case 2:
                    btnUpdate.Enabled = true;
                    break;

            }
        }

        private void SetFormDataGridView()
        {
            txbPageSize.Text = "10";
            txbPageNo.Text = "1";
            dataGridViewDsp.ReadOnly = true;
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Chumon = chumonDataAccess.GetChumonData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Chumon.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;


            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "注文ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "受付ID";
            dataGridViewDsp.Columns[5].HeaderText = "注文年月日";
            dataGridViewDsp.Columns[6].HeaderText = "注文状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "注文管理グラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";

            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;

            lblPage.Text = "/" + ((int)Math.Ceiling(Chumon.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbChID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value != null)
                txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            //Date
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbHidden.Text = String.Empty;

        }

        private void SetFormDetailDataGridView()
        {
            txbDetailPageSize.Text = "5";
            txbDetailPageNo.Text = "1";
            dataGridViewDetailDsp.ReadOnly = true;
            dataGridViewDetailDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetailDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            ChumonDetail = chumonDetailDataAccess.GetChumonDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            dataGridViewDetailDsp.DataSource = ChumonDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDetailDsp.Columns[0].Width = 100;
            dataGridViewDetailDsp.Columns[1].Width = 100;
            dataGridViewDetailDsp.Columns[2].Width = 100;
            dataGridViewDetailDsp.Columns[3].Width = 100;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "注文詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "注文ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPage.Text = "/" + ((int)Math.Ceiling(ChumonDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbChDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbChIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }


        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize);
            SetDataGridView();
        }

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize);
            SetDataGridView();
        }
        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 10);
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
        }

        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                txbFlag.Text = "0";
                txbStateFlag.Text = "0";
            }
            commonModule.KeyIDKeyPress(sender, txbChDetailID);
        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbChID);
        }

        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.PageKeyPress(e);
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 4);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Chumon));
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Chumon));
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Chumon));
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Chumon));
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ChumonDetail));
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ChumonDetail));
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ChumonDetail));
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ChumonDetail));
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbChID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            txbDate.Text = String.Empty;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ch情報抽出
            GenereteDataAdSelect();
            //ch情報抽出結果
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            if (!int.TryParse(txbChID.Text, out int chID))
                chID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            T_Chumon selectCondition = new T_Chumon()
            {//検索に使用するデータ
                ChID = chID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                OrID = orID
            };
            //chデータの抽出
            Chumon = chumonDataAccess.GetChumonData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Chumon;

            lblPage.Text = "/" + ((int)Math.Ceiling(Chumon.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updCh = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateArrival(updCh);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!chumonDataAccess.CheckChIDExistence(int.Parse(txbChID.Text)))
            {
                messageDsp.MsgDsp("");
                txbChID.Focus();
                return false;
            }
            if (!salesOfficeIDataAccess.CheckSoIDExistence(int.Parse(txbSoID.Text)))
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (!employeelDataAccess.CheckEmIDExistence(int.Parse(txbEmID.Text)))
            {
                messageDsp.MsgDsp("");
                txbEmID.Focus();
                return false;
            }
            if (!clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text)))
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            if (!orderDataAccess.CheckOrIDExistence(int.Parse(txbOrID.Text)))
            {
                messageDsp.MsgDsp("");
                txbOrID.Focus();
                return false;
            }
            return true;
        }

        private T_Chumon GenerateDataAtUpdate()
        {
            return new T_Chumon
            {
                ChID = int.Parse(txbClID.Text.Trim()),
                ChFlag = 2,
                ChHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateArrival(T_Chumon updCh)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = chumonDataAccess.UpdateChumonData(updCh);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbChID.Focus();

            GetDataGridView();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenereteDetailDataAdSelect();
            SetSelectDetailData();
        }

        private void GenereteDetailDataAdSelect()
        {
            if (!int.TryParse(txbChDetailID.Text, out int chDetailID))
                chDetailID = 0;
            if (!int.TryParse(txbChIDsub.Text, out int chID))
                chID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            //検索に使用するデータ
            T_ChumonDetail selectCondition = new T_ChumonDetail()
            {//検索に使用するデータ　全て変数で行う
                ChDetailID = chDetailID,
                ChID = chID,
                PrID = prID,
            };
            //arデータの抽出
            ChumonDetail = chumonDetailDataAccess.GetChumonDetailData(selectCondition);
        }
        private void SetSelectDetailData()
        {//ページ数の表示
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            dataGridViewDetailDsp.DataSource = ChumonDetail;
            lblDetailPage.Text = "/" + ((int)Math.Ceiling(ChumonDetail.Count / (double)pageSize)) + "ページ";
        }
    
    }
}
