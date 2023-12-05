using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDataAccess
    {
        public bool CheckOrIDExistence(int OrID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Orders.Any(x => x.OrID == OrID);
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

        public bool AddOrderData(T_Order regOr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Orders.Add(regOr);
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

        public bool UpdateOrderData(T_Order updOr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Single(x => x.OrID == updOr.OrID);

                order.SoID = updOr.SoID;
                order.EmID = updOr.EmID;
                order.ClID = updOr.ClID;
                order.ClCharge = updOr.ClCharge;
                order.OrDate = updOr.OrDate;
                order.OrStateFlag = updOr.OrStateFlag;
                order.OrFlag = updOr.OrFlag;
                order.OrHidden = updOr.OrHidden;

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
        public List<T_Order> GetOrderData()
        {
            List<T_Order> order = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x => x.OrStateFlag == 0 && x.OrFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Order> GetOrderData(T_Order selectCondition,int dateCondition)
        {
            List<T_Order> order = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                  (selectCondition.ClCharge == null|| x.ClCharge == selectCondition.ClCharge)&&
                  (selectCondition.OrDate == DateTime.Parse("0001/01/01") ||
                  (dateCondition == 0 && x.OrDate == selectCondition.OrDate) ||
                  (dateCondition == 1 && x.OrDate >= selectCondition.OrDate) ||
                  (dateCondition == 2 && x.OrDate <= selectCondition.OrDate)) &&
                  (selectCondition.OrStateFlag == 3 || x.OrStateFlag == selectCondition.OrStateFlag) &&
                  (selectCondition.OrFlag == 3 || x.OrFlag == selectCondition.OrFlag)
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
    }
}
