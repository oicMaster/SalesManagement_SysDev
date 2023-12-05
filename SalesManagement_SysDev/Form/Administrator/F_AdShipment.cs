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
    public partial class F_AdShipment : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ShipmentDataAccess shipmentDataAccess = new ShipmentDataAccess();
        ShipmentDetailDataAccess shipmentDetailDataAccess = new ShipmentDetailDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        CommonModule commonModule = new CommonModule();

        private static List<T_Shipment> Shipment;
        private static List<T_ShipmentDetail> ShipmentDetail;

        public F_AdShipment()
        {
            InitializeComponent();
        }

        private void F_Shipment_Load(object sender, EventArgs e)
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
            Shipment = shipmentDataAccess.GetShipmentData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Shipment.Skip(pageSize * pageNo).Take(pageSize).ToList();
            //列幅の指定
            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;
            //列の文字の位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "出荷ID";
            dataGridViewDsp.Columns[1].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].HeaderText = "出荷状態フラグ";
            dataGridViewDsp.Columns[6].HeaderText = "出荷完了年月日";
            dataGridViewDsp.Columns[7].HeaderText = "出荷管理フラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";

            
            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            

            //データグリッドビューの総ページ数
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Shipment.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbShID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[6].Value.ToString();
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
            ShipmentDetail = shipmentDetailDataAccess.GetShipmentDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            dataGridViewDetailDsp.DataSource = ShipmentDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDetailDsp.Columns[0].Width = 100;
            dataGridViewDetailDsp.Columns[1].Width = 100;
            dataGridViewDetailDsp.Columns[2].Width = 100;
            dataGridViewDetailDsp.Columns[3].Width = 100;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "出荷詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "出荷ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbShDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbShIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
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
            }
            txbShIDsub.Text = txbShID.Text;
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
            txbShID.Text = txbShIDsub.Text;
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
        //private void txb~~~~~_KeyPress(object sender, KeyPressEventArgs e)



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Shipment.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Shipment.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Shipment.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Shipment.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Shipment.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Shipment.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Shipment.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            dataGridViewDetailDsp.DataSource = ShipmentDetail.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = "1";
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 2;
            dataGridViewDetailDsp.DataSource = ShipmentDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDetailDsp.DataSource = ShipmentDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbDetailPageNo.Text = lastPage.ToString();
            else
                txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize) - 1;
            dataGridViewDetailDsp.DataSource = ShipmentDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            txbShID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            txbStateFlag.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
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
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            //文字列型以外はif文を付ける　FlagとHiddenはいらない
            if (!int.TryParse(txbShID.Text, out int shID))
                shID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;            
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;
            T_Shipment selectCondition = new T_Shipment()
            {
                ShID = shID,
                ClID = clID,
                EmID = emID,
                SoID = soID,               
                OrID = orID,
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Shipment = shipmentDataAccess.GetShipmentData(selectCondition,dateCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Shipment;

            lblPageNo.Text = "/" + ((int)Math.Ceiling(Shipment.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updSh = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateShipment(updSh);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!shipmentDataAccess.CheckShIDExistence(int.Parse(txbShID.Text)))
            {
                messageDsp.MsgDsp("");
                txbShID.Focus();
                return false;
            }
            return true;
        }

        private T_Shipment GenerateDataAtUpdate()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbClID.Text.Trim()),
                ShFlag = 2,
                ShHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateShipment(T_Shipment updSh)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = shipmentDataAccess.UpdateShipmentData(updSh);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbShID.Focus();

            GetDataGridView();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
