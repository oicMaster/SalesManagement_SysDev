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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagement_SysDev
{
    public partial class F_AdSale : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        SaleDataAccess saleDataAccess = new SaleDataAccess();
        SaleDetailDataAccess saleDetailDataAccess = new SaleDetailDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<T_Sale> Sale;
        private static List<T_SaleDetail> SaleDetail;

        public F_AdSale()
        {
            InitializeComponent();
        }
        private void F_Sale_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                case 0:
                    btnSearch.Enabled = true;
                    break;
                case 1:
                    btnSearch.Enabled = true;
                    break;
            }
        }

        private void fncTextBoxReadOnry(int chk)
        {
            switch (chk)
            { //顧客IDが空であれば0、でなければ1として、テキストボックスの入力を制限する
                case 0:
                    txbSoID.ReadOnly = true;
                    txbSaID.ReadOnly = true;
                    txbEmID.ReadOnly = true;
                    txbSaHidden.ReadOnly = true;
                    txbSaDate.ReadOnly = true;
                    txbSaDetailID.ReadOnly = true;
                    txbPrID.ReadOnly = true;
                    txbSaFlag.ReadOnly = true;
                    txbSaHidden.ReadOnly = true;
                    break;
                case 1:
                    txbSoID.ReadOnly = false;
                    txbSaID.ReadOnly = false;
                    txbEmID.ReadOnly = false;
                    txbSaHidden.ReadOnly = false;
                    txbSaDate.ReadOnly = false;
                    txbSaDetailID.ReadOnly = false;
                    txbPrID.ReadOnly = false;
                    txbSaHidden.ReadOnly = false;
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
            Sale = saleDataAccess.GetSaleData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Sale.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;


            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "売上ID";
            dataGridViewDsp.Columns[1].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[2].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[3].HeaderText = "社員ID";
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].HeaderText = "売上日時";
            dataGridViewDsp.Columns[6].HeaderText = "非表示理由";
            dataGridViewDsp.Columns[7].HeaderText = "売上管理フラグ";




            lblPage.Text = "/" + ((int)Math.Ceiling(Sale.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbSaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbChID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbSaDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbSaFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value != null)
                txbSaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            else
                txbSaHidden.Text = String.Empty;
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
            //SaleDetail = saleDetailDataAccess.GetArrivalDetailData();

            SetDataGridViewSub();
        }


        private void SetDataGridViewSub()
        {
            int pageSize = int.Parse(txbPageSizeSub.Text);
            int pageNo = int.Parse(txbPageNoSub.Text) - 1;
            dataGridViewSubDsp.DataSource = SaleDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewSubDsp.Columns[0].Width = 100;
            dataGridViewSubDsp.Columns[1].Width = 100;
            dataGridViewSubDsp.Columns[2].Width = 100;
            dataGridViewSubDsp.Columns[3].Width = 100;
            dataGridViewSubDsp.Columns[4].Width = 100;


            dataGridViewSubDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSubDsp.Columns[0].HeaderText = "売上詳細ID";
            dataGridViewSubDsp.Columns[1].HeaderText = "売上ID";
            dataGridViewSubDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewSubDsp.Columns[3].HeaderText = "個数";
            dataGridViewSubDsp.Columns[4].HeaderText = "合計金額";

            dataGridViewSubDsp.Columns[4].Visible = false;
            dataGridViewSubDsp.Columns[5].Visible = false;

            lblPageSub.Text = "/" + ((int)Math.Ceiling(SaleDetail.Count / (double)pageSize)) + "ページ";

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
        private void txbSaID_TextChanged(object sender, EventArgs e)
        {//顧客IDが入力が入力されているかどうか
            if (txbSaID.Text == "" || txbSaID.Text == null)
            {
                fncButtonEnable(0);
                fncTextBoxReadOnry(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                fncTextBoxReadOnry(1);
                txbSaFlag.Text = "0";
            }

        }

        private void txbSaHidden_TextChanged(object sender, EventArgs e) //10/31 千田　hiddinになってる直さなきゃダメ
        {
            if (txbSaHidden.Text == "" || txbSaHidden.Text == null)
                txbSaFlag.Text = "0";
            else
                txbSaFlag.Text = "2";
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  if ((sender as TextBox).Text.Length < 6)
            //{
              //  if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
             //       e.Handled = true;
            //}
            //else if ((sender as TextBox).Text.Length == 6)
            //{
              //  if (e.KeyChar != '\b')
              //      e.Handled = true;
            //}
        }


        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbSaQuantity.Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (txbSaQuantity.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Sale.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Sale.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Sale.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Sale.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Sale.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Sale.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Sale.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
        {//テキストボックスを空にする
            txbSoID.Text = string.Empty;
            txbSaID.Text = string.Empty;
            txbEmID.Text = string.Empty;
            txbSaHidden.Text = string.Empty;
            txbSaDate.Text = string.Empty;
            txbSaDetailID.Text = string.Empty;
            txbPrID.Text = string.Empty;
            txbSaFlag.Text = string.Empty;
            txbSaHidden.Text = string.Empty;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
        private void labelLoginName_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //妥当なSaデータを取得
            if (!GetValidDataAtSelect())
                return;
            //Sa情報抽出
            GenereteDataAdSelect();
            //Sa情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()//検索
        {
            //空白でないか確認
            if (String.IsNullOrEmpty(txbSaID.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbSaID.Focus();
                return false;
            }
            return true;
        }

        private void GenereteDataAdSelect()
        {
            T_Sale selectCondition = new T_Sale()
            {//検索に使用するデータ
                SaID = int.Parse(txbSaID.Text.Trim()),
            };
            //顧客データの抽出
            Sale = saleDataAccess.GetSaleData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Sale;

            lblPage.Text = "/" + ((int)Math.Ceiling(Sale.Count / (double)pageSize)) + "ページ";
        }
       

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            if (!GetValidDetailDataAtSelect())
                return;
            GenerateDetailDataAdSelect();
            //Sa情報抽出結果
            SetSelectDetailData();
        }
        private bool GetValidDetailDataAtSelect()
        {
            return true;
        }
        private void GenerateDetailDataAdSelect()
        {
            if (!int.TryParse(txbSaDetailID.Text, out int saDetailID))
                saDetailID = 0;
            if (!int.TryParse(txbSaID.Text, out int saID))
                saID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            //検索に使用するデータ
            T_SaleDetail selectCondition = new T_SaleDetail()
            {//検索に使用するデータ　全て変数で行う
                SaDetailID = saDetailID,
                SaID = saID,
                PrID = prID,
            };
            //saデータの抽出
            SaleDetail = saleDetailDataAccess.GetSaleDetailData(selectCondition);
        }
        private void SetSelectDetailData()
        
        {
                //ページ数の表示
                txbPageNoSub.Text = "1";
                int pageSize = int.Parse(txbPageSizeSub.Text.Trim());
                dataGridViewSubDsp.DataSource = SaleDetail;
                lblPageSub.Text = "/" + ((int)Math.Ceiling(SaleDetail.Count / (double)pageSize)) + "ページ";
        }
    }
}


       