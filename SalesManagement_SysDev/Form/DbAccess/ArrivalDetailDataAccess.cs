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
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_ArrivalDetails.Any(x => x.ArDetailID == ArDetailID);
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

        public bool UpdateArrivalDetailData(T_ArrivalDetail updArD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var arrivalDetail = context.T_ArrivalDetails.Single(x => x.ArDetailID == updArD.ArDetailID);

                arrivalDetail.ArDetailID = updArD.ArDetailID;
                arrivalDetail.ArID = updArD.ArID;
                arrivalDetail.PrID = updArD.PrID;
                arrivalDetail.ArQuantity = updArD.ArQuantity;
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


        public List<T_ArrivalDetail> GetArrivalDetailData()
        {
            List<T_ArrivalDetail> arrivalDetail = new List<T_ArrivalDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrivalDetail = context.T_ArrivalDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrivalDetail;
        }



        public List<T_ArrivalDetail> GetArrivalDetailData(T_ArrivalDetail selectCondition)
        {
            List<T_ArrivalDetail> arrivalDetail = new List<T_ArrivalDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                arrivalDetail = context.T_ArrivalDetails.Where(x => x.ArDetailID == selectCondition.ArDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrivalDetail;
        }
    }
}
