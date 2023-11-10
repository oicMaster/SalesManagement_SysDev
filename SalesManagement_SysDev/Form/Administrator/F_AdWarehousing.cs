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

        private void F_Warehousing_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            GetDataGridView();
            SetDataGridView();
            SetFormDataGridViewSub();
            SetDataGridViewSub();
        }
        private void SetFormDataGridView()
        {
            //データグリッドビューのページサイズの設定
            txbPageSize.Text = "10";
            //データグリッドビューのページ番号の設定
            txbPageNo.Text = "1";
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //行をクリックで選択出来る
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダーの位置
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //データグリッドビューのデータ取得
            GetDataGridView();
        }
        private void GetDataGridView()
        {
            Warehousing = warehousingDataAccess.GetWarehousingData();
            //データグリッドビューに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Warehousing.Skip(pageSize * pageNo).Take(pageSize).ToList();
            //列幅の指定
            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;

            //列の文字の位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "入庫ID";
            dataGridViewDsp.Columns[1].HeaderText = "発注ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "入庫年月日";
            dataGridViewDsp.Columns[4].HeaderText = "入庫済フラグ（棚）";
            dataGridViewDsp.Columns[5].HeaderText = "非表示理由";
            dataGridViewDsp.Columns[6].HeaderText = "入庫管理フラグ";


            //データグリッドビューの総ページ数
            lblPage.Text = "/" + ((int)Math.Ceiling(Warehousing.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックした行のデータをテキストボックスへ
            txbWaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbWaDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbWaStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbWaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbWaFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value != null)
                txbWaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            else
                txbWaHidden.Text = String.Empty;
        }
        private void SetFormDataGridViewSub()
        {
            txbPageSizeSub.Text = "5";
            txbPageNoSub.Text = "1";
            dataGridViewSubDsp.ReadOnly = true;
            dataGridViewSubDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDataGridViewMini();
        }
        private void GetDataGridViewMini()
        {
            //WarehousingDetail = werehousingDetailDataAccess.GetWarehousingDetailData();

            SetDataGridView();
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
            dataGridViewSubDsp.Columns[1].HeaderText = "入庫";
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

        //txbPageSize_TextChanged()
        //{}

        //txbPageNo_TextChanged()
        //{}

        //txbID_KeyPress()
        //{}上限値のあるテキストボックスだけ

        //txb▼_KeyPress()
        //{}                 

        //txbPage_KeyPress()
        //{}

        //txbQuntity_KeyPress()
        //{} 

        //btnFirstPage_Click()
        //{}

        //btnPreviousPage_Click()
        //{}

        //btnNextPage_Click()
        //{}

        //btnLastPage_Click()
        //{}

        //btnClear_Click()
        //{}

        //ClearInput()
        //{}

        //btnDisplay_Click()
        //{}

        //lblLoginName_Click()
        //{}

        //btnClose_Click()
        //{}


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtSelect())
                return;
            //入庫情報抽出
            GenereteDataAdSelect();
            //入庫情報抽出結果
            SetSelectData();
        }
        private bool GetValidDataAtSelect()
        {

            return true;
        }
        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Warehousing;

            lblPage.Text = "/" + ((int)Math.Ceiling(Warehousing.Count / (double)pageSize)) + "ページ";
        }
        private void GenereteDataAdSelect()
        {
            T_Warehousing selectCondition = new T_Warehousing()
            {//検索に使用するデータ
                WaID = int.Parse(txbWaID.Text.Trim()),
            };
            //入庫データの抽出
            Warehousing = warehousingDataAccess.GetWarehousingData(selectCondition);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
