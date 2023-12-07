using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

        public List<M_Product> GetProductData()
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        //オーバーロード
        public List<M_Product> GetProductData(M_Product selectCondition,int dateCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                var context = new SalesManagement_DevContext();
                product = context.M_Products.Where(x =>
                  (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                  (selectCondition.MaID == 0 || x.MaID == selectCondition.MaID) &&
                  (selectCondition.PrName == null || x.PrName.Contains(selectCondition.PrName)) &&
                  (selectCondition.Price == 0 || x.Price == selectCondition.Price) &&
                  (selectCondition.ScID == 0 || x.ScID == selectCondition.ScID) &&
                  (selectCondition.PrModelNumber == null || x.PrModelNumber.Contains(selectCondition.PrModelNumber)) &&
                  (selectCondition.PrColor == null || x.PrColor.Contains(selectCondition.PrColor)) &&
                  (selectCondition.PrReleaseDate == DateTime.Parse("0001/01/01") ||
                  (dateCondition == 0 && x.PrReleaseDate == selectCondition.PrReleaseDate) ||
                  (dateCondition == 1 && x.PrReleaseDate >= selectCondition.PrReleaseDate) ||
                  (dateCondition == 2 && x.PrReleaseDate <= selectCondition.PrReleaseDate))&&
                  (selectCondition.PrFlag == 3 || x.PrFlag == selectCondition.PrFlag)
                ).ToList();
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        public void GetProductNameData(object sender, Label lblName)
        {
            List<M_Product> product = new List<M_Product>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckPrIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    product = GetProductData();
                    var data = product.Single(x => x.PrID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.PrName;
                    return;
                }
            }
            lblName.Text = "----";
        }
    }
}
    

