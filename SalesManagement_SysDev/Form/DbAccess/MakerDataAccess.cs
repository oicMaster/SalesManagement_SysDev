using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class MakerDataAccess
    {
        public bool CheckMaIDExistence(int MaID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.M_Makers.Any(x => x.MaID == MaID);
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

        public bool AddMakerData(M_Maker regMa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Makers.Add(regMa);
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

        public bool UpdateMakerData(M_Maker updMa)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var maker = context.M_Makers.Single(x => x.MaID == updMa.MaID);

                //maker.MaID = updMa.MaID;
                //↑のように書いてください。

                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<M_Maker> GetMakerData()
        {
            List<M_Maker> maker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                maker = context.M_Makers.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maker;
        }



        public List<M_Maker> GetMakerData(M_Maker selectCondition)
        {
            List<M_Maker> maker = new List<M_Maker>();
            try
            {
                var context = new SalesManagement_DevContext();
                maker = context.M_Makers.Where(x => x.MaID == selectCondition.MaID).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maker;
        }
    }
}
