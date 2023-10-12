using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_AdClient : Form
    {
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
            SetFormComboBox();
            SetFormDataGridView();
        }

        private void SetFormComboBox()
        {

        }
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
            int pageNo = int.Parse(txbPageNo.Text)-1;
            dataGridViewDsp.DataSource = Client.Skip(pageSize + pageNo).Take(pageSize).ToList();

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
                    messageDsp.DspMsg("");
                    txbClID.Focus();
                    return false;
                }
                //6文字以内か確認
                if (txbClID.TextLength >= 6)
                {
                    messageDsp.DspMsg("");
                    txbClID.Focus();
                    return false;
                }
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
          
        }

    

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void labelLoginName_Click(object sender, EventArgs e)
        {

        }
    }
}
