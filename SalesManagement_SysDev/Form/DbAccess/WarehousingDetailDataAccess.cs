using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagement_SysDev
{
    internal class WarehousingDetailDataAccess
    {
        public bool CheckWaDetailIDExistence(int WaDetailID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_WarehousingDetails.Any(x => x.WaDetailID == WaDetailID);
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

        public bool AddWarehousingDetailData(T_WarehousingDetail regWaD)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_WarehousingDetails.Add(regWaD);
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


        public List<T_WarehousingDetail> GetWarehousingDetailData()
        {
            List<T_WarehousingDetail> warehousingDetail = new List<T_WarehousingDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    warehousingDetail = context.T_WarehousingDetails.ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousingDetail;
        }


        public List<T_WarehousingDetail> GetWarehousingDetailData(T_WarehousingDetail selectCondition,int quantityCondition)
        {
            List<T_WarehousingDetail> warehousingDetail = new List<T_WarehousingDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    warehousingDetail = context.T_WarehousingDetails.Where(x =>
                      (selectCondition.WaDetailID == 0 || x.WaDetailID == selectCondition.WaDetailID) &&
                      (selectCondition.WaID == 0 || x.WaID == selectCondition.WaID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.WaQuantity == 0 ||
                      (quantityCondition == 0 && x.WaQuantity == selectCondition.WaQuantity) ||
                      (quantityCondition == 1 && x.WaQuantity >= selectCondition.WaQuantity) ||
                      (quantityCondition == 2 && x.WaQuantity <= selectCondition.WaQuantity))
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousingDetail;
        }


        public bool ConfirmWarehousingDetailToStock(int waID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_WarehousingDetail> warehousingDetail = context.T_WarehousingDetails.Where(x => x.WaID == waID).ToList();
                    foreach (var waDetail in warehousingDetail)
                    {
                        var product = context.M_Products.Single(x => x.PrID == waDetail.PrID);
                        var stock = context.T_Stocks.Single(x => x.PrID == waDetail.PrID);
                        stock.StQuantity += waDetail.WaQuantity;
                        if (product.PrSafetyStock <= stock.StQuantity)
                            stock.StState = 0;
                        context.SaveChanges();
                    }
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

        public void GetWaQuantityData(object sender, Label Quantity)
        {

            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                int sum = 0;
                int prID = int.Parse((sender as TextBox).Text);
                using (var context = new SalesManagement_DevContext()) 
                {
                    if (context.M_Products.Any(x => x.PrID == prID))
                    {
                        List<T_WarehousingDetail> warehousingDetail = context.T_WarehousingDetails.Where(x => x.PrID == prID).ToList();
                        foreach (var waDetail in warehousingDetail)
                        {
                            sum += waDetail.WaQuantity;
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
