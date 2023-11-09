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
