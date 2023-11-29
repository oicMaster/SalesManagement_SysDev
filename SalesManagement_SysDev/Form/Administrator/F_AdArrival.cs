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
    public partial class F_AdArrival : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();
        ArrivalDetailDataAccess arrivalDetailDataAccess = new ArrivalDetailDataAccess();
        SalesOfficeDataAccess salesOfficeIDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeelDataAccess = new EmployeeDataAccess();
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        CommonModule commonModule = new CommonModule();

        private static List<T_Arrival> Arrival = new List<T_Arrival>();
        private static List<T_ArrivalDetail> ArrivalDetail;

        public F_AdArrival()
        {
            InitializeComponent();
        }

        private void F_Arrival_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            txbFlag.ReadOnly = true;
            txbStateFlag.ReadOnly = true;

            //コード追加部分
            txbArID.TabIndex = 0;
            txbSoID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            txbClID.TabIndex = 3;
            txbOrID.TabIndex = 4;
            txbDate.TabIndex = 5;
            txbHidden.TabIndex = 6;
            btnSearch.TabIndex = 7;
            btnHidden.TabIndex = 8;
            btnDisplay.TabIndex = 9;
            btnConfirm.TabIndex = 10;
            btnClear.TabIndex = 11;
            txbArDetailID.TabIndex = 12;
            txbArIDsub.TabIndex = 13;
            txbPrID.TabIndex = 14;
            txbQuantity.TabIndex = 15;
            btnDetailSearch.TabIndex = 16;
            txbPageSize.TabIndex = 17;
            txbPageNo.TabIndex = 18;
            btnFirstPage.TabIndex = 19;
            btnPreviousPage.TabIndex = 20;
            btnNextPage.TabIndex = 21;
            btnLastPage.TabIndex = 22;
            btnClose.TabIndex = 23;
            txbFlag.TabStop = false;
            txbStateFlag.TabStop = false;
            dataGridViewDsp.TabStop = false;
            dataGridViewDetailDsp.TabStop = false;

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnConfirm.Enabled = false;
                    btnHidden.Enabled = false;
                    break;
                case 1:
                    btnConfirm.Enabled = true;
                    break;
                //非表示理由とIDが入力されているか
                case 2:
                    btnHidden.Enabled = true;
                    break;

            }
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageNo, txbPageSize, dataGridViewDsp);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Arrival = arrivalDataAccess.GetArrivalData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();
            lblPage.Text = "/" + ((int)Math.Ceiling(Arrival.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Columns[0].Width = 120;
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[2].Width = 150;
            dataGridViewDsp.Columns[3].Width = 340;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 120;
            dataGridViewDsp.Columns[6].Width = 140;
            dataGridViewDsp.Columns[7].Width = 160;
            dataGridViewDsp.Columns[8].Width = 550;


            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "入荷ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "受付ID";
            dataGridViewDsp.Columns[5].HeaderText = "入荷年月日";
            dataGridViewDsp.Columns[6].HeaderText = "入荷状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "入荷管理グラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";


            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value != null)
                txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            //※
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbHidden.Text = String.Empty;
        }

        private void SetFormDetailDataGridView()
        {
            commonModule.SetFormDataGridView(txbDetailPageNo, txbDetailPageSize, dataGridViewDetailDsp);
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            ArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            commonModule.SetDataGridView(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, lblDetailPage, new List<object>(ArrivalDetail));

            dataGridViewDetailDsp.Columns[0].Width = 100;
            dataGridViewDetailDsp.Columns[1].Width = 100;
            dataGridViewDetailDsp.Columns[2].Width = 100;
            dataGridViewDetailDsp.Columns[3].Width = 100;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "入荷詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "入荷ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbArDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbArIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }


        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender);
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
            commonModule.KeyIDKeyPress(sender, txbArDetailID);
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            commonModule.HiddenTextChanged(sender,txbFlag);
        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbArID);
        }

        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.PageKeyPress(e);
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender,e,6);
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender,e,4);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Arrival));
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Arrival));
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize,txbPageNo, dataGridViewDsp, new List<object>(Arrival));
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Arrival));
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ArrivalDetail));
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ArrivalDetail));
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ArrivalDetail));
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ArrivalDetail));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbArID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
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
            GenereteDataAdSelect();
            //Ar情報抽出結果
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            //文字列型以外はif文を付ける　FlagとHiddenはいらない
            if (!int.TryParse(txbArID.Text, out int arID))
                arID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            //検索に使用するデータ
            T_Arrival selectCondition = new T_Arrival()
            {//検索に使用するデータ　全て変数で行う
                ArID = arID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                OrID = orID
            };
            //arデータの抽出
            Arrival = arrivalDataAccess.GetArrivalData(selectCondition);

        }
        private void SetSelectData()
        {
            commonModule.SetSelectData(txbPageNo, txbPageSize, dataGridViewDsp,lblPage,new List<object>(ArrivalDetail));
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updAr = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateArrival(updAr);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!arrivalDataAccess.CheckArIDExistence(int.Parse(txbArID.Text)))
            {
                messageDsp.MsgDsp("");
                txbArID.Focus();
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

        private T_Arrival GenerateDataAtUpdate()
        {
            return new T_Arrival
            {
                ArID = int.Parse(txbClID.Text),
                //足りない
                ArHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateArrival(T_Arrival updAr)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = arrivalDataAccess.UpdateArrivalData(updAr);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbArID.Focus();

            GetDataGridView();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenerateDetailDataAdSelect();
            //Ar情報抽出結果
            SetSelectDetailData();
        }

        private void GenerateDetailDataAdSelect()
        {
            if (!int.TryParse(txbArDetailID.Text, out int arDetailID))
                arDetailID = 0;
            if (!int.TryParse(txbArIDsub.Text, out int arID))
                arID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            //検索に使用するデータ
            T_ArrivalDetail selectCondition = new T_ArrivalDetail()
            {//検索に使用するデータ　全て変数で行う
                ArDetailID = arDetailID,
                ArID = arID,
                PrID = prID,
            };
            //arデータの抽出
            ArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailData(selectCondition);
        }
        private void SetSelectDetailData()
        {//ページ数の表示
            commonModule.SetSelectData(txbDetailPageNo, txbDetailPageSize, dataGridViewDetailDsp, lblDetailPage, new List<object>(ArrivalDetail));
        }
    }
}
