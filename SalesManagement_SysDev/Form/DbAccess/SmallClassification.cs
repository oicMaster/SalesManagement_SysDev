using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class SmallClassification
    {
        public bool CheckScIDExistence(int ScID)
        {
            bool flg = false;
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    flg = context.M_SmallClassifications.Any(x => x.ScID == ScID);
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

        public List<M_SmallClassification> GetScData()
        {
            List<M_SmallClassification> smallClassifications = new List<M_SmallClassification>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    smallClassifications = context.M_SmallClassifications.Where(x => x.ScFlag == 0).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return smallClassifications;
        }

        public void GetScNameData(object sender, Label lblName)
        {
            List<M_SmallClassification> smallClassification = new List<M_SmallClassification>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckScIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    smallClassification = GetScData();
                    var data = smallClassification.Single(x => x.ScID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.ScName;
                    return;
                }
            }
            lblName.Text = "----";
        }
    }
}
