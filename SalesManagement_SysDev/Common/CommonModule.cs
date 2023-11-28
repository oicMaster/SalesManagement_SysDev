using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev.Common
{
    public class CommonModule
    {
        public void FirstPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList)
        {
            int pageSize = int.Parse(Size.Text);
            dgv.DataSource = dataList.Take(pageSize).ToList();

            dgv.Refresh();

            dgv.Text = "1";
        }

        public void PreviousPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList)
        {
            int pageSize = int.Parse(Size.Text);
            int pageNo = int.Parse(No.Text) - 2;
            dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dgv.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                No.Text = (pageNo + 1).ToString();
            else
                No.Text = "1";
        }

        public void NextPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList)
        {
            int pageSize = int.Parse(Size.Text);
            int pageNo = int.Parse(No.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(dataList.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dgv.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(dataList.Count / (double)pageSize);
            if (pageNo >= lastPage)
                No.Text = lastPage.ToString();
            else
                No.Text = (pageNo + 1).ToString();



        }

        public void LastPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList)
        {

            int pageSize = int.Parse(Size.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(dataList.Count / (double)pageSize) - 1;
            dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dgv.Refresh();
            //ページ番号の設定
            No.Text = (pageNo + 1).ToString();
        }

        public void PageNoTextChanged(object sender)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
            {
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                }
            }
        }

        public void PageSizeTextChanged(object sender,int value)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > value)
                {
                    (sender as TextBox).Text = value.ToString();
                    return;
                }
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                    return;
                }
            }
        }

        public void PageLeave(TextBox Page)
        {
            if (String.IsNullOrEmpty(Page.Text))
            {
                Page.Text = "1";
            }
        }

        public void PageKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void LimitValueKeyPress(object sender, KeyPressEventArgs e, int value)
        {
            if ((sender as TextBox).Text.Length < value)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if ((sender as TextBox).Text.Length == value)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }

        public void LimitStringKeyPress(object sender, KeyPressEventArgs e, int value)
        {
            if ((sender as TextBox).Text.Length < value)
            {
                e.Handled = true;
            }
            else if ((sender as TextBox).Text.Length == value)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }


        public void KeyIDKeyPress(object sender, TextBox KeyID)
        {
            KeyID.Text = (sender as TextBox).Text;
        }

        public void SetFormDataGridView(TextBox Size, TextBox No, DataGridView dgv,int value)
        {
            Size.Text = value.ToString();
            No.Text = "1";
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public int ComboBoxHint(object sender)
        {
            switch ((sender as ComboBox).Text)
            {
                case "登録":
                    return 1;
                case "検索":
                    return 2;
                case "更新":
                    return 3;
                case "非表示":
                    return 4;
                case "確定":
                    return 5;
                case "詳細登録":
                    return 6;
                case "詳細検索":
                    return 7;
                case "詳細更新":
                    return 8;
            }
            return 0;
        }
    }
}