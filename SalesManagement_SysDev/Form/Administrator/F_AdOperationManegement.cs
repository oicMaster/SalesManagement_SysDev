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
using System.Xml.Linq;
using SalesManagement_SysDev.Common;

namespace SalesManagement_SysDev
{
    public partial class F_AdOperationManegement : Form
    {
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();
        private F_AdMenu AdMenu;
        public F_AdOperationManegement(F_AdMenu adMenu,string ID,string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "パスワード更新";
            lblLoginIDData.Text = ID;
            txbEmID.Text = ID;
            lblLoginNameData.Text = Name;

            txbCurrentPassword.MaxLength = 10;
            txbUpdatePassword.MaxLength = 10;
            txbSecondUpdatePassword.MaxLength = 10;
        }

        private void F_OperationManegement_Load(object sender, EventArgs e)
        {
            txbCurrentPassword.PasswordChar = '*';
            txbUpdatePassword.PasswordChar = '*';
            txbSecondUpdatePassword.PasswordChar = '*';
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }

        private void ButtonEnabled()
        {
            if (!String.IsNullOrEmpty(txbCurrentPassword.Text)
                && !String.IsNullOrEmpty(txbUpdatePassword.Text)
                && !String.IsNullOrEmpty(txbSecondUpdatePassword.Text))
                if (txbUpdatePassword.Text == txbSecondUpdatePassword.Text)
                {
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.Red;
                    return;
                }
            btnUpdate.Enabled = false;
            btnUpdate.ForeColor = Color.Black;
        }

        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txbCurrentPassword.PasswordChar = '\0';
            txbUpdatePassword.PasswordChar = '\0';
            txbSecondUpdatePassword.PasswordChar = '\0';
            lblVisible.Text = "(꒪꒫꒪)";
        }

        private void lblVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txbCurrentPassword.PasswordChar = '*';
            txbUpdatePassword.PasswordChar = '*';
            txbSecondUpdatePassword.PasswordChar = '*';
            lblVisible.Text = "(-꒫-)";
        }

        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        MessageDsp messageDsp = new MessageDsp();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool flg = employeeDataAccess.GetEmployeePassData(txbEmID.Text, txbCurrentPassword.Text);
            if (!flg)
            {
                messageDsp.MsgDsp("M4005");
                return;
            }

            var updEm = GenerateDataAtUpdate();
            //顧客情報更新
            UpdatePassword(updEm); 

        }

        private void ClearInput()
        {
            txbCurrentPassword.Text = String.Empty;
            txbUpdatePassword.Text = String.Empty;
            txbSecondUpdatePassword.Text = String.Empty;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            ButtonEnabled();
        }

        private M_Employee GenerateDataAtUpdate()
        {

            return new M_Employee
            {
                EmID = int.Parse(txbEmID.Text),
                EmName = String.Empty,
                SoID = 0,
                PoID = 0,
                EmHiredate = null,
                EmPassword = txbUpdatePassword.Text.Trim(),
                EmPhone = String.Empty,
                EmFlag = 0,
                EmHidden = null,
            };
        }
        private void UpdatePassword(M_Employee updEm)
        {
            DialogResult result = messageDsp.MsgDspQ("M4001");
            if (result != DialogResult.OK)
                return;

            bool flg = employeeDataAccess.UpdateEmployeeData(updEm);
            if (flg == true)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M4002");
            }
            else
                messageDsp.MsgDsp("M4003");

            ClearInput();
            txbCurrentPassword.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
