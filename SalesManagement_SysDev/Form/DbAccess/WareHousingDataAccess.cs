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
                warehousing = context.T_Warehousings.Where(x => x.WaShelfFlag == 0 && x.WaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousing;
        }



        public List<T_Warehousing> GetWarehousingData(T_Warehousing selectCondition,int dateCondition)
        {
            List<T_Warehousing> warehousing = new List<T_Warehousing>();
            try
            {
                var context = new SalesManagement_DevContext();
                warehousing = context.T_Warehousings.Where(x =>
                  (selectCondition.WaID == 0 || x.WaID == selectCondition.WaID) &&
                  (selectCondition.HaID == 0 || x.HaID == selectCondition.HaID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.WaDate == DateTime.Parse("0001/01/01") ||
                  (dateCondition == 0 && x.WaDate == selectCondition.WaDate) ||
                  (dateCondition == 1 && x.WaDate >= selectCondition.WaDate) ||
                  (dateCondition == 2 && x.WaDate <= selectCondition.WaDate)) &&
                  (selectCondition.WaShelfFlag == 3 || x.WaShelfFlag == selectCondition.WaShelfFlag) &&
                  (selectCondition.WaFlag == 3 || x.WaFlag == selectCondition.WaFlag)
                ).ToList();
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
