using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehousingDataAccess
    {
        public bool CheckWaIDExistence(int WaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Warehousings.Any(x => x.WaID == WaID);
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

        public bool AddWarehousingData(T_Warehousing regWa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Warehousings.Add(regWa);
                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateWarehousingData(T_Warehousing updWa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var warehousing = context.T_Warehousings.Single(x => x.WaID == updWa.WaID);

               warehousing.WaID = updWa.WaID;
               warehousing.HaID = updWa.HaID;
               warehousing.EmID = updWa.EmID;
               warehousing.WaDate = updWa.WaDate;
               warehousing.WaShelfFlag = updWa.WaShelfFlag;
                warehousing.WaHidden = updWa.WaHidden;
                warehousing.WaFlag = updWa.WaFlag;

                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<T_Warehousing> GetWarehousingData()
        {
            List<T_Warehousing> warehousing = new List<T_Warehousing>();
            try
            {
                var context = new SalesManagement_DevContext();
                warehousing = context.T_Warehousings.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousing;
        }



        public List<T_Warehousing> GetWarehousingData(T_Warehousing selectCondition)
        {
            List<T_Warehousing> warehousing = new List<T_Warehousing>();
            try
            {
                var context = new SalesManagement_DevContext();
                warehousing = context.T_Warehousings.Where(x => x.WaID == selectCondition.WaID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousing;
        }
    }
}
