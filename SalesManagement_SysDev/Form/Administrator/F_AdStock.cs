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
    public partial class F_AdStock : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        //メッセージの表示用のクラスのインスタンス化
        StockDataAccess stockDataAccess = new StockDataAccess();
        //データベーステーブル用のインスタンス化
        CommonModule dataInputFormCheck = new CommonModule();
        //dataグリッドビュー用のテーブルデータインスタンス化
        private static List<T_Stock> Stock;
        
        
        public F_AdStock()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtUpdate())
                return;

            var updSt = GenerateDataAtUpdate();

            UpdateStock(updSt);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!stockDataAccess.CheckStIDExistence(int.Parse(txbStID.Text.Trim())))//要確認
            {
                messageDsp.MsgDsp("");
                txbStID.Focus();
                return false;
            }
            //※
            return false;
        }
        private T_Stock GenerateDataAtUpdate()
        {
            return new T_Stock
            {
                StID = int.Parse(txbStID.Text.Trim()),
                PrID = int.Parse(txbPrID.Text.Trim()),
                StQuantity = int.Parse(txbStQuantity.Text),
                StFlag = int.Parse(txbStFlag.Text.Trim())//要確認
            };
        }

        private void UpdateStock(T_Stock updSt)
        {
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            //更新
            bool flg = stockDataAccess.UpdateStockData(updSt);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbPrID.Focus();

            // 入力のクリア
                            //要確認

            // データグリッドビューの表示
            GetDataGridView();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void SetFormDataGridView()
        {
            txbPageSize.Text = "10";
            txbPageNo.Text = "1";
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridView();
        }
        private void GetDataGridView()
        {
            Stock = stockDataAccess.GetStockData();

            SetDataGridView();
        }
       
        
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pazeNo=int.Parse(txbPageNo.Text)-1;
            dataGridViewDsp.DataSource = Stock.Skip(pageSize * pazeNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewDsp.Columns[0].HeaderText = "在庫ID";
            dataGridViewDsp.Columns[1].HeaderText = "商品ID";
            dataGridViewDsp.Columns[2].HeaderText = "在庫数";
            dataGridViewDsp.Columns[3].HeaderText = "在庫管理フラグ";
            

            lblPage.Text = "/" + ((int)Math.Ceiling(Stock.Count / (double)pageSize)) + "ページ";
            dataGridViewDsp.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenerateDataAtSelect();

            SetSelectData();

        }
        private void GenerateDataAtSelect()
        {
            if (!int.TryParse(txbStID.Text, out int stID))
                stID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbStQuantity.Text, out int stQuantity))
                stQuantity = 0;

            T_Stock selectCondition = new T_Stock()
            {
                StID = stID,
                PrID = prID,
                StQuantity = stQuantity,
            };
            Stock = stockDataAccess.GetStockData(selectCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text);

            dataGridViewDsp.DataSource = Stock;

            lblPage.Text = "/" + ((int)Math.Ceiling(Stock.Count / (double)pageSize)) + "ページ";
        }
    }
}
