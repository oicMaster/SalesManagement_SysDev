using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SalesManagement_SysDev
{
    public partial class F_AdClient : Form
    {
        //他クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<M_Client> Client;

        public F_AdClient()
        {
            InitializeComponent();
        }

        private void F_Client_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            txbClFlag.ReadOnly = true;
        }
        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //顧客IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:
                    btnRegist.Enabled = true;
                    btnSearch.Enabled = true;
                    btnUpdate.Enabled = false;
                    break;
                case 1:
                    btnRegist.Enabled = false;
                    btnSearch.Enabled = true;
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
            //顧客データの取得
            Client = clientDataAccess.GetClientData();
            //データグリッドビューに表示するデータを指定
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Client.Skip(pageSize * pageNo).Take(pageSize).ToList();
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

            dataGridViewDsp.Columns[0].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "顧客名";
            dataGridViewDsp.Columns[3].HeaderText = "住所";
            dataGridViewDsp.Columns[4].HeaderText = "電話番号";
            dataGridViewDsp.Columns[5].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[6].HeaderText = "FAX";
            dataGridViewDsp.Columns[7].HeaderText = "顧客管理グラフ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";


            //データグリッドビューの総ページ数
            lblPage.Text = "/" + ((int)Math.Ceiling(Client.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }
        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックした行のデータをテキストボックスへ
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbClName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbClAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbClPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbClPostal.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbClFAX.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbClFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbClHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbClHidden.Text = String.Empty;
        }

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPageSize.Text.Trim()))
            {
                if (int.Parse(txbPageSize.Text) == 0)
                    txbPageSize.Text = "1";
                if (int.Parse(txbPageSize.Text) > 10)
                    txbPageSize.Text = "10";
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

        private void txbClID_TextChanged(object sender, EventArgs e)
        {//顧客IDが入力されているかどうか
            if (txbClID.Text == "" || txbClID.Text == null)
            {
                fncButtonEnable(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                txbClFlag.Text = "0";
            }

        }
        private void txbClHidden_TextChanged(object sender, EventArgs e)
        {
            if (txbClHidden.Text == "" || txbClHidden.Text == null)
                txbClFlag.Text = "0";
            else
                txbClFlag.Text = "2";
        }

        private void txbID_KeyPress()
        {

        }

        //txb▼_KeyPress

        private void txbPage_KeyPress()
        {

        }

        private void txbQuntity_KeyPress()
        {

        }








        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Client.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Client.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Client.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Client.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Client.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Client.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Client.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
        {//テキストボックスを空にする
            txbClID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbClName.Text = String.Empty;
            txbClAddress.Text = String.Empty;
            txbClPhone.Text = String.Empty;
            txbClPostal.Text = String.Empty;
            txbClFAX.Text = String.Empty;
            txbClFlag.Text = String.Empty;
            txbClHidden.Text = String.Empty;
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
            //妥当な顧客データを取得
            if (!GetValidDataAtSelect())
                return;
            //顧客情報抽出
            GenereteDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()
        {
            return true;
        }

        private void GenereteDataAdSelect()
        {
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if(!int.TryParse(txbSoID.Text,out int soID))
                soID = 0;
            string clName = txbClName.Text.Trim();
            string clAddress = txbClAddress.Text.Trim();
            string clPhone = txbClPhone.Text.Trim();
            string clPostal = txbClPostal.Text.Trim();
            string clFAX = txbClFAX.Text.Trim();

            M_Client selectCondition = new M_Client()
            {//検索に使用するデータ
                ClID = clID,
                SoID = soID,
                ClName = clName,
                ClAddress = clAddress,
                ClPhone = clPhone,
                ClPostal = clPostal,
                ClFAX = clFAX,

            };
            //顧客データの抽出
            Client = clientDataAccess.GetClientData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Client;
            lblPage.Text = "/" + ((int)Math.Ceiling(Client.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            //妥当な顧客情報取得
            if (!GetValidDataAtRegistration())
                return;
            //顧客情報作成
            var regClient = GenereteDataAdRegistration();

            //顧客情報登録
            RegistrationClient(regClient);
        }

        private bool GetValidDataAtRegistration()
        {
            if (!String.IsNullOrEmpty(txbSoID.Text.Trim()))
            {
                //▼外部キー認証
                //DBACCESSを一番上に追加して、主キーの存在有無を確認する
            }
            else
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClName.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClAddress.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClAddress.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClPhone.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClPhone.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClPostal.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClPostal.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClFAX.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClFAX.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbClFAX.Text.Trim()))
            {//登録の時は非表示理由を必ず空白にしたい
                messageDsp.MsgDsp("");
                txbClFAX.Focus();
                return false;
            }
            return true;
        }
        private M_Client GenereteDataAdRegistration()
        {
            return new M_Client
            {
                //▼全部
            };
        }

        private void RegistrationClient(M_Client regClient)
        {
            // 登録確認メッセージ
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の登録
            bool flg = clientDataAccess.AddClientData(regClient);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbClID.Focus();

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();
        }







        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updCl = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateClient(updCl);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!String.IsNullOrEmpty(txbClID.Text.Trim()))
            {
                if (!clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text.Trim())))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbSoID.Text.Trim()))
            {
                //▼外部キー認証
            }
            else
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClName.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClAddress.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClAddress.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClPhone.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClPhone.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClPostal.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClPostal.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbClFAX.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClFAX.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbClHidden.Text.Trim()))
            {//登録の時は非表示理由を必ず空白にしたい
                messageDsp.MsgDsp("");
                txbClHidden.Focus();
                return false;
            }
            return true;

        }

        private M_Client GenerateDataAtUpdate()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClID.Text.Trim()),
                SoID = int.Parse((txbSoID.Text.Trim())),
                ClName = txbClName.Text.Trim(),
                ClAddress = txbClAddress.Text.Trim(),
                ClPhone = txbClPhone.Text.Trim(),
                ClPostal = txbClPostal.Text.Trim(),
                ClFAX = txbClFAX.Text.Trim(),
                ClFlag = int.Parse(txbClFlag.Text),
                ClHidden = txbClHidden.Text.Trim(),
            };
        }


        private void UpdateClient(M_Client updCl)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = clientDataAccess.UpdateClientData(updCl);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbClID.Focus();

            GetDataGridView();
        }
     
    }
}
