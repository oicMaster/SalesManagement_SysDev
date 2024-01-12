using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDetailDataAccess
    {
        public bool CheckShDetailIDExistence(int ShDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_ShipmentDetails.Any(x => x.ShDetailID == ShDetailID);
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

        public bool AddShipmentDetailData(T_ShipmentDetail regShD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ShipmentDetails.Add(regShD);
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
        public List<T_ShipmentDetail> GetShipmentDetailData()
        {
            List<T_ShipmentDetail> shipmentDetail = new List<T_ShipmentDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                shipmentDetail = context.T_ShipmentDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipmentDetail;
        }


        public List<T_ShipmentDetail> GetShipmentDetailData(T_ShipmentDetail selectCondition,int quantityCondition)
        {
            List<T_ShipmentDetail> shipmentDetail = new List<T_ShipmentDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                shipmentDetail = context.T_ShipmentDetails.Where(x =>
                  (selectCondition.ShDetailID == 0 || x.ShDetailID == selectCondition.ShDetailID) &&
                  (selectCondition.ShID == 0 || x.ShID == selectCondition.ShID) &&
                  (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                  (selectCondition.ShQuantity == 0 ||
                  (quantityCondition == 0 && x.ShQuantity == selectCondition.ShQuantity) ||
                  (quantityCondition == 1 && x.ShQuantity >= selectCondition.ShQuantity) ||
                  (quantityCondition == 2 && x.ShQuantity <= selectCondition.ShQuantity))
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipmentDetail;
        }

        public bool ConfirmShipmentDetailToSaleDetail(int shID)
        {

            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_ShipmentDetail> shipmentDetail = context.T_ShipmentDetails.Where(x => x.ShID == shID).ToList();

                    foreach (var shDetail in shipmentDetail)
                    {
                        var product = context.M_Products.SingleOrDefault(a => a.PrID == shDetail.PrID);
                        var saleDetail = new T_SaleDetail
                        {
                            SaID = shDetail.ShID,
                            PrID = shDetail.PrID,
                            SaQuantity = shDetail.ShQuantity,
                            SaTotalPrice = shDetail.ShQuantity * product.Price
                        };
                        context.T_SaleDetails.Add(saleDetail);
                        context.SaveChanges();
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
    }
}
