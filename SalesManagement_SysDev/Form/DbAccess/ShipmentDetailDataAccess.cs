using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ShipmentDetailDataAccess
    {
        public bool CheckShDetailIDExistence(int ShDetailID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.T_ShipmentDetails.Any(x => x.ShDetailID == ShDetailID);
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

        public bool AddShipmentData(T_Shipment regShD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_ShipmentDetails.Add(regShD);
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

        public bool UpdateShipmentDetailData(T_ShipmentDetail updShD)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var shipmentDetail = context.T_ShipmentDetails.Single(x => x.ShDetailID == updShD.ShDetailID);

                shipmentDetail.ShDetailID = updShD.ShDetailID;
                shipmentDetail.ShID = updShD.ShID;
                shipmentDetail.PrID = updShD.PrID;
                shipmentDetail.ShQuantity = updShD.ShQuantity;
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


        public List<T_ShipmentDetail> GetShipmentDetailData()
        {
            List<T_ShipmentDetail> shipmentDetail = new List<T_ShipmentDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                shipmentDetail = context.T_ShipmentDetails.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipmentDetail;
        }



        public List<T_ShipmentDetail> GetShipmentDetailData(T_ShipmentDetail selectCondition)
        {
            List<T_ShipmentDetail> shipmentDetail = new List<T_ShipmentDetail>();
            try
            {
                var context = new SalesManagement_DevContext();
                shipmentDetail = context.T_ShipmentDetails.Where(x => x.ShDetailID == selectCondition.ShDetailID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return shipmentDetail;
        }
    }
}
