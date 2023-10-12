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
            Product = productDataAccess.GetproductData();
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
            dataGridViewDsp.Columns[12].Width = 100;

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
            dataGridViewDsp.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            lblPage.Text ="/"+((int)Math.Ceiling(Product.Count/(double)pageSize))+"ページ";

            dataGridViewDsp.Refresh();

        }

        private bool GetValidDataAtSelect()
        {
            //商品ID入力時チェック
            if (!String.IsNullOrEmpty(txbPrID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(txbPrID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    txbPrID.Focus();
                    return false;
                }
                //商品IDの文字数チェック
                if (txbPrID.TextLength >= 6)
                {
                    //MessageBox.Show("商品IDは６文字までです");
                    messageDsp.DspMsg("");
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
                 PrID=int.Parse(txbPrID.Text.Trim()),
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtSelect())
                return;
            GenerateDataAtSelect();
            SetSelectData();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void F_AdProduct_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
    }
}
