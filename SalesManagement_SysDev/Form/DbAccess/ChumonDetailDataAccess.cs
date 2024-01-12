using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDetailDataAccess
    {
        public bool CheckChDetailIDExistence(int ChDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_ChumonDetails.Any(x => x.ChDetailID == ChDetailID);
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


        public bool AddChumonDetailData(T_ChumonDetail regChD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ChumonDetails.Add(regChD);
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

        public List<T_ChumonDetail> GetChumonDetailData()
        {
            List<T_ChumonDetail> chumonDetail = new List<T_ChumonDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumonDetail = context.T_ChumonDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumonDetail;
        }


        public List<T_ChumonDetail> GetChumonDetailData(T_ChumonDetail selectCondition,int quantityCondition)
        {
            List<T_ChumonDetail> chumonDetail = new List<T_ChumonDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumonDetail = context.T_ChumonDetails.Where(x =>
                  (selectCondition.ChDetailID == 0 || x.ChDetailID == selectCondition.ChDetailID) &&
                  (selectCondition.ChID == 0 || x.ChID == selectCondition.ChID) &&
                  (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                  (selectCondition.ChQuantity == 0 ||
                  (quantityCondition == 0 && x.ChQuantity == selectCondition.ChQuantity) ||
                  (quantityCondition == 1 && x.ChQuantity >= selectCondition.ChQuantity) ||
                  (quantityCondition == 2 && x.ChQuantity <= selectCondition.ChQuantity))
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumonDetail;
        }

        public bool ConfirmChumonDetailToSyukkoDetail(int chID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_ChumonDetail> chumonDetail = context.T_ChumonDetails.Where(x => x.ChID == chID).ToList();

                    foreach (var chDetail in chumonDetail)
                    {
                        var syukkoDetail = new T_SyukkoDetail
                        {
                            SyID = chID,
                            PrID = chDetail.PrID,
                            SyQuantity = chDetail.ChQuantity,
                        };
                        context.T_SyukkoDetails.Add(syukkoDetail);
                       
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
