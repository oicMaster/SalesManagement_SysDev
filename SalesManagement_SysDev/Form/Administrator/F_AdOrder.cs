using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        CommonModule commonModule = new CommonModule();
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();



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

            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;
            dataGridViewDsp.Columns[15].Visible = false;
            dataGridViewDsp.Columns[16].Visible = false;

            lblPageNo.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbCharge.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
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
            txbDetailPageSize.Text = "5";
            txbDetailPageNo.Text = "1";
            dataGridViewDetailDsp.ReadOnly = true;
            dataGridViewDetailDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetailDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewDetailDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDetailDsp.Columns[0].Width = 100;
            dataGridViewDetailDsp.Columns[1].Width = 100;
            dataGridViewDetailDsp.Columns[2].Width = 100;
            dataGridViewDetailDsp.Columns[3].Width = 100;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "受注詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "受注ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(OrderDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbOrDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbOrIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }


        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > 10)
                {
                    (sender as TextBox).Text = "10";
                    return;
                }
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                    return;
                }
            }
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
            {
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                }
            }
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
            txbOrIDsub.Text = txbOrID.Text;
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
                txbFlag.Text = "0";
            else
                txbFlag.Text = "2";
        }

        //メイングリッドビュー,サブグリッドビューで使用する主キーのテキストボックスの文字を連動させる。
        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            txbOrID.Text = txbOrIDsub.Text;
        }

        //PageSize,Noのテキストボックスに連結させる。
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //IDがつく全てのテキストボックスに連結させる。
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length < 6)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if ((sender as TextBox).Text.Length == 6)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //数量or個数のテキストボックスに連結させる。
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (this.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //↓入力上限がある全てのデータに設定する。

        private void txbCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length <  50)
            {
                    e.Handled = true;
            }
            else if ((sender as TextBox).Text.Length == 50)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }


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

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            dataGridViewDetailDsp.DataSource = OrderDetail.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = "1";
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 2;
            dataGridViewDetailDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbDetailPageNo.Text = (pageNo + 1).ToString();
            else
                txbDetailPageNo.Text = "1";
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(OrderDetail.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDetailDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(OrderDetail.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbDetailPageNo.Text = lastPage.ToString();
            else
                txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(OrderDetail.Count / (double)pageSize) - 1;
            dataGridViewDetailDsp.DataSource = OrderDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = (pageNo + 1).ToString();
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
            //Or情報抽出
            GenereteDataAdSelect();
            //Or情報抽出結果
            SetSelectData();
        }

        private void GenereteDataAdSelect()
        {
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            T_Order selectCondition = new T_Order()
            {//検索に使用するデータ
                OrID = orID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
            };
            //orデータの抽出
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            orderDataAccess.GetOrderData(selectCondition,dateCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Order;

            lblPageNo.Text = "/" + ((int)Math.Ceiling(Order.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            //妥当な顧客情報取得
            if (!GetValidDataAtRegistration())
                return;
            //顧客情報作成
            var regOrder = GenereteDataAdRegistration();

            //顧客情報登録
            RegistrationOrder(regOrder);
        }
        private bool GetValidDataAtRegistration()
        {
            if (orderDataAccess.CheckOrIDExistence(int.Parse(txbOrID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbOrID.Focus();
                return false;
            }
            if (salesOfficeDataAccess.CheckSoIDExistence(int.Parse(txbSoID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (employeeDataAccess.CheckEmIDExistence(int.Parse(txbEmID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbEmID.Focus();
                return false;
            }
            if (clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            return true;
        }
        private T_Order GenereteDataAdRegistration()
        {
            string hidden = txbHidden.Text;
            return new T_Order
            {
                OrID =int.Parse(txbOrID.Text),
                SoID = int.Parse(txbSoID.Text),
                EmID = int.Parse(txbEmID.Text),
                ClID = int.Parse(txbClID.Text),
                OrDate = DateTime.Now,
                OrStateFlag = int.Parse(txbFlag.Text),
                OrFlag = int.Parse(txbFlag.Text),
                OrHidden = hidden,
            };
            
        }
        private void RegistrationOrder(T_Order regOrder)
        {
            // 登録確認メッセージ
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の登録
            bool flg = orderDataAccess.AddOrderData(regOrder);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbClID.Focus();

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updOr = GenerateDataAtUpdate();

            //顧客情報更新
            UpdateOrder(updOr);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!orderDataAccess.CheckOrIDExistence(int.Parse(txbOrID.Text)))
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            return true;
        }

        private T_Order GenerateDataAtUpdate()
        {
            return new T_Order
            {
                OrID = int.Parse(txbClID.Text.Trim()),
                OrFlag = 2,
                OrHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateOrder(T_Order updOr)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = orderDataAccess.UpdateOrderData(updOr);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbOrID.Focus();

            GetDataGridView();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }


        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenerateDetailDataAdSelect();
            //Or情報抽出結果
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
            
            //検索に使用するデータ
            T_OrderDetail selectCondition = new T_OrderDetail()
            {//検索に使用するデータ　全て変数で行う
                OrDetailID = orDetailID,
                OrID = orID,
                PrID = prID,               
            };
            //orデータの抽出
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            int totalPriceCondition = commonModule.ComboBoxCondition(cmbTotalPrice.Text);
            OrderDetail = orderDetailDataAccess.GetOrderDetailData(selectCondition,quantityCondition,totalPriceCondition);
        }
        private void SetSelectDetailData()
        {
            //ページ数の表示
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            dataGridViewDetailDsp.DataSource = OrderDetail;
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(OrderDetail.Count / (double)pageSize)) + "ページ";
        }

        private void btnDetailRegist_Click(object sender, EventArgs e)
        {
            
        }
        private void GetValidDetailDataAtRegistration()
        {
            
        }
        private void GenerateDetailDataAdRegistration()
        {

        }
        private void RegistrationOrderDetail()
        {

        }

    }
}

