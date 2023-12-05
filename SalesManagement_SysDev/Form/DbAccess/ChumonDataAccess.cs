using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class ChumonDataAccess
    {
        public bool CheckChIDExistence(int ChID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.T_Chumons.Any(x => x.ChID == ChID);
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

        public bool AddChumonData(T_Chumon regCh)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.T_Chumons.Add(regCh);
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

        public bool UpdateChumonData(T_Chumon updCh)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var chumon = context.T_Chumons.Single(x => x.ChID == updCh.ChID);

                chumon.SoID = updCh.SoID;
                chumon.EmID = updCh.EmID;
                chumon.ClID = updCh.ClID;
                chumon.OrID = updCh.OrID;
                chumon.ChDate = updCh.ChDate;
                chumon.ChStateFlag = updCh.ChStateFlag;
                chumon.ChFlag = updCh.ChFlag;
                chumon.ChHidden = updCh.ChHidden;

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

        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x => x.ChStateFlag == 0 && x.ChFlag == 0).ToList();
                context.Dispose();
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
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x =>
                  (selectCondition.ChID == 0 || x.ChID == selectCondition.ChID) &&
                  (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                  (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                  (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                  (selectCondition.OrID == 0 || x.OrID == selectCondition.OrID) &&
                  (selectCondition.ChDate == DateTime.Parse("0001/01/01") ||
                  (dateCondition == 0 && x.ChDate == selectCondition.ChDate) ||
                  (dateCondition == 1 && x.ChDate >= selectCondition.ChDate) ||
                  (dateCondition == 2 && x.ChDate <= selectCondition.ChDate)) &&
                  (selectCondition.ChStateFlag == 3 || x.ChStateFlag == selectCondition.ChStateFlag) &&
                  (selectCondition.ChFlag == 3 || x.ChFlag == selectCondition.ChFlag)
                  ).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }
    }
}
