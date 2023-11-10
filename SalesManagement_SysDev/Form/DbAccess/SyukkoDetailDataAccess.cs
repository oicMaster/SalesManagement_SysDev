using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDetailDataAccess
    {
        public bool CheckSyDetailIDExistence(int SyDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_SyukkoDetails.Any(x => x.SyDetailID == SyDetailID);
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

        public bool AddSyukkoData(T_SyukkoDetail regSyD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_SyukkoDetails.Add(regSyD);
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

        public bool UpdateSyukkoDetailData(T_SyukkoDetail updSyD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var syukkoDetail = context.T_SyukkoDetails.Single(x => x.SyDetailID == updSyD.SyDetailID);

                syukkoDetail.SyDetailID = updSyD.SyDetailID;
                syukkoDetail.SyID = updSyD.SyID;
                syukkoDetail.PrID = updSyD.PrID;
                syukkoDetail.SyQuantity = updSyD.SyQuantity;
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


        public List<T_SyukkoDetail> GetSyukkoDetailData()
        {
            List<T_SyukkoDetail> syukkoDetail = new List<T_SyukkoDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukkoDetail = context.T_SyukkoDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkoDetail;
        }



        public List<T_SyukkoDetail> GetSyukkoDetailData(T_SyukkoDetail selectCondition)
        {
            List<T_SyukkoDetail> syukkoDetail = new List<T_SyukkoDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukkoDetail = context.T_SyukkoDetails.Where(x => x.SyDetailID == selectCondition.SyDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukkoDetail;
        }
    }
}
