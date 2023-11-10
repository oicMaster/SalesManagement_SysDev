using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class PositionDataAccess
    {
        public bool CheckPoIDExistence(int PoID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.M_Positions.Any(x => x.PoID == PoID);
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

        //public bool AddPositionData(M_Position regPo)
        //public bool UpdatePositionData(M_Position updPo)
        //public List<M_Position> GetPositionData()
        //public List<M_Position> GetPositionData(M_Position selectCondition)
    }
}
