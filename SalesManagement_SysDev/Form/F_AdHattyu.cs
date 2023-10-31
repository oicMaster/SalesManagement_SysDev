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
    public partial class F_AdHattyu : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        HattyuDataAccess hattyuDataAccess = new HattyuDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<T_Hattyu> Hattyu;
        public F_AdHattyu()
        {
            InitializeComponent();
        }
        private void F_Hattyu_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            fncTextBoxReadOnly(0);
            txbHaFlag.ReadOnly = true;
            txbWaWereHouseFlag.ReadOnly = true;
        }
        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = false;
                    btnConfirm.Enabled = false;
                    break;
                case 1:
                    btnSearch.Enabled = true;
                    btnRegist.Enabled = true;
                    btnConfirm.Enabled = true;
                    break;
            }
        }

        private void fncTextBoxReadOnly(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、テキストボックスの入力を制限する
                case 0:
                    txbMaID.ReadOnly = true;
                    txbEmID.ReadOnly = true;
                    txbHaDate.ReadOnly = true;
                    txbHaHidden.ReadOnly = true;
                    break;
                case 1:
                    txbMaID.ReadOnly = false;
                    txbEmID.ReadOnly = false;
                    txbHaDate.ReadOnly = false;
                    txbHaHidden.ReadOnly = false;
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


            lblPage.Text = "/" + ((int)Math.Ceiling(Hattyu.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbHaDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbWaWereHouseFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbHaFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value != null)
                txbHaHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            else
                txbHaHidden.Text = String.Empty;
        }

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
        private void txbHaID_TextChanged(object sender, EventArgs e)
        {//顧客IDが入力されているかどうか
            if (txbHaID.Text == "" || txbHaID.Text == null)
            {
                fncButtonEnable(0);
                fncTextBoxReadOnly(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                fncTextBoxReadOnly(1);
                txbHaFlag.Text = "0";
            }

        }
        private void txbHaHidden_TextChanged(object sender, EventArgs e)
        {
            if (txbHaHidden.Text == "" || txbHaHidden.Text == null)
                txbHaFlag.Text = "0";
            else
                txbHaFlag.Text = "2";
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//テキストボックスを空にする
            txbHaID.Text = String.Empty;
            txbMaID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbHaDate.Text = String.Empty;
            txbWaWereHouseFlag.Text = String.Empty;
            txbHaFlag.Text = String.Empty;
            txbHaHidden.Text = String.Empty;
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
            //妥当なHaデータを取得
            if (!GetValidDataAtSelect())
                return;
            //Ha情報抽出
            GenereteDataAdSelect();
            //Ha情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()
        {
            //空白でないか確認
            if (!String.IsNullOrEmpty(txbHaID.Text.Trim()))
            {
                //数値かどうか確認？？
                if (!dataInputFormCheck.CheckNumeric(txbHaID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbHaID.Focus();
                    return false;
                }
                //6文字以内か確認
                if (txbHaID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbHaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbHaID.Focus();
                return false;
            }
            return true;
        }

        private void GenereteDataAdSelect()
        {
            T_Hattyu selectCondition = new T_Hattyu()
            {//検索に使用するデータ
                HaID = int.Parse(txbHaID.Text.Trim()),
            };
            //顧客データの抽出
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
            if (!String.IsNullOrEmpty(txbHaID.Text.Trim()))
            {
                if (!hattyuDataAccess.CheckHaIDExistence(int.Parse(txbHaID.Text.Trim())))
                {
                    messageDsp.MsgDsp("");
                    txbHaID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbHaID.Focus();
                return false;
            }

            //ここ


            if (!String.IsNullOrEmpty(txbHaHidden.Text.Trim()))
            {//登録の時は非表示理由を必ず空白にしたい
                messageDsp.MsgDsp("");
                txbHaHidden.Focus();
                return false;
            }
            return true;
        }
        private T_Hattyu GenereteDataAdRegistration()
        {
            return new　T_Hattyu
            {
                //▼全部
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }

}
