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

        //データの取得
        public List<T_Chumon> GetChumonData()
        {
            List<T_Chumon> chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }

        //条件一致したデータの取得　オーバーロード
        public List<T_Chumon> GetChumonData(T_Chumon selectCondition)
        {
            List<T_Chumon> chumon = new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x => x.ChID == selectCondition.ChID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chumon;
        }



        //非表示を除いたデータの取得
        public List<T_Chumon> GetChumonDspData()
        {
            List<T_Chumon> chumon= new List<T_Chumon>();
            try
            {
                var context = new SalesManagement_DevContext();
                chumon = context.T_Chumons.Where(x => x.ChFlag == 2).ToList();
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
