using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_AdClient : Form
    {
        //他クラスのインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();

        private static List<M_Client> Client;

        public F_AdClient()
        {
            InitializeComponent();
        }

        private void F_Client_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            //SetFormComboBox();
            SetFormDataGridView();
            fncButtonEnable(0);
        }

        //private void SetFormComboBox()
        //{
        //}

        private void SetFormDataGridView()
        {
            txbPageSize.Text = "10";
            txbPageNo.Text = "1";
            dataGridViewDsp.ReadOnly = true;
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Client = clientDataAccess.GetClientData();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Client.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 100;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[4].Width = 100;
            dataGridViewDsp.Columns[5].Width = 100;
            dataGridViewDsp.Columns[6].Width = 100;
            dataGridViewDsp.Columns[7].Width = 100;
            dataGridViewDsp.Columns[8].Width = 100;
            dataGridViewDsp.Columns[9].Width = 100;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblPage.Text = "/" + ((int)Math.Ceiling(Client.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbClName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbClAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbClPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbClPostal.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbClFAX.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbClFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbClHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbClHidden.Text = String.Empty;
        }


        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                //顧客IDが空であれば0、でなければ1
                case 0:
                    btnRegist.Enabled = true;
                    btnSearch.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnHidden.Enabled = false;
                    break;
                case 1:
                    btnRegist.Enabled = true;
                    btnSearch.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnHidden.Enabled = true;
                    break;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtSelect())
                return;
            //顧客情報抽出
            GenereteDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }

        private bool GetValidDataAtSelect()
        {
            if (!String.IsNullOrEmpty(txbClID.Text.Trim()))
            {
                //数値かどうか確認
                if (!dataInputFormCheck.CheckNumeric(txbClID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
                //6文字以内か確認
                if (txbClID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            return true;
        }

        private void GenereteDataAdSelect()
        {
            M_Client selectCondition = new M_Client()
            {
                ClID = int.Parse(txbClID.Text.Trim()),
            };
            //顧客データの抽出
            Client = clientDataAccess.GetClientData(selectCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Client;

            lblPage.Text = "/" + ((int)Math.Ceiling(Client.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtUpdate())
                return;

            var updCl= GenerateDataAtUpdate();

            UpdateClient(updCl);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!String.IsNullOrEmpty(txbClID.Text.Trim()))
            {
                if (!dataInputFormCheck.CheckNumeric(txbClID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
                if (txbClID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
                if (!clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text.Trim())))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            return false;
        }

        private M_Client GenerateDataAtUpdate()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClID.Text.Trim()),
            };
        }


        private void UpdateClient(M_Client updCl)
        {
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            bool flg = clientDataAccess.UpdateClientData(updCl);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbClID.Focus();

            GetDataGridView();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            SetFormDataGridView();
        }

        private void labelLoginName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {

            dataGridViewDsp.Rows.Clear();
            SetFormDataGridView();
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (GetValidDataAtDelete())
                return;

            int mClID = int.Parse((txbClID.Text.Trim()));
            DialogResult result = messageDsp.MsgDsp("",mClID,txbClName.Text);
            if (result == DialogResult.Cancel)
                return;

            GenerateDataAtHidden();
        }

        private bool GetValidDataAtDelete()
        {
            if (!String.IsNullOrEmpty(txbClID.Text.Trim()))
            {
                if (dataInputFormCheck.CheckNumeric(txbClID.Text.Trim()))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
                if (txbClID.TextLength > 6)
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
                if (clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text)))
                {
                    messageDsp.MsgDsp("");
                    txbClID.Focus();
                    return false;
                }
            }
            else
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            if (!String.IsNullOrEmpty(txbClHidden.Text.Trim()))
            {
                messageDsp.MsgDsp("");
                txbClHidden.Focus();
                return false;
            }

            return true;
        }

        private M_Client GenerateDataAtHidden()
        {
            return new M_Client
            {
                ClID = int.Parse(txbClID.Text),
            };
        }



        private void txbClID_TextChanged(object sender, EventArgs e)
        {
            if (txbClID.Text == "" || txbClID.Text == null)
                fncButtonEnable(0);
            else
                fncButtonEnable(1);
        }

        private void btnPageSizeChange_Click(object sender, EventArgs e)
        {

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }
    }
}
