using System;
using System.Collections.Generic;
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
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Syukkos.Any(x => x.SyID == SyID);
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

        public bool AddSyukkoData(T_Syukko regSy)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Syukkos.Add(regSy);
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

        public bool UpdateSyukkoData(T_Syukko updSy)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var syukko = context.T_Syukkos.Single(x => x.SyID == updSy.SyID);

                syukko.EmID = updSy.EmID;
                syukko.ClID = updSy.ClID;
                syukko.SoID = updSy.SoID;
                syukko.OrID = updSy.OrID;
                syukko.SyDate = updSy.SyDate;
                syukko.SyStateFlag = updSy.SyStateFlag;
                syukko.SyFlag = updSy.SyFlag;
                syukko.SyHidden = updSy.SyHidden;

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
        public List<T_Syukko> GetSyukkoData()
        {
            List<T_Syukko> syukko = new List<T_Syukko>();
            try
            {
                var context = new SalesManagement_DevContext();
                syukko = context.T_Syukkos.Where(x => x.SyStateFlag == 0 && x.SyFlag == 0).ToList();
                context.Dispose();
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
                var context = new SalesManagement_DevContext();
                syukko = context.T_Syukkos.Where(x =>
                  (selectCondition.SyID == 0 || x.SyID == selectCondition.SyID) &&
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.SyDate == DateTime.Parse("0001/01/01") ||
                  (dateCondition == 0 && x.SyDate == selectCondition.SyDate) ||
                  (dateCondition == 1 && x.SyDate >= selectCondition.SyDate) ||
                  (dateCondition == 2 && x.SyDate <= selectCondition.SyDate)) &&
                  (selectCondition.SyStateFlag == 3 || x.SyStateFlag == selectCondition.SyStateFlag) &&
                  (selectCondition.SyFlag == 3 || x.SyFlag == selectCondition.SyFlag)
                ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return syukko;
        }
    }
}
