using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDetailDataAccess
    {
        public bool CheckSaDetailIDExistence(int SaDetailID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_SaleDetails.Any(x => x.SaDetailID == SaDetailID);
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

        public bool AddSaleDetailData(T_SaleDetail regSaD)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_SaleDetails.Add(regSaD);
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


        public List<T_SaleDetail> GetSaleDetailData()
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    saleDetail = context.T_SaleDetails.ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }


        public List<T_SaleDetail> GetSaleDetailData(T_SaleDetail selectCondition,int quantityCondition,int sumCondition)
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    saleDetail = context.T_SaleDetails.Where(x =>
                    (selectCondition.SaDetailID == 0 || x.SaDetailID == selectCondition.SaDetailID) &&
                      (selectCondition.SaID == 0 || x.SaID == selectCondition.SaID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.SaQuantity == 0 ||
                      (quantityCondition == 0 && x.SaQuantity == selectCondition.SaQuantity) ||
                      (quantityCondition == 1 && x.SaQuantity >= selectCondition.SaQuantity) ||
                      (quantityCondition == 2 && x.SaQuantity <= selectCondition.SaQuantity)) &&
                      (selectCondition.SaTotalPrice == 0 ||
                      (sumCondition == 0 && x.SaTotalPrice == selectCondition.SaTotalPrice) ||
                      (sumCondition == 1 && x.SaTotalPrice >= selectCondition.SaTotalPrice) ||
                      (sumCondition == 2 && x.SaTotalPrice <= selectCondition.SaTotalPrice))
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }
    }
}
