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

                if (updWa.WaID != 0)
                    warehousing.WaID = updWa.WaID;
                if (updWa.HaID != 0)
                    warehousing.HaID = updWa.HaID;
                if (updWa.EmID != 0)
                    warehousing.EmID = updWa.EmID;
                if (updWa.WaDate != null)
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
        public T_Warehousing GenerateDataAdError()
        {
            var context = new SalesManagement_DevContext();
            var warehousing = context.T_Warehousings.Max(x => x.WaID);

            return new T_Warehousing
            {
                WaID = warehousing,
                HaID = 0,
                EmID = 0,
                WaDate = null,
                WaShelfFlag = 0,
                WaFlag = 2,
                WaHidden = "SystemError"
            };
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
                  (selectCondition.WaDate == null ||
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

        public void GetWarehousingFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Warehousing> warehousing = new List<T_Warehousing>();


            if (CheckWaIDExistence(int.Parse((sender as TextBox).Text)))
            {

                var context = new SalesManagement_DevContext();
                warehousing = context.T_Warehousings.ToList();
                var data = warehousing.Single(x => x.WaID == int.Parse((sender as TextBox).Text));
                confirm.Text = data.WaShelfFlag.ToString();
                hidden.Text = data.WaFlag.ToString();
                context.Dispose();
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }
    }
}
