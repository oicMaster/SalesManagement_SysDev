using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SalesManagement_SysDev
{
    public partial class F_AdArrival : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ArrivalDataAccess arrivalDataAccess = new ArrivalDataAccess();
        ArrivalDetailDataAccess arrivalDetailDataAccess = new ArrivalDetailDataAccess();
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        OrderDataAccess orderDataAccess = new OrderDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        ClientDataAccess clientDataAccess = new ClientDataAccess();
        CommonModule commonModule = new CommonModule();

        private static List<T_Arrival> Arrival;
        private static List<T_ArrivalDetail> ArrivalDetail;

        public F_AdArrival()
        {
            InitializeComponent();

        }

        private void F_Arrival_Load(object sender, EventArgs e)
        {
            //lblLoginNameData.Text = "管理者："+FormMenu.lblLoginName;
            //lblLoginIDData.Text = FormMenu.lblLoginID;
            dtpDate.Value = DateTime.Now;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            fncButtonEnable(0);
            fncButtonEnable(4);





            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("非表示");
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
                    break;
                case 4:
                    btnUpdate.Enabled = false;
                    break;
                case 5:
                    btnUpdate.Enabled = true;
                    break;

            }
        }

        private void fncTextColor(int chk)
        {
            switch (chk)
            {
                case 0:
                    lblArID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblArDetailID.ForeColor = Color.Black;
                    lblArIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    break;
                case 2:
                    lblArID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblClID.ForeColor = Color.Blue;
                    lblOrID.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Blue;
                    lblHidden.ForeColor = Color.Black;
                    lblArDetailID.ForeColor = Color.Black;
                    lblArIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    break;
                case 4:
                    lblArID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Black;
                    lblArDetailID.ForeColor = Color.Black;
                    lblArIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;
                case 5:
                    lblArID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblArDetailID.ForeColor = Color.Black;
                    lblArIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;
                case 7:
                    lblArID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblArDetailID.ForeColor = Color.Blue;
                    lblArIDsub.ForeColor = Color.Blue;
                    lblPrID.ForeColor = Color.Blue;
                    lblQuantity.ForeColor = Color.Blue;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;

            }
        }

        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Arrival = arrivalDataAccess.GetArrivalData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text);

            dataGridViewDsp.DataSource = Arrival;
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Arrival.Count / (double)pageSize)) + "ページ";


            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            //dataGridViewDsp.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            //dataGridViewDsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridViewDsp.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dataGridViewDsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridViewDsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridViewDsp.Columns[0].Width = 140;
            dataGridViewDsp.Columns[1].Width = 140;
            dataGridViewDsp.Columns[2].Width = 140;
            dataGridViewDsp.Columns[3].Width = 140;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 200;
            dataGridViewDsp.Columns[6].Width = 200;
            dataGridViewDsp.Columns[7].Width = 200;
            dataGridViewDsp.Columns[8].Width = 577;


            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "入荷ID";
            dataGridViewDsp.Columns[1].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[4].HeaderText = "受付ID";
            dataGridViewDsp.Columns[5].HeaderText = "入荷年月日";
            dataGridViewDsp.Columns[6].HeaderText = "入荷状態フラグ";
            dataGridViewDsp.Columns[7].HeaderText = "入荷管理フラグ";
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
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value != null)
                txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            //※
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
            ArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDetailDsp.DataSource = ArrivalDetail;
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(ArrivalDetail.Count / (double)pageSize)) + "ページ";



            dataGridViewDetailDsp.RowHeadersVisible = false;
            dataGridViewDetailDsp.Font = new Font("MS UI Gothic", 18);
            dataGridViewDetailDsp.Columns[0].Width = 250;
            dataGridViewDetailDsp.Columns[1].Width = 250;
            dataGridViewDetailDsp.Columns[2].Width = 250;
            dataGridViewDetailDsp.Columns[3].Width = 237;


            dataGridViewDetailDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetailDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDetailDsp.Columns[0].HeaderText = "入荷詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "入荷ID";
            dataGridViewDetailDsp.Columns[2].HeaderText = "商品ID";
            dataGridViewDetailDsp.Columns[3].HeaderText = "数量";


            dataGridViewDetailDsp.Columns[4].Visible = false;
            dataGridViewDetailDsp.Columns[5].Visible = false;

            dataGridViewDetailDsp.Refresh();
        }

        private void dataGridViewDetailDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDetailDsp.SelectedCells.Count == 0)
                return;
            txbArDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbArIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }


        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize);
            SetDataGridView();
        }

        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize);
            SetDataGridView();
        }
        private void txbDetailPageNo_Leave(object sender, EventArgs e)
        {
            SetDataGridView();
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
                fncButtonEnable(4);
            }
            else
            {
                fncButtonEnable(1);
                if (!String.IsNullOrEmpty(txbHidden.Text))
                    fncButtonEnable(5);
            }
            commonModule.KeyIDKeyPress(sender, txbArIDsub);
        }
        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbHidden.Text))
            {
                if (!String.IsNullOrEmpty(txbArID.Text))
                    fncButtonEnable(5);
            }
            else
                fncButtonEnable(4);

        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbArID);
        }

        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.PageKeyPress(e);
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
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Arrival.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbPageNo.Text = (pageNo + 1).ToString();
            else
                txbPageNo.Text = "1";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(Arrival.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Arrival.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Arrival.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Arrival.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            dataGridViewDetailDsp.DataSource = ArrivalDetail.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = "1";
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text) - 2;
            dataGridViewDetailDsp.DataSource = ArrivalDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            if (pageNo + 1 > 1)
                txbDetailPageNo.Text = (pageNo + 1).ToString();
            else
                txbDetailPageNo.Text = "1";
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            int pageNo = int.Parse(txbDetailPageNo.Text);
            //最終ページの計算
            int lastNo = (int)Math.Ceiling(ArrivalDetail.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDetailDsp.DataSource = ArrivalDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(ArrivalDetail.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbDetailPageNo.Text = lastPage.ToString();
            else
                txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbDetailPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(ArrivalDetail.Count / (double)pageSize) - 1;
            dataGridViewDetailDsp.DataSource = ArrivalDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDetailDsp.Refresh();
            //ページ番号の設定
            txbDetailPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbArID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GenerateDataAdDisplay();
            SetDataGridView();
            GetDetailDataGridView();
        }
        private void GenerateDataAdDisplay()
        {
            int Flag = 0;
            int StateFlag = 0;
            if (cbxConfirm.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked)
                Flag = 3;

            T_Arrival selectCondition = new T_Arrival()
            {
                ArFlag = Flag,
                ArStateFlag = StateFlag
            };

            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
             Arrival = arrivalDataAccess.GetArrivalData(selectCondition, dateCondition);
        }
            private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenereteDataAdSelect();
            //Ar情報抽出結果
            SetSelectData();
        }
        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime date = DateTime.Parse("0001/01/01");

            if (!int.TryParse(txbArID.Text, out int arID))
                arID = 0;
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
            if (cbxConfirm.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked)
                Flag = 3;


            //検索に使用するデータ
            T_Arrival selectCondition = new T_Arrival()
            {//検索に使用するデータ　全て変数で行う
                ArID = arID,
                SoID = soID,
                EmID = emID,
                ClID = clID,
                OrID = orID,
                ArDate = date,
                ArFlag = Flag,
                ArStateFlag = StateFlag
            };
            //arデータの抽出
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Arrival = arrivalDataAccess.GetArrivalData(selectCondition, dateCondition);

        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Arrival;
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Arrival.Count / (double)pageSize)) + "ページ";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updAr = GenerateDataAtUpdate();
            //エラー文を書かなきゃダメ

            //顧客情報更新
            UpdateArrival(updAr);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!arrivalDataAccess.CheckArIDExistence(int.Parse(txbArID.Text)))
            {
                messageDsp.MsgDsp("");
                txbArID.Focus();
                return false;
            }
            if (!salesOfficeDataAccess.CheckSoIDExistence(int.Parse(txbSoID.Text)))
            {
                messageDsp.MsgDsp("");
                txbSoID.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmID.Text))
            {
                if (!employeeDataAccess.CheckEmIDExistence(int.Parse(txbEmID.Text)))
                {
                    messageDsp.MsgDsp("");
                    txbEmID.Focus();
                    return false;
                }
            }
            if (!clientDataAccess.CheckClIDExistence(int.Parse(txbClID.Text)))
            {
                messageDsp.MsgDsp("");
                txbClID.Focus();
                return false;
            }
            if (!orderDataAccess.CheckOrIDExistence(int.Parse(txbOrID.Text)))
            {
                messageDsp.MsgDsp("");
                txbOrID.Focus();
                return false;
            }
            return true;
        }

        private T_Arrival GenerateDataAtUpdate()
        {
            return new T_Arrival
            {
                ArID = int.Parse(txbClID.Text),
                //足りない
                ArHidden = txbHidden.Text.Trim()
            };
        }

        private void UpdateArrival(T_Arrival updAr)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = arrivalDataAccess.UpdateArrivalData(updAr);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbArID.Focus();
            GetDataGridView();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //foreach()

        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            GenerateDetailDataAdSelect();
            SetSelectDetailData();
        }

        private void GenerateDetailDataAdSelect()
        {
            if (!int.TryParse(txbArDetailID.Text, out int arDetailID))
                arDetailID = 0;
            if (!int.TryParse(txbArIDsub.Text, out int arID))
                arID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if(!int.TryParse(txbPrID.Text,out int arQuantity))
                arQuantity = 0;
            T_ArrivalDetail selectCondition = new T_ArrivalDetail()
            {
                ArDetailID = arDetailID,
                ArID = arID,
                PrID = prID,
                ArQuantity = arQuantity,
            };
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            ArrivalDetail = arrivalDetailDataAccess.GetArrivalDetailData(selectCondition, quantityCondition);
        }
        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDetailDsp.DataSource = ArrivalDetail;
            lblPageNo.Text = "/" + ((int)Math.Ceiling(ArrivalDetail.Count / (double)pageSize)) + "ページ";
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chk = commonModule.ComboBoxHint(sender);
            fncTextColor(chk);
        }
    }
}
