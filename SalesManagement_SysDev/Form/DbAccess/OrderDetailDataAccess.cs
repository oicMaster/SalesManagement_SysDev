using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagement_SysDev
{
    internal class OrderDetailDataAccess
    {
        public bool CheckOrDetailIDExistence(int OrDetailID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_OrderDetails.Any(x => x.OrDetailID == OrDetailID);
                    //DB更新
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                //エラーメッセージ(基本形)
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        public bool AddOrderDetailData(T_OrderDetail regOrD)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_OrderDetails.Add(regOrD);
                    context.SaveChanges();
                    context.Dispose();
                }
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
                using (var context = new SalesManagement_DevContext())
                {
                    orderDetail = context.T_OrderDetails.ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetail;
        }



        public List<T_OrderDetail> GetOrderDetailData(T_OrderDetail selectCondition, int quantityCondition,int sumCondition)
        {
            List<T_OrderDetail> orderDetail = new List<T_OrderDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    orderDetail = context.T_OrderDetails.Where(x =>
                      (selectCondition.OrDetailID == 0 || x.OrDetailID == selectCondition.OrDetailID) &&
                      (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.OrQuantity == 0 ||
                      (quantityCondition == 0 && x.OrQuantity == selectCondition.OrQuantity) ||
                      (quantityCondition == 1 && x.OrQuantity >= selectCondition.OrQuantity) ||
                      (quantityCondition == 2 && x.OrQuantity <= selectCondition.OrQuantity)) &&
                      (selectCondition.OrTotalPrice == 0 ||
                      (sumCondition == 0 && x.OrTotalPrice == selectCondition.OrTotalPrice) ||
                      (sumCondition == 1 && x.OrTotalPrice >= selectCondition.OrTotalPrice) ||
                      (sumCondition == 2 && x.OrTotalPrice <= selectCondition.OrTotalPrice))
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetail;
        }

        public bool ConfirmOrderDetailToChumonDetail(int orID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_OrderDetail> orderDetail = context.T_OrderDetails.Where(x => x.OrID == orID).ToList();

                    foreach (var orDetail in orderDetail)
                    {
                        var chumonDetail = new T_ChumonDetail
                        {
                            ChID = orID,
                            PrID = orDetail.PrID,
                            ChQuantity = orDetail.OrQuantity,
                        };
                        context.T_ChumonDetails.Add(chumonDetail);

                    }

                   
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

        public bool ConfirmOrderAndUpdateStock(int orID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_OrderDetail> orderDetail = context.T_OrderDetails.Where(x => x.OrID == orID).ToList();

                    foreach (var orDetail in orderDetail)
                    {
                        var product = context.M_Products.Single(x => x.PrID == orDetail.PrID);
                        var stock = context.T_Stocks.Single(x => x.PrID == orDetail.PrID);
                        stock.StQuantity -= orDetail.OrQuantity;
                        if (product.PrSafetyStock > stock.StQuantity)
                            stock.StState = 1;
                        context.SaveChanges();
                    }
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












        public bool CheckDuplicateOrderDetail(int orID, int PrID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_OrderDetail> orderDetail = context.T_OrderDetails.Where(x => x.OrID == orID).ToList();

                    foreach (var orDetail in orderDetail)
                    {
                        if (orDetail.PrID == PrID)
                            return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckStock(int orID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_OrderDetail> orderDetail = context.T_OrderDetails.Where(x => x.OrID == orID).ToList();

                    foreach (var orDetail in orderDetail)
                    {
                        var stock = context.T_Stocks.Single(x => x.PrID == orDetail.PrID);
                        if (orDetail.OrQuantity > stock.StQuantity)
                            return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void GetOrQuantityData(object sender, Label Quantity)
        {

            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                int sum = 0;
                int prID = int.Parse((sender as TextBox).Text);
                using (var context = new SalesManagement_DevContext())
                {
                    if (context.M_Products.Any(x => x.PrID == prID))
                    {
                        List<T_OrderDetail> orderDetail = context.T_OrderDetails.Where(x => x.PrID == prID).ToList();
                        foreach (var orDetail in orderDetail)
                        {
                            sum += orDetail.OrQuantity;
                        }
                        context.Dispose();
                        Quantity.Text = sum.ToString();
                        return;
                    }
                }
            }
            Quantity.Text = "----";
        }
    }
}
