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
    public partial class F_AdHattyu : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        HattyuDataAccess hattyuDataAccess = new HattyuDataAccess();
        HattyuDetailDataAccess hattyuDetailDataAccess = new HattyuDetailDataAccess();
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();

        private static List<T_Hattyu> Hattyu;
        private static List<T_HattyuDetail> HattyuDetail;

        //登録のボタンEnable条件がまだ

        public F_AdHattyu()
        {
            InitializeComponent();
        }
        private void F_Hattyu_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            txbFlag.ReadOnly = true;
            txbStateFlag.ReadOnly = true;

            //※

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnConfirm.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnRegist.Enabled = false;
                    break;
                case 1:
                    btnConfirm.Enabled = true;
                    break;
                //非表示理由とIDが入力されているか
                case 2:
                    btnUpdate.Enabled = true;
                    break;
                    //全部入力されているか
                case 3:
                    btnRegist.Enabled = true;
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
            Hattyu = hattyuDataAccess.GetHattyuData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Hattyu.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;



            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "受注ID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "発注年月日";
            dataGridViewDsp.Columns[4].HeaderText = "入庫済フラグ";
            dataGridViewDsp.Columns[5].HeaderText = "発注管理フラグ";
            dataGridViewDsp.Columns[6].HeaderText = "非表示理由";

            
            dataGridViewDsp.Columns[7].Visible = false;
            dataGridViewDsp.Columns[8].Visible = false;
            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            
            lblPage.Text = "/" + ((int)Math.Ceiling(Hattyu.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            //※
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            else
                txbHidden.Text = String.Empty;
        }

        private void SetFormDetailDataGridView()
        {
            txbDetailPageSize.Text = "5";
            txbDetailPageNo.Text = "1";
            dataGridViewDetailDsp.ReadOnly = true;
            dataGridViewDetailDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetailDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            dataGridViewDetailDsp.DataSource = HattyuDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDetailDsp.Columns[0].Width = 100;
            dataGridViewDetailDsp.Columns[1].Width = 100;
            dataGridViewDetailDsp.Columns[2].Width = 100;
            dataGridViewDetailDsp.Columns[3].Width = 100;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "発注詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "発注ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPage.Text = "/" + ((int)Math.Ceiling(HattyuDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbHaDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbHaIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }


        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > 10)
                {
                    (sender as TextBox).Text = "10";
                    return;
                }
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                    return;
                }
            }
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
            {
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                }
            }
        }

        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                txbFlag.Text = "0";
                txbStateFlag.Text = "0";
            }
            txbHaIDsub.Text = txbHaID.Text;
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
                txbFlag.Text = "0";
            else
                txbFlag.Text = "2";
        }

        //メイングリッドビュー,サブグリッドビューで使用する主キーのテキストボックスの文字を連動させる。
        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            txbHaID.Text = txbHaIDsub.Text;
        }

        //PageSize,Noのテキストボックスに連結させる。
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //IDがつく全てのテキストボックスに連結させる。
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length < 6)
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
        //数量or個数のテキストボックスに連結させる。
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //↓入力上限がある全てのデータに設定する。
        //private void txb~~~~~_KeyPress(object sender, KeyPressEventArgs e)



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Hattyu.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Hattyu.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Hattyu.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Hattyu.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Hattyu.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Hattyu.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Hattyu.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            dataGridViewDetailDsp.DataSource = HattyuDetail.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = "1";
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 2;
            dataGridViewDetailDsp.DataSource = HattyuDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbDetailPageNo.Text = (pageNo + 1).ToString();
            else
                txbDetailPageNo.Text = "1";
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(HattyuDetail.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDetailDsp.DataSource = HattyuDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(HattyuDetail.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbDetailPageNo.Text = lastPage.ToString();
            else
                txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(HattyuDetail.Count / (double)pageSize) - 1;
            dataGridViewDetailDsp.DataSource = HattyuDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbHaID.Text = String.Empty;
            txbMaID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbDate.Text = String.Empty;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }







        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Ha情報抽出
            GenerateDataAdSelect();
            //Ha情報抽出結果
            SetSelectData();
        }
        private void GenerateDataAdSelect()
        {
            
            //文字列型以外はif文を付ける　FlagとHiddenはいらない
            if (!int.TryParse(txbHaID.Text, out int haID))
                haID = 0;
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            
            
            //検索に使用するデータ
            T_Hattyu selectCondition = new T_Hattyu()
            {//検索に使用するデータ　全て変数で行う
                HaID = haID,
                MaID = maID,
                EmID = emID,
               
            };
            //arデータの抽出
            Hattyu = hattyuDataAccess.GetHattyuData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Hattyu;

            lblPage.Text = "/" + ((int)Math.Ceiling(Hattyu.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            //妥当な顧客情報取得
            if (!GetValidDataAtRegistration())
                return;
            //顧客情報作成
            var regHattyu = GenereteDataAdRegistration();

            //顧客情報登録
            RegistrationHattyu(regHattyu);
        }

        private bool GetValidDataAtRegistration()
        {
            return true;
        }
        private T_Hattyu GenereteDataAdRegistration()
        {
            string hidden = txbHidden.Text;
            return new　T_Hattyu
            {
                HaID =int.Parse(txbHaID.Text.Trim()),
                MaID =int.Parse(txbMaID.Text.Trim()),
                EmID =int.Parse(txbEmID.Text.Trim()),
                HaDate = DateTime.Parse(txbDate.Text.Trim()),
                HaFlag =int.Parse(txbFlag.Text.Trim()),
                HaHidden = hidden,
            };
        }

        private void RegistrationHattyu(T_Hattyu regHattyu)
        {
            // 登録確認メッセージ
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の登録
            bool flg = hattyuDataAccess.AddHattyuData(regHattyu);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbHaID.Focus();

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //顧客情報作成
            var updHa = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateHattyu(updHa);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!hattyuDataAccess.CheckHaIDExistence(int.Parse(txbHaID.Text)))
            {
                messageDsp.MsgDsp("");
                txbHaID.Focus();
                return false;
            }
            return true;
        }

        private T_Hattyu GenerateDataAtUpdate()
        {
            return new T_Hattyu
            {
                HaID = int.Parse(txbHaID.Text.Trim()),
                HaFlag = 2,
                HaHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateHattyu(T_Hattyu updHa)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = hattyuDataAccess.UpdateHattyuData(updHa);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbHaID.Focus();

            GetDataGridView();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenereteDetailDataAdSelect();
            //Ar情報抽出結果
            SetSelectDetailData();
        }

        private void GenereteDetailDataAdSelect()
        {
            if (!int.TryParse(txbHaDetailID.Text, out int haDetailID))
                haDetailID = 0;
            if (!int.TryParse(txbHaIDsub.Text, out int haID))
                haID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            //検索に使用するデータ
            T_HattyuDetail selectCondition = new T_HattyuDetail()
            {//検索に使用するデータ　全て変数で行う
                HaDetailID = haDetailID,
                HaID = haID,
                PrID = prID,
            };
            //arデータの抽出
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData(selectCondition);
        }
        private void SetSelectDetailData()
        {//ページ数の表示
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            dataGridViewDetailDsp.DataSource = HattyuDetail;
            lblDetailPage.Text = "/" + ((int)Math.Ceiling(HattyuDetail.Count / (double)pageSize)) + "ページ";
        }

        private void btnDetailRegist_Click(object sender, EventArgs e)
        {

        }
        private void GetValidDetailDataAtRegistration()
        {

        }
        private void GenerateDetailDataAdRegistration()
        {

        }
        private void RegistrationOrderDetail()
        {

        }

 
    }
}
