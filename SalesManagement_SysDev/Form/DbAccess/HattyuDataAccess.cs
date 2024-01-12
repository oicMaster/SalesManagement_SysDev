using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class HattyuDataAccess
    {
        public bool CheckHaIDExistence(int HaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Hattyus.Any(x => x.HaID == HaID);
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

        public bool AddHattyuData(T_Hattyu regHa)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Hattyus.Add(regHa);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateHattyuData(T_Hattyu updHa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Single(x => x.HaID == updHa.HaID);
                if (updHa.MaID != 0)
                    hattyu.MaID = updHa.MaID;
                if (updHa.EmID != 0)
                    hattyu.EmID = updHa.EmID;
                hattyu.WaWarehouseFlag = updHa.WaWarehouseFlag;
                hattyu.HaFlag = updHa.HaFlag;
                hattyu.HaHidden = updHa.HaHidden;

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

        public T_Hattyu GenerateDataAdError()
        {
            var context = new SalesManagement_DevContext();
            var hattyu = context.T_Hattyus.Max(x => x.HaID);

            return new T_Hattyu
            {
                HaID = hattyu,
                MaID = 0,
                EmID = 0,
                HaDate = null,
                WaWarehouseFlag = 0,
                HaFlag = 2,
                HaHidden = "SystemError"
            };
        }

        //データの取得
        public List<T_Hattyu> GetHattyuData()
        {
            List<T_Hattyu> hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyu = context.T_Hattyus.Where(x => x.WaWarehouseFlag == 0 && x.HaFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyu;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Hattyu> GetHattyuData(T_Hattyu selectCondition,int dateCondition)
        {
            List<T_Hattyu> hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyu = context.T_Hattyus.Where(x =>
                  (selectCondition.HaID == 0 || x.HaID == selectCondition.HaID) &&
                  (selectCondition.MaID == 0 || x.MaID == selectCondition.MaID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.HaDate == null ||
                  (dateCondition == 0 && x.HaDate == selectCondition.HaDate) ||
                  (dateCondition == 1 && x.HaDate >= selectCondition.HaDate) ||
                  (dateCondition == 2 && x.HaDate <= selectCondition.HaDate)) &&
                  (selectCondition.WaWarehouseFlag == 3 || x.WaWarehouseFlag == selectCondition.WaWarehouseFlag) &&
                  (selectCondition.HaFlag == 3 || x.HaFlag == selectCondition.HaFlag)
                  ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyu;
        }

        public int GetHattyuIDData()
        {
            int HaID = 0;
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Max(x => x.HaID);
                HaID = hattyu;
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return HaID;
        }

        public void GetHattyuFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Hattyu> hattyu = new List<T_Hattyu>();


            if (CheckHaIDExistence(int.Parse((sender as TextBox).Text)))
            {

                var context = new SalesManagement_DevContext();
                hattyu = context.T_Hattyus.ToList();
                var data = hattyu.Single(x => x.HaID == int.Parse((sender as TextBox).Text));
                confirm.Text = data.WaWarehouseFlag.ToString();
                hidden.Text = data.HaFlag.ToString();
                context.Dispose();
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }


 


        public bool ConfirmHattyuToWarehousing(int haID, int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var hattyu = context.T_Hattyus.Single(x => x.HaID == haID);

                    var warehousing = new T_Warehousing
                    {
                        HaID = haID,
                        EmID = emID,
                        WaDate = null,
                        WaShelfFlag = 0,
                        WaFlag = 0,
                        WaHidden = null
                    };
                    context.T_Warehousings.Add(warehousing);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
