using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class HattyuDetailDataAccess
    {
        public bool CheckHaDetailIDExistence(int HaDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_HattyuDetails.Any(x => x.HaDetailID == HaDetailID);
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

        public bool AddHattyuDetailData(T_HattyuDetail regHaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_HattyuDetails.Add(regHaD);
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

        public bool UpdateHattyuDetailData(T_HattyuDetail updHaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyuDetail = context.T_HattyuDetails.Single(x => x.HaDetailID == updHaD.HaDetailID);

                hattyuDetail.HaDetailID = updHaD.HaDetailID;
                hattyuDetail.HaID = updHaD.HaID;
                hattyuDetail.PrID = updHaD.PrID;
                hattyuDetail.HaQuantity = updHaD.HaQuantity;
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


        public List<T_HattyuDetail> GetHattyuDetailData()
        {
            List<T_HattyuDetail> hattyuDetail = new List<T_HattyuDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyuDetail = context.T_HattyuDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyuDetail;
        }

        public List<T_HattyuDetail> GetHattyuDetailData(T_HattyuDetail selectCondition,int quantityCondition)
        {
            List<T_HattyuDetail> hattyuDetail = new List<T_HattyuDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                hattyuDetail = context.T_HattyuDetails.Where(x =>
                  (selectCondition.HaDetailID == 0 || x.HaDetailID == selectCondition.HaDetailID) &&
                  (selectCondition.HaID == 0 || x.HaID == selectCondition.HaID) &&
                  (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                  (selectCondition.HaQuantity == 0 ||
                  (quantityCondition == 0 && x.HaQuantity == selectCondition.HaQuantity) ||
                  (quantityCondition == 1 && x.HaQuantity >= selectCondition.HaQuantity) ||
                  (quantityCondition == 2 && x.HaQuantity <= selectCondition.HaQuantity))
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hattyuDetail;
        }

        public bool ConfirmHattyuDetailToWarehousingDetail(int haID)
        {

            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_HattyuDetail> hattyuDetail = context.T_HattyuDetails.Where(x => x.HaID == haID).ToList();

                    foreach (var haDetail in hattyuDetail)
                    {
                        var warehousingDetail = new T_WarehousingDetail
                        {
                            WaID = haID,
                            PrID = haDetail.PrID,
                            WaQuantity = haDetail.HaQuantity
                        };
                        context.T_WarehousingDetails.Add(warehousingDetail);
                      
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

        
      
    }
}
