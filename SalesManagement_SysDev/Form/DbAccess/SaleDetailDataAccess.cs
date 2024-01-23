using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SaleDetailDataAccess
    {
        public bool CheckSaDetailIDExistence(int SaDetailID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_SaleDetails.Any(x => x.SaDetailID == SaDetailID);
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

        public bool AddSaleDetailData(T_SaleDetail regSaD)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_SaleDetails.Add(regSaD);
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


        public List<T_SaleDetail> GetSaleDetailData()
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    saleDetail = context.T_SaleDetails.ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }


        public List<T_SaleDetail> GetSaleDetailData(T_SaleDetail selectCondition,int quantityCondition,int sumCondition)
        {
            List<T_SaleDetail> saleDetail = new List<T_SaleDetail>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    saleDetail = context.T_SaleDetails.Where(x =>
                    (selectCondition.SaDetailID == 0 || x.SaDetailID == selectCondition.SaDetailID) &&
                      (selectCondition.SaID == 0 || x.SaID == selectCondition.SaID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.SaQuantity == 0 ||
                      (quantityCondition == 0 && x.SaQuantity == selectCondition.SaQuantity) ||
                      (quantityCondition == 1 && x.SaQuantity >= selectCondition.SaQuantity) ||
                      (quantityCondition == 2 && x.SaQuantity <= selectCondition.SaQuantity)) &&
                      (selectCondition.SaTotalPrice == 0 ||
                      (sumCondition == 0 && x.SaTotalPrice == selectCondition.SaTotalPrice) ||
                      (sumCondition == 1 && x.SaTotalPrice >= selectCondition.SaTotalPrice) ||
                      (sumCondition == 2 && x.SaTotalPrice <= selectCondition.SaTotalPrice))
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saleDetail;
        }



        public void SumSale(int year,int month,int day,ComboBox cmbSum,Label lblSumPrice)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                  
                    int sum = 0;
                    int count = 0;
                    switch (cmbSum.Text)
                    {
                        case "日間総売上":
                            List<T_Sale> saleD = context.T_Sales.Where(x => x.SaFlag == 0 && x.SaDate.Value.Year == year && x.SaDate.Value.Month == month && x.SaDate.Value.Day == day).ToList();
                            foreach (var ExistSale in saleD)
                            {
                                count += 1;
                                List<T_SaleDetail> saleDetail = context.T_SaleDetails.Where(x => x.SaID == ExistSale.SaID).ToList();
                                foreach (var saDetail in saleDetail)
                                {

                                    sum += (int)saDetail.SaTotalPrice;
                                }
                            }
                            break;
                        case "月間総売上":
                            List<T_Sale> saleM = context.T_Sales.Where(x => x.SaFlag == 0&&x.SaDate.Value.Year == year&&x.SaDate.Value.Month == month).ToList();
                            foreach (var ExistSale in saleM)
                            {
                                count += 1;
                                List<T_SaleDetail> saleDetail = context.T_SaleDetails.Where(x => x.SaID == ExistSale.SaID).ToList();
                                foreach (var saDetail in saleDetail)
                                {
                                    sum += (int)saDetail.SaTotalPrice;
                                }
                            }
                            break;
                        case "年間総売上":
                            List<T_Sale> saleY = context.T_Sales.Where(x => x.SaFlag == 0 && x.SaDate.Value.Year == year).ToList();
                            foreach (var ExistSale in saleY)
                            {
                                count += 1;
                                List<T_SaleDetail> saleDetail = context.T_SaleDetails.Where(x => x.SaID == ExistSale.SaID).ToList();
                                foreach (var saDetail in saleDetail)
                                {
                                    sum += (int)saDetail.SaTotalPrice;
                                }
                            }
                            break;
                        case "条件内総売上":
                            lblSumPrice.Text = "[___件:___円]";
                            return;
                    }
                    string formattedValue ="["+count +"件:"+  $"{sum:N0}円]";
                    lblSumPrice.Text = formattedValue;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchPrice(List<T_Sale> dataList, Label lblSumPrice)
        {
            int sum = 0;
            int count = 0;
            using (var context = new SalesManagement_DevContext())
            {
                foreach (var ExistSale in dataList)
                {
                    count += 1;
                    List<T_SaleDetail> saleDetail = context.T_SaleDetails.Where(x => x.SaID == ExistSale.SaID).ToList();
                    foreach (var saDetail in saleDetail)
                    {
                        sum += (int)saDetail.SaTotalPrice;
                    }
                }
            }
            string formattedValue = "[" + count + "件:" + $"{sum:N0}円]";
            lblSumPrice.Text = formattedValue;
        }
    }
}
