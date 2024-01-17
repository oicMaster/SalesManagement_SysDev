using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDetailDataAccess
    {
        public bool CheckArDetailIDExistence(int ArDetailID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_ArrivalDetails.Any(x => x.ArDetailID == ArDetailID);
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


        public bool AddArrivalDetailData(T_ArrivalDetail regArD)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_ArrivalDetails.Add(regArD);
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

        public List<T_ArrivalDetail> GetArrivalDetailData()
        {
            List<T_ArrivalDetail> arrivalDetail = new List<T_ArrivalDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    arrivalDetail = context.T_ArrivalDetails.ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrivalDetail;
        }


        public List<T_ArrivalDetail> GetArrivalDetailData(T_ArrivalDetail selectCondition,int quantityCondition)
        {
            List<T_ArrivalDetail> arrivalDetail = new List<T_ArrivalDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    arrivalDetail = context.T_ArrivalDetails.Where(x =>
                      (selectCondition.ArDetailID == 0 || x.ArDetailID == selectCondition.ArDetailID) &&
                      (selectCondition.ArID == 0 || x.ArID == selectCondition.ArID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.ArQuantity == 0 ||
                      (quantityCondition == 0 && x.ArQuantity == selectCondition.ArQuantity) ||
                      (quantityCondition == 1 && x.ArQuantity >= selectCondition.ArQuantity) ||
                      (quantityCondition == 2 && x.ArQuantity <= selectCondition.ArQuantity))
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrivalDetail;
        }

        public bool ConfirmArrialDetailToShipmentDetail(int arID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    List<T_ArrivalDetail> arrivalDetail = context.T_ArrivalDetails.Where(x => x.ArID == arID).ToList();

                    foreach (var arDetail in arrivalDetail)
                    {
                        var shipmentDetail = new T_ShipmentDetail
                        {
                            ShID = arID,
                            PrID = arDetail.PrID,
                            ShQuantity = arDetail.ArQuantity,
                        };
                        context.T_ShipmentDetails.Add(shipmentDetail);
                 
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
