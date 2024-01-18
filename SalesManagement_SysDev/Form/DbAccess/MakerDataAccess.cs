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
                using (var context = new SalesManagement_DevContext())
                {
                    //顧客IDと一致するデータがあるかどうか
                    flg = context.M_Makers.Any(x => x.MaID == MaID && x.MaFlag == 0);
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

        public bool AddMakerData(M_Maker regMa)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.M_Makers.Add(regMa);
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

        public bool UpdateMakerData(M_Maker updMa)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    var maker = context.M_Makers.Single(x => x.MaID == updMa.MaID);
                    if (maker.MaID != 0)
                        maker.MaID = updMa.MaID;
                    if (updMa.MaName != String.Empty)
                        maker.MaName = updMa.MaName;
                    if (updMa.MaAddress != String.Empty)
                        maker.MaAddress = updMa.MaAddress;
                    if (updMa.MaPhone != String.Empty)
                        maker.MaPhone = updMa.MaPhone;
                    if (updMa.MaPostal != String.Empty)
                        maker.MaPostal = updMa.MaPostal;
                    if (updMa.MaFAX != String.Empty)
                        maker.MaFAX = updMa.MaFAX;
                    maker.MaFlag = updMa.MaFlag;
                    maker.MaHidden = updMa.MaHidden;

                }
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
                using (var context = new SalesManagement_DevContext())
                {
                    maker = context.M_Makers.Where(x => x.MaFlag == 0).ToList();
                    context.Dispose();
                }
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
                using (var context = new SalesManagement_DevContext())
                {
                    maker = context.M_Makers.Where(x =>
                            (selectCondition.MaID == 0 || x.MaID == selectCondition.MaID) &&
                            (selectCondition.MaName == null || x.MaName.Contains(selectCondition.MaName)) &&
                            (selectCondition.MaAddress == null || x.MaAddress.Contains(selectCondition.MaAddress)) &&
                            (selectCondition.MaPhone == null || x.MaPhone.Contains(selectCondition.MaPhone)) &&
                            (selectCondition.MaPostal == null || x.MaPostal.Contains(selectCondition.MaPostal)) &&
                            (selectCondition.MaFAX == null || x.MaFAX.Contains(selectCondition.MaFAX)) &&
                            (selectCondition.MaFlag == 3 || x.MaFlag == selectCondition.MaFlag)
                    ).ToList();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maker;
        }

        public void GetMakerNameData(object sender, Label lblName)
        {
            List<M_Maker> maker = new List<M_Maker>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckMaIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    maker = GetMakerData();
                    var data = maker.Single(x => x.MaID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.MaName;
                    return;
                }
            }
            lblName.Text = "----";
        }


        public void GetMakerFlagData(object sender, TextBox hidden)
        {
            List<M_Maker> maker = new List<M_Maker>();


            if (CheckMaIDExistence(int.Parse((sender as TextBox).Text)))
            {

                using (var context = new SalesManagement_DevContext())
                {
                    maker = context.M_Makers.ToList();
                    var data = maker.Single(x => x.MaID == int.Parse((sender as TextBox).Text));
                    hidden.Text = data.MaFlag.ToString();
                    context.Dispose();
                }
                return;
            }
            hidden.Text = "------";
        }


    }
}
