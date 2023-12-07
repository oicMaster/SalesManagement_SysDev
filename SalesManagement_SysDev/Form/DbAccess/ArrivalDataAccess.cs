using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDataAccess
    {
        public bool CheckArIDExistence(int ArID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Arrivals.Any(x => x.ArID == ArID);
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

        public bool AddArrivalData(T_Arrival regAr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Arrivals.Add(regAr);
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

        public bool UpdateArrivalData(T_Arrival updAr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var arrival = context.T_Arrivals.Single(x => x.ArID == updAr.ArID);

                arrival.SoID = updAr.SoID;
                arrival.EmID = updAr.EmID;
                arrival.ClID = updAr.ClID;
                arrival.OrID = updAr.OrID;
                arrival.ArDate = updAr.ArDate;
                arrival.ArStateFlag = updAr.ArStateFlag;
                arrival.ArFlag = updAr.ArFlag;
                arrival.ArHidden = updAr.ArHidden;

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

        public List<T_Arrival> GetArrivalData()
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrival = context.T_Arrivals.Where(x => x.ArStateFlag == 0 && x.ArFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Arrival> GetArrivalData(T_Arrival selectCondition,int dateCondition)
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrival = context.T_Arrivals.Where(x =>
                  (selectCondition.ArID == 0 || x.ArID == selectCondition.ArID) && 
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) && 
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) && 
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) && 
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.ArDate == null||
                  (dateCondition == 0 && x.ArDate == selectCondition.ArDate) || 
                  (dateCondition == 1 && x.ArDate >= selectCondition.ArDate)||
                  (dateCondition == 2 && x.ArDate <= selectCondition.ArDate)) &&
                  (selectCondition.ArStateFlag == 3 || x.ArStateFlag == selectCondition.ArStateFlag) && 
                  (selectCondition.ArFlag == 3 || x.ArFlag == selectCondition.ArFlag)
                  ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }
    }

}
