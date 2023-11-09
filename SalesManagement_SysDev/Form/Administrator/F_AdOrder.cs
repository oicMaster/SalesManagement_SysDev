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
    public partial class F_AdOrder : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<T_Order> Order;
        private static List<T_OrderDetail> OrderDetail;

        public F_AdOrder()
        {
            InitializeComponent();
        }
        private void F_Order_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            
            txbOrFlag.ReadOnly = true;
            txbOrStateFlag.ReadOnly = true;
        }
        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = false;
                    btnConfirm.Enabled = false;
                    break;
                case 1:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = true;
                    btnConfirm.Enabled = true;
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
            Order = orderDataAccess.GetOrderData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Order.Skip(pageSize * pageNo).Take(pageSize).ToList();

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

            dataGridViewDsp.Columns[0].HeaderText = "受注ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "顧客担当者名";
            dataGridViewDsp.Columns[5].HeaderText = "受注年月日";
            dataGridViewDsp.Columns[6].HeaderText = "受注状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "受注管理フラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";



            lblPage.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbClCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbOrDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbOrStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbOrFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbOrHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbOrHidden.Text = String.Empty;
        }

        private void SetFormDataGridViewSub()
        {
            txbPageSizeSub.Text = "5";
            txbPageNoSub.Text = "1";
            dataGridViewSubDsp.ReadOnly = true;
            dataGridViewSubDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridViewSub();
        }
        private void GetDataGridViewSub()
        {
            //OrderDetail = orderDetailDataAccess.GetOrderDetailData();

            SetDataGridViewSub();
        }


        private void SetDataGridViewSub()
        {
            int pageSize = int.Parse(txbPageSizeSub.Text);
            int pageNo = int.Parse(txbPageNoSub.Text) - 1;
            dataGridViewSubDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewSubDsp.Columns[0].Width = 100;
            dataGridViewSubDsp.Columns[1].Width = 100;
            dataGridViewSubDsp.Columns[2].Width = 100;
            dataGridViewSubDsp.Columns[3].Width = 100;


            dataGridViewSubDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSubDsp.Columns[0].HeaderText = "受注詳細ID";
            dataGridViewSubDsp.Columns[1].HeaderText = "受注ID";
            dataGridViewSubDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewSubDsp.Columns[3].HeaderText = "数量";


            dataGridViewSubDsp.Columns[4].Visible = false;
            dataGridViewSubDsp.Columns[5].Visible = false;

            lblPageSub.Text = "/" + ((int)Math.Ceiling(OrderDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewSubDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPageSize.Text.Trim()))
            {
                if (int.Parse(txbPageSize.Text) > 10)
                {
                    messageDsp.MsgDsp("");
                    txbPageSize.Text = "10";
                    return;
                }
                if (int.Parse(txbPageSize.Text) == 0)
                {
                    messageDsp.MsgDsp("");
                    txbPageSize.Text = "1";
                    return;
                }
            }
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPageNo.Text.Trim()))
            {
                if (int.Parse(txbPageNo.Text) == 0)
                {
                    messageDsp.MsgDsp("");
                    txbPageNo.Text = "1";
                }
            }
        }

        private void txbOrID_TextChanged(object sender, EventArgs e)
        {//IDが入力されているかどうか
            if (txbOrID.Text == "" || txbOrID.Text == null)
            {
                fncButtonEnable(0);              
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);              
                txbOrFlag.Text = "0";
            }

        }
        private void txbOrHidden_TextChanged(object sender, EventArgs e)
        {
            if (txbOrHidden.Text == "" || txbOrHidden.Text == null)
                txbOrFlag.Text = "0";
            else
                txbOrFlag.Text = "2";
        }
        // private void txbPage_KeyPress
        // private void txbQuntity_KeyPress

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Order.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Order.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbPageNo.Text = (pageNo + 1).ToString();
            else
                txbPageNo.Text = "1";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(Order.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Order.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Order.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Order.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Order.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            txbOrID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbClCharge.Text = String.Empty;
            txbOrDate.Text = String.Empty;
            txbOrStateFlag.Text = String.Empty;
            txbOrFlag.Text = String.Empty;
            txbOrHidden.Text = String.Empty;
        }



        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void lblLoginName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //妥当なOrデータを取得
            if (!GetValidDataAtSelect())
                return;
            //Or情報抽出
            GenereteDataAdSelect();
            //Or情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()
        {
            //空白でないか確認
            if (!String.IsNullOrEmpty(txbOrID.Text.Trim()))
            {
                //数値かどうか確認
                if (!dataInputFormCheck.CheckNumeric(txbOrID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbOrID.Focus();
                    return false;
                }
                //6文字以内か確認
                if (txbOrID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbOrID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbOrID.Focus();
                return false;
            }
            return true;
        }

        private void GenereteDataAdSelect()
        {
            T_Order selectCondition = new T_Order()
            {//検索に使用するデータ
                OrID = int.Parse(txbOrID.Text.Trim()),
            };
            //orデータの抽出
            orderDataAccess.GetOrderData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Order;

            lblPage.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {

        }
        private void GetValidDataAtRegistration()
        {

        }
        private void GenerateDataAdRegistration()
        {

        }
        private void RegistrationOrder()
        {

        }
       

        

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
      

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {

        }
        private void GetValidDetailDataAtSelect(object sender, EventArgs e)
        {

        }
        private void GenerateDetailDataAdSelect(object sender, EventArgs e)
        {

        }
        private void SetSelectDetailData(object sender, EventArgs e)
        {

        }

        private void btnDetailRegist_Click(object sender, EventArgs e)
        {

        }
        private void GetValidDataAtRegistration(object sender, EventArgs e)
        {

        }
        private void GenerateDataAdRegistration(object sender, EventArgs e)
        {

        }
        private void RegistrationOrder(object sender, EventArgs e)
        {

        }
    }
}

