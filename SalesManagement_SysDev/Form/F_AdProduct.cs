using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SalesManagement_SysDev
{
    public partial class F_AdProduct : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<M_Product> Product;

        public F_AdProduct()
        {
            InitializeComponent();
        }

        private void F_AdProduct_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            fncTextBoxReadOnly(0);
            txbPrFlag.ReadOnly = true;
        }
        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                case 1:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void fncTextBoxReadOnly(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、テキストボックスの入力を制限する
                case 0:
                    txbMaID.ReadOnly = true;
                    txbPrName.ReadOnly = true;
                    txbPrice.ReadOnly = true;
                    txbPrSafetyStock.ReadOnly = true;
                    txbScID.ReadOnly = true;
                    txbPrModelNumber.ReadOnly = true;
                    txbPrColor.ReadOnly = true;
                    txbPrReleaseDate.ReadOnly = true;
                    txbPrHidden.ReadOnly = true;
                    break;
                case 1:
                    txbMaID.ReadOnly = false;
                    txbPrName.ReadOnly = false;
                    txbPrice.ReadOnly = false;
                    txbPrSafetyStock.ReadOnly = false;
                    txbScID.ReadOnly = false;
                    txbPrModelNumber.ReadOnly = false;
                    txbPrColor.ReadOnly = false;
                    txbPrReleaseDate.ReadOnly = false;
                    txbPrHidden.ReadOnly = false;
                    break;
            }
        }

        private void SetFormDataGridView()
        {
            txbPageSize.Text = "10";
            txbPageNo.Text = "1";
            dataGridViewDsp.ReadOnly=true;
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetDataGridView();
        }
        private void GetDataGridView()
        {
            Product = productDataAccess.GetProductData();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize =int.Parse(txbPageSize.Text);
            int pageNo=int.Parse(txbPageNo.Text);
            dataGridViewDsp.DataSource =Product.Skip(pageSize+pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;
            dataGridViewDsp.Columns[9].Width = 100;
            dataGridViewDsp.Columns[10].Width = 100;
            dataGridViewDsp.Columns[11].Width = 100;
            

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            

            lblPage.Text ="/"+((int)Math.Ceiling(Product.Count/(double)pageSize))+"ページ";

            dataGridViewDsp.Refresh();

        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbPrSafetyStock.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbScID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbPrModelNumber.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbPrColor.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            txbPrReleaseDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            txbPrFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value != null)
                txbPrHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value.ToString();
            else
                txbPrHidden.Text = String.Empty;
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

        private void txbPrID_TextChanged(object sender, EventArgs e)
        {//IDが入力されているかどうか
            if (txbPrID.Text == "" || txbPrID.Text == null)
            {
                fncButtonEnable(0);
                fncTextBoxReadOnly(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                fncTextBoxReadOnly(1);
                txbPrFlag.Text = "0";
            }

        }
        private void txbPrHidden_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbPageSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Product.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Product.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Product.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Product.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            txbMaID.Text = String.Empty;
            txbPrName.Text = String.Empty;
            txbPrice.Text = String.Empty;
            txbPrSafetyStock.Text = String.Empty;
            txbScID.Text = String.Empty;
            txbPrModelNumber.Text = String.Empty;
            txbPrColor.Text = String.Empty;
            txbPrReleaseDate.Text = String.Empty;
            txbPrFlag.Text = String.Empty;
            txbPrHidden.Text = String.Empty;
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
            if (!GetValidDataAtSelect())
                return;
            GenerateDataAtSelect();
            SetSelectData();
            
        }
        private bool GetValidDataAtSelect()
        {
            //商品ID入力時チェック
            if (!String.IsNullOrEmpty(txbPrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(txbPrID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbPrID.Focus();
                    return false;
                }
                //商品IDの文字数チェック
                if (txbPrID.TextLength >= 6)
                {
                    //MessageBox.Show("商品IDは６文字までです");
                    messageDsp.MsgDsp("");
                    txbPrID.Focus();
                    return false;
                }
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(txbPrID.Text.Trim()),
            };
            Product = productDataAccess.GetProductData(selectCondition);

        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Product;

            lblPage.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {

        }
    }
}
