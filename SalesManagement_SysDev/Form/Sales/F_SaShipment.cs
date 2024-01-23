﻿using SalesManagement_SysDev.Common;
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
    public partial class F_SaShipment : Form
    {

        F_SaMenu SaMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        ShipmentDataAccess shipmentDataAccess = new ShipmentDataAccess();
        ShipmentDetailDataAccess shipmentDetailDataAccess = new ShipmentDetailDataAccess();
        private static List<T_Shipment> Shipment;
        private static List<T_ShipmentDetail> ShipmentDetail;
        SaleDataAccess saleDataAccess = new SaleDataAccess();


        ClientDataAccess clientDataAccess = new ClientDataAccess();
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        SalesOfficeDataAccess salesOfficeDataAccess = new SalesOfficeDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();





        public F_SaShipment(F_SaMenu saMenu, string ID, string Name)
        {
            InitializeComponent();
            SaMenu = saMenu;
            Text = "出荷管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            txbShID.TabIndex = 0;
            txbSoID.TabIndex = 1;
            txbEmID.TabIndex = 2;
            txbClID.TabIndex = 3;
            txbOrID.TabIndex = 4;
            dtpDate.TabIndex = 5;
            txbHidden.TabIndex = 6;

            txbShDetailID.TabIndex = 7;
            txbShIDsub.TabIndex = 8;
            txbPrID.TabIndex = 9;
            txbQuantity.TabIndex = 10;
            //↑テキストボックス
            cbxDisplay.TabIndex = 11;
            cbxConfirm.TabIndex = 12;
            cbxHidden.TabIndex = 13;
            //↑メインのチェックボックス
            cmbHint.TabIndex = 14;
            cmbDate.TabIndex = 15;
            cmbQuantity.TabIndex = 16;
            //↑条件のコンボボックス
            btnSort.TabIndex = 17;
            btnDetailSort.TabIndex = 18;
            cbxLink.TabIndex = 19;
            //↑その他機能
            btnDisplay.TabIndex = 20;
            btnClear.TabIndex = 21;
            btnUpdate.TabIndex = 22;
            btnConfirm.TabIndex = 23;
            btnSearch.TabIndex = 24;
            btnDetailSearch.TabIndex = 25;
            //↑ボタン各種

            txbPageSize.TabIndex = 26;
            txbPageNo.TabIndex = 27;
            btnFirstPage.TabIndex = 28;
            btnPreviousPage.TabIndex = 29;
            btnNextPage.TabIndex = 30;
            btnLastPage.TabIndex = 31;
            //↑メイングリッドビューの諸々

            txbDetailPageSize.TabIndex = 32;
            txbDetailPageNo.TabIndex = 33;
            btnDetailFirstPage.TabIndex = 34;
            btnDetailPreviousPage.TabIndex = 35;
            btnDetailNextPage.TabIndex = 36;
            btnDetailLastPage.TabIndex = 37;
            //↑サブグリッドビューの諸々

            dataGridViewDsp.TabIndex = 38;
            dataGridViewDetailDsp.TabIndex = 39;
            //↑グリッドビュー

            btnClose.TabIndex = 40;
            //↑閉じる


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

        private void F_Shipment_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            SetFormDataGridView();
            SetFormDetailDataGridView();
            //グリッドビューの設定
            fncButtonEnable(0);
            fncButtonEnable(2);
            //ボタンの設定

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

                    //01確定　23非表示　45登録　67詳細登録　89更新
            }
        }

        private void fncTextColor(string Item)
        {


            switch (Item)
            {
                /*
                一覧表示　チェックボックス3つを青
                登録　必須入力を赤、マスタ系と数値系とフラグのテキストボックスを紫
                検索　メイン側の非表示理由以外の入力可能なテキストボックスとチェックボックスを青、条件と日付を紫
                更新　非表示理由以外の入力可能なテキストボックスを青、非表示理由を紫
                非表示更新　主キーIDと非表示理由を赤、フラグのテキストボックスを紫
                確定　主キーIDを赤、フラグのテキストボックスを紫
                詳細登録　必須入力を赤、マスタ系と数値系とフラグのテキストボックスを紫
                詳細検索　詳細側の入力可能なテキストボックスとチェックボックスと条件を青
                 */
                case "一覧表示":
                    lblShID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblShDetailID.ForeColor = Color.Black;
                    lblShIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    //全テキストボックス分
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    //メインのチェックボックス
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    //検索条件
                    break;
                case "検索":
                    lblShID.ForeColor = Color.Blue;
                    lblSoID.ForeColor = Color.Blue;
                    lblEmID.ForeColor = Color.Blue;
                    lblClID.ForeColor = Color.Blue;
                    lblOrID.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblShDetailID.ForeColor = Color.Black;
                    lblShIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    lblDateCondition.ForeColor = Color.Blue;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "非表示更新":
                    lblShID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblShDetailID.ForeColor = Color.Black;
                    lblShIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "確定":
                    lblShID.ForeColor = Color.Red;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Fuchsia;
                    lblHidden.ForeColor = Color.Black;
                    lblShDetailID.ForeColor = Color.Black;
                    lblShIDsub.ForeColor = Color.Black;
                    lblPrID.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    cbxConfirm.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblQuantityCondition.ForeColor = Color.Black;
                    break;
                case "詳細検索":
                    lblShID.ForeColor = Color.Black;
                    lblSoID.ForeColor = Color.Black;
                    lblEmID.ForeColor = Color.Black;
                    lblClID.ForeColor = Color.Black;
                    lblOrID.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblStateFlag.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblShDetailID.ForeColor = Color.Blue;
                    lblShIDsub.ForeColor = Color.Blue;
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
            if (!int.TryParse(txbShID.Text, out int shID))
                shID = 0;
            T_ShipmentDetail selectCondition = new T_ShipmentDetail()
            {
                ShDetailID = 0,
                ShID = shID,
                PrID = 0,
                ShQuantity = 0,
            };
            ShipmentDetail = shipmentDetailDataAccess.GetShipmentDetailData(selectCondition, 0);
            //IDで検索した結果をリンク表示させる
        }




        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 10);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Shipment = shipmentDataAccess.GetShipmentData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Shipment.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Shipment.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Shipment.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);
            //列幅の指定
            dataGridViewDsp.Columns[0].Width = 140;
            dataGridViewDsp.Columns[1].Width = 140;
            dataGridViewDsp.Columns[2].Width = 140;
            dataGridViewDsp.Columns[3].Width = 140;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 200;
            dataGridViewDsp.Columns[6].Width = 210;
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

            dataGridViewDsp.Columns[0].HeaderText = "出荷ID";
            dataGridViewDsp.Columns[1].HeaderText = "顧客ID";
            dataGridViewDsp.Columns[2].HeaderText = "社員ID";
            dataGridViewDsp.Columns[3].HeaderText = "営業所ID";
            dataGridViewDsp.Columns[4].HeaderText = "受注ID";
            dataGridViewDsp.Columns[5].HeaderText = "出荷状態フラグ";
            dataGridViewDsp.Columns[6].HeaderText = "出荷年月日";
            dataGridViewDsp.Columns[7].HeaderText = "出荷管理フラグ";
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
            txbShID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbClID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value != null)
                txbEmID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            else
                txbEmID.Text = String.Empty;
            txbSoID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbOrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            txbStateFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            else
                txbHidden.Text = String.Empty;

        }

        private void SetFormDetailDataGridView()
        {
            commonModule.SetFormDataGridView(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, 10);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDetailDataGridView();
        }
        private void GetDetailDataGridView()
        {
            ShipmentDetail = shipmentDetailDataAccess.GetShipmentDetailData();
            SetDetailDataGridView();
        }


        private void SetDetailDataGridView()
        {
            int pageNo = int.Parse(txbDetailPageNo.Text) - 1;
            int pageSize = int.Parse(txbDetailPageSize.Text);

            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = ShipmentDetail.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = ShipmentDetail.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize)) + "ページ";

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

            dataGridViewDetailDsp.Columns[0].HeaderText = "出荷詳細ID";
            dataGridViewDetailDsp.Columns[1].HeaderText = "出荷ID";
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
            txbShDetailID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbShIDsub.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbPrID.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbQuantity.Text = dataGridViewDetailDsp.Rows[dataGridViewDetailDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 10);
            //空白の時に数値を入力
            SetSelectData();

        }

        private void txbPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageNo, 1);
            //空白の時に数値を入力
            SetDataGridView();
            //SetSelectDataとSetDataGridViewを間違えずに！
        }

        private void txbDetailPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageSize, 10);
            //空白の時に数値を入力
            SetSelectDetailData();
        }
        private void txbDetailPageNo_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbDetailPageNo, 1);
            //空白の時に数値を入力
            SetDetailDataGridView();
            //SetSelectDetailDataとSetDetailDataGridViewを間違えずに！
        }

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 5, 1);
            commonModule.CellFormatting(e, 7, 2);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示)
        }

        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
        }
        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxConfirm.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
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
            //下限値上限値設定
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageNoTextChanged(sender);
            //下限値設定
        }


        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                fncButtonEnable(0);
                fncButtonEnable(2);
                txbStateFlag.Text = String.Empty;
                txbFlag.Text = String.Empty;
                //↑初期状態
                if (cbxLink.Checked)
                    GetDetailDataGridView();
                //リンクしている場合、全件表示に戻す。
            }
            else
            {
                shipmentDataAccess.GetShipmentFlagData(sender, txbStateFlag, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                {//表示、未確定の場合
                    fncButtonEnable(1);
                    //確定可能
                    if (!String.IsNullOrEmpty(txbHidden.Text))
                        //非表示理由が入力されている場合
                        fncButtonEnable(3);
                   　//非表示可能
                }
                else
                    fncButtonEnable(0);
                //どちらかが非表示、確定済の場合　確定不可

                if (cbxLink.Checked)
                {
                    GenerateDetailLinkData();
                    //↑リンク用検索メソッド
                    SetDetailDataGridView();
                }
                //リンクしている場合、IDで詳細検索した結果を渡す。
            }
            commonModule.KeyIDKeyPress(sender, txbShIDsub);
            //詳細側のテキストボックスと連動
        }
        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbHidden.Text))
            {
                if (commonModule.ButtonEnabled(txbStateFlag, 1) && commonModule.ButtonEnabled(txbFlag, 2))
                    fncButtonEnable(3);
                //非表示理由が空白でない、フラグが表示・未確定である場合に非表示可能
                //フラグに文字が表示されてる=IDのテキストボックスに何かしら入力されている状態
            }
            else
                fncButtonEnable(2);
            //非表示理由が空白の場合、非表示不可

        }

        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            commonModule.KeyIDKeyPress(sender, txbShID);
            //メイン側のテキストボックスと連動
        }

        //名前欄があるもののみ
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
            //数値のみ入力可
        }

        private void txbPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 10);
            //10文字以下の数値のみ入力可
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 6);
            //6文字以下の数値のみ入力可
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 4);
            //4文字以下の数値のみ入力可
        }




        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Shipment), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Shipment), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Shipment), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Shipment), btnSort);
        }

        private void btnDetailFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ShipmentDetail), btnDetailSort);
        }

        private void btnDetailPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ShipmentDetail), btnDetailSort);
        }

        private void btnDetailNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ShipmentDetail), btnDetailSort);
        }
        private void btnDetailLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbDetailPageSize, txbDetailPageNo, dataGridViewDetailDsp, new List<object>(ShipmentDetail), btnDetailSort);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetSelectData();
        }

        private void btnDetailSort_Click(object sender, EventArgs e)
        {
            txbDetailPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetDetailDataGridView();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbShID.Text = String.Empty;
            txbSoID.Text = String.Empty;
            txbEmID.Text = String.Empty;
            txbClID.Text = String.Empty;
            txbOrID.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbStateFlag.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
            //↑メイン↓詳細のテキストボックス、DTPの初期化(IDsubは勝手に初期化される)
            txbShDetailID.Text = String.Empty;
            txbPrID.Text = String.Empty;
            txbQuantity.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            txbDetailPageNo.Text = "1";
            GenerateDataAdDisplay();
            //チェックボックスの要素のみ検索条件に
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

            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示

            T_Shipment selectCondition = new T_Shipment()
            {
                ShID = 0,
                SoID = 0,
                EmID = 0,
                ClID = 0,
                OrID = 0,
                ShFinishDate = null,
                ShFlag = Flag,
                ShStateFlag = StateFlag,
                ShHidden = null
            };

            Shipment = shipmentDataAccess.GetShipmentData(selectCondition, 0);
            ShipmentDetail = shipmentDetailDataAccess.GetShipmentDetailData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            SaMenu.Show();
            Dispose();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenereteDataAdSelect();
            SetSelectData();
            if (cbxLink.Checked)
            {
                GenerateDetailLinkData();
                //↑リンク用検索メソッド
                SetDetailDataGridView();
            }
            //リンクしている場合、IDで詳細検索した結果を渡す。
        }
        private void GenereteDataAdSelect()
        {
            int Flag = 0;
            int StateFlag = 0;
            DateTime? date = null;


            if (!int.TryParse(txbShID.Text, out int shID))
                shID = 0;
            if (!int.TryParse(txbClID.Text, out int clID))
                clID = 0;
            if (!int.TryParse(txbEmID.Text, out int emID))
                emID = 0;
            if (!int.TryParse(txbSoID.Text, out int soID))
                soID = 0;
            if (!int.TryParse(txbOrID.Text, out int orID))
                orID = 0;

            if (dtpDate.Checked)
                date = dtpDate.Value;
            //DTPにチェックが入っている場合、検索条件に含める

            if (cbxConfirm.Checked && !cbxDisplay.Checked)
                StateFlag = 1;
            if (cbxConfirm.Checked && cbxDisplay.Checked)
                StateFlag = 3;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                Flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                Flag = 3;

            //0は表示未確定のみ　1は確定のみ　2は非表示済のみ　3は全件表示
            T_Shipment selectCondition = new T_Shipment()
            {
                ShID = shID,
                ClID = clID,
                EmID = emID,
                SoID = soID,
                OrID = orID,
                ShFinishDate = date,
                ShFlag = Flag,
                ShStateFlag = StateFlag
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            Shipment = shipmentDataAccess.GetShipmentData(selectCondition, dateCondition);
        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Shipment.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Shipment.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Shipment.Count / (double)pageSize)) + "ページ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updSh = GenerateDataAtUpdate();
            UpdateShipment(updSh);
        }

        private T_Shipment GenerateDataAtUpdate()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbShID.Text),
                SoID = 0,
                EmID = 0,
                ClID = 0,
                OrID = 0,
                ShFinishDate = null,
                ShStateFlag = 0,
                ShFlag = 2,
                ShHidden = txbHidden.Text
            };
            //非表示は　ID Flag=2 Hiddenを使用　Dateはnull
        }

        private void UpdateShipment(T_Shipment updSh)
        {
            DialogResult result = messageDsp.MsgDspQ("M2001", lblShID, txbShID);
            //●●ID:00を非表示にしますか？
            if (result != DialogResult.OK)
                return;

            bool flg = shipmentDataAccess.UpdateShipmentData(updSh);
            if (flg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M2002", lblShID, txbShID);
                //●●ID:00を非表示にしました。
            }
            else
            {
                messageDsp.MsgDsp("M2003", lblShID, txbShID);
                //●●ID:00の非表示に失敗しました。
                return;
            }

            ClearInput();
            txbShID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            SetDetailDataGridView();
            //全件表示
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var updSh = GenerateDataAtConfirm();
            ConfirmShipment(updSh);
        }
        private T_Shipment GenerateDataAtConfirm()
        {
            return new T_Shipment
            {
                ShID = int.Parse(txbShID.Text),
                SoID = 0,
                EmID = int.Parse(lblLoginIDData.Text),
                ClID = 0,
                OrID = 0,
                ShFinishDate = DateTime.Now,
                ShStateFlag = 1,
                ShFlag = 0,
                ShHidden = null
            };
        }
        private void ConfirmShipment(T_Shipment updSh)
        {
            DialogResult result = messageDsp.MsgDspQ("M3001", lblShID, txbShID);
            //●●ID:00の処理を確定しますか？
            if (result != DialogResult.OK)
                return;


            bool Mflg = shipmentDataAccess.ConfirmShipmentToSale(int.Parse(txbShID.Text), int.Parse(lblLoginIDData.Text));
            //メイン側の登録
            bool Sflag = false;
            if (Mflg)
            {
                //メインが登録出来たら詳細の登録、管理側の更新
                Sflag = shipmentDetailDataAccess.ConfirmShipmentDetailToSaleDetail(int.Parse(txbShID.Text))
                 && shipmentDataAccess.UpdateShipmentData(updSh);
                if (!Sflag)
                {//どちらかが失敗した際に、メイン側の登録をなかったことにする(非表示理由をSystemErrorとして、非表示にする)
                    var updSa = saleDataAccess.GenerateDataAdError();
                    saleDataAccess.UpdateSaleData(updSa);
                }
            }

            if (Mflg && Sflag)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), this.Text, btnConfirm.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
                messageDsp.MsgDsp("M3002", lblShID, txbShID);
                //●●ID:00の処理を確定しました。
            }
            else
            {
                messageDsp.MsgDsp("M3003", lblShID, txbShID);
                //●●ID:00の確定に失敗しました。
                return;
            }

            ClearInput();
            txbShID.Focus();
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
            if (!int.TryParse(txbShDetailID.Text, out int shDetailID))
                shDetailID = 0;
            if (!int.TryParse(txbShIDsub.Text, out int shID))
                shID = 0;
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbQuantity.Text, out int shQuantity))
                shQuantity = 0;

            T_ShipmentDetail selectCondition = new T_ShipmentDetail()
            {
                ShDetailID = shDetailID,
                ShID = shID,
                PrID = prID,
                ShQuantity = shQuantity,
            };
            int quantityCondition = commonModule.ComboBoxCondition(cmbQuantity.Text);
            //検索条件を取り出す
            ShipmentDetail = shipmentDetailDataAccess.GetShipmentDetailData(selectCondition, quantityCondition);
        }

        private void SetSelectDetailData()
        {
            txbDetailPageNo.Text = "1";
            int pageSize = int.Parse(txbDetailPageSize.Text.Trim());
            switch (btnDetailSort.Text)
            {
                case "降順":
                    dataGridViewDetailDsp.DataSource = ShipmentDetail.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDetailDsp.DataSource = ShipmentDetail.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblDetailPageNo.Text = "/" + ((int)Math.Ceiling(ShipmentDetail.Count / (double)pageSize)) + "ページ";
        }
    }
}