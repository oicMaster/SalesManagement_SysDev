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
        public DialogResult MsgDsp(string msgCD)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Single(x => x.MsgCD == msgCD);
                MessageBoxButtons btn = new MessageBoxButtons();
                MessageBoxIcon icon = new MessageBoxIcon();
                string msgcom = message.MsgComments.Replace("\\r", "\r").Replace("\\n", "\n");
                string msgtitle = message.MsgTitle + "　(メッセージ番号：" + msgCD + ")";
                btn = (MessageBoxButtons)message.MsgButton;
                icon = (MessageBoxIcon)message.MsgIcon;
                result = MessageBox.Show(msgcom, msgtitle, btn, icon);
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DialogResult MsgDsp(string msgcd, int cnt, string nm)
        {
            DialogResult result = DialogResult.None;
            try
            {
                var context = new SalesManagement_DevContext();
                var message = context.M_Messages.Where(x => x.MsgCD == msgcd).ToArray();
                MessageBoxButtons btn = new MessageBoxButtons();
                MessageBoxIcon icon = new MessageBoxIcon();
                btn = (MessageBoxButtons)message[0].MsgButton;
                icon = (MessageBoxIcon)message[0].MsgIcon;
                string str = "";
                switch (msgcd.Substring(0, 2))
                {
                    case "M1":
                        str = "顧客";
                        break;
                    case "M2":
                        str = "　";
                        break;
                }
                result = MessageBox.Show(str + "ID：" + cnt + "　" + str + "名：" + nm + "\n\r" + message[0].MsgComments, message[0].MsgTitle, btn, icon);
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
