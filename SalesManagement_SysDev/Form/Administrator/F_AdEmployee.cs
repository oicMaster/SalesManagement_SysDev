using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesManagement_SysDev
{
    public partial class F_AdEmployee : Form
    {

        F_AdMenu AdMenu;
        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();


        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        private static List<M_Employee> Employee;

        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        PositionDataAccess positionDataAccess = new PositionDataAccess();


        public F_AdEmployee(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "社員管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;


            txbName.MaxLength = 50;
            txbPoID.MaxLength = 6;
            txbSoID.MaxLength = 6;
            txbPhone.MaxLength = 13;
            txbPassword.MaxLength = 10;

            txbEmID.TabIndex = 0;
            txbName.TabIndex = 2;
            txbPoID.TabIndex = 3;
            txbSoID.TabIndex = 4;
            dtpDate.TabIndex = 5;
            txbPhone.TabIndex = 6;
            txbPassword.TabIndex = 7;
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
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("更新");
            cmbHint.SelectedIndex = 0;

            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Employee_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
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
                    lblEmID.ForeColor = Color.Black;
                    lblName.ForeColor = Color.Black;
                    lblPoID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblPhone.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblPassword.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cmbDate.ForeColor = Color.Black;
                    break;
                case "登録":
                    lblEmID.ForeColor = Color.Black;
                    lblName.ForeColor = Color.Red;
                    lblPoID.ForeColor = Color.Fuchsia;
                    lblSoID.ForeColor = Color.Fuchsia;
                    lblPhone.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Red;
                    lblPassword.ForeColor = Color.Red;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cmbDate.ForeColor = Color.Black;
                    break;
                case "検索":
                    lblEmID.ForeColor = Color.Blue;
                    lblName.ForeColor = Color.Blue;
                    lblPoID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblPhone.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblPassword.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cmbDate.ForeColor = Color.Blue;
                    break;
                case "更新":
                    lblEmID.ForeColor = Color.Red;
                    lblName.ForeColor = Color.Blue;
                    lblPoID.ForeColor = Color.Fuchsia;
                    lblSoID.ForeColor = Color.Fuchsia;
                    lblPhone.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Black;
                    lblPassword.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cmbDate.ForeColor = Color.Black;
                    break;


            }


        }
        private void RegistEnabled()
        {
            bool flg = false;
            if (lblPoName.Text != "----"
                && lblSoName.Text != "----"
                && !String.IsNullOrEmpty(txbName.Text.Trim())
                && !String.IsNullOrEmpty(txbPhone.Text.Trim())
                && !String.IsNullOrEmpty(txbPassword.Text.Trim()))
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
            Employee = employeeDataAccess.GetEmployeeData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Employee.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Employee.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Employee.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDsp.Columns[0].Width = 140;
            dataGridViewDsp.Columns[1].Width = 400;
            dataGridViewDsp.Columns[2].Width = 140;
            dataGridViewDsp.Columns[3].Width = 140;
            dataGridViewDsp.Columns[4].Width = 200;
            dataGridViewDsp.Columns[6].Width = 200;
            dataGridViewDsp.Columns[7].Width = 230;
            dataGridViewDsp.Columns[8].Width = 427;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewDsp.Columns[0].HeaderText = "社員ID";
            dataGridViewDsp.Columns[1].HeaderText = "社員名";
            dataGridViewDsp.Columns[2].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[3].HeaderText = "役職ID";
            dataGridViewDsp.Columns[4].HeaderText = "入社年月日";
            dataGridViewDsp.Columns[6].HeaderText = "電話番号";
            dataGridViewDsp.Columns[7].HeaderText = "社員管理フラグ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";

            dataGridViewDsp.Columns[5].Visible = false;
            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;
            dataGridViewDsp.Columns[15].Visible = false;
            dataGridViewDsp.Columns[16].Visible = false;
            dataGridViewDsp.Columns[17].Visible = false;
            dataGridViewDsp.Columns[18].Visible = false;
            dataGridViewDsp.Columns[19].Visible = false;
            dataGridViewDsp.Columns[20].Visible = false;



            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            //グリッドビューが空の際に処理しない
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbPoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            //DTPの設定　※コントロールのMAX MINの確認
            txbPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbHidden.Text = String.Empty;
            //Null値のif

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
            commonModule.CellFormatting(e, 7, 2);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示)
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
            //項目情報の色設定
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
                employeeDataAccess.GetEmployeeFlagData(sender, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbFlag, 2))
                {
                    fncButtonEnable(9);
                }

            }
        }
        private void txbPoID_TextChanged(object sender, EventArgs e)
        {
            positionDataAccess.GetPositionNameData(sender, lblSoName);
        }
        private void txbSoID_TextChanged(object sender, EventArgs e)
        {
            salesOfficeDataAccess.GetSalesOfficeNameData(sender, lblSoName);
            RegistEnabled();
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
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Employee), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Employee), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Employee), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Employee), btnSort);
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
            txbEmID.Text = String.Empty;
            txbPoID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbName.Text = String.Empty;
            txbPhone.Text = String.Empty;
            txbPassword.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
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

            M_Employee selectCondition = new M_Employee()
            {
                EmID = 0,
                SoID = 0,
                PoID = 0,
                EmName = String.Empty,
                EmHiredate = null,
                EmPhone = String.Empty,
                EmFlag = Flag,
                EmPassword = String.Empty,
                EmHidden = null
            };
            Employee = employeeDataAccess.GetEmployeeData(selectCondition,0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            //顧客情報抽出
            GenerateDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }
        private void GenerateDataAdSelect()
        {
            int Flag = 0;
            DateTime? date = null;
            string Name = String.Empty;
            string Phone = String.Empty;

            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbPoID.Text, out int poID))
                poID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;

            if (dtpDate.Checked)
                date = dtpDate.Value;

            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            if (!String.IsNullOrEmpty(txbPhone.Text.Trim()))
                Phone = txbPhone.Text.Trim();

            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            M_Employee selectCondition = new M_Employee()
            {
                EmID = emID,
                SoID = poID,
                PoID = soID,
                EmName = Name,
                EmHiredate = date,
                EmPhone = Phone,
                EmFlag = Flag,
                EmPassword = String.Empty,
                EmHidden = null
            };
            //顧客データの抽出
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Employee = employeeDataAccess.GetEmployeeData(selectCondition,dateCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Employee.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Employee.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Employee.Count / (double)pageSize)) + "ページ";
        }


        private void btnRegist_Click(object sender, EventArgs e)
        {
            var regEm = GenereteDataAdRegistration();
            RegistrationEmployee(regEm);
        }


        private M_Employee GenereteDataAdRegistration()
        {
            return new M_Employee
            {
                EmID = 0,
                SoID = int.Parse(txbSoID.Text),
                PoID = int.Parse(txbPoID.Text),
                EmName = txbName.Text.Trim(),
                EmHiredate = dtpDate.Value,
                EmPhone = txbPhone.Text.Trim(),
                EmFlag = 0,
                EmPassword = txbPassword.Text.Trim(),
                EmHidden = null
            };
        }

        private void RegistrationEmployee(M_Employee regEm)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = employeeDataAccess.AddEmployeeData(regEm);
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
            txbEmID.Focus();
            ClearInput();
            GenerateDataAdDisplay();
            SetSelectData();
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updEm = GenerateDataAtUpdate();
            UpdateEmployee(updEm);
        }

        private M_Employee GenerateDataAtUpdate()
        {
            int Flag = 0;
            DateTime? date = null;
            string Name = String.Empty;
            string Phone = String.Empty;

            if (!int.TryParse(txbPoID.Text, out int poID))
                poID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;

            if (dtpDate.Checked)
                date = dtpDate.Value;

            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            if (!String.IsNullOrEmpty(txbPhone.Text.Trim()))
                Phone = txbPhone.Text.Trim();

            if (!String.IsNullOrEmpty(txbHidden.Text))
                Flag = 2;

            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text),
                SoID = poID,
                PoID = soID,
                EmName = Name,
                EmHiredate = date,
                EmPhone = Phone,
                EmFlag = Flag,
                EmPassword = String.Empty,
                EmHidden = txbHidden.Text
            };
        }


        private void UpdateEmployee(M_Employee updEm)
        {
            string MsgCode = "M1";
            if (!String.IsNullOrEmpty(txbHidden.Text))
                MsgCode = "M2";

            DialogResult result = messageDsp.MsgDspQ(MsgCode + "001", lblEmID, txbEmID);
            //●●ID:00の情報を更新しますか？
            //●●ID:00を非表示にしますか？

            if (result != DialogResult.OK)
                return;

            bool flg = employeeDataAccess.UpdateEmployeeData(updEm);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);

                result = messageDsp.MsgDsp(MsgCode + "002", lblEmID, txbEmID);
                //●●ID:00の情報を更新しました。
                //●●ID:00を非表示にしました。

            }
            else
            {
                result = messageDsp.MsgDsp(MsgCode + "003", lblEmID, txbEmID);
                //●●ID:00の情報を更新に失敗しました。
                //●●ID:00を非表示に失敗しました。
                return;
            }

            ClearInput();
            txbEmID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            //全件表示
        }


    }
}









