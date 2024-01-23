using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_SaMenu : Form
    {


        private F_Login login;
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        public F_SaMenu(F_Login login, string emID)
        {
            InitializeComponent();
            this.login = login;
            lblLoginIDData.Text = emID;
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeDataAccess.GetEmployeeNameData(emID, lblLoginNameData);

        }

        private void OpenForm(string formName)
        {
            string ID = lblLoginIDData.Text;
            string Name = lblLoginNameData.Text;
            Form frm = new Form();
            //引数より、開くフォームを設定
            switch (formName)
            {
                case "顧客管理":
                    frm = new F_SaClient(this, ID, Name);
                    break;
                case "売上管理":
                    frm = new F_SaSale(this, ID, Name);
                    break;
                case "受注管理":
                    frm = new F_SaOrder(this, ID, Name);
                    break;
                case "注文管理":
                    frm = new F_SaChumon(this, ID, Name);
                    break;
                case "入荷管理":
                    frm = new F_SaArrival(this, ID, Name);
                    break;
                case "出荷管理":
                    frm = new F_SaShipment(this, ID, Name);
                    break;
                case "パスワード管理":
                    frm = new F_SaOperationManegement(this, ID, Name);
                    break;
            }

            frm.Show();
            this.Hide();
        }



        private void btnForm_Click(object sender, EventArgs e)
        {
            OpenForm(((Button)sender).Text);
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnClose.Text);
            operationHistoryDataAccess.AddOperationHistoryData(regOh);
            login.Show();
            this.Dispose();
        }
    }
}
