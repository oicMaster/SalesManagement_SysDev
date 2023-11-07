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
        SalesOfficeDataAccess salesOfficeIDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeelDataAccess = new EmployeeDataAccess();
        OrderDataAccess orderDataAccess = new OrderDataAccess();




        private static List<T_Arrival> Arrival;

        public F_AdArrival()
        {
            InitializeComponent();
        }

        private void F_Arrival_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            txbArFlag.ReadOnly = true;
            txbArStateFlag.ReadOnly = true;

            //コード追加部分
            txbArID.TabIndex = 0;
            txbSoID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            txbClID.TabIndex = 3;
            txbOrID.TabIndex = 4;
            txbArDate.TabIndex = 5;
            txbArHidden.TabIndex = 6;
            btnSearch.TabIndex = 7;
            btnUpdate.TabIndex = 8;
            btnDisplay.TabIndex = 9;
            btnConfirm.TabIndex = 10;
            btnClear.TabIndex = 11;
            txbArDetailID.TabIndex = 12;
            txbArIDsub.TabIndex = 13;
            txbPrID.TabIndex = 14;
            txbArQuantity.TabIndex = 15;
            btnDetailSearch.TabIndex = 16;
            txbPageSize.TabIndex = 17;
            txbPageNo.TabIndex = 18;
            btnFirstPage.TabIndex = 19;
            btnPreviousPage.TabIndex = 20;
            btnNextPage.TabIndex = 21;
            btnLastPage.TabIndex = 22;
            btnClose.TabIndex = 23;
            txbArFlag.TabStop = false;
            txbArStateFlag.TabStop = false;
            dataGridViewDsp.TabStop = false;
            dataGridViewMiniDsp.TabStop = false;

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnSearch.Enabled = true;
                    btnConfirm.Enabled = false;
                    break;
                case 1:
                    btnSearch.Enabled = true;
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
            Arrival = arrivalDataAccess.GetArrivalData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

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

            dataGridViewDsp.Columns[0].HeaderText = "入荷ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "受付ID";
            dataGridViewDsp.Columns[5].HeaderText = "入荷年月日";
            dataGridViewDsp.Columns[6].HeaderText = "入荷状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "入荷管理グラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";


            lblPage.Text = "/" + ((int)Math.Ceiling(Arrival.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }


        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbArID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value != null)
                txbArHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value != null)
                txbArHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            else
                txbArDate.Text = String.Empty;
            txbArStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbArFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbArHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbArHidden.Text = String.Empty;
        }
    

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPageSize.Text.Trim()))
            {
                if (int.Parse(txbPageSize.Text) > 10)
                {
                    txbPageSize.Text = "10";
                    return;
                }
                if (int.Parse(txbPageSize.Text) == 0)
                {
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
                    txbPageNo.Text = "1";
                }
            }
        }

        private void txbArID_TextChanged(object sender, EventArgs e)
        {//IDが入力されているかどうか
            if (String.IsNullOrEmpty(txbArID.Text.Trim()))
            {
                fncButtonEnable(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                txbArFlag.Text = "0";
                txbArStateFlag.Text = "0";
            }
            txbArIDsub.Text = txbArID.Text;
        }
        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
                (sender as TextBox).Text = "0";
            else
                (sender as TextBox).Text = "2";
        }
        private void txbArIDsub_TextChanged(object sender, EventArgs e)
        {
            txbArID.Text = txbArIDsub.Text;
        }


        //コード変更部分
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((sender as TextBox).Text.Length < 6)
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
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbArQuantity.Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (txbArQuantity.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Arrival.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Arrival.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Arrival.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Arrival.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            txbArID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            txbArDate.Text = String.Empty;
            txbArStateFlag.Text = String.Empty;
            txbArFlag.Text = String.Empty;
            txbArHidden.Text = String.Empty;
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
            //データ取得
            if (!GetValidDataAtSelect())
                return;
            //Ar情報
            GenereteDataAdSelect();
            //Ar情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()
        {
            //空白がないか
            if (String.IsNullOrEmpty(txbArID.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbArID.Focus();
                return false;
            }
            return true;
        }
        private void GenereteDataAdSelect()
        {
            if (int.TryParse(txbArID.Text, out var arID))
                arID = int.Parse(txbSoID.Text);
            else
                arID = "";
            int soID = int.Parse(txbSoID.Text);
            int emID = int.Parse(txbEmID.Text);
            int clID = int.Parse(txbClID.Text);
            int orID = int.Parse(txbOrID.Text);
            DateTime arDate = DateTime.Parse(txbArDate.Text.Trim());
            string arHidden = txbArHidden.Text;
            //検索に使用するデータ
            T_Arrival selectCondition = new T_Arrival()
            {//検索に使用するデータ
                ArID = arID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                OrID = orID,
                ArDate = arDate,
                ArHidden = arHidden
        };
            //arデータの抽出
            Arrival = arrivalDataAccess.GetArrivalData(selectCondition);

        }
        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Arrival;
            lblPage.Text = "/" + ((int)Math.Ceiling(Arrival.Count / (double)pageSize)) + "ページ";
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {


        }
    }
}
