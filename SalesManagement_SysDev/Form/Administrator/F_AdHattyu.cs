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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SalesManagement_SysDev
{
    public partial class F_AdHattyu : Form
    {
        F_AdMenu AdMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        HattyuDataAccess hattyuDataAccess = new HattyuDataAccess();
        HattyuDetailDataAccess hattyuDetailDataAccess = new HattyuDetailDataAccess();
        private static List<T_Hattyu> Hattyu;
        private static List<T_HattyuDetail> HattyuDetail;
        WarehousingDataAccess warehousingDataAccess = new WarehousingDataAccess();
        WarehousingDetailDataAccess warehousingDetailDataAccess = new WarehousingDetailDataAccess();
        
        StockDataAccess stockDataAccess = new StockDataAccess();
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        OrderDetailDataAccess orderDetailDataAccess = new OrderDetailDataAccess();
       



        public F_AdHattyu(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "発注管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;


            txbHaID.TabIndex = 0;
            txbMaID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            dtpDate.TabIndex = 5;
            txbHidden.TabIndex = 6;

            txbHaDetailID.TabIndex = 7;
            txbHaIDsub.TabIndex = 8;
            txbPrID.TabIndex = 9;
            txbQuantity.TabIndex = 10;

            cbxDisplay.TabIndex = 11;
            cbxConfirm.TabIndex = 12;
            cbxHidden.TabIndex = 13;

            cmbHint.TabIndex = 14;
            cmbDate.TabIndex = 15;
            cmbQuantity.TabIndex = 16;

            btnSort.TabIndex = 17;
            btnDetailSort.TabIndex = 18;
            cbxLink.TabIndex = 19;

            btnDisplay.TabIndex = 20;
            btnClear.TabIndex = 21;
            btnUpdate.TabIndex = 22;
            btnConfirm.TabIndex = 23;
            btnSearch.TabIndex = 24;
            btnDetailSearch.TabIndex = 25;

            txbPageSize.TabIndex = 26;
            txbPageNo.TabIndex = 27;

            btnFirstPage.TabIndex = 28;
            btnPreviousPage.TabIndex = 29;
            btnNextPage.TabIndex = 30;
            btnLastPage.TabIndex = 31;

            txbDetailPageSize.TabIndex = 32;
            txbDetailPageNo.TabIndex = 33;

            btnDetailFirstPage.TabIndex = 34;
            btnDetailPreviousPage.TabIndex = 35;
            btnDetailNextPage.TabIndex = 36;
            btnDetailLastPage.TabIndex = 37;

            dataGridViewDsp.TabIndex = 38;
            dataGridViewDetailDsp.TabIndex = 39;

            btnClose.TabIndex = 40;


            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("非表示更新");
            cmbHint.Items.Add("確定");
            cmbHint.Items.Add("詳細登録");
            cmbHint.Items.Add("詳細検索");
            cmbHint.SelectedIndex = 0;


            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;

            cmbQuantity.Items.Add("完全一致");
            cmbQuantity.Items.Add("以上");
            cmbQuantity.Items.Add("以下");
            cmbQuantity.SelectedIndex = 0;


            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
        private void F_Hattyu_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            fncButtonEnable(2);
            fncButtonEnable(4);
            fncButtonEnable(6);

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {
                case 0:
                    btnConfirm.Enabled = false;
                    break;
                case 1:
                    btnConfirm.Enabled = true;
                    btnConfirm.ForeColor = Color.Red;
                    break;
                case 2:
                    btnUpdate.Enabled = false;
                    break;
                case 3:
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.Red;
                    break;
                case 4:
                    btnRegist.Enabled = false;
                    break;
                case 5:
                    btnRegist.Enabled = true;
                    btnRegist.ForeColor = Color.Red;
                    break;
                case 6:
                    btnDetailRegist.Enabled = false;
                    break;
                case 7:
                    btnDetailRegist.Enabled = true;
                    btnDetailRegist.ForeColor = Color.Red;
                    break;
            }
        }


        private bool RegistrationCondition(int chk)
        {
            if (chk == 0)
            {
                if (lblMaName.Text == "----")
                    return false;
            }
            if (chk == 1)
            {
                if (txbFlag.Text != "表示" || txbStateFlag.Text != "未確定")
                    return false;
                if (String.IsNullOrEmpty(txbHaIDsub.Text))
                    return false;
            }
            if (lblPrName.Text == "----")
                return false;
            if (String.IsNullOrEmpty(txbQuantity.Text)||int.Parse(txbQuantity.Text) < 0)
                return false;

            return true;
        }

        private void fncTextColor(string Item)
        {
            switch (Item)
            {
                case "一覧表示":
                    lblHaID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "登録":
                    lblHaID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Fuchsia;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Fuchsia;
                    lblQuantity.ForeColor = Color.Fuchsia;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "検索":
                    lblHaID.ForeColor = Color.Blue;
                    lblMaID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    lblDateCondition.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "非表示更新":
                    lblHaID.ForeColor = Color.Red;
                    lblMaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "確定":
                    lblHaID.ForeColor = Color.Red;
                    lblMaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "詳細登録":
                    lblHaID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Black;
                    lblHaIDsub.ForeColor = Color.Red;
                    lblPrID.ForeColor = Color.Fuchsia;
                    lblQuantity.ForeColor = Color.Fuchsia;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "詳細検索":
                    lblHaID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblHaDetailID.ForeColor = Color.Blue;
                    lblHaIDsub.ForeColor = Color.Blue;
                    lblPrID.ForeColor = Color.Blue;
                    lblQuantity.ForeColor = Color.Blue;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Blue;
                    break;

            }
        }
        private void GenerateDetailLinkData()
        {
            if (!int.TryParse(txbHaID.Text, out int haID))
                haID = 0;
            T_HattyuDetail selectCondition = new T_HattyuDetail()
            {
                HaDetailID = 0,
                HaID = haID,
                PrID = 0,
                HaQuantity = 0,
            };
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData(selectCondition, 0);
            //IDで検索した結果をリンク表示させる
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Hattyu = hattyuDataAccess.GetHattyuData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Hattyu.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Hattyu.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Hattyu.Count / (double)pageSize)) + "ページ";


            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDsp.Columns[0].Width = 170;
            dataGridViewDsp.Columns[1].Width = 170;
            dataGridViewDsp.Columns[2].Width = 170;
            dataGridViewDsp.Columns[3].Width = 200;
            dataGridViewDsp.Columns[4].Width = 200;
            dataGridViewDsp.Columns[5].Width = 200;
            dataGridViewDsp.Columns[6].Width = 767;



            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "発注ID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "発注年月日";
            dataGridViewDsp.Columns[4].HeaderText = "入庫済フラグ";
            dataGridViewDsp.Columns[5].HeaderText = "発注管理フラグ";
            dataGridViewDsp.Columns[6].HeaderText = "非表示理由";

            
            dataGridViewDsp.Columns[7].Visible = false;
            dataGridViewDsp.Columns[8].Visible = false;
            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            
            

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            txbHaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            else
                txbHidden.Text = String.Empty;
        }

        private void SetFormDetailDataGridView()
        {
            commonModule.SetFormDataGridView(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, 10);
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = HattyuDetail.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = HattyuDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }


            dataGridViewDetailDsp.RowHeadersVisible = false;
            dataGridViewDetailDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDetailDsp.Columns[0].Width = 270;
            dataGridViewDetailDsp.Columns[1].Width = 270;
            dataGridViewDetailDsp.Columns[2].Width = 270;
            dataGridViewDetailDsp.Columns[3].Width = 317;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "発注詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "発注ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(HattyuDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDetailDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDetailDsp.SelectedCells.Count == 0)
                return;
            txbHaDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbHaIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 10);
            SetSelectData();
        }

        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageNo, 1);
            SetDataGridView();
        }

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize, 10);
            SetSelectDetailData();
        }
        private void txbDetailPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageNo, 1);
            SetDetailDataGridView();
        }

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 4, 1);
            commonModule.CellFormatting(e, 5, 2);
        }
        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
        }

        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxConfirm.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
        }
        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 10);
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
        }


        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(0);
                fncButtonEnable(2);
                txbStateFlag.Text = String.Empty;
                txbFlag.Text = String.Empty;
                if (cbxLink.Checked)
                    GetDetailDataGridView();
            }
            else
            {
                hattyuDataAccess.GetHattyuFlagData(sender, txbStateFlag, txbFlag);
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                {
                        fncButtonEnable(1);
                    if (!String.IsNullOrEmpty(txbHidden.Text))
                        fncButtonEnable(3);
                }
                else
                    fncButtonEnable(0);
                if (cbxLink.Checked)
                {
                    GenerateDetailLinkData();
                    SetDetailDataGridView();
                }

            }
            if (RegistrationCondition(1))
                fncButtonEnable(7);
            else
                fncButtonEnable(6);
            commonModule.KeyIDKeyPress(sender, txbHaIDsub);
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbHidden.Text))
            {
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                    if (!String.IsNullOrEmpty(txbHidden.Text))
                        fncButtonEnable(3);
            }
            else
                fncButtonEnable(2);
        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbHaID);
        }

        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.ValueKeyPress(e);
        }

        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 4);
        }
        private void txbMaID_TextChanged(object sender, EventArgs e)
        {
            makerDataAccess.GetMakerNameData(sender, lblMaName);
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
        }
        private void txbEmID_TextChanged(object sender, EventArgs e)
        {
            employeeDataAccess.GetEmployeeNameData(txbEmID.Text, lblEmName);
        }
        private void txbPrID_TextChanged(object sender, EventArgs e)
        {
            productDataAccess.GetProductNameData(sender, lblPrName);
            stockDataAccess.GetStockValueData(txbPrID, txbQuantity, lblStockValue, 1);
            productDataAccess.GetSafetyStockData(sender, lblSafetyStockValue);
            warehousingDetailDataAccess.GetWaQuantityData(sender,lblWaQuantityValue);
            orderDetailDataAccess.GetOrQuantityData(sender, lblOrQuantityValue);

            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
            if (RegistrationCondition(1))
                fncButtonEnable(7);
            else
                fncButtonEnable(6);
        }

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            stockDataAccess.GetStockValueData(txbPrID, txbQuantity, lblStockValue, 1);
            if (RegistrationCondition(0))
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
            if (RegistrationCondition(1))
                fncButtonEnable(7);
            else
                fncButtonEnable(6);
        }


        private void btnFirstPage_Click(object sender, EventArgs e)
        {

            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Hattyu),btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
          commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Hattyu),btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Hattyu),btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Hattyu),btnSort);
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
           commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(HattyuDetail),btnDetailSort);
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(HattyuDetail),btnDetailSort);
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(HattyuDetail),btnDetailSort);
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(HattyuDetail),btnDetailSort);
        }
        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbStateFlag, 1);
            commonModule.FlagTextChanged(txbFlag, 2);
        }



        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            SetSelectData();
        }

        private void btnDetailSort_Click(object sender, EventArgs e)
        {
            txbDetailPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            SetDetailDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            txbHaID.Text = String.Empty;
            txbMaID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
            txbHaDetailID.Text = String.Empty;
            txbPrID.Text = String.Empty;
            txbQuantity.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            txbDetailPageNo.Text = "1";
            GenerateDataAdDisplay();
            SetDataGridView();
            SetDetailDataGridView();

        }

        private void GenerateDataAdDisplay()
        {
            int Flag = 0;
            int StateFlag = 0;
            if (cbxConfirm.Checked && !cbxDisplay.Checked)
                StateFlag = 1;
            if (cbxConfirm.Checked && cbxDisplay.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = 0,
                MaID = 0,
                EmID = 0,
                HaDate = null,
                WaWarehouseFlag = StateFlag,
                HaFlag = Flag,
                HaHidden = null
            };

            Hattyu = hattyuDataAccess.GetHattyuData(selectCondition, 0);
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }







        private void btnSearch_Click(object sender, EventArgs e)
        {

            GenerateDataAdSelect();
            SetSelectData();
        }
        private void GenerateDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime? date = null;

            if (!int.TryParse(txbHaID.Text, out int haID))
                haID = 0;
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (dtpDate.Checked)
                date = dtpDate.Value;
            if (cbxConfirm.Checked && !cbxDisplay.Checked)
                StateFlag = 1;
            if (cbxConfirm.Checked && cbxDisplay.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            T_Hattyu selectCondition = new T_Hattyu()
            {
                HaID = haID,
                MaID = maID,
                EmID = emID,
                HaDate = date,
                WaWarehouseFlag = StateFlag,
                HaFlag = Flag
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Hattyu = hattyuDataAccess.GetHattyuData(selectCondition,dateCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Hattyu.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Hattyu.Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Hattyu.Count / (double)pageSize)) + "ページ";
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var regHa = GenereteDataAdRegistration();
            RegistrationHattyu(regHa);            
        }

        private T_Hattyu GenereteDataAdRegistration()
        {
            string hidden = txbHidden.Text;
            return new T_Hattyu
            {
                MaID = int.Parse(txbMaID.Text.Trim()),
                EmID = int.Parse(lblLoginIDData.Text),
                HaDate = DateTime.Now,
                WaWarehouseFlag = 0,
                HaFlag = 0,
                HaHidden = null
            };
        }

        private void RegistrationHattyu(T_Hattyu regHa)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = hattyuDataAccess.AddHattyuData(regHa);
            if (flg)
            {
                var regHaD = GenerateDetailDataAdRegistrationPlus();
                RegistrationHattyuDetailPlus(regHaD);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
        }
        private T_HattyuDetail GenerateDetailDataAdRegistrationPlus()
        {
            return new T_HattyuDetail()
            {
                HaID = hattyuDataAccess.GetHattyuIDData(),
                PrID = int.Parse(txbPrID.Text),
                HaQuantity = int.Parse(txbQuantity.Text),
            };
        }

        private void RegistrationHattyuDetailPlus(T_HattyuDetail regHaD)
        {
            bool flg = hattyuDetailDataAccess.AddHattyuDetailData(regHaD);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M0002");
            }
            else
            {
                var updHa = hattyuDataAccess.GenerateDataAdError();
                hattyuDataAccess.UpdateHattyuData(updHa);
                messageDsp.MsgDsp("M0003");
                GenerateDataAdDisplay();
                SetSelectData();
                return;
            }
            txbHaID.Focus();
            ClearInput();
            GenerateDataAdDisplay();
            SetSelectData();
            GetDetailDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updHa = GenerateDataAtUpdate();
            UpdateHattyu(updHa);
        }


        private T_Hattyu GenerateDataAtUpdate()
        {
            return new T_Hattyu
            {
                HaID = int.Parse(txbHaID.Text),
                MaID = 0,
                EmID = 0,
                HaDate = null,
                WaWarehouseFlag = 0,
                HaFlag = 2,
                HaHidden = null
            };
        }

        private void UpdateHattyu(T_Hattyu updHa)
        {
            DialogResult result = messageDsp.MsgDspQ("M2001", lblHaID, txbHaID);
            //●●ID:00を非表示にしますか？
            if (result != DialogResult.OK)
                return;

            bool flg = hattyuDataAccess.UpdateHattyuData(updHa);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M2002", lblHaID, txbHaID);
                //●●ID:00を非表示にしました。
            }
            else
            {
                messageDsp.MsgDsp("M2003", lblHaID, txbHaID);
                //●●ID:00の非表示に失敗しました。
                return;
            }


            ClearInput();
            txbHaID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var updHa = GenerateDataAdConfirm();
            ConfirmHattyu(updHa);
        }


        private T_Hattyu GenerateDataAdConfirm()
        {
            return new T_Hattyu
            {
                HaID = int.Parse(txbHaID.Text),
                MaID = 0,
                EmID = int.Parse(lblLoginIDData.Text),
                HaDate = DateTime.Now,
                WaWarehouseFlag = 1,
                HaFlag = 0,
                HaHidden = null
            };
        }
        private void ConfirmHattyu(T_Hattyu updHa)
        {
            DialogResult result = messageDsp.MsgDspQ("M3001", lblHaID, txbHaID);
            //●●ID:00の処理を確定しますか？
            if (result != DialogResult.OK)
                return;


            bool Mflg = hattyuDataAccess.ConfirmHattyuToWarehousing(int.Parse(txbHaID.Text), int.Parse(lblLoginIDData.Text));
            bool Sflag = false;
            if (Mflg)
            {
                Sflag = hattyuDetailDataAccess.ConfirmHattyuDetailToWarehousingDetail(int.Parse(txbHaID.Text))
                 && hattyuDataAccess.UpdateHattyuData(updHa);
                if (!Sflag)
                {
                    var updWa = warehousingDataAccess.GenerateDataAdError();
                    warehousingDataAccess.UpdateWarehousingData(updWa);
                }
            }
            //メインの登録、詳細の複数登録、更新の順番

            if (Mflg && Sflag)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnConfirm.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M3002", lblHaID, txbHaID);
                //●●ID:00の処理を確定しました。
            }
            else
            {
                messageDsp.MsgDsp("M3003", lblHaID, txbHaID);
                //●●ID:00の確定に失敗しました。
                return;
            }

            ClearInput();
            txbHaID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }


        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenereteDetailDataAdSelect();
            SetSelectDetailData();
        }

        private void GenereteDetailDataAdSelect()
        {
            if (!int.TryParse(txbHaDetailID.Text, out int haDetailID))
                haDetailID = 0;
            if (!int.TryParse(txbHaIDsub.Text, out int haID))
                haID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            T_HattyuDetail selectCondition = new T_HattyuDetail()
            {
                HaDetailID = haDetailID,
                HaID = haID,
                PrID = prID,
            };
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            HattyuDetail = hattyuDetailDataAccess.GetHattyuDetailData(selectCondition,quantityCondition);
        }
        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = HattyuDetail.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = HattyuDetail.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(HattyuDetail.Count / (double)pageSize)) + "ページ";
        }



        private void btnDetailRegist_Click(object sender, EventArgs e)
        {
            var regHaD = GenerateDetailDataAdRegistration();
            RegistrationHattyuDetail(regHaD);
        }
        private T_HattyuDetail GenerateDetailDataAdRegistration()
        {
            return new T_HattyuDetail()
            {
                HaID = int.Parse(txbHaID.Text),
                PrID = int.Parse(txbPrID.Text),
                HaQuantity = int.Parse(txbQuantity.Text),
            };
        }
        private void RegistrationHattyuDetail(T_HattyuDetail regHaD)
        {
            DialogResult result = messageDsp.MsgDsp("M0001");
            if (result != DialogResult.OK)
               return;

            bool flg = hattyuDetailDataAccess.AddHattyuDetailData(regHaD);
            if (flg)
            {
                messageDsp.MsgDsp("M0002");
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnDetailRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
            txbHaIDsub.Focus();
            ClearInput();
            GetDetailDataGridView();
        }
    }
}
