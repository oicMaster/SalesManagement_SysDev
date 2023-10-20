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
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<T_Syukko> Syukko;
        public F_AdSyukko()
        {
            InitializeComponent();
        }
        private void F_Syukko_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            //fncButtonEnable(0);
            //fncTextBoxReadOnly(0);
            //txbClFlag.ReadOnly = true;
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
            txbSyFinishDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbSyFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbSyHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbSyHidden.Text = String.Empty;
        }



        private void label6_Click(object sender, EventArgs e)
        {

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
            if (!String.IsNullOrEmpty(txbSyID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(txbSyID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbSyID.Focus();
                    return false;
                }
                if(txbSyID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbSyID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbSyID.Focus();
                return false;
            }
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
