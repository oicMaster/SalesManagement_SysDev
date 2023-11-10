using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDetailDataAccess
    {
        public bool CheckOrDetailIDExistence(int OrDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_OrderDetails.Any(x => x.OrDetailID == OrDetailID);
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

        public bool AddOrderData(T_OrderDetail regOrD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_OrderDetails.Add(regOrD);
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

        public bool UpdateOrderDetailData(T_OrderDetail updOrD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var orderDetail = context.T_ArrivalDetails.Single(x => x.ArDetailID == updArD.ArDetailID);

                orderDetail.OrDetailID = updOrD.OrDetailID;
                orderDetail.OrID = updOrD.OrID;
                orderDetail.PrID = updOrD.PrID;
                orderDetail.OrQuantity = updOrD.OrQuantity;
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


        public List<T_OrderDetail> GetOrderDetailData()
        {
            List<T_OrderDetail> orderDetail = new List<T_OrderDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                orderDetail = context.T_OrderDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetail;
        }



        public List<T_OrderDetail> GetOrderDetailData(T_OrderDetail selectCondition)
        {
            List<T_OrderDetail> orderDetail = new List<T_OrderDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                orderDetail = context.T_OrderDetails.Where(x => x.OrDetailID == selectCondition.OrDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetail;
        }
    }
}
