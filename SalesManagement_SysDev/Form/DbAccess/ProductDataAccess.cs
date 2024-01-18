using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                using (var context = new SalesManagement_DevContext())
                {
                    //商品IDと一致するデータがあるかどうか
                    flg = context.M_Products.Any(x => x.PrID == prID && x.PrFlag == 0);
                    //DB更新
                    context.Dispose();
                }
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
                using (var context = new SalesManagement_DevContext())
                {
                    context.M_Products.Add(regPr);
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


        public bool UpdateProductData(M_Product updPr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var product = context.M_Products.Single(x => x.PrID == updPr.PrID);

                    if (updPr.MaID != 0)
                        product.MaID = updPr.MaID;
                    if (updPr.PrName != String.Empty)
                        product.PrName = updPr.PrName;
                    if (updPr.Price != 0)
                        product.Price = updPr.Price;
                    if (updPr.PrSafetyStock != 0)
                        product.PrSafetyStock = updPr.PrSafetyStock;
                    if (updPr.ScID != 0)
                        product.ScID = updPr.ScID;
                    if (updPr.PrModelNumber != String.Empty)
                        product.PrModelNumber = updPr.PrModelNumber;
                    if (updPr.PrColor != String.Empty)
                        product.PrColor = updPr.PrColor;
                    if (updPr.PrReleaseDate != null)
                        product.PrReleaseDate = updPr.PrReleaseDate;
                    product.PrFlag = updPr.PrFlag;
                    product.PrHidden = updPr.PrHidden;

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

        public List<M_Product> GetProductData()
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    product = context.M_Products.Where(x => x.PrFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        //オーバーロード
        public List<M_Product> GetProductData(M_Product selectCondition,int dateCondition,int priceCondition,int stockCondition)
        {
            List<M_Product> product = new List<M_Product>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    product = context.M_Products.Where(x =>
                      (selectCondition.PrID == 0 || x.PrID == selectCondition.PrID) &&
                      (selectCondition.MaID == 0 || x.MaID == selectCondition.MaID) &&
                      (selectCondition.PrName == null || x.PrName.Contains(selectCondition.PrName)) &&
                      (selectCondition.Price == 0 ||
                      (priceCondition == 0 && x.Price == selectCondition.Price) ||
                      (priceCondition == 1 && x.Price >= selectCondition.Price) ||
                      (priceCondition == 2 && x.Price <= selectCondition.Price)) &&
                      (selectCondition.PrSafetyStock == 0 ||
                      (stockCondition == 0 && x.PrSafetyStock == selectCondition.PrSafetyStock) ||
                      (stockCondition == 1 && x.PrSafetyStock >= selectCondition.PrSafetyStock) ||
                      (stockCondition == 2 && x.PrSafetyStock <= selectCondition.PrSafetyStock)) &&
                      (selectCondition.ScID == 0 || x.ScID == selectCondition.ScID) &&
                      (selectCondition.PrModelNumber == null || x.PrModelNumber.Contains(selectCondition.PrModelNumber)) &&
                      (selectCondition.PrColor == null || x.PrColor.Contains(selectCondition.PrColor)) &&
                      (selectCondition.PrReleaseDate == null ||
                      (dateCondition == 0 && x.PrReleaseDate == selectCondition.PrReleaseDate) ||
                      (dateCondition == 1 && x.PrReleaseDate >= selectCondition.PrReleaseDate) ||
                      (dateCondition == 2 && x.PrReleaseDate <= selectCondition.PrReleaseDate)) &&
                      (selectCondition.PrFlag == 3 || x.PrFlag == selectCondition.PrFlag)
                    ).ToList();
                    context.Dispose();
                }
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

        public int GetSafetyStockCheck(TextBox prID,int Quantity)
        {
            using (var context = new SalesManagement_DevContext())
            {
                if (CheckPrIDExistence(int.Parse(prID.Text)))
                    if (Quantity != -1)
                    {
                        var data = context.M_Products.Single(x => x.PrID == int.Parse(prID.Text));
                        if (data.PrSafetyStock > Quantity)
                            return 1;
                        else
                            return 0;
                    }
            }
            return -1;
        }

      



        public void GetSafetyStockData(object sender, Label lblSafetyStock)
        {
            List<M_Product> product = new List<M_Product>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckPrIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    product = GetProductData();
                    var data = product.Single(x => x.PrID == int.Parse((sender as TextBox).Text));
                    lblSafetyStock.Text = data.PrSafetyStock.ToString();
                    return;
                }
            }
            lblSafetyStock.Text = "----";
        }

       

        public void GetProductFlagData(object sender, TextBox hidden)
        {
            List<M_Product> product = new List<M_Product>();


            if (CheckPrIDExistence(int.Parse((sender as TextBox).Text)))
            {

                using (var context = new SalesManagement_DevContext())
                {
                    product = context.M_Products.ToList();
                    var data = product.Single(x => x.PrID == int.Parse((sender as TextBox).Text));
                    hidden.Text = data.PrFlag.ToString();
                    context.Dispose();
                }
                return;
            }
            hidden.Text = "------";
        }

        

        public decimal GetProductTotalPriceData(TextBox prID, TextBox Quantity)
        {
            List<M_Product> product = new List<M_Product>();
            using (var context = new SalesManagement_DevContext())
            {
                product = context.M_Products.ToList();

                var data = product.Single(x => x.PrID == int.Parse(prID.Text));
                decimal totalPrice = data.Price * int.Parse(Quantity.Text);
                context.Dispose();

                return totalPrice;
            }
        }
    }
}
    

