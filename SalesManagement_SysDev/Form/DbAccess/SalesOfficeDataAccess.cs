using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SalesOfficeDataAccess
    {
        public bool CheckSoIDExistence(int SoID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();

                flg = context.M_SalesOffices.Any(x => x.SoID == SoID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                //エラーメッセージ(基本形)
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

         public bool AddSaleDetailData(M_SalesOffice regSo)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_SalesOffices.Add(regSo);
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

        public bool AddSaleData(M_SalesOffice regSo)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_SalesOffices.Add(regSo);
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

        public bool UpdateSaleData(M_SalesOffice updSo)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var sale = context.M_SalesOffices.Single(x => x.SoID == updSo.SoID);

                sale.SoName = updSo.SoName;
                sale.SoAddress = updSo.SoAddress;
                sale.SoPhone = updSo.SoPhone;
                sale.SoPostal = updSo.SoPostal;
                sale.SoFAX = updSo.SoFAX;
                sale.SoFlag = updSo.SoFlag;
                sale.SoHidden = updSo.SoHidden;

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
        public List<M_SalesOffice> GetSaleData()
        {
            List<M_SalesOffice> salesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                salesOffice = context.M_SalesOffices.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesOffice;
        }

        //条件一致したデータの取得　オーバーロード
        public List<M_SalesOffice> GetSaleData(M_SalesOffice selectCondition)
        {
            List<M_SalesOffice> salesOffices = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                salesOffices = context.M_SalesOffices.Where(x => x.SoID == selectCondition.SoID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesOffices;
        }
        //public bool AddSalesOfficeData(M_SalesOffice regSo)
        //public bool UpdateSalesOfficeData(M_SalesOffice updSo)
        //public List<M_SalesOffice> GetSalesOfficeData()
        //public List<M_SalesOffice> GetSalesOfficeData(M_SalesOffice selectCondition)
    }
}
