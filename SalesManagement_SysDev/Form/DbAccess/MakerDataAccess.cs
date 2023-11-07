using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class MakerDataAccess
    {
        public bool CheckMaIDExistence(int MaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Makers.Any(x => x.MaID == MaID);
                //DB更新
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
