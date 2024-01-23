using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    internal class ChumonDataAccess
    {
        public bool CheckChIDExistence(int ChID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.T_Chumons.Any(x => x.ChID == ChID);
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

        public bool AddChumonData(T_Chumon regCh)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_Chumons.Add(regCh);
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

        public bool UpdateChumonData(T_Chumon updCh)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var chumon = context.T_Chumons.Single(x => x.ChID == updCh.ChID);
                    if (updCh.SoID != 0)
                        chumon.SoID = updCh.SoID;
                    if (updCh.EmID != 0)
                        chumon.EmID = updCh.EmID;
                    if (updCh.ClID != 0)
                        chumon.ClID = updCh.ClID;
                    if (updCh.OrID != 0)
                        chumon.OrID = updCh.OrID;
                    if (updCh.ChDate != null)
                        chumon.ChDate = updCh.ChDate;
                    chumon.ChStateFlag = updCh.ChStateFlag;
                    chumon.ChFlag = updCh.ChFlag;
                    chumon.ChHidden = updCh.ChHidden;

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

        public T_Chumon GenerateDataAdError()
        {
            using (var context = new SalesManagement_DevContext())
            {
                var chumon = context.T_Chumons.Max(x => x.ChID);

                return new T_Chumon
                {
                    ChID = chumon,
                    SoID = 0,
                    EmID = 0,
                    ClID = 0,
                    OrID = 0,
                    ChDate = null,
                    ChFlag = 2,
                    ChStateFlag = 0,
                    ChHidden = "SystemError"
                };
            }
        }

        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> chumon = new List<T_Chumon>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    chumon = context.T_Chumons.Where(x => x.ChStateFlag == 0 && x.ChFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Chumon> GetChumonData(T_Chumon selectCondition,int dateCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    chumon = context.T_Chumons.Where(x =>
                      (selectCondition.ChID == 0 || x.ChID == selectCondition.ChID) &&
                      (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                      (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                      (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                      (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                      (selectCondition.ChDate == null ||
                      (dateCondition == 0 && DbFunctions.TruncateTime(x.ChDate) == DbFunctions.TruncateTime(selectCondition.ChDate)) ||
                      (dateCondition == 1 && DbFunctions.TruncateTime(x.ChDate )>= DbFunctions.TruncateTime(selectCondition.ChDate)) ||
                      (dateCondition == 2 && DbFunctions.TruncateTime(x.ChDate )<= DbFunctions.TruncateTime(selectCondition.ChDate))) &&
                      (selectCondition.ChStateFlag == 3 || x.ChStateFlag == selectCondition.ChStateFlag) &&
                      (selectCondition.ChFlag == 3 || x.ChFlag == selectCondition.ChFlag)
                      ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }

        public void GetChumonFlagData(object sender, TextBox confirm, TextBox hidden)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();

            try
            {
                if (CheckChIDExistence(int.Parse((sender as TextBox).Text)))
                {

                    using (var context = new SalesManagement_DevContext())
                    {
                        chumon = context.T_Chumons.ToList();
                        var data = chumon.Single(x => x.ChID == int.Parse((sender as TextBox).Text));
                        confirm.Text = data.ChStateFlag.ToString();
                        hidden.Text = data.ChFlag.ToString();
                        context.Dispose();
                    }
                    return;
                }
                confirm.Text = "------";
                hidden.Text = "------";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public bool ConfirmChumonToSyukko(int chID, int emID)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var chumon = context.T_Chumons.Single(x => x.ChID == chID);

                    var syukko = new T_Syukko
                    {
                        ClID = chumon.ClID,
                        SoID = chumon.SoID,
                        EmID = emID,
                        OrID = chumon.OrID,
                        SyDate = null,
                        SyStateFlag = 0,
                        SyFlag = 0,
                        SyHidden = null
                    };
                    context.T_Syukkos.Add(syukko);
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
