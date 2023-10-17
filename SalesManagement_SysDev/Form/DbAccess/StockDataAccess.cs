using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Form.DbAccess
{
    internal class StockDataAccess
    {
        public bool CheckStIDExistence(int stID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //在庫IDと一致するデータがあるかどうか
                flg = context.T_Stocks.Any(x => x.StID == stID);
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
       public List<T_Stock>
    }
}
