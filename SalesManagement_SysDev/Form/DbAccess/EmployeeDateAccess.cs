using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Form.DbAccess
{
    internal class EmployeeDateAccess
    {
        public bool CheckEmployeeCDXxistence(int emID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID == emID);
                context.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        public bool Add
    }
}
