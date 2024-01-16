using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDataAccess
    {
        public bool CheckShIDExistence(int ShID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_Shipments.Any(x => x.ShID == ShID);
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

        public bool AddShipmentData(T_Shipment regSh)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Shipments.Add(regSh);
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

        public bool UpdateShipmentData(T_Shipment updSh)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var shipment = context.T_Shipments.Single(x => x.ShID == updSh.ShID);

                    if (updSh.ClID != 0)
                        shipment.ClID = updSh.ClID;
                    if (updSh.EmID != 0)
                        shipment.EmID = updSh.EmID;
                    if (updSh.SoID != 0)
                        shipment.SoID = updSh.SoID;
                    if (updSh.OrID != 0)
                        shipment.OrID = updSh.OrID;
                    if (updSh.ShFinishDate != null)
                        shipment.ShFinishDate = updSh.ShFinishDate;
                    shipment.ShStateFlag = updSh.ShStateFlag;
                    shipment.ShFlag = updSh.ShFlag;
                    shipment.ShHidden = updSh.ShHidden;

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

        public T_Shipment GenerateDataAdError()
        {
            using (var context = new SalesManagement_DevContext())
            {
                var shipment = context.T_Shipments.Max(x => x.ShID);

                return new T_Shipment
                {
                    ShID = shipment,
                    SoID = 0,
                    EmID = 0,
                    ClID = 0,
                    OrID = 0,
                    ShFinishDate = null,
                    ShFlag = 2,
                    ShStateFlag = 0,
                    ShHidden = "SystemError"
                };
            }
        }


        //データの取得
        public List<T_Shipment> GetShipmentData()
        {
            List<T_Shipment> shipment = new List<T_Shipment>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    shipment = context.T_Shipments.Where(x => x.ShStateFlag == 0 && x.ShFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipment;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Shipment> GetShipmentData(T_Shipment selectCondition,int dateCondition)
        {
            List<T_Shipment> shipment = new List<T_Shipment>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    shipment = context.T_Shipments.Where(x =>
                      (selectCondition.ShID == 0 || x.ShID == selectCondition.ShID) &&
                      (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                      (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                      (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                      (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                      (selectCondition.ShFinishDate == null ||
                      (dateCondition == 0 && x.ShFinishDate == selectCondition.ShFinishDate) ||
                      (dateCondition == 1 && x.ShFinishDate >= selectCondition.ShFinishDate) ||
                      (dateCondition == 2 && x.ShFinishDate <= selectCondition.ShFinishDate)) &&
                      (selectCondition.ShStateFlag == 3 || x.ShStateFlag == selectCondition.ShStateFlag) &&
                      (selectCondition.ShFlag == 3 || x.ShFlag == selectCondition.ShFlag)
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipment;
        }

        public void GetShipmentFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Shipment> shipment = new List<T_Shipment>();


            if (CheckShIDExistence(int.Parse((sender as TextBox).Text)))
            {

                using (var context = new SalesManagement_DevContext())
                {
                    shipment = context.T_Shipments.ToList();
                    var data = shipment.Single(x => x.ShID == int.Parse((sender as TextBox).Text));
                    confirm.Text = data.ShStateFlag.ToString();
                    hidden.Text = data.ShFlag.ToString();
                    context.Dispose();
                }
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }



     
        public bool ConfirmShipmentToSale(int shID, int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var shipment = context.T_Shipments.Single(x => x.ShID == shID);

                    var sale = new T_Sale
                    {
                        ClID = shipment.ClID,
                        SoID = shipment.SoID,
                        EmID = emID,
                        ChID = shipment.OrID,
                        SaDate = DateTime.Now,
                        SaFlag = 0,
                        SaHidden = null
                    };
                    context.T_Sales.Add(sale);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
