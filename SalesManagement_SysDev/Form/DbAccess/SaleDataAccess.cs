using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    internal class SaleDataAccess
    {
        public bool CheckSaIDExistence(int SaID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_Sales.Any(x => x.SaID == SaID);
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

        public bool AddSaleData(T_Sale regSa)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Sales.Add(regSa);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public T_Sale GenerateDataAdError()
        {
            using (var context = new SalesManagement_DevContext())
            {
                var sale = context.T_Sales.Max(x => x.SaID);

                return new T_Sale
                {
                    SaID = sale,
                    SoID = 0,
                    EmID = 0,
                    ClID = 0,
                    ChID = 0,
                    SaDate = null,
                    SaFlag = 2,
                    SaHidden = "SystemError"
                };
            }
        }



        public bool UpdateSaleData(T_Sale updSa)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var sale = context.T_Sales.Single(x => x.SaID == updSa.SaID);
                    if (updSa.SoID != 0)
                        sale.SoID = updSa.SoID;
                    if (updSa.EmID != 0)
                        sale.EmID = updSa.EmID;
                    if (updSa.ClID != 0)
                        sale.ClID = updSa.ClID;
                    if (updSa.ChID != 0)
                        sale.ChID = updSa.ChID;
                    if (updSa.SaDate != null)
                        sale.SaDate = updSa.SaDate;
                    sale.SaHidden = updSa.SaHidden;
                    sale.SaFlag = updSa.SaFlag;

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


        //データの取得
        public List<T_Sale> GetSaleData()
        {
            List<T_Sale> sale = new List<T_Sale>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    sale = context.T_Sales.Where(x => x.SaFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sale;
        }


        //条件一致したデータの取得　オーバーロード
        public List<T_Sale> GetSaleData(T_Sale selectCondition,int dateCondition)
        {
            List<T_Sale> sale = new List<T_Sale>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    sale = context.T_Sales.Where(x =>
                      (selectCondition.SaID == 0 || x.SaID == selectCondition.SaID) &&
                      (selectCondition.ChID == 0 || x.ChID == selectCondition.ChID) &&
                      (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                      (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                      (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                      (selectCondition.SaDate == null ||
                      (dateCondition == 0 && DbFunctions.TruncateTime(x.SaDate) == DbFunctions.TruncateTime( selectCondition.SaDate)) ||
                      (dateCondition == 1 && DbFunctions.TruncateTime(x.SaDate )>= DbFunctions.TruncateTime (selectCondition.SaDate))||
                      (dateCondition == 2 && DbFunctions.TruncateTime(x.SaDate) <= DbFunctions.TruncateTime(selectCondition.SaDate))) &&
                      (selectCondition.SaFlag == 3 || x.SaFlag == selectCondition.SaFlag)
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sale;
        }

        public void GetSaleFlagData(object sender, TextBox hidden)
        {
            List<T_Sale> sale = new List<T_Sale>();


            if (CheckSaIDExistence(int.Parse((sender as TextBox).Text)))
            {

                using (var context = new SalesManagement_DevContext())
                {
                    sale = context.T_Sales.ToList();
                    var data = sale.Single(x => x.SaID == int.Parse((sender as TextBox).Text));
                    hidden.Text = data.SaFlag.ToString();
                    context.Dispose();
                }
                return;
            }
            hidden.Text = "------";
        }
    }
}
