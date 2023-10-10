using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SalesManagement_SysDev
{
    public partial class F_AdProduct : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        

        public F_AdProduct()
        {
            InitializeComponent();
        }
        public bool CheckNumeric(string text)
        {
            bool flg;
            Regex regex = new Regex("^[0-9]+$");
            //数値かを確認
            if (!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }

        private bool GetValidDataAtSelect()
        {
            //商品ID入力時チェック
            if(!String.IsNullOrEmpty(txbPrID.Text.Trim()))
            //商品IDの文字数チェック
            if (txbPrID.TextLength>6)
            {
                //MessageBox.Show("商品IDは６文字までです");
                //
                return false;
            }

        
            return true;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtSelect())
                return;
            
        }
    }
}
