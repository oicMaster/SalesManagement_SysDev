using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagement_SysDev
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
    
        }

        MessageDsp messageDsp = new MessageDsp();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        PasswordHash passwordHash = new PasswordHash();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();


        private void F_Login_Load(object sender, EventArgs e)
        {
          
            txbPassword.PasswordChar = '*';
            txbPassword.MaxLength = 10;
        }

       


        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txbPassword.PasswordChar = '\0';
            lblVisible.Text = "(꒪꒫꒪)";
        }

        private void lblVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txbPassword.PasswordChar = '*';
            lblVisible.Text = "(-꒫-)";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flg = employeeDataAccess.GetEmployeePassData(txbEmID.Text, txbPassword.Text);
            if (!flg)
            {
                messageDsp.MsgDsp("M4003");
                return;
            }
            var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(txbEmID.Text), this.Text, btnLogin.Text);
            operationHistoryDataAccess.AddOperationHistoryData(regOh);
            F_Success FSuccess = new F_Success();
            FSuccess.Show();

            // Timerを使用
            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += (s, args) =>
            {
                // タイマーのイベントハンドラ内でFormCを非表示にし、FormBに遷移する
                FSuccess.Dispose();
                MenuSelection();

                // タイマーを停止
                timer.Stop();
            };

            // タイマーを開始
            timer.Start();
            txbPassword.Text = string.Empty;
        }

        private void MenuSelection()
        {

            Form frm = new Form();
            int poID = employeeDataAccess.GetEmployeePoIDData(txbEmID.Text);
            switch (poID)
            {
                case 1:
                    frm = new F_AdMenu(this, txbEmID.Text);
                    break;
                case 2:
                    frm = new F_SaMenu(this, txbEmID.Text);
                    break;
                case 3:
                    frm = new F_LoMenu(this, txbEmID.Text);
                    break;
            }

            frm.Show();
            this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txbEmID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
        }
    }
}
