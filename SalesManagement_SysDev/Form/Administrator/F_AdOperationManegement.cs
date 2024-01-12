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

        private F_AdMenu AdMenu;
        public F_AdOperationManegement(F_AdMenu adMenu,string ID,string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "パスワード更新";
            lblLoginIDData.Text = ID;
            lblEmIDData.Text = ID;
            lblLoginNameData.Text = Name;
        }

        private void txbEmID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void lblVisible_Click(object sender, EventArgs e)
        {

        }

        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txbCurrentPassword.PasswordChar = '\0';
            txbUpdatePassword.PasswordChar = '\0';
            txbSecondUpdatePassword.PasswordChar = '\0';
            lblVisible.Text = "(👀";
        }

        private void lblVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txbCurrentPassword.PasswordChar = '*';
            txbUpdatePassword.PasswordChar = '*';
            txbSecondUpdatePassword.PasswordChar = '*';
            lblVisible.Text = "(--";
        }

        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        MessageDsp messageDsp = new MessageDsp();

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool flg = employeeDataAccess.GetEmployeePassData(lblEmIDData.Text, txbCurrentPassword.Text);
            if (!flg)
                return;
            if (String.IsNullOrEmpty(txbUpdatePassword.Text.Trim())&&txbUpdatePassword.Text != txbSecondUpdatePassword.Text)
                return;

            var updEm = GenerateDataAtUpdate();
            //顧客情報更新
            UpdatePassword(updEm); 

        }

        private M_Employee GenerateDataAtUpdate()
        {

            return new M_Employee
            {
                EmID = int.Parse(lblEmIDData.Text),
                EmName = null,
                SoID = 0,
                PoID = 0,
                EmPassword = txbUpdatePassword.Text.Trim(),
                EmPhone = null,
                EmFlag = 0,
                EmHidden = null,
            };
        }
        private void UpdatePassword(M_Employee updEm)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = employeeDataAccess.UpdateEmployeeData(updEm);
            if (flg == true)
                messageDsp.MsgDsp("M0001");
            else
                messageDsp.MsgDsp("0001");

            ClearInput();
            txbCurrentPassword.Focus();
        }

        private void ClearInput()
        {
            txbCurrentPassword.Text = String.Empty;
            txbUpdatePassword.Text = String.Empty;
            txbSecondUpdatePassword.Text = String.Empty;
        }
    }
}
