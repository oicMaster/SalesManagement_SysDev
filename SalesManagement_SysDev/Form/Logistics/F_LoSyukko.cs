using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_LoSyukko : Form
    {
        F_LoMenu LoMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        SyukkoDataAccess syukkoDataAccess = new SyukkoDataAccess();
        SyukkoDetailDataAccess syukkoDetailDataAccess = new SyukkoDetailDataAccess();
        private static List<T_Syukko> Syukko;
        private static List<T_SyukkoDetail> SyukkoDetail;
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();

        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();



        public F_LoSyukko(F_LoMenu loMenu, string ID, string Name)
        {
            InitializeComponent();
            LoMenu = loMenu;
            Text = "出庫管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;


            txbSyID.TabIndex = 0;
            txbSoID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            txbClID.TabIndex = 3;
            txbOrID.TabIndex = 4;
            dtpDate.TabIndex = 5;
            txbHidden.TabIndex = 6;

            txbSyDetailID.TabIndex = 7;
            txbSyIDsub.TabIndex = 8;
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
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("非表示更新");
            cmbHint.Items.Add("確定");
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
        private void F_Syukko_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            fncButtonEnable(2);

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
            }
        }


        private void fncTextColor(string Item)
        {
            switch (Item)
            {
                case "一覧表示":
                    lblSyID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;

                    lblSyDetailID.ForeColor = Color.Black;
                    lblSyIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;

                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;

                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "検索":
                    lblSyID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblClID.ForeColor = Color.Blue;
                    lblOrID.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblSyDetailID.ForeColor = Color.Black;
                    lblSyIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    lblDateCondition.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "非表示更新":
                    lblSyID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Red;
                    lblSyDetailID.ForeColor = Color.Black;
                    lblSyIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "確定":
                    lblSyID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    lblSyDetailID.ForeColor = Color.Black;
                    lblSyIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "詳細検索":
                    lblSyID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblSyDetailID.ForeColor = Color.Blue;
                    lblSyIDsub.ForeColor = Color.Blue;
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
            if (!int.TryParse(txbSyID.Text, out int syID))
                syID = 0;
            T_SyukkoDetail selectCondition = new T_SyukkoDetail()
            {
                SyDetailID = 0,
                SyID = syID,
                PrID = 0,
                SyQuantity = 0,
            };
            SyukkoDetail = syukkoDetailDataAccess.GetSyukkoDetailData(selectCondition, 0);
        }


        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Syukko = syukkoDataAccess.GetSyukkoData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Syukko.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Syukko.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Syukko.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            //列幅の指定
            dataGridViewDsp.Columns[0].Width = 140;
            dataGridViewDsp.Columns[1].Width = 140;
            dataGridViewDsp.Columns[2].Width = 140;
            dataGridViewDsp.Columns[3].Width = 140;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 210;
            dataGridViewDsp.Columns[6].Width = 200;
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[8].Width = 567;

            //列の文字の位置の指定
            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "出庫ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[4].HeaderText = "受付ID";
            dataGridViewDsp.Columns[5].HeaderText = "出庫年月日";
            dataGridViewDsp.Columns[6].HeaderText = "出庫状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "出庫管理フラグ";
            dataGridViewDsp.Columns[8].HeaderText = "非表示理由";


            dataGridViewDsp.Columns[9].Visible = false;
            dataGridViewDsp.Columns[10].Visible = false;
            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            txbSyID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value != null)
                txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
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
            SyukkoDetail = syukkoDetailDataAccess.GetSyukkoDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            dataGridViewDetailDsp.DataSource = SyukkoDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

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

            dataGridViewDetailDsp.Columns[0].HeaderText = "出庫詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "出庫ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(SyukkoDetail.Count / (double)pageSize)) + "ページ";

            dataGridViewDetailDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 10);
            SetDataGridView();
        }
        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageNo, 1);
            SetDataGridView();
        }

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize, 10);
            SetDataGridView();
        }
        private void txbDetailPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageNo, 1);
            SetDetailDataGridView();
        }

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 6, 1);
            commonModule.CellFormatting(e, 7, 2);
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
        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbStateFlag, 1);
            commonModule.FlagTextChanged(txbFlag, 2);
            //フラグ数値_日本語化　(1確定未確定 2表示非表示)
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
                syukkoDataAccess.GetSyukkoFlagData(sender, txbStateFlag, txbFlag);
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
            commonModule.KeyIDKeyPress(sender, txbSyIDsub);
        }


        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbHidden.Text))
            {
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                    fncButtonEnable(3);
            }
            else
                fncButtonEnable(2);
        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbSyID);
        }

        private void txbPrID_TextChanged(object sender, EventArgs e)
        {
            productDataAccess.GetProductNameData(sender, lblPrName);
        }

        private void txbClID_TextChanged(object sender, EventArgs e)
        {
            clientDataAccess.GetClientNameData(sender, lblClName);
        }

        private void txbEmID_TextChanged(object sender, EventArgs e)
        {
            employeeDataAccess.GetEmployeeNameData(txbEmID.Text, lblEmName);
        }

        private void txbSoID_TextChanged(object sender, EventArgs e)
        {
            salesOfficeDataAccess.GetSalesOfficeNameData(sender, lblSoName);
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



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Syukko), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Syukko), btnSort);
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Syukko), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Syukko), btnSort);
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(SyukkoDetail), btnDetailSort);
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(SyukkoDetail), btnDetailSort);
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(SyukkoDetail), btnDetailSort);
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(SyukkoDetail), btnDetailSort);
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
            txbSyID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
            txbSyDetailID.Text = String.Empty;
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

            T_Syukko selectCondition = new T_Syukko()
            {
                SoID = 0,
                EmID = 0,
                ClID = 0,
                OrID = 0,
                SyDate = null,
                SyFlag = Flag,
                SyStateFlag = StateFlag,
                SyHidden = null
            };

            Syukko = syukkoDataAccess.GetSyukkoData(selectCondition, 0);
            SyukkoDetail = syukkoDetailDataAccess.GetSyukkoDetailData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            LoMenu.Show();
            Dispose();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenereteDataAdSelect();
            SetSelectData();
            if (cbxLink.Checked)
            {
                GenerateDetailLinkData();
                SetDetailDataGridView();
            }
        }

        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime? date = null;

            if (!int.TryParse(txbSyID.Text, out int syID))
                syID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;

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
            T_Syukko selectCondition = new T_Syukko()
            {
                SyID = syID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                OrID = orID,
                SyDate = date,
                SyFlag = Flag,
                SyStateFlag = StateFlag
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Syukko = syukkoDataAccess.GetSyukkoData(selectCondition, dateCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Syukko.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Syukko.Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Syukko.Count / (double)pageSize)) + "ページ";
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updSy = GenerateDataAtUpdate();
            UpdateSyukko(updSy);
        }
        private T_Syukko GenerateDataAtUpdate()
        {
            return new T_Syukko
            {
                SyID = int.Parse(txbSyID.Text),
                SoID = 0,
                EmID = 0,
                ClID = 0,
                OrID = 0,
                SyDate = null,
                SyStateFlag = 0,
                SyFlag = 2,
                SyHidden = txbHidden.Text
            };
        }

        private void UpdateSyukko(T_Syukko updSy)
        {
            DialogResult result = messageDsp.MsgDspQ("M1001", lblSyID, txbSyID);
            if (result == DialogResult.Cancel)
                return;

            bool flg = syukkoDataAccess.UpdateSyukkoData(updSy);
            if (flg == true)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnUpdate.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M1002", lblSyID, txbSyID);
            }
            else
            {
                messageDsp.MsgDsp("M1003", lblSyID, txbSyID);
                return;
            }

            ClearInput();
            txbSyID.Focus();
            GetDataGridView();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var updSy = GenerateDataAtConfirm();
            ConfirmSyukko(updSy);
        }

        private T_Syukko GenerateDataAtConfirm()
        {

            return new T_Syukko
            {
                SyID = int.Parse(txbSyID.Text),
                SoID = 0,
                EmID = int.Parse(lblLoginIDData.Text),
                ClID = 0,
                OrID = 0,
                SyDate = DateTime.Now,
                SyStateFlag = 1,
                SyFlag = 0,
                SyHidden = null
            };
        }

        private void ConfirmSyukko(T_Syukko updSy)
        {
            DialogResult result = messageDsp.MsgDspQ("M3001", lblSyID, txbSyID);
            if (result == DialogResult.Cancel)
                return;


            bool Mflg = syukkoDataAccess.ConfirmSyukkoToArrival(int.Parse(txbSyID.Text), int.Parse(lblLoginIDData.Text));
            bool Sflag = false;
            if (Mflg)
            {
                //メインが登録出来たら詳細の登録、管理側の更新
                Sflag = syukkoDetailDataAccess.ConfirmSyukkoDetailToArrivalDetail(int.Parse(txbSyID.Text))
                 && syukkoDataAccess.UpdateSyukkoData(updSy);
                if (!Sflag)
                {//どちらかが失敗した際に、メイン側の登録をなかったことにする(非表示理由をSystemErrorとして、非表示にする)
                    var updAr = arrivalDataAccess.GenerateDataAdError();
                    arrivalDataAccess.UpdateArrivalData(updAr);
                }
            }

            if (Mflg && Sflag)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnConfirm.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M3002", lblSyID, txbSyID);
                //●●ID:00の処理を確定しました。
            }
            else
            {
                messageDsp.MsgDsp("M3003", lblSyID, txbSyID);
                //●●ID:00の確定に失敗しました。
                return;
            }

            ClearInput();
            txbSyID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }



        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenerateDetailDataAdSelect();
            SetSelectDetailData();
        }
        private void GenerateDetailDataAdSelect()
        {
            if (!int.TryParse(txbSyDetailID.Text, out int syDetailID))
                syDetailID = 0;
            if (!int.TryParse(txbSyIDsub.Text, out int syID))
                syID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbSyID.Text, out int syQuantity))
                syQuantity = 0;

            //検索に使用するデータ
            T_SyukkoDetail selectCondition = new T_SyukkoDetail()
            {
                SyDetailID = syDetailID,
                SyID = syID,
                PrID = prID,
                SyQuantity = syQuantity
            };
            //arデータの抽出
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            SyukkoDetail = syukkoDetailDataAccess.GetSyukkoDetailData(selectCondition, quantityCondition);
        }

        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = SyukkoDetail.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = SyukkoDetail.Take(pageSize).ToList();
                    break;
            }
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(SyukkoDetail.Count / (double)pageSize)) + "ページ";
        }
    }
}
