using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class StockDataAccess
    {
        public bool CheckStIDExistence(int stID)//コード有無の確認
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //在庫IDと一致するデータがあるかどうか
                flg = context.T_Stocks.Any(x => x.StID == stID);
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

        public bool UpdateStockData(T_Stock updSt)//更新
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var stock = context.T_Stocks.Single(x => x.StID == updSt.StID);

                stock.PrID = updSt.PrID;//更新するデータ's
                stock.StQuantity = updSt.StQuantity;
                stock.StFlag = updSt.StFlag;

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

        public List<T_Stock> GetStockData()//データ取得
        {
            List<T_Stock> stock = new List<T_Stock>();
            try
            {
                var context = new SalesManagement_DevContext();
                stock = context.T_Stocks.Where(x => x.StFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return stock;
        }


        public List<T_Stock> GetStockData(T_Stock selectCondition,int quantityCondition)
        {
            List<T_Stock> stock = new List<T_Stock>();
            try
            {
                var context = new SalesManagement_DevContext();
                stock = context.T_Stocks.Where(x =>
                  (selectCondition.StID == 0 || x.StID == selectCondition.StID) &&
                  (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                  (selectCondition.StQuantity == 0 ||
                  (quantityCondition == 0 && x.StQuantity == selectCondition.StQuantity) ||
                  (quantityCondition == 1 && x.StQuantity >= selectCondition.StQuantity) ||
                  (quantityCondition == 2 && x.StQuantity <= selectCondition.StQuantity))&&
                  (selectCondition.StFlag == 3 || x.StFlag == selectCondition.StFlag)

                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return stock;
        }
    }
}

    
