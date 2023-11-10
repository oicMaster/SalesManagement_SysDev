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
    public partial class F_AdWarehousing : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        WarehousingDetailDataAccess werehousingDetailDataAccess = new WarehousingDetailDataAccess();


        private static List<T_Warehousing> Warehousing;
        private static List<T_WarehousingDetail> WarehousingDetail;
        
        public F_AdWarehousing()
        {
            InitializeComponent();
        }

        private void SetFormDataGridViewSub()
        {
            txbPageSizeSub.Text = "5";
            txbPageNoSub.Text = "1";
            dataGridViewSubDsp.ReadOnly = true;
            dataGridViewSubDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridViewmini();
        }
        private void GetDataGridViewmini()
        {
            //WarehousingDetail = werehousingDetailDataAccess.GetWarehousingDetailData();

            SetDataGridViewSub();
        }


        private void SetDataGridViewSub()
        {
            int pageSize = int.Parse(txbPageSizeSub.Text);
            int pageNo = int.Parse(txbPageNoSub.Text) - 1;
            dataGridViewSubDsp.DataSource = WarehousingDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewSubDsp.Columns[0].Width = 100;
            dataGridViewSubDsp.Columns[1].Width = 100;
            dataGridViewSubDsp.Columns[2].Width = 100;
            dataGridViewSubDsp.Columns[3].Width = 100;


            dataGridViewSubDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSubDsp.Columns[0].HeaderText = "入庫詳細ID";
            dataGridViewSubDsp.Columns[1].HeaderText = "入庫ID";
            dataGridViewSubDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewSubDsp.Columns[3].HeaderText = "数量";


            dataGridViewSubDsp.Columns[4].Visible = false;
            dataGridViewSubDsp.Columns[5].Visible = false;

            lblPageSub.Text = "/" + ((int)Math.Ceiling(WarehousingDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewSubDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
