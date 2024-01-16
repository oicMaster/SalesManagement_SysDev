﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OrderDataAccess
    {
        public bool CheckOrIDExistence(int OrID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Orders.Any(x => x.OrID == OrID);
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

        public bool AddOrderData(T_Order regOr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Orders.Add(regOr);
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

        public bool UpdateOrderData(T_Order updOr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var order = context.T_Orders.Single(x => x.OrID == updOr.OrID);

                    if (updOr.SoID != 0)
                        order.SoID = updOr.SoID;
                    if (updOr.EmID != 0)
                        order.EmID = updOr.EmID;
                    if (updOr.ClID != 0)
                        order.ClID = updOr.ClID;

                    if (!String.IsNullOrEmpty(updOr.ClCharge))
                        order.ClCharge = updOr.ClCharge;

                    if (updOr.OrDate != null)
                        order.OrDate = updOr.OrDate;

                    order.OrStateFlag = updOr.OrStateFlag;
                    order.OrFlag = updOr.OrFlag;
                    order.OrHidden = updOr.OrHidden;

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

        public T_Order GenerateDataAdError()
        {
            var context = new SalesManagement_DevContext();
            var order= context.T_Orders.Max(x => x.OrID);

            return new T_Order
            {
                OrID = order,
                SoID = 0,
                EmID = 0,
                ClID = 0,
                ClCharge = String.Empty,
                OrDate = null,
                OrStateFlag = 0,
                OrFlag = 2,
                OrHidden = "SystemError"
            };
        }

        //データの取得
        public List<T_Order> GetOrderData()
        {
            List<T_Order> order = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x => x.OrStateFlag == 0 && x.OrFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Order> GetOrderData(T_Order selectCondition,int dateCondition)
        {
            List<T_Order> order = new List<T_Order>();
            try
            {
                var context = new SalesManagement_DevContext();
                order = context.T_Orders.Where(x =>
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                  (selectCondition.ClCharge == String.Empty||x.ClCharge == selectCondition.ClCharge)&&
                  (selectCondition.OrDate == null ||
                  (dateCondition == 0 && x.OrDate == selectCondition.OrDate) ||
                  (dateCondition == 1 && x.OrDate >= selectCondition.OrDate) ||
                  (dateCondition == 2 && x.OrDate <= selectCondition.OrDate)) &&
                  (selectCondition.OrStateFlag == 3 || x.OrStateFlag == selectCondition.OrStateFlag) &&
                  (selectCondition.OrFlag == 3 || x.OrFlag == selectCondition.OrFlag)
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }

        public int GetOrderIDData()
        {
            int OrID = 0;
            try
            {
                var context = new SalesManagement_DevContext();
                var order = context.T_Orders.Max(x => x.OrID);
                OrID = order;
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OrID;
        }



        public void GetOrderFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Order> order = new List<T_Order>();


            if (CheckOrIDExistence(int.Parse((sender as TextBox).Text)))
            {

                var context = new SalesManagement_DevContext();
                order = context.T_Orders.ToList();
                var data = order.Single(x => x.OrID == int.Parse((sender as TextBox).Text));
                confirm.Text = data.OrStateFlag.ToString();
                hidden.Text = data.OrFlag.ToString();
                context.Dispose();
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }

        public bool ConfirmOrderToChumon(int orID, int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var order = context.T_Orders.Single(x => x.OrID == orID);

                    var chumon = new T_Chumon
                    {
                        ClID = order.ClID,
                        SoID = order.SoID,
                        EmID = emID,
                        OrID = order.OrID,
                        ChDate = order.OrDate,
                        ChStateFlag = 0,
                        ChFlag = 0,
                        ChHidden = null
                    };
                    context.T_Chumons.Add(chumon);
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
