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
    public partial class F_AdSyukko : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        SyukkoDataAccess syukkoDataAccess = new SyukkoDataAccess();
        SyukkoDetailDataAccess syukkoDetailDataAccess = new SyukkoDetailDataAccess();

        private static List<T_Syukko> Syukko;
        private static List<T_SyukkoDetail> SyukkoDetail;
        public F_AdSyukko()
        {
            InitializeComponent();
        }
        private void F_Syukko_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            GetDataGridView();
            SetDataGridView();
            SetFormDataGridViewSub();
            SetDataGridViewSub();
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
            Syukko = syukkoDataAccess.GetSyukkoData();
            //データグリッドビューに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Syukko.Skip(pageSize * pageNo).Take(pageSize).ToList();
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

            dataGridViewDsp.Columns[0].HeaderText = "商品ID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカID";
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[4].HeaderText = "JANコード";
            dataGridViewDsp.Columns[5].HeaderText = "安全在庫数";
            dataGridViewDsp.Columns[6].HeaderText = "小分類ID";
            dataGridViewDsp.Columns[7].HeaderText = "型番";
            dataGridViewDsp.Columns[8].HeaderText = "色";

            //データグリッドビューの総ページ数
            lblPage.Text = "/" + ((int)Math.Ceiling(Syukko.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックした行のデータをテキストボックスへ
            txbSyID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbSyStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbSyDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbSyFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbSyHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbSyHidden.Text = String.Empty;
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
            //SyukkoDetail = SyukkoDetailDataAccess.GetArrivalDetailData();

            SetDataGridViewSub();
        }


        private void SetDataGridViewSub()
        {
            int pageSize = int.Parse(txbPageSizeSub.Text);
            int pageNo = int.Parse(txbPageNoSub.Text) - 1;
            dataGridViewSubDsp.DataSource = SyukkoDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewSubDsp.Columns[0].Width = 100;
            dataGridViewSubDsp.Columns[1].Width = 100;
            dataGridViewSubDsp.Columns[2].Width = 100;
            dataGridViewSubDsp.Columns[3].Width = 100;


            dataGridViewSubDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSubDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSubDsp.Columns[0].HeaderText = "出庫詳細ID";
            dataGridViewSubDsp.Columns[1].HeaderText = "出庫ID";
            dataGridViewSubDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewSubDsp.Columns[3].HeaderText = "数量";

            dataGridViewSubDsp.Columns[4].Visible = false;
            dataGridViewSubDsp.Columns[5].Visible = false;

            lblPageSub.Text = "/" + ((int)Math.Ceiling(SyukkoDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewSubDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //txbPageSize_TextChanged()
        //{}
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

        //txbPageNo_TextChanged()
        //{}
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

        //txbID_KeyPress()
        //{}上限値のあるテキストボックスだけ
        private void txbArID_TextChanged()//(object , EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSyID.Text.Trim()))
            {
                fncButtonEnable(0);
               // ClearInput();
               //↑クリアボタンつけ忘れ
            }
            else
            {
                fncButtonEnable(1);
                txbSyFlag.Text = "0";
                txbSyStateFlag.Text = "0";
            }
            txbSyIDSub.Text = txbSyID.Text;
        }//マスター系は理由がなければ非表示にできない

        //txb▼_KeyPress()
        //{}                 
        private void txbSyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //txbPage_KeyPress()
        //{}
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //txbQuntity_KeyPress()
        //{} 
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbSyQuantity.Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (txbSyQuantity.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //btnFirstPage_Click()
        //{}
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Syukko.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        //btnPreviousPage_Click()
        //{}
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Syukko.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbPageNo.Text = (pageNo + 1).ToString();
            else
                txbPageNo.Text = "1";
        }

        //btnNextPage_Click()
        //{}
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(Syukko.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Syukko.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Syukko.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        //btnLastPage_Click()
        //{}
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Syukko.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Syukko.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }
        //btnClear_Click()
        //{}
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbSyID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            txbSyDate.Text = String.Empty;
            txbSyStateFlag.Text = String.Empty;
            txbSyHidden.Text = String.Empty;
        }
        //ClearInput()
        //{}
        private void btnClear_Click()//(object sender, EventArgs e)
        {
            ClearInput();
        }
        

        //btnDisplay_Click()
        //{}
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        //lblLoginName_Click()
        //{}
        private void lblLoginName_Click(object sender, EventArgs e)
        {

        }

        //btnClose_Click()
        //{}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtSelect())
                return;
            //出庫情報抽出
            GenereteDataAdSelect();
            //出庫情報抽出結果
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
            dataGridViewDsp.DataSource = Syukko;

            lblPage.Text = "/" + ((int)Math.Ceiling(Syukko.Count / (double)pageSize)) + "ページ";
        }
        private void GenereteDataAdSelect()
        {
            T_Syukko selectCondition = new T_Syukko()
            {//検索に使用するデータ
                SyID = int.Parse(txbSyID.Text.Trim()),
            };
            //出庫データの抽出
            Syukko = syukkoDataAccess.GetSyukkoData(selectCondition);
        }

    }
}
