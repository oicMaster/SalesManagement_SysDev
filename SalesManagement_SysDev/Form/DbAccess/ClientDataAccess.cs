using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    internal class ClientDataAccess
    {
        public bool CheckClIDExistence(int clID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //顧客IDと一致するデータがあるかどうか
                flg = context.M_Clients.Any(x => x.ClID == clID&& x.ClFlag == 0);
                //DB更新
                context.Dispose();
            }
            catch(Exception ex)
            {
                //エラーメッセージ(基本形)
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        public bool AddClientData(M_Client regCl)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.M_Clients.Add(regCl);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateClientData(M_Client updCl)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var client = context.M_Clients.Single(x => x.ClID == updCl.ClID);

                if (updCl.SoID != 0)
                    client.SoID = updCl.SoID;
                
                if (updCl.ClName != String.Empty)
                    client.ClName = updCl.ClName;
                if (updCl.ClAddress != String.Empty)
                    client.ClAddress = updCl.ClAddress;
                if (updCl.ClPhone != String.Empty)
                    client.ClPhone = updCl.ClPhone;
                if (updCl.ClPostal != String.Empty)
                    client.ClPostal = updCl.ClPostal;
                if (updCl.ClFAX != String.Empty)
                    client.ClFAX = updCl.ClFAX;
                
                client.ClFlag = updCl.ClFlag;
                client.ClHidden = updCl.ClHidden;

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
        public List<M_Client> GetClientData()
        {
            List<M_Client> client = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x => x.ClFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }

        //条件一致したデータの取得　オーバーロード
        public List<M_Client> GetClientData(M_Client selectCondition)
        {
           List<M_Client> client = new List<M_Client>();
            try
            {
                var context = new SalesManagement_DevContext();
                client = context.M_Clients.Where(x =>
                        (selectCondition.ClID == 0 || x.ClID == selectCondition.ClID) &&
                        (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                        (selectCondition.ClName == String.Empty || x.ClName.Contains(selectCondition.ClName)) &&
                        (selectCondition.ClAddress == String.Empty || x.ClAddress.Contains(selectCondition.ClAddress)) &&
                        (selectCondition.ClPhone == String.Empty || x.ClPhone.Contains(selectCondition.ClPhone)) &&
                        (selectCondition.ClPostal == String.Empty || x.ClPostal.Contains(selectCondition.ClPostal)) &&
                        (selectCondition.ClFAX == String.Empty || x.ClFAX.Contains(selectCondition.ClFAX)) &&
                        (selectCondition.ClFlag == 3 || x.ClFlag == selectCondition.ClFlag)
                        ).ToList();
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return client;
        }

        public void GetClientNameData(object sender, Label lblName)
        {
            List<M_Client> client = new List<M_Client>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckClIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    client = GetClientData();
                    var data = client.Single(x => x.ClID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.ClName;
                    return;
                }
            }
            lblName.Text = "----";
        }

        public void GetClientFlagData(object sender,TextBox hidden)
        {
            List<M_Client> client = new List<M_Client>();


            if (CheckClIDExistence(int.Parse((sender as TextBox).Text)))
            {

                var context = new SalesManagement_DevContext();
                client = context.M_Clients.ToList();
                var data = client.Single(x => x.ClID == int.Parse((sender as TextBox).Text));
                hidden.Text = data.ClFlag.ToString();
                context.Dispose();
                return;
            }
            hidden.Text = "------";
        }

    }
}
