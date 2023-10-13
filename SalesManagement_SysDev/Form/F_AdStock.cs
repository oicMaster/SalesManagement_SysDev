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
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //dataグリッドビュー用のテーブルデータインスタンス化
        private static List<T_Stock> Stock;
        
        
        public F_AdStock()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
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
            dataGridViewDsp.DataSource = Stock.Skip(pageSize *pazeNo).Take(pageSize).ToList();
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            lblPage.Text = "/" + ((int)Math.Ceiling(Stock.Count / (double)pageSize)) + "ページ";
            dataGridViewDsp.Refresh();
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
            if (!String.IsNullOrEmpty(txbStID.Text.Trim()))
            {
                if(!dataInputFormCheck.CheckHalfAlphabetNumeric(txbStID.Text.Trim()))
                {
                    messageDsp.DspMsg("");//半角チェック
                    txbStID.Focus();
                    return false;
                }
                if (txbStID.TextLength > 6)//文字数7文字以上
                {
                    messageDsp.DspMsg("");
                    txbStID.Focus();
                    return false;
                }
            }
            return false;
            
        }
        private void GenerateDataAtSelect()
        {
            T_Stock selectCondition = new T_Stock()
            {
                StID = int.Parse(txbStID.Text.Trim()),

            };
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text);

            dataGridViewDsp.DataSource = Stock;

            lblPage.Text ="/"+((int)Math.Ceiling(Stock.Count/(double)pageSize))+"ページ";
        }
    }
}
