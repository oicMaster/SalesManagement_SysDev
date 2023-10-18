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

        //データの取得
        public List<T_Arrival> GetArrivalData()
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrival = context.T_Arrivals.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Arrival> GetArrivalData(T_Arrival selectCondition)
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrival = context.T_Arrivals.Where(x => x.ArID == selectCondition.ArID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }



        //非表示を除いたデータの取得
        public List<T_Arrival> GetArrivalDspData()
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrival = context.T_Arrivals.Where(x => x.ArFlag == 2).ToList();
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
