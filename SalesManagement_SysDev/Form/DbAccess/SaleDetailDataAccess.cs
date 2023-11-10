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
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_SaleDetails.Any(x => x.SaDetailID == SaDetailID);
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

        public bool AddSaleDetailData(T_SaleDetail regSaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SaleDetails.Add(regSaD);
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

        public bool UpdateSaleDetailData(T_SaleDetail updSaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var saleDetail = context.T_SaleDetails.Single(x => x.SaDetailID == updSaD.SaDetailID);

                saleDetail.SaDetailID = updSaD.SaDetailID;
                saleDetail.SaID = updSaD.SaID;
                saleDetail.PrID = updSaD.PrID;
                saleDetail.SaQuantity = updSaD.SaQuantity;
                saleDetail.SaTotalPrice = updSaD.SaTotalPrice;
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


        public List<T_SaleDetail> GetSaleDetailData()
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                saleDetail = context.T_SaleDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }



        public List<T_SaleDetail> GetSaleDetailData(T_SaleDetail selectCondition)
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                saleDetail = context.T_SaleDetails.Where(x => x.SaDetailID == selectCondition.SaDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }
    }
}
