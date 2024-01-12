using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SalesManagement_SysDev.Common
{
    public class CommonModule
    {

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool keyPressed = false;
            // バックスペース以外のすべてのキーで処理する
            if (e.KeyCode != Keys.Back)
            {
                // 1文字分しか処理しない
                if (!keyPressed)
                {
                    e.Handled = true;
                }
            }
        }

        public void FirstPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList, Button sort)
        {
            if (dataList.Count != 0)
            {
                int pageSize = int.Parse(Size.Text);
                switch (sort.Text)
                {
                    case "降順":
                        dgv.DataSource = dataList.AsEnumerable().Reverse().Take(pageSize).ToList();
                        break;
                    case "昇順":
                        dgv.DataSource = dataList.Take(pageSize).ToList();
                        break;
                }
                dgv.Refresh();
                No.Text = "1";
            }
        }

        public void PreviousPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList,Button sort)
        {
            if (dataList.Count != 0)
            {
                int pageSize = int.Parse(Size.Text);
                int pageNo = int.Parse(No.Text) - 2;
                switch (sort.Text)
                {
                    case "降順":
                        dgv.DataSource = dataList.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                        break;
                    case "昇順":
                        dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();
                        break;
                }

                dgv.Refresh();

                if (pageNo + 1 > 1)
                    No.Text = (pageNo + 1).ToString();
                else
                    No.Text = "1";
            }

        }

        public void NextPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList, Button sort)
        {
            if (dataList.Count != 0)
            {
                int pageSize = int.Parse(Size.Text);
                int pageNo = int.Parse(No.Text);
                int lastNo = (int)Math.Ceiling(dataList.Count / (double)pageSize) - 1;
                if (pageNo <= lastNo)
                {
                    switch (sort.Text)
                    {
                        case "降順":
                            dgv.DataSource = dataList.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                            break;
                        case "昇順":
                            dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();
                            break;
                    }
                }

                dgv.Refresh();
                int lastPage = (int)Math.Ceiling(dataList.Count / (double)pageSize);
                if (pageNo >= lastPage)
                    No.Text = lastPage.ToString();
                else
                    No.Text = (pageNo + 1).ToString();
            }


        }

        public void LastPageClick(TextBox Size, TextBox No, DataGridView dgv, List<object> dataList, Button sort)
        {
            if (dataList.Count != 0)
            {
                int pageSize = int.Parse(Size.Text);
                int pageNo = (int)Math.Ceiling(dataList.Count / (double)pageSize) - 1;
                switch (sort.Text)
                {
                    case "降順":
                        dgv.DataSource = dataList.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                        break;
                    case "昇順":
                        dgv.DataSource = dataList.Skip(pageSize * pageNo).Take(pageSize).ToList();
                        break;
                }
                dgv.Refresh();
                No.Text = (pageNo + 1).ToString();
            }
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
                if ((sender as TextBox).Text.Substring(0,1) == "0")
                {
                    (sender as TextBox).Text = "1";
                    return;
                }
            }
        }

        public void PriceTextChanged(object sender)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                decimal decimalValue;

                // Decimal型に変換できるか確認
                if (decimal.TryParse((sender as TextBox).Text, out decimalValue))
                {
                    // Decimal型からInt型に変換
                    int intValue = (int)decimalValue;

                    // 変換後の値をテキストボックスにセット
                    (sender as TextBox).Text = intValue.ToString();
                }
            }
        }

        public void PageLeave(TextBox Page,int value)
        {
            if (String.IsNullOrEmpty(Page.Text))
            {
                Page.Text = value.ToString();
            }
        }

        public void ValueKeyPress(KeyPressEventArgs e)
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
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

        public int ComboBoxCondition(string cmbText)
        {
            switch (cmbText)
            {
                case "完全一致":
                    return 0;
                case "部分一致":
                    return 0;
                case "不一致":
                    return 3;
                case "以降":
                    return 1;
                case "以前":
                    return 2;
                case "以上":
                    return 1;
                case "以下":
                    return 2;
            }
            return 0;
        }

        public void CellFormatting(DataGridViewCellFormattingEventArgs e, int cell, int data)
        {
            switch (data)
            {
                case 1:
                    if (e.ColumnIndex == cell)
                        switch (e.Value)
                        {
                            case 0:
                                e.Value = "未確定";
                                break;
                            case 1:
                                e.Value = "確定済";
                                e.CellStyle.ForeColor = Color.Fuchsia;
                                break;
                        }
                    break;
                case 2:
                    if (e.ColumnIndex == cell)
                        switch (e.Value)
                        {
                            case 0:
                                e.Value = "表示";
                                break;
                            case 2:
                                e.Value = "非表示";
                                e.CellStyle.ForeColor = Color.Fuchsia;
                                break;
                        }
                    break;
                case 3:
                    if (e.ColumnIndex == cell)
                        switch (e.Value)
                        {
                            case 0:
                                e.Value = "充分";
                                break;
                            case 1:
                                e.Value = "不足";
                                e.CellStyle.ForeColor = Color.Red;
                                break;
                        }
                    break;
            }

        }

        public void FlagTextChanged(TextBox flag,int chk)
        {
            switch (chk)
            {
                case 1:
                    if (flag.Text == "0")
                    {
                        flag.Text = "未確定";
                    }
                    else if (flag.Text == "1")
                    {
                        flag.Text = "確定済";
                    }
                    break;
                case 2:
                    if (flag.Text == "0")
                    {
                        flag.Text = "表示";

                    }
                    else if (flag.Text == "2")
                    {
                        flag.Text = "非表示";
                    }
                    break;
                case 3:
                    if (flag.Text == "0")
                    {
                        flag.Text = "充分";

                    }
                    else if (flag.Text == "1")
                    {
                        flag.Text = "不足";
                    }
                    break;
            }
        }


        public bool ButtonEnabled(TextBox flag, int chk)
        {
            switch (chk)
            {
                case 1:
                    if (flag.Text == "未確定")
                        return true;
                    break;
                case 2:
                    if (flag.Text == "表示")
                        return true;
                    break;
            }
            return false;
        }

        public void SortButtonChanged(object sender)
        {
            switch((sender as Button).Text)
            {
                case "昇順":
                    (sender as Button).Text = "降順";
                    break;
                case "降順":
                    (sender as Button).Text = "昇順";
                    break;
            }

        }
    }
}