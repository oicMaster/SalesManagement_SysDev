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
                var context = new SalesManagement_DevContext();
                context.T_Hattyus.Add(regHa);
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

        public bool UpdateHattyuData(T_Hattyu updHa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyu = context.T_Hattyus.Single(x => x.HaID == updHa.HaID);

                hattyu.MaID = updHa.MaID;
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

        //データの取得
        public List<T_Hattyu> GetHattyuData()
        {
            List<T_Hattyu> hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyu = context.T_Hattyus.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyu;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Hattyu> GetHattyuData(T_Hattyu selectCondition)
        {
            List<T_Hattyu> hattyu = new List<T_Hattyu>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyu = context.T_Hattyus.Where(x => x.HaID == selectCondition.HaID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyu;
        }
    }
}
