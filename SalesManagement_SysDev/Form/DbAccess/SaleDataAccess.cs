using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDataAccess
    {
        public bool CheckSaIDExistence(int SaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Sales.Any(x => x.SaID ==SaID);
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

        public bool AddSaleData(T_Sale regSa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Sales.Add(regSa);
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

        public bool UpdateSaleData(T_Sale updSa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var sale = context.T_Sales.Single(x => x.SaID == updSa.SaID);

                sale.ClID = updSa.ClID;
                sale.SoID = updSa.SoID;
                sale.EmID = updSa.EmID;
                sale.ChID = updSa.ChID;
                sale.SaDate = updSa.SaDate;
                sale.SaHidden = updSa.SaHidden;
                sale.SaFlag = updSa.SaFlag;

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

        //データの取得
        public List<T_Sale> GetSaleData()
        {
            List<T_Sale> sale = new List<T_Sale>();
            try
            {
                var context = new SalesManagement_DevContext();
                sale = context.T_Sales.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sale;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Sale> GetSaleData(T_Sale selectCondition)
        {
            List<T_Sale> sale = new List<T_Sale>();
            try
            {
                var context = new SalesManagement_DevContext();
                sale = context.T_Sales.Where(x => x.SaID == selectCondition.SaID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sale;
        }



        //非表示を除いたデータの取得
        public List<T_Sale> GetSaleDspData()
        {
            List<T_Sale> sale = new List<T_Sale>();
            try
            {
                var context = new SalesManagement_DevContext();
                sale = context.T_Sales.Where(x => x.SaFlag == 2).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sale;
        }
    }
}
