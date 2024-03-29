﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ArrivalDataAccess
    {
        public bool CheckArIDExistence(int ArID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_Arrivals.Any(x => x.ArID == ArID);
                    //DB更新
                }
            }
            catch (Exception ex)
            {
                //エラーメッセージ(基本形)
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        public bool AddArrivalData(T_Arrival regAr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Arrivals.Add(regAr);
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



        public bool UpdateArrivalData(T_Arrival updAr)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var arrival = context.T_Arrivals.Single(x => x.ArID == updAr.ArID);
                    if (updAr.SoID != 0)
                        arrival.SoID = updAr.SoID;
                    if (updAr.EmID != 0)
                        arrival.EmID = updAr.EmID;
                    if (updAr.ClID != 0)
                        arrival.ClID = updAr.ClID;
                    if (updAr.OrID != 0)
                        arrival.OrID = updAr.OrID;

                    if (updAr.ArDate != null)
                        arrival.ArDate = updAr.ArDate;

                    arrival.ArStateFlag = updAr.ArStateFlag;
                    arrival.ArFlag = updAr.ArFlag;
                    arrival.ArHidden = updAr.ArHidden;

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

        public T_Arrival GenerateDataAdError()
        {

            using (var context = new SalesManagement_DevContext())
            {
                var arrival = context.T_Arrivals.Max(x => x.ArID);

                return new T_Arrival
                {
                    ArID = arrival,
                    SoID = 0,
                    EmID = 0,
                    ClID = 0,
                    OrID = 0,
                    ArDate = null,
                    ArFlag = 2,
                    ArStateFlag = 0,
                    ArHidden = "SystemError"
                };
            }


        }

        public List<T_Arrival> GetArrivalData()
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    arrival = context.T_Arrivals.Where(x => x.ArStateFlag == 0 && x.ArFlag == 0).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Arrival> GetArrivalData(T_Arrival selectCondition,int dateCondition)
        {
            List<T_Arrival> arrival = new List<T_Arrival>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    arrival = context.T_Arrivals.Where(x =>
                  (selectCondition.ArID == 0 || x.ArID == selectCondition.ArID) &&
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.ArDate == null ||
                  (dateCondition == 0 && x.ArDate == selectCondition.ArDate) ||
                  (dateCondition == 1 && x.ArDate >= selectCondition.ArDate) ||
                  (dateCondition == 2 && x.ArDate <= selectCondition.ArDate)) &&
                  (selectCondition.ArStateFlag == 3 || x.ArStateFlag == selectCondition.ArStateFlag) &&
                  (selectCondition.ArFlag == 3 || x.ArFlag == selectCondition.ArFlag)
                  ).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrival;
        }

        public void GetArrivalFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Arrival> arrival = new List<T_Arrival>();

            if (CheckArIDExistence(int.Parse((sender as TextBox).Text)))
            {
                using (var context = new SalesManagement_DevContext())
                {
                    arrival = context.T_Arrivals.ToList();
                    var data = arrival.Single(x => x.ArID == int.Parse((sender as TextBox).Text));
                    confirm.Text = data.ArStateFlag.ToString();
                    hidden.Text = data.ArFlag.ToString();
                }
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }



        public bool ConfirmArrivalToShipment(int arID,int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var arrival = context.T_Arrivals.Single(x => x.ArID == arID);

                    var shipment = new T_Shipment
                    {
                        ClID = arrival.ClID,
                        SoID = arrival.SoID,
                        EmID = emID,
                        OrID = arrival.OrID,
                        ShFinishDate = null,
                        ShStateFlag = 0,
                        ShFlag = 0,
                        ShHidden = null
                    };
                    context.T_Shipments.Add(shipment);
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
