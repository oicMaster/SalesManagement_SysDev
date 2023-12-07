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

        MessageDsp messageDsp = new MessageDsp();
        EmployeeDataAccess employeeDateAccess = new EmployeeDataAccess();
        SalesOfficeDataAccess salesOfficeIDataAccess = new SalesOfficeDataAccess();
        PositionDataAccess positionDataAccess = new PositionDataAccess();
        CommonModule commonModule = new CommonModule();
        private static List<M_Employee> Employees;



        public F_AdEmployee()
        {
            InitializeComponent();
        }

        private void F_Employee_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(2);
            fncButtonEnable(4);
            txbFlag.ReadOnly = true;


            dtpDate.Value = DateTime.Now;



            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("更新");
            cmbHint.SelectedIndex = 0;

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                case 2:
                    btnRegist.Enabled = false;
                    break;
                case 3:
                    btnRegist.Enabled = true;
                    break;
                case 4:
                    btnUpdate.Enabled = false;
                    break;
                case 5:
                    btnUpdate.Enabled = true;
                    break;

            }

        }
        private void fncTextBoxColor(int chk)
        {
            switch (chk)
            {
                case 1: 
                    lblEmID.ForeColor = Color.Red;
                    lblName.ForeColor = Color.Red;
                    lblPoID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Red;
                    lblPhone.ForeColor = Color.Red;
                    lblPassword.ForeColor = Color.Red;
                    lblHidden.ForeColor = Color.Black;
                    break;
                case 2:
                    lblEmID.ForeColor = Color.Blue;
                    lblName.ForeColor = Color.Blue;
                    lblPoID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblPhone.ForeColor = Color.Black;
                    lblPassword.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    break;
                case 3:
                    lblEmID.ForeColor = Color.Red;
                    lblName.ForeColor = Color.Red;
                    lblPoID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Red;
                    lblPhone.ForeColor = Color.Red;
                    lblPassword.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Blue;
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
            Employees = employeeDateAccess.GetEmployeeData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Employees.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 200;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 400;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewDsp.Columns[0].HeaderText = "社員ID";
            dataGridViewDsp.Columns[1].HeaderText = "社員名";
            dataGridViewDsp.Columns[2].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[3].HeaderText = "役職ID";
            dataGridViewDsp.Columns[4].HeaderText = "入社年月日";
            dataGridViewDsp.Columns[6].HeaderText = "電話番号";
            dataGridViewDsp.Columns[8].HeaderText = "社員管理フラグ";
            dataGridViewDsp.Columns[9].HeaderText = "非表示理由";


            lblPageNo.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //※
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
            dataGridViewDsp.DataSource = Employees.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbEmID.Text = String.Empty;
            txbName.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            txbSoID.Text = String.Empty;
            txbPoID.Text = String.Empty;
            txbPhone.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHiddin.Text = String.Empty;
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
            if (!GetValidDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }


        private bool GetValidDataAtSelect()
        {
            if (!String.IsNullOrEmpty(txbEmID.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmID.Focus();
                return false;
            }
            if (!salesOfficeIDataAccess.CheckSoIDExistence(int.Parse(txbSoID.Text)))
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (!positionDataAccess.CheckPoIDExistence(int.Parse(txbPoID.Text)))
            {
                messageDsp.MsgDsp("");
                txbPoID.Focus();
                return false;
            }
            return true;
        }
        private void GenerateDataAtSelect()
        {　　//検索条件セット
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(txbEmID.Text.Trim()),

            };
            //社員データの抽出
            //Employees = employeeDateAccess.GetEmployeeData(selectCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";

            int pageSize = int.Parse(txbPageNo.Text.Trim());

            dataGridViewDsp.DataSource = Employees;

            lblPageNo.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ ";
            dataGridViewDsp.Refresh();
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
            return true;
        }

        private M_Employee GenereteDataAdRegistration()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text.Trim()),
                EmName = txbName.Text.Trim(),
                SoID = int.Parse((txbSoID.Text.Trim())),
                PoID = int.Parse((txbPoID.Text.Trim())),
                EmHiredate = dtpDate.Value,
                EmPhone = txbPhone.Text.Trim(),
                EmFlag = int.Parse(txbFlag.Text.Trim()),
                EmHidden = txbHiddin.Text.Trim(),
            };
        }

        private void RegistrationClient(M_Employee regClient)
        {
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            bool flg = employeeDateAccess.AddEmployeeData(regClient);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbEmID.Focus();

            ClearInput();

            GetDataGridView();

        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updEm = GenerateDataAtUpdate();
            //顧客情報更新
            UpdateClient(updEm);    //エラーでます
        }

        private bool GetValidDataAtUpdate()
        {
            
            return true;
        }

        private M_Employee GenerateDataAtUpdate()
        {

            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text.Trim()),
                EmName = txbName.Text.Trim(),
                SoID = int.Parse((txbSoID.Text.Trim())),
                PoID = int.Parse((txbPoID.Text.Trim())),
                EmHiredate = dtpDate.Value,
                EmPhone = txbPhone.Text.Trim(),
                EmFlag = int.Parse(txbFlag.Text.Trim()),
                EmHidden = txbHiddin.Text.Trim(),
            };
        }

        private void UpdateClient(M_Employee updCl)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = employeeDateAccess.UpadateEmployeeData(updCl);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbEmID.Focus();

            GetDataGridView();
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextBoxColor(0);
        }
    }
}









