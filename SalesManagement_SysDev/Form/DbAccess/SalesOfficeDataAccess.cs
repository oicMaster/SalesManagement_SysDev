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

        public bool AddSalesOfficeData(M_SalesOffice regSo)
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

        public bool UpdateSalesOfficeData(M_SalesOffice updSo)
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
        public List<M_SalesOffice> GetSalesOfficeData()
        {
            List<M_SalesOffice> salesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                salesOffice = context.M_SalesOffices.Where(x => x.SoFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesOffice;
        }

        //条件一致したデータの取得　オーバーロード
        public List<M_SalesOffice> GetSalesOfficeData(M_SalesOffice selectCondition)
        {
            List<M_SalesOffice> salesOffice = new List<M_SalesOffice>();
            try
            {
                var context = new SalesManagement_DevContext();
                salesOffice = context.M_SalesOffices.Where(x =>
                        (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                        (selectCondition.SoName == null || x.SoName.Contains(selectCondition.SoName)) &&
                        (selectCondition.SoAddress == null || x.SoAddress.Contains(selectCondition.SoAddress)) &&
                        (selectCondition.SoPhone == null || x.SoPhone.Contains(selectCondition.SoPhone)) &&
                        (selectCondition.SoPostal == null || x.SoPostal.Contains(selectCondition.SoPostal)) &&
                        (selectCondition.SoFAX == null || x.SoFAX.Contains(selectCondition.SoFAX)) &&
                        (selectCondition.SoFlag == 3 || x.SoFlag == selectCondition.SoFlag)
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salesOffice;
        }

        public void GetSalesOfficeNameData(object sender, Label lblName)
        {
            List<M_SalesOffice> salesOffice = new List<M_SalesOffice>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckSoIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    salesOffice = GetSalesOfficeData();
                    var data = salesOffice.Single(x => x.SoID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.SoName;
                    return;
                }
            }
            lblName.Text = "----";
        }
    }
}
