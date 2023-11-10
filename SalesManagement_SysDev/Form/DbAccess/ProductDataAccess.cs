using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SalesManagement_SysDev
{
    internal class ProductDataAccess
    {
        public bool CheckPrIDExistence(int prID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //商品IDと一致するデータがあるかどうか
                flg = context.M_Products.Any(x => x.PrID == prID);
                //DB更新
                context.Dispose();
            }
            catch (Exception ex)
            {
                //エラーメッセージ
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }


        public bool AddProductData(M_Product regPr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Products.Add(regPr);
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


        public bool UpdateProductData(M_Product updPr)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var product = context.M_Products.Single(x => x.PrID == updPr.PrID);

                product.MaID = updPr.MaID;
                product.PrName = updPr.PrName;
                product.Price = updPr.Price;
                product.PrJCode = updPr.PrJCode;
                product.PrSafetyStock = updPr.PrSafetyStock;
                product.ScID = updPr.ScID;
                product.PrModelNumber = updPr.PrModelNumber;
                product.PrColor = updPr.PrColor;
                product.PrReleaseDate = updPr.PrReleaseDate;
                product.PrFlag = updPr.PrFlag;
                product.PrHidden = updPr.PrHidden;

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
        public List<M_Product> GetProductData()
        {
            List<M_Product> product= new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x=> x.PrFlag ==0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        //オーバーロード
        public List<M_Product> GetProductData(M_Product selectCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrID == selectCondition.PrID).ToList();
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }
    }
}
    

