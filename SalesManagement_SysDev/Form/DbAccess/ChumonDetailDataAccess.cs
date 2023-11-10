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

        public bool UpdateChumonDetailData(T_ChumonDetail updChD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumonDetail = context.T_ChumonDetails.Single(x => x.ChDetailID == updChD.ChDetailID);

                chumonDetail.ChDetailID = updChD.ChDetailID;
                chumonDetail.ChID = updChD.ChID;
                chumonDetail.PrID = updChD.PrID;
                chumonDetail.ChQuantity = updChD.ChQuantity;
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



        public List<T_ChumonDetail> GetChumonDetailData(T_ChumonDetail selectCondition)
        {
            List<T_ChumonDetail> chumonDetail = new List<T_ChumonDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumonDetail = context.T_ChumonDetails.Where(x => x.ChDetailID == selectCondition.ChDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumonDetail;
        }
    }
}
