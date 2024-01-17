using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class PositionDataAccess
    {
        public bool CheckPoIDExistence(int PoID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.M_Positions.Any(x => x.PoID == PoID);
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

        public List<M_Position> GetPositionData()
        {
            List<M_Position> position = new List<M_Position>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    position = context.M_Positions.Where(x => x.PoFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return position;
        }

        public void GetPositionNameData(object sender, Label lblName)
        {
            List<M_Position> position = new List<M_Position>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckPoIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    position = GetPositionData();
                    var data = position.Single(x => x.PoID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.PoName;
                    return;
                }
            }
            lblName.Text = "----";
        }
    }
}
