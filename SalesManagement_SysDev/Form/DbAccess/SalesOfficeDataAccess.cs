using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SalesOfficeDataAccess
    {
        public bool CheckSoIDExistence(int SoID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                flg = context.M_SalesOffices.Any(x => x.SoID == SoID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                //エラーメッセージ(基本形)
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
    }
}
