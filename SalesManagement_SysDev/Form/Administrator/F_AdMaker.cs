using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesManagement_SysDev
{
    public partial class F_AdMaker : Form
    {
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Maker> Maker;
        MessageDsp messageDsp = new MessageDsp();
        public F_AdMaker()
        {
            InitializeComponent();
        }

        private void F_Maker_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();

            fncButtonEnable(0);
            txbFlag.ReadOnly = true;


            //コード追加部分
            //※

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            { //IDが空であれば0、でなければ1として、ボタンの使用を制限する
                case 0:

                    btnUpdate.Enabled = false;
                    break;
                case 1:

                    break;
                //非表示理由とIDが入力されているか
                case 2:
                    btnUpdate.Enabled = true;
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
            //Maker = makerDataAccess.GetMakerData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Maker.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 120;
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[2].Width = 150;
            dataGridViewDsp.Columns[3].Width = 340;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 120;
            dataGridViewDsp.Columns[6].Width = 140;
            dataGridViewDsp.Columns[7].Width = 550;



            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewDsp.Columns[0].HeaderText = "メーカID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカ名";
            dataGridViewDsp.Columns[2].HeaderText = "住所";
            dataGridViewDsp.Columns[3].HeaderText = "電話番号";
            dataGridViewDsp.Columns[4].HeaderText = "郵便番号";
            dataGridViewDsp.Columns[5].HeaderText = "FAX";
            dataGridViewDsp.Columns[6].HeaderText = "メーカ管理フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "非表示理由";



            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;

            lblPage.Text = "/" + ((int)Math.Ceiling(Maker.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();      
            txbName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbPostal.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbFAX.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            else
                txbHidden.Text = String.Empty;
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

            }

        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
                txbFlag.Text = "0";
            else
                txbFlag.Text = "2";
        }

        //メイングリッドビュー,サブグリッドビューで使用する主キーのテキストボックスの文字を連動させる。

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
            if ((sender as TextBox).Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (this.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //↓入力上限がある全てのデータに設定する。
        //private void txb~~~~~_KeyPress(object sender, KeyPressEventArgs e)



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Maker.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Maker.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Maker.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Maker.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Maker.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Maker.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Maker.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
        {//全てのテキストボックスを空白にする
            txbMaID.Text = String.Empty;
            txbName.Text = String.Empty;
            txbAddress.Text = String.Empty;
            txbPhone.Text = String.Empty;
            txbPostal.Text = String.Empty;
            txbFAX.Text = String.Empty;
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
            //メーカ情報抽出
            GenereteDataAdSelect();
            //メーカ情報抽出結果
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;          
            string maName = txbName.Text.Trim();
            string maAddress = txbAddress.Text.Trim();
            string maPhone = txbPhone.Text.Trim();
            string maPostal = txbPostal.Text.Trim();
            string maFAX = txbFAX.Text.Trim();


            M_Maker selectCondition = new M_Maker()
            {//検索に使用するデータ
                MaID = maID,
                MaName = maName,
                MaAddress = maAddress,
                MaPhone = maPhone,
                MaPostal = maPostal,
                MaFAX = maFAX,

            };
            //メーカデータの抽出
            Maker = makerDataAccess.GetMakerData(selectCondition);
        }

        private void SetSelectData()
        {//ページ数の表示
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Maker;
            lblPage.Text = "/" + ((int)Math.Ceiling(Maker.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            //妥当なメーカ情報取得
            if (!GetValidDataAtRegistration())
                return;
            //メーカ情報作成
            var regMaker = GenereteDataAdRegistration();

            //メーカ情報登録
            RegistrationClient(regMaker);
        }
        private bool GetValidDataAtRegistration()
        {
            if (!makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text)))
            {
                messageDsp.MsgDsp("");
                txbMaID.Focus();

                return false;
            }
            
           
            return true;
        }
        private M_Maker GenereteDataAdRegistration()
        {
            string hidden = txbHidden.Text;
            return new M_Maker
            {

                MaID = int.Parse(txbMaID.Text),               
                MaName = txbName.Text,
                MaAddress = txbName.Text,
                MaPhone = txbPhone.Text,
                MaPostal = txbPostal.Text,
                MaFAX = txbFAX.Text,
                MaFlag = int.Parse(txbFlag.Text),
                MaHidden = hidden,
            };
        }

        private void RegistrationClient(M_Maker regMaker)
        {
            // 登録確認メッセージ
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の登録
            bool flg = makerDataAccess.AddMakerData(regMaker);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbMaID.Focus();

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {          
            if (!GetValidDataAtUpdate())
                return;      
            var updMa = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ         
            UpdateMaker(updMa);
        }
        private bool GetValidDataAtUpdate()
        {
            if (!makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbMaID.Focus();
                return false;
            }
            return true;
        }

        private M_Maker GenerateDataAtUpdate()
        {
            string hidden = txbHidden.Text;
            return new M_Maker
            {
                MaID = int.Parse(txbMaID.Text),
                MaName = txbName.Text,
                MaAddress = txbName.Text,
                MaPhone = txbPhone.Text,
                MaPostal = txbPostal.Text,
                MaFAX = txbFAX.Text,
                MaFlag = int.Parse(txbFlag.Text),
                MaHidden = hidden,
            };
        }


        private void UpdateMaker(M_Maker updMa)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = makerDataAccess.UpdateMakerData(updMa);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbMaID.Focus();

            GetDataGridView();
        }
    }
}
