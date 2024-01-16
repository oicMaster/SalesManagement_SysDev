using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace SalesManagement_SysDev
{
    public partial class F_AdProduct : Form
    {

        F_AdMenu AdMenu;

        MessageDsp messageDsp = new MessageDsp();
        CommonModule commonModule = new CommonModule();
        OperationHistoryDataAccess operationHistoryDataAccess = new OperationHistoryDataAccess();

        ProductDataAccess productDataAccess = new ProductDataAccess();
        private static List<M_Product> Product;

        StockDataAccess stockDataAccess = new StockDataAccess();
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        SmallClassification smallClassificationDataAccess = new SmallClassification();
    


        public F_AdProduct(F_AdMenu adMenu, string ID, string Name)
        {
            InitializeComponent();
            AdMenu = adMenu;
            Text = "商品管理";
            lblLoginIDData.Text = ID;
            lblLoginNameData.Text = "管理者：　" + Name;

            txbPrID.MaxLength = 6;
            txbMaID.MaxLength = 6;
            txbScID.MaxLength = 6;
            txbName.MaxLength = 50;
            txbPrice.MaxLength =9;
            txbSafetyStock.MaxLength = 4;
            txbModelNumber.MaxLength = 20;
            txbColor.MaxLength = 20;


            txbPrID.TabIndex = 0;
            txbMaID.TabIndex = 1;
            txbScID.TabIndex = 2;
            txbName.TabIndex = 3;
            txbSafetyStock.TabIndex = 4;
            txbModelNumber.TabIndex = 5;
            txbColor.TabIndex = 6;
            dtpDate.TabIndex = 7;
            txbFlag.TabIndex = 8;
            txbHidden.TabIndex = 9;
            //↑テキストボックス
            cbxDisplay.TabIndex = 11;
            cbxHidden.TabIndex = 13;
            //↑メインのチェックボックス
            cmbHint.TabIndex = 14;
            cmbDate.TabIndex = 15;
            cmbPrice.TabIndex = 16;
            //↑条件のコンボボックス
            btnSort.TabIndex = 17;
            //↑その他機能
            btnDisplay.TabIndex = 20;
            btnClear.TabIndex = 21;
            btnUpdate.TabIndex = 22;
            btnSearch.TabIndex = 24;
            //↑ボタン各種

            txbPageSize.TabIndex = 26;
            txbPageNo.TabIndex = 27;
            btnFirstPage.TabIndex = 28;
            btnPreviousPage.TabIndex = 29;
            btnNextPage.TabIndex = 30;
            btnLastPage.TabIndex = 31;
            //↑メイングリッドビューの諸々

            dataGridViewDsp.TabIndex = 38;
            //↑グリッドビュー

            btnClose.TabIndex = 40;
            //↑閉じる

            cmbHint.Items.Add("一覧表示");
            cmbHint.Items.Add("登録");
            cmbHint.Items.Add("検索");
            cmbHint.Items.Add("更新");
            cmbHint.SelectedIndex = 0;


            cmbDate.Items.Add("完全一致");
            cmbDate.Items.Add("以降");
            cmbDate.Items.Add("以前");
            cmbDate.SelectedIndex = 0;


            cmbPrice.Items.Add("完全一致");
            cmbPrice.Items.Add("以上");
            cmbPrice.Items.Add("以下");
            cmbPrice.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_AdProduct_Load(object sender, EventArgs e)
        {

            SetFormDataGridView();
            fncButtonEnable(4);
            fncButtonEnable(8);

        }

        private void fncButtonEnable(int chk)
        {
            switch (chk)
            {

                case 4:
                    btnRegist.Enabled = false;
                    break;
                case 5:
                    btnRegist.Enabled = true;
                    btnRegist.ForeColor = Color.Red;
                    break;
                case 8:
                    btnUpdate.Enabled = false;
                    break;
                case 9:
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
                case "一覧表示":
                    lblPrID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Black;
                    lblScID.ForeColor = Color.Black;
                    lblName.ForeColor = Color.Black;
                    lblSafetyStock.ForeColor = Color.Black;
                    lblModelNumber.ForeColor = Color.Black;
                    lblColor.ForeColor = Color.Black;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblPriceCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    
                    break;
                case "登録":
                    lblPrID.ForeColor = Color.Black;
                    lblMaID.ForeColor = Color.Fuchsia;
                    lblScID.ForeColor = Color.Fuchsia;
                    lblName.ForeColor = Color.Red;
                    lblSafetyStock.ForeColor = Color.Fuchsia;
                    lblModelNumber.ForeColor = Color.Red;
                    lblColor.ForeColor = Color.Red;
                    lblDate.ForeColor = Color.Black;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Black;
                    lblPriceCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;
                case "検索":
                    lblPrID.ForeColor = Color.Blue;
                    lblMaID.ForeColor = Color.Blue;
                    lblScID.ForeColor = Color.Blue;
                    lblName.ForeColor = Color.Blue;
                    lblSafetyStock.ForeColor = Color.Blue;
                    lblModelNumber.ForeColor = Color.Blue;
                    lblColor.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Fuchsia;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Black;
                    lblDateCondition.ForeColor = Color.Blue;
                    lblPriceCondition.ForeColor = Color.Blue;
                    cbxDisplay.ForeColor = Color.Blue;
                    cbxHidden.ForeColor = Color.Blue;
                    break;
                case "更新":
                    lblPrID.ForeColor = Color.Red;
                    lblMaID.ForeColor = Color.Fuchsia;
                    lblScID.ForeColor = Color.Fuchsia;
                    lblName.ForeColor = Color.Blue;
                    lblSafetyStock.ForeColor = Color.Fuchsia;
                    lblModelNumber.ForeColor = Color.Blue;
                    lblColor.ForeColor = Color.Blue;
                    lblDate.ForeColor = Color.Blue;
                    lblFlag.ForeColor = Color.Black;
                    lblHidden.ForeColor = Color.Blue;
                    lblDateCondition.ForeColor = Color.Black;
                    lblPriceCondition.ForeColor = Color.Black;
                    cbxDisplay.ForeColor = Color.Black;
                    cbxHidden.ForeColor = Color.Black;
                    break;


            }
        }
        private void RegistEnabled()
        {
            bool flg = false;
            bool maFlg = false;
            bool scFlg = false;
            if (!String.IsNullOrEmpty(txbMaID.Text))
                if (makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text)))
                    maFlg = true;
            if (!String.IsNullOrEmpty(txbScID.Text))
                if (smallClassificationDataAccess.CheckScIDExistence(int.Parse(txbScID.Text)))
                    scFlg = true;
            if (!String.IsNullOrEmpty(txbName.Text.Trim())
                && !String.IsNullOrEmpty(txbPrice.Text.Trim())
                && !String.IsNullOrEmpty(txbSafetyStock.Text.Trim())
                && !String.IsNullOrEmpty(txbModelNumber.Text.Trim())
                && !String.IsNullOrEmpty(txbColor.Text.Trim()))
                if (decimal.Parse(txbPrice.Text) > 0
                 && int.Parse(txbSafetyStock.Text) > 0)
                    flg = true;

            if (flg && maFlg && scFlg)
                fncButtonEnable(5);
            else
                fncButtonEnable(4);
        }

        private void UpdateEnabled()
        {

            bool flg = true;
            if (!String.IsNullOrEmpty(txbPrID.Text))
            {
                if (!productDataAccess.CheckPrIDExistence(int.Parse(txbPrID.Text)))
                    flg = false;
            }
            else
                flg = false;
            if (!String.IsNullOrEmpty(txbMaID.Text))
                if (!makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text)))
                    flg = false;

            if (!String.IsNullOrEmpty(txbScID.Text))
                if (!smallClassificationDataAccess.CheckScIDExistence(int.Parse(txbScID.Text)))
                    flg = false;

            if (!String.IsNullOrEmpty(txbPrice.Text))
                if (decimal.Parse(txbPrice.Text) <= 0)
                    flg = false;
            if (!String.IsNullOrEmpty(txbSafetyStock.Text))
                if (int.Parse(txbSafetyStock.Text) <= 0)
                    flg = false;

            if (flg)
                fncButtonEnable(9);
            else
                fncButtonEnable(8);
        }


        private void SetFormDataGridView()
        {
            commonModule.SetFormDataGridView(txbPageSize, txbPageNo, dataGridViewDsp, 20);
            //サイズ_ナンバー_グリッドビュー_サイズの初期値
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            Product = productDataAccess.GetProductData();
            SetDataGridView();
        }

        private void SetDataGridView()
        {

            int pageNo = int.Parse(txbPageNo.Text) - 1;
            int pageSize = int.Parse(txbPageSize.Text);
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Product.AsEnumerable().Reverse().Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();
                    break;
            }
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.RowHeadersVisible = false;
            dataGridViewDsp.Font = new Font("MS UI Gothic", 18);

            dataGridViewDsp.Columns[0].Width = 120;
            dataGridViewDsp.Columns[1].Width = 120;
            dataGridViewDsp.Columns[2].Width = 300;
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[5].Width = 160;
            dataGridViewDsp.Columns[6].Width = 120;
            dataGridViewDsp.Columns[7].Width = 140;
            dataGridViewDsp.Columns[8].Width = 100;
            dataGridViewDsp.Columns[9].Width = 140;
            dataGridViewDsp.Columns[10].Width = 140;
            dataGridViewDsp.Columns[11].Width = 407;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[3].DefaultCellStyle.Format = "#,0";
            dataGridViewDsp.Columns[5].DefaultCellStyle.Format = "#,0";

            dataGridViewDsp.Columns[0].HeaderText = "商品ID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカID";
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[5].HeaderText = "安全在個数";
            dataGridViewDsp.Columns[6].HeaderText = "小分類ID";
            dataGridViewDsp.Columns[7].HeaderText = "型番";
            dataGridViewDsp.Columns[8].HeaderText = "色";
            dataGridViewDsp.Columns[9].HeaderText = "発売日";
            dataGridViewDsp.Columns[10].HeaderText = "商品管理フラグ";
            dataGridViewDsp.Columns[11].HeaderText = "非表示理由";

            dataGridViewDsp.Columns[4].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;
            dataGridViewDsp.Columns[15].Visible = false;
            dataGridViewDsp.Columns[16].Visible = false;
            dataGridViewDsp.Columns[17].Visible = false;
            dataGridViewDsp.Columns[18].Visible = false;
            dataGridViewDsp.Columns[19].Visible = false;
            dataGridViewDsp.Columns[20].Visible = false;
            dataGridViewDsp.Columns[21].Visible = false;
            dataGridViewDsp.Columns[22].Visible = false;


            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (dataGridViewDsp.SelectedCells.Count == 0)
                return;
            txbPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbSafetyStock.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbScID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbModelNumber.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            txbColor.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value != null)
                dtpDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString();
            else
            {
                dtpDate.Value = DateTime.Now;
                dtpDate.Checked = false;
            }
            txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[11].Value != null)
                txbHidden.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[11].Value.ToString();
            else
                txbHidden.Text = String.Empty;
        }
        private void txbPageSize_Leave(object sender, EventArgs e)
        {
            commonModule.PageLeave(txbPageSize, 20);
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

        private void dataGridViewDsp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            commonModule.CellFormatting(e, 10, 2);
            //グリッドビュー_何行目_フラグ情報　(1確定未確定　2表示非表示)
        }
        private void cmbHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            fncTextColor((sender as ComboBox).Text);
            //項目情報の色設定
        }
        private void cbxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxDisplay.Checked && !cbxHidden.Checked)
                cbxDisplay.Checked = true;
            //全てのチェックボックスが消えることはない。
       　}

        private void txbFlag_TextChanged(object sender, EventArgs e)
        {
            commonModule.FlagTextChanged(txbFlag, 2);
            //フラグ数値_日本語化　(1確定未確定 2表示非表示)
        }

        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            commonModule.PageSizeTextChanged(sender, 20);
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
                fncButtonEnable(8);
                txbFlag.Text = String.Empty;
            }
            else
            {
                productDataAccess.GetProductFlagData(sender, txbFlag);
                //フラグの数値を取得
                if (commonModule.ButtonEnabled(txbFlag, 2))
                {
                    UpdateEnabled();
                }

            }
        }
        private void txbMaID_TextChanged(object sender, EventArgs e)
        {
            makerDataAccess.GetMakerNameData(sender, lblMaName);
            RegistEnabled();
            UpdateEnabled();
        }
        private void txbScID_TextChanged(object sender, EventArgs e)
        {
            smallClassificationDataAccess.GetScNameData(sender, lblScName);
            RegistEnabled();
            UpdateEnabled();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            RegistEnabled();
            UpdateEnabled();
        }



        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
            commonModule.PriceTextChanged(sender);
            RegistEnabled();
            UpdateEnabled();
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
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 9);
            //6文字以下の数値のみ入力可
        }
        private void txbSfetyStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            commonModule.LimitValueKeyPress(sender, e, 4);
            //6文字以下の数値のみ入力可
        }


        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            commonModule.FirstPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Product), btnSort);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            commonModule.PreviousPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Product), btnSort);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            commonModule.NextPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Product), btnSort);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            commonModule.LastPageClick(txbPageSize, txbPageNo, dataGridViewDsp, new List<object>(Product), btnSort);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            commonModule.SortButtonChanged(sender);
            //ボタン押下で表示内容を変更する
            SetSelectData();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbPrID.Text = String.Empty;
            txbMaID.Text = String.Empty;
            txbScID.Text = String.Empty;
            txbName.Text = String.Empty;
            txbSafetyStock.Text = String.Empty;
            txbModelNumber.Text = String.Empty;
            txbColor.Text = String.Empty;
            txbPrice.Text = String.Empty;
            dtpDate.Value = DateTime.Now;
            dtpDate.Checked = false;
            txbFlag.Text = String.Empty;
            txbHidden.Text =String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txbPageNo.Text = "1";
            GenerateDataAdDisplay();
            //チェックボックスの要素のみ検索条件に
            SetDataGridView();
        }

        private void GenerateDataAdDisplay()
        {
            int flag = 0;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                flag = 3;

            M_Product selectCondition = new M_Product()
            {
                PrID = 0,
                MaID = 0,
                PrName = String.Empty,
                Price = 0,
                PrSafetyStock = 0,
                ScID = 0,
                PrModelNumber = String.Empty,
                PrColor = String.Empty,
                PrFlag = flag,
                PrReleaseDate = null,
                PrHidden = null
            };
            Product = productDataAccess.GetProductData(selectCondition, 0,0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AdMenu.Show();
            Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //顧客情報抽出
            GenerateDataAdSelect();
            //顧客情報抽出結果
            SetSelectData();
        }


        private void GenerateDataAdSelect()
        {
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;
            if (!int.TryParse(txbScID.Text, out int scID))
                scID = 0;


            if (!decimal.TryParse(txbPrice.Text, out decimal price))
                price = 0;
            if (!int.TryParse(txbSafetyStock.Text, out int prSafetyStock))
                prSafetyStock = 0;
            
            string name = String.Empty;
            string modelNumber = String.Empty;
            string color = String.Empty;

            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            if (!String.IsNullOrEmpty(txbModelNumber.Text.Trim()))
                modelNumber = txbModelNumber.Text.Trim();
            if (!String.IsNullOrEmpty(txbColor.Text.Trim()))
                color = txbColor.Text.Trim();

            DateTime? date = null;
            if (dtpDate.Checked)
                date = dtpDate.Value;

            int flag = 0;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                flag = 3;

            M_Product selectCondition = new M_Product()
            {
                PrID = prID,
                MaID = maID,
                PrName = name,
                Price = price,
                PrSafetyStock = prSafetyStock,
                ScID = scID,
                PrModelNumber = modelNumber,
                PrColor = color,
                PrFlag = flag,
                PrReleaseDate = date,
                PrHidden = null
            };
            int dateCondition = commonModule.ComboBoxCondition(cmbDate.Text);
            int priceCondition = commonModule.ComboBoxCondition(cmbPrice.Text);
            Product = productDataAccess.GetProductData(selectCondition,dateCondition,priceCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            switch (btnSort.Text)
            {
                case "降順":
                    dataGridViewDsp.DataSource = Product.AsEnumerable().Reverse().Take(pageSize).ToList();
                    break;
                case "昇順":
                    dataGridViewDsp.DataSource = Product.Take(pageSize).ToList();
                    break;
            }
            //Skipなし
            lblPageNo.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";
        }
        private void btnRegist_Click(object sender, EventArgs e)
        {
            var regPr = GenereteDataAdRegistration();
            var regSt = GenereteDataAdRegistrationPlus();
            RegistrationProduct(regPr,regSt);
        }

        private M_Product GenereteDataAdRegistration()
        {
            return new M_Product
            {
                PrID = 0,
                MaID = int.Parse(txbMaID.Text),
                PrName = txbName.Text.Trim(),
                Price = decimal.Parse(txbPrice.Text),
                PrSafetyStock = int.Parse(txbSafetyStock.Text),
                ScID = int.Parse(txbScID.Text),
                PrModelNumber = txbModelNumber.Text.Trim(),
                PrColor = txbColor.Text.Trim(),
                PrFlag = 0,
                PrReleaseDate = dtpDate.Value,
                PrHidden = null
            };
        }

        private T_Stock GenereteDataAdRegistrationPlus()
        {
            return new T_Stock
            {
                StID = 0,
                PrID = int.Parse(txbPrID.Text),
                StQuantity = 0,
                StState = 1,
                StFlag = 0,
                StHidden = null
            };
        }

        private void RegistrationProduct(M_Product regPr,T_Stock regSt)
        {
            DialogResult result = messageDsp.MsgDspQ("M0001");
            if (result != DialogResult.OK)
                return;

            bool flg = productDataAccess.AddProductData(regPr)&&stockDataAccess.AddStockData(regSt);
            if (flg)
            {
                messageDsp.MsgDsp("M0002");
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnRegist.Text);
                operationHistoryDataAccess.AddOperationHistoryData(regOh);
            }
            else
            {
                messageDsp.MsgDsp("M0003");
                return;
            }
            txbPrID.Focus();
            ClearInput();
            GenerateDataAdDisplay();
            SetSelectData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updPr = GenerateDataAdUpdate();
            UpdateProduct(updPr);
        }

        private M_Product GenerateDataAdUpdate()
        {
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;
            if (!int.TryParse(txbScID.Text, out int scID))
                scID = 0;


            if (!decimal.TryParse(txbPrice.Text, out decimal price))
                price = 0;
            if (!int.TryParse(txbSafetyStock.Text, out int safetyStock))
                safetyStock = 0;

            string name = String.Empty;
            string modelNumber = String.Empty;
            string color = String.Empty;

            if (!String.IsNullOrEmpty(txbName.Text.Trim()))
                Name = txbName.Text.Trim();
            
            if (!String.IsNullOrEmpty(txbModelNumber.Text.Trim()))
                modelNumber = txbModelNumber.Text.Trim();

            if (!String.IsNullOrEmpty(txbColor.Text.Trim()))
                color = txbColor.Text.Trim();

            DateTime? date = null;
            if (dtpDate.Checked)
                date = dtpDate.Value;

            int flag = 0;
            if (cbxHidden.Checked && !cbxDisplay.Checked)
                flag = 2;
            if (cbxHidden.Checked && cbxDisplay.Checked)
                flag = 3;

            return new M_Product
            {
                PrID = prID,
                MaID = maID,
                PrName = name,
                Price = price,
                PrSafetyStock = safetyStock,
                ScID = scID,
                PrModelNumber = modelNumber,
                PrColor = color,
                PrFlag = flag,
                PrReleaseDate = date,
                PrHidden = null
            };
        }
        private T_Stock GenerateDataAdUpdatePlus()
        {
            int stFlag = stockDataAccess.GetFlagAndStockCheck(txbPrID, 0);
            int stQuantity = stockDataAccess.GetFlagAndStockCheck(txbPrID, 1);

            int state = productDataAccess.GetSafetyStockCheck(txbPrID, stQuantity);
            return new T_Stock
            {
                StID = 0,
                PrID = int.Parse(txbPrID.Text),
                StQuantity = stQuantity,
                StState = state,
                StFlag = stFlag,
                StHidden = txbHidden.Text
            };
        }

        private void UpdateProduct(M_Product updPr)
        {
            string MsgCode = "M1";
            if (!String.IsNullOrEmpty(txbHidden.Text))
                MsgCode = "M2";

            DialogResult result = messageDsp.MsgDspQ(MsgCode + "001", lblPrID, txbPrID);
            //●●ID:00の情報を更新しますか？
            //●●ID:00を非表示にしますか？

            if (result != DialogResult.OK)
                return;

            bool Mflg = productDataAccess.UpdateProductData(updPr);
            bool Sflg = false;
            if (Mflg)
            {
                var updSt = GenerateDataAdUpdatePlus();
                Sflg =stockDataAccess.UpdateStockData(updSt);
            }
          
            if (Mflg&&Sflg)
            {
                var regOh = operationHistoryDataAccess.GenereteDataAdRegistration(int.Parse(lblLoginIDData.Text), Text, btnUpdate.Text);
                //社員ID_管理フォーム名_使用ボタン
                operationHistoryDataAccess.AddOperationHistoryData(regOh);

                result = messageDsp.MsgDsp(MsgCode + "002", lblPrID, txbPrID);
                //●●ID:00の情報を更新しました。
                //●●ID:00を非表示にしました。

            }
            else
            {
                result = messageDsp.MsgDsp(MsgCode + "003", lblPrID, txbPrID);
                //●●ID:00の情報を更新に失敗しました。
                //●●ID:00を非表示に失敗しました。
                return;
            }

            ClearInput();
            txbPrID.Focus();
            //初期化
            GenerateDataAdDisplay();
            SetSelectData();
            //全件表示
        }
    }
}
