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
        F_AdMenu AdMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Maker> Maker;
     

       

        public F_AdMaker(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "メーカ管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            txbName.MaxLength = 50;
            txbAddress.MaxLength = 50;
            txbPhone.MaxLength = 13;
            txbPostal.MaxLength = 7;
            txbFAX.MaxLength = 13;

            txbMaID.TabIndex = 0;
            txbName.TabIndex = 2;
            txbAddress.TabIndex = 4;
            txbPostal.TabIndex = 5;
            txbPhone.TabIndex = 6;
            txbFAX.TabIndex = 7;
            txbFlag.TabIndex = 8;
            txbHidden.TabIndex = 9;
            //↑テキストボックス
            cbxDisplay.TabIndex = 11;
            cbxHidden.TabIndex = 13;
            //↑メインのチェックボックス
            cmbHint.TabIndex = 14;
            //↑条件のコンボボックス
            btnSort.TabIndex = 17;
            //↑その他機能
            btnDisplay.TabIndex = 20;
            btnClear.TabIndex = 21;
            btnUpdate.TabIndex = 22;
            btnSearch.TabIndex = 24;
            //↑ボタン各種

            txbPageSize.TabIndex = 26;
            txbPageNo.TabIndex = 27;
            btnFirstPage.TabIndex = 28;
            btnPreviousPage.TabIndex = 29;
            btnNextPage.TabIndex = 30;
            btnLastPage.TabIndex = 31;
            //↑メイングリッドビューの諸々

            dataGridViewDsp.TabIndex = 38;
            //↑グリッドビュー

            btnClose.TabIndex = 40;
            //↑閉じる


            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("更新");
            cmbHint.SelectedIndex = 0;



            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void F_Maker_Load(object sender, EventArgs e)
        {
            SetFormDataGridView();
            fncButtonEnable(4);
            fncButtonEnable(8);

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {

                case 4:
                    btnRegist.Enabled = false;
                    break;
                case 5:
                    btnRegist.Enabled = true;
                    btnRegist.ForeColor = Color.Red;
                    break;
                case 8:
                    btnUpdate.Enabled = false;
                    break;
                case 9:
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.Red;
                    break;

                    //01確定　23非表示　45登録　67詳細登録　89更新
            }

        }
        private void fncTextColor(string Item)
        {
            switch (Item)
            {
                case "一覧表示":
                    lblMaID.ForeColor = Color.Black;
                    lblName.ForeColor = Color.Black;
                    lblAddress.ForeColor = Color.Black;
                    lblPhone.ForeColor = Color.Black;
                    lblPostal.ForeColor = Color.Black;
                    lblFAX.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    break;
                case "登録":
                    lblMaID.ForeColor = Color.Black;
                    lblName.ForeColor = Color.Red;
                    lblAddress.ForeColor = Color.Red;
                    lblPhone.ForeColor = Color.Red;
                    lblPostal.ForeColor = Color.Red;
                    lblFAX.ForeColor = Color.Red;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;
                case "検索":
                    lblMaID.ForeColor = Color.Blue;
                    lblName.ForeColor = Color.Blue;
                    lblAddress.ForeColor = Color.Blue;
                    lblPhone.ForeColor = Color.Blue;
                    lblPostal.ForeColor = Color.Blue;
                    lblFAX.ForeColor = Color.Blue;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    break;
                case "更新":
                    lblMaID.ForeColor = Color.Red;
                    lblName.ForeColor = Color.Blue;
                    lblAddress.ForeColor = Color.Blue;
                    lblPhone.ForeColor = Color.Blue;
                    lblPostal.ForeColor = Color.Blue;
                    lblFAX.ForeColor = Color.Blue;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;
            }
        }
        private void RegistEnabled()
        {
            bool flg = false;
            if (!String.IsNullOrEmpty(txbName.Text.Trim())
                && !String.IsNullOrEmpty(txbAddress.Text.Trim())
                && !String.IsNullOrEmpty(txbPostal.Text.Trim())
                && !String.IsNullOrEmpty(txbPhone.Text.Trim())
                && !String.IsNullOrEmpty(txbFAX.Text.Trim()))
                flg = true;

            if (flg)
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 20);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Maker = makerDataAccess.GetMakerData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Maker.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Maker.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Maker.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDsp.Columns[0].Width = 120;
            dataGridViewDsp.Columns[1].Width = 230;
            dataGridViewDsp.Columns[2].Width = 220;
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[4].Width = 230;
            dataGridViewDsp.Columns[5].Width = 270;
            dataGridViewDsp.Columns[6].Width = 140;
            dataGridViewDsp.Columns[7].Width = 467;



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


            dataGridViewDsp.Columns[8].Visible = false;
            dataGridViewDsp.Columns[9].Visible = false;

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewDsp.SelectedCells.Count == 0)
                return;
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


        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 20);
            //空白の時に数値を入力
            SetSelectData();

        }
        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageNo, 1);
            //空白の時に数値を入力
            SetDataGridView();
            //SetSelectDataとSetDataGridViewを間違えずに！
        }

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 6, 2);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示)
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
        }
        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxDisplay.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
       　}


        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbFlag, 2);
            //フラグ数値_日本語化　(1確定未確定 2表示非表示)
        }

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 20);
            //下限値上限値設定
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
            //下限値設定
        }


        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(8);
                txbFlag.Text = String.Empty;
            }
            else
            {
                makerDataAccess.GetMakerFlagData(sender, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbFlag, 2))
                {
                    fncButtonEnable(9);
                }

            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            RegistEnabled();

        }


        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.ValueKeyPress(e);
            //数値のみ入力可
        }

        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
            //10文字以下の数値のみ入力可
        }
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
            //6文字以下の数値のみ入力可
        }
       


        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Maker), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Maker), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Maker), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Maker), btnSort);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetSelectData();
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
            txbPageNo.Text = "1";
            GenerateDataAdDisplay();
            //チェックボックスの要素のみ検索条件に
            SetDataGridView();
        }
        private void GenerateDataAdDisplay()
        {
            int Flag = 0;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示

            M_Maker selectCondition = new M_Maker()
            {
                MaID = 0,
                MaName = String.Empty,
                MaAddress = String.Empty,
                MaPhone = String.Empty,
                MaPostal = String.Empty,
                MaFAX = String.Empty,
                MaFlag = Flag,
                MaHidden = null
            };
            Maker = makerDataAccess.GetMakerData(selectCondition);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //顧客情報抽出
            GenereteDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            string Name = String.Empty;
            string Address = String.Empty;
            string Phone = String.Empty;
            string Postal = String.Empty;
            string FAX = String.Empty;

            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;

            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            if (!String.IsNullOrEmpty(txbAddress.Text.Trim()))
                Address = txbAddress.Text.Trim();
            if (!String.IsNullOrEmpty(txbPhone.Text.Trim()))
                Phone = txbPhone.Text.Trim();
            if (!String.IsNullOrEmpty(txbPostal.Text.Trim()))
                Postal = txbPostal.Text.Trim();
            if (!String.IsNullOrEmpty(txbFAX.Text.Trim()))
                FAX = txbFAX.Text.Trim();


            if (!String.IsNullOrEmpty(txbHidden.Text))
                Flag = 2;
            M_Maker selectCondition = new M_Maker()
            {
                MaID = maID,
                MaName = Name,
                MaAddress = Address,
                MaPhone = Phone,
                MaPostal = Postal,
                MaFlag = Flag,
                MaFAX = FAX
            };
            //顧客データの抽出
            Maker = makerDataAccess.GetMakerData(selectCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Maker.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Maker.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Maker.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var regMa = GenereteDataAdRegistration();
            RegistrationMaker(regMa);
        }


        private M_Maker GenereteDataAdRegistration()
        {
            return new M_Maker
            {
                MaID = 0,
                MaName = txbName.Text.Trim(),
                MaAddress = txbAddress.Text.Trim(),
                MaPhone = txbPhone.Text.Trim(),
                MaPostal = txbPostal.Text.Trim(),
                MaFAX = txbFAX.Text.Trim(),
                MaFlag = 0,
                MaHidden = null
            };
        }

        private void RegistrationMaker(M_Maker regMa)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = makerDataAccess.AddMakerData(regMa);
            if (flg)
            {
                messageDsp.MsgDsp("M0002");
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
            txbMaID.Focus();
            ClearInput();
            GenerateDataAdDisplay();
            SetSelectData();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updMa = GenerateDataAtUpdate();
            UpdateMaker(updMa);
        }

        private M_Maker GenerateDataAtUpdate()
        {
            int Flag = 0;
            string Name = String.Empty;
            string Address = String.Empty;
            string Phone = String.Empty;
            string Postal = String.Empty;
            string FAX = String.Empty;


            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            if (!String.IsNullOrEmpty(txbAddress.Text.Trim()))
                Address = txbAddress.Text.Trim();
            if (!String.IsNullOrEmpty(txbPhone.Text.Trim()))
                Phone = txbPhone.Text.Trim();
            if (!String.IsNullOrEmpty(txbPostal.Text.Trim()))
                Postal = txbPostal.Text.Trim();
            if (!String.IsNullOrEmpty(txbFAX.Text.Trim()))
                FAX = txbFAX.Text.Trim();
            if (!String.IsNullOrEmpty(txbHidden.Text))
                Flag = 2;

            return new M_Maker
            {
                MaID = int.Parse(txbMaID.Text),
                MaName = Name,
                MaAddress = Address,
                MaPhone = Phone,
                MaPostal = Postal,
                MaFAX = FAX,
                MaFlag = Flag,
                MaHidden = txbHidden.Text
            };
        }


        private void UpdateMaker(M_Maker updMa)
        {
            string MsgCode = "M1";
            if (!String.IsNullOrEmpty(txbHidden.Text))
                MsgCode = "M2";

            DialogResult result = messageDsp.MsgDspQ(MsgCode + "001", lblMaID, txbMaID);
            //●●ID:00の情報を更新しますか？
            //●●ID:00を非表示にしますか？

            if (result != DialogResult.OK)
                return;

            bool flg = makerDataAccess.UpdateMakerData(updMa);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);

                    result = messageDsp.MsgDsp(MsgCode + "002", lblMaID, txbMaID);
                //●●ID:00の情報を更新しました。
                //●●ID:00を非表示にしました。

            }
            else
            {
                    result = messageDsp.MsgDsp(MsgCode + "003", lblMaID, txbMaID);
                //●●ID:00の情報を更新に失敗しました。
                //●●ID:00を非表示に失敗しました。
                return;
            }

            ClearInput();
            txbMaID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            //全件表示
        }
    }
}
