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

namespace SalesManagement_SysDev
{
    public partial class F_AdEmployee : Form
    {
        //メッセージ表示用のインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //データベース社員テーブルアクセス用のクラスのインスタンス化
        EmployeeDataAccess employeeDateAccess = new EmployeeDataAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //データグリッドビュー用の社員データ
        private static List<M_Employee> Employees;



        public F_AdEmployee()
        {
            InitializeComponent();
        }

        private void F_Employee_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            fncButtonEnable(0);
            fncTextBoxReadOnly(0);
            txbEmFlag.ReadOnly = true;
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
                    btnRegist.Enabled = true;
                    btnSearch.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void fncTextBoxReadOnly(int chk)
        {
            switch (chk)
            {
                case 0:
                    txbEmID.ReadOnly = true;
                    txbEmName.ReadOnly = true;
                    txbSoID.ReadOnly = true;
                    txbPoID.ReadOnly = true;
                    txbEmHiredate.ReadOnly = true;
                    txbEmPhone.ReadOnly = true;
                    txbEmHiddin.ReadOnly = true;
                    break;
                case 1:
                    txbEmID.ReadOnly = false;
                    txbEmName.ReadOnly = false;
                    txbSoID.ReadOnly = false;
                    txbPoID.ReadOnly = false;
                    txbEmHiredate.ReadOnly = false;
                    txbEmPhone.ReadOnly = false;
                    txbEmHiddin.ReadOnly = false;
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
            Employees = employeeDateAccess.GetEmployeeData();

            SetDataGridView();

        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNO = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Employees.Skip(pageSize * pageNO);

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 200;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 400;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            lblPage.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

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
        private void txbEmID_TextChanged(object sender, EventArgs e)
        {
            //顧客IDが入力されているかどうか
            if (txbEmID.Text == "" || txbEmID.Text == null)
            {
                fncButtonEnable(0);
                fncTextBoxReadOnly(0);
                ClearInput();
            }
            else
            {
                fncButtonEnable(1);
                fncTextBoxReadOnly(1);
                txbEmFlag.Text = "0";
            }
        }

        private void txbEmHidden_TextChanged(object sender, EventArgs e)
        {
            if (txbEmHiddin.Text == "" || txbEmHiddin == null)
                txbEmFlag.Text = "0";
            else
                txbEmFlag.Text = "2";
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
            dataGridViewDsp.DataSource = Employees.Take(pageSize).ToList();

            //DataGridViewを更新
            dataGridViewDsp.Refresh();

            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Employees.Skip(pageSize * pageNo).Take(pageSize).ToList();


            //DataGridViewを更新
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
            int PageNo = int.Parse(txbPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(Employees.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (PageNo <= lastNo)
                txbPageNo.Text = lastNo.ToString();
            else
                txbPageNo.Text = (PageNo + 1).ToString();

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Employees.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Employees.Skip(pageSize * pageNo).Take(pageSize).ToString();

            //DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            txbEmID.Text = String.Empty;
            txbEmName.Text = String.Empty;
            txbEmHiredate.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbPoID.Text = String.Empty;
            txbEmPhone.Text = String.Empty;
            txbEmFlag.Text = String.Empty;
            txbEmHiddin.Text = String.Empty;
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
            return true;
        }
        private void GenerateDataAtSelect()
        {　　//検索条件セット
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(txbEmID.Text.Trim()),

            };
            //社員データの抽出
            Employees = employeeDateAccess.GetEmployeeData(selectCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";

            int pageSize = int.Parse(txbPageNo.Text.Trim());

            dataGridViewDsp.DataSource = Employees;

            lblPage.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ ";
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
            if (!String.IsNullOrEmpty(txbEmID.Text.Trim()))
            {
                if (!employeeDateAccess.CheckEmployeeCDExistence(int.Parse(txbEmID.Text.Trim())))
                {
                    messageDsp.MsgDsp("");
                    txbEmID.Focus();
                    return false;
                }

            }
            else
            {
                messageDsp.MsgDsp("");
                txbEmID.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbSoID.Text.Trim()))
            {

            }
            else
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbPoID.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbPoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmHiredate.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmHiredate.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmPhone.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmPhone.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmHiddin.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmHiddin.Focus();
                return false;
            }
            return true;




        }

        private M_Employee GenereteDataAdRegistration()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text.Trim()),
                EmName = txbEmName.Text.Trim(),
                SoID = int.Parse((txbSoID.Text.Trim())),
                PoID = int.Parse((txbPoID.Text.Trim())),
                EmHiredate = DateTime.Parse(txbEmHiredate.Text.Trim()),
                EmPhone = txbEmPhone.Text.Trim(),
                EmFlag = int.Parse(txbEmFlag.Text.Trim()),
                EmHidden = txbEmHiddin.Text.Trim(),
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





        private void btnUpdate_Click_1(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(txbEmID.Text.Trim()))
            {
                if (!employeeDateAccess.CheckEmployeeCDExistence(int.Parse(txbEmID.Text.Trim())))
                {
                    messageDsp.MsgDsp("");
                    txbEmID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbEmID.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbEmID.Text.Trim()))
            {

            }
            else
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbPoID.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbPoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmHiredate.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmHiredate.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmPhone.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmPhone.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmHiddin.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbEmHiddin.Focus();
                return false;
            }
            return true;
        }

        private M_Employee GenerateDataAtUpdate()
        {
            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text.Trim()),
                EmName = txbEmName.Text.Trim(),
                SoID = int.Parse((txbSoID.Text.Trim())),
                PoID = int.Parse((txbPoID.Text.Trim())),
                EmHiredate = DateTime.Parse(txbEmHiredate.Text.Trim()),
                EmPhone = txbEmPhone.Text.Trim(),
                EmFlag = int.Parse(txbEmFlag.Text.Trim()),
                EmHidden = txbEmHiddin.Text.Trim(),
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

    }
}









