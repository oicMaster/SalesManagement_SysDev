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
    public partial class F_LoMenu : Form
    {
        private F_Login login;

        public F_LoMenu(F_Login login, string emID)
        {
            InitializeComponent();
            this.login = login;
            lblLoginIDData.Text = emID;
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeDataAccess.GetEmployeeNameData(emID, lblLoginNameData);
        }

        private void F_LoMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }
    }
}
