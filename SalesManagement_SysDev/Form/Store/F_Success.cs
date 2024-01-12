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
    public partial class F_Success : Form
    {
        public F_Success()
        {
            InitializeComponent();
        }

        private void F_Display_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
        }
    }
}
