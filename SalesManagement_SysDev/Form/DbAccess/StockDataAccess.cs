using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class StockDataAccess
    {
        public bool CheckStIDExistence(int prID)//コード有無の確認
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //在庫IDと一致するデータがあるかどうか
                    flg = context.T_Stocks.Any(x => x.PrID == prID);
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
        public bool AddStockData(T_Stock regPr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Stocks.Add(regPr);
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


        public bool UpdateStockData(T_Stock updSt)//更新
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var stock = context.T_Stocks.Single(x => x.PrID == updSt.PrID);
                    if (updSt.StQuantity != -1)
                        stock.StQuantity = updSt.StQuantity;
                    if (updSt.StState != -1)
                        stock.StState = updSt.StState;
                    stock.StFlag = updSt.StFlag;
                    stock.StHidden = updSt.StHidden;

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

        public List<T_Stock> GetStockData()//データ取得
        {
            List<T_Stock> stock = new List<T_Stock>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    stock = context.T_Stocks.Where(x => x.StFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return stock;
        }

        public void GetStockFlagData(object sender, TextBox hidden,TextBox state)
        {
            List<T_Stock> stock = new List<T_Stock>();

            if (CheckStIDExistence(int.Parse((sender as TextBox).Text)))
            {
                using (var context = new SalesManagement_DevContext())
                {
                    stock = context.T_Stocks.ToList();
                    var data = stock.Single(x => x.PrID == int.Parse((sender as TextBox).Text));
                    hidden.Text = data.StFlag.ToString();
                    state.Text = data.StState.ToString();
                    context.Dispose();
                }
                return;
            }
            hidden.Text = "------";
            state.Text = "--------";
        }
        public int GetFlagAndStockCheck(TextBox prID, int chk)
        {
            List<T_Stock> stock = new List<T_Stock>();
            stock = GetStockData();
            var data = stock.Single(x => x.PrID == int.Parse(prID.Text));
                if (chk == 0)
                return data.StFlag;
            else
                return data.StQuantity;
        }



        public void GetStockValueData(TextBox txbPrID, TextBox Quantity,Label stockValue,int chk)
        {
            using (var context = new SalesManagement_DevContext())
            {
                bool flg = false;
                if (!String.IsNullOrEmpty(txbPrID.Text))
                {
                    int prID = int.Parse(txbPrID.Text);
                    flg = context.T_Stocks.Any(x => x.PrID == prID);
                    if (flg)
                    {
                        var stock = context.T_Stocks.Single(x => x.PrID == prID);
                        stockValue.Text = stock.StQuantity.ToString();
                        switch (chk)
                        {
                            case 0:
                                if (!String.IsNullOrEmpty(Quantity.Text))
                                {
                                    if (int.Parse(Quantity.Text) > int.Parse(stockValue.Text))
                                        stockValue.ForeColor = System.Drawing.Color.Red;
                                    else
                                        stockValue.ForeColor = System.Drawing.Color.Black;
                                }
                                else
                                    stockValue.ForeColor = System.Drawing.Color.Black;
                                break;

                            case 1:
                                var product = context.M_Products.Single(x => x.PrID == prID);
                                if (int.Parse(stockValue.Text) < product.PrSafetyStock)
                                    stockValue.ForeColor = System.Drawing.Color.Red;
                                else
                                    stockValue.ForeColor = System.Drawing.Color.Black;
                                if (!String.IsNullOrEmpty(Quantity.Text))
                                {
                                    if (int.Parse(stockValue.Text) + int.Parse(Quantity.Text) < product.PrSafetyStock)
                                        stockValue.ForeColor = System.Drawing.Color.Red;
                                    else
                                        stockValue.ForeColor = System.Drawing.Color.Black;
                                }
                                break;
                        }
                        return;
                    }

                }
            }
            stockValue.Text = "----";
            stockValue.ForeColor = System.Drawing.Color.Black;
        }





        public List<T_Stock> GetStockData(T_Stock selectCondition,int quantityCondition)
        {
            List<T_Stock> stock = new List<T_Stock>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    stock = context.T_Stocks.Where(x =>
                      (selectCondition.StID == 0 || x.StID == selectCondition.StID) &&
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.StState == 3 || x.StState == selectCondition.StState) &&
                      (selectCondition.StQuantity == -1 ||
                      (quantityCondition == 0 && x.StQuantity == selectCondition.StQuantity) ||
                      (quantityCondition == 1 && x.StQuantity >= selectCondition.StQuantity) ||
                      (quantityCondition == 2 && x.StQuantity <= selectCondition.StQuantity)) &&
                      (selectCondition.StFlag == 3 || x.StFlag == selectCondition.StFlag)

                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return stock;
        }
    }
}

    
