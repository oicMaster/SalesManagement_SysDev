using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class WarehousingDetailDataAccess
    {
        public bool CheckWaDetailIDExistence(int WaDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_WarehousingDetails.Any(x => x.WaDetailID == WaDetailID);
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

        public bool AddWarehousingDetailData(T_WarehousingDetail regWaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_WarehousingDetails.Add(regWaD);
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

        public bool UpdateWarehousingDetailData(T_WarehousingDetail updWaD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var hattyuDetail = context.T_WarehousingDetails.Single(x => x.WaDetailID == updWaD.WaDetailID);

                hattyuDetail.WaDetailID = updWaD.WaDetailID;
                hattyuDetail.WaID = updWaD.WaID;
                hattyuDetail.PrID = updWaD.PrID;
                hattyuDetail.WaQuantity = updWaD.WaQuantity;
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


        public List<T_WarehousingDetail> GetWarehousingDetailData()
        {
            List<T_WarehousingDetail> warehousingDetail = new List<T_WarehousingDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                warehousingDetail = context.T_WarehousingDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousingDetail;
        }



        public List<T_WarehousingDetail> GetWarehousingDetailData(T_WarehousingDetail selectCondition)
        {
            List<T_WarehousingDetail> warehousingDetail = new List<T_WarehousingDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                warehousingDetail = context.T_WarehousingDetails.Where(x => x.WaDetailID == selectCondition.WaDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return warehousingDetail;
        }
    }
}
