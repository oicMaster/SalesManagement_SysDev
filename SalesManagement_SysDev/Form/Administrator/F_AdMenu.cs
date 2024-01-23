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
    public partial class F_AdMenu : Form
    {


        private F_Login login;
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        public F_AdMenu(F_Login login,string emID)
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
                    frm = new F_AdClient(this, ID, Name);
                    break;
                case "商品管理":
                    frm = new F_AdProduct(this, ID, Name);
                    break;
                case "在庫管理":
                    frm = new F_AdStock(this, ID, Name);
                    break;
                case "社員管理":
                    frm = new F_AdEmployee(this, ID, Name);
                    break;
                case "売上管理":
                    frm = new F_AdSale(this, ID, Name);
                    break;
                case "受注管理":
                    frm = new F_AdOrder(this, ID, Name);
                    break;
                case "注文管理":
                    frm = new F_AdChumon(this, ID, Name);
                    break;
                case "発注管理":
                    frm = new F_AdHattyu(this, ID, Name);
                    break;
                case "入庫管理":
                    frm = new F_AdWarehousing(this, ID, Name);
                    break;
                case "出庫管理":
                    frm = new F_AdSyukko(this, ID, Name);
                    break;
                case "入荷管理":
                    frm = new F_AdArrival(this,ID,Name);
                    break;
                case "出荷管理":
                    frm = new F_AdShipment(this, ID, Name);
                    break;
                case "ログ管理":
                    frm = new F_AdOperationHistory(this, ID, Name);
                    break;
                case "メーカ管理":
                    frm = new F_AdMaker(this, ID, Name);
                    break;
                case "営業所管理":
                    frm = new F_AdSalesOffice(this, ID, Name);
                    break;
                case "パスワード管理":
                    frm = new F_AdOperationManegement(this, ID, Name);
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
