using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesManagement_SysDev
{
    public partial class F_AdOperationHistory : Form
    {
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();
        F_AdMenu AdMenu;

        public F_AdOperationHistory(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "ログ管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;



            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_AdOperationHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }
    }
}
