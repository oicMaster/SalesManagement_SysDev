using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Common
{
    class MessageDsp
    {
        public DialogResult MsgDspQ(string msgCD)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Single(x => x.MsgCD == msgCD);
                result = MessageBox.Show(message.MsgComments,"確認メッセージ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DialogResult MsgDspQ(string msgCD, Label ID, TextBox No)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Single(x => x.MsgCD == msgCD);
                int no = int.Parse(No.Text);
                result = MessageBox.Show(ID.Text + " :  " + no.ToString() + message.MsgComments, "確認メッセージ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DialogResult MsgDsp(string msgCD)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Single(x => x.MsgCD == msgCD);
                result = MessageBox.Show(message.MsgComments);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DialogResult MsgDsp(string msgCD,Label ID,TextBox No)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Single(x => x.MsgCD == msgCD);
                int no = int.Parse(No.Text);
                result = MessageBox.Show(ID.Text +" :  "+ no.ToString() + message.MsgComments);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
