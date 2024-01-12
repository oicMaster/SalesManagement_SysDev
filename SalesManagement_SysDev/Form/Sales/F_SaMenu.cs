using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_SaMenu : Form
    {
        private F_Login login;

        public F_SaMenu(F_Login login, string emID)
        {
            InitializeComponent();
            this.login = login;
            lblLoginIDData.Text = emID;
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeDataAccess.GetEmployeeNameData(emID, lblLoginNameData);
        }

        private void F_SaMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void OpenForm(string formName)
        {
            string ID = lblLoginIDData.Text;
            string Name = lblLoginNameData.Text;
            Form frm = new Form();
            //引数より、開くフォームを設定
            switch (formName)
            {
                
                //case "パスワード管理":
                    //frm = new F_AdOperationManegement(this, ID, Name);
                    //break;
            }

            //frm.Show();
            //this.Hide();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            OpenForm(((Button)sender).Text);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }
    }
}
