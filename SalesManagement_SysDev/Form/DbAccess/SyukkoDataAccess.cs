using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SyukkoDataAccess
    {
        public bool CheckSyIDExistence(int SyID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_Syukkos.Any(x => x.SyID == SyID);
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

        public bool AddSyukkoData(T_Syukko regSy)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Syukkos.Add(regSy);
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

        public bool UpdateSyukkoData(T_Syukko updSy)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var syukko = context.T_Syukkos.Single(x => x.SyID == updSy.SyID);
                    if (updSy.EmID != 0)
                        syukko.EmID = updSy.EmID;
                    if (updSy.ClID != 0)
                        syukko.ClID = updSy.ClID;
                    if (updSy.SoID != 0)
                        syukko.SoID = updSy.SoID;
                    if (updSy.OrID != 0)
                        syukko.OrID = updSy.OrID;
                    if (updSy.SyDate != null)
                        syukko.SyDate = updSy.SyDate;
                    syukko.SyStateFlag = updSy.SyStateFlag;
                    syukko.SyFlag = updSy.SyFlag;
                    syukko.SyHidden = updSy.SyHidden;

                    context.SaveChanges();
                    context.Dispose();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public T_Syukko GenerateDataAdError()
        {
            using (var context = new SalesManagement_DevContext())
            {
                var syukko = context.T_Syukkos.Max(x => x.SyID);

                return new T_Syukko
                {
                    SyID = syukko,
                    SoID = 0,
                    EmID = 0,
                    ClID = 0,
                    OrID = 0,
                    SyDate = null,
                    SyFlag = 2,
                    SyStateFlag = 0,
                    SyHidden = "SystemError"
                };
            }
        }

        //データの取得
        public List<T_Syukko> GetSyukkoData()
        {
            List<T_Syukko> syukko = new List<T_Syukko>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    syukko = context.T_Syukkos.Where(x => x.SyStateFlag == 0 && x.SyFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukko;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Syukko> GetSyukkoData(T_Syukko selectCondition,int dateCondition)
        {
            List<T_Syukko> syukko = new List<T_Syukko>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    syukko = context.T_Syukkos.Where(x =>
                      (selectCondition.SyID == 0 || x.SyID == selectCondition.SyID) &&
                      (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                      (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                      (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                      (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                      (selectCondition.SyDate == null ||
                      (dateCondition == 0 && DbFunctions.TruncateTime(x.SyDate )== DbFunctions.TruncateTime(selectCondition.SyDate)) ||
                      (dateCondition == 1 && DbFunctions.TruncateTime(x.SyDate )>= DbFunctions.TruncateTime(selectCondition.SyDate))||
                      (dateCondition == 2 && DbFunctions.TruncateTime(x.SyDate) <= DbFunctions.TruncateTime(selectCondition.SyDate))) &&
                      (selectCondition.SyStateFlag == 3 || x.SyStateFlag == selectCondition.SyStateFlag) &&
                      (selectCondition.SyFlag == 3 || x.SyFlag == selectCondition.SyFlag)
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukko;
        }

        public void GetSyukkoFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Syukko> syukko = new List<T_Syukko>();


            if (CheckSyIDExistence(int.Parse((sender as TextBox).Text)))
            {

                using (var context = new SalesManagement_DevContext())
                {
                    syukko = context.T_Syukkos.ToList();
                    var data = syukko.Single(x => x.SyID == int.Parse((sender as TextBox).Text));
                    confirm.Text = data.SyStateFlag.ToString();
                    hidden.Text = data.SyFlag.ToString();
                    context.Dispose();
                }
                return;
            }
            confirm.Text = "------";
            hidden.Text = "------";
        }




        public bool ConfirmSyukkoToArrival(int syID, int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var syukko = context.T_Syukkos.Single(x => x.SyID == syID);

                    var arrival = new T_Arrival
                    {
                        ClID = syukko.ClID,
                        SoID = syukko.SoID,
                        EmID = emID,
                        OrID = syukko.OrID,
                        ArDate = null,
                        ArStateFlag = 0,
                        ArFlag = 0,
                        ArHidden = null
                    };
                    context.T_Arrivals.Add(arrival);
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
