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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SalesManagement_SysDev
{
    public partial class F_AdProduct : Form
    {
        MessageDsp messageDsp = new MessageDsp();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        SmallClassification smallClassification = new SmallClassification();

        private static List<M_Product> Product;

        public F_AdProduct()
        {
            InitializeComponent();
        }

        private void F_AdProduct_Load(object sender, EventArgs e)
        {
            //labelLoginName.Text = FormMenu.LoginName;
            //labelLoginName.Text = FormMenu.LoginName;
            SetFormDataGridView();
            txbFlag.ReadOnly = true;
            txbHidden.ReadOnly = true;
            //※

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
            Product = productDataAccess.GetProductData();
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

            dataGridViewDsp.Columns[0].Width = 120;
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[2].Width = 150;
            dataGridViewDsp.Columns[3].Width = 340;
            dataGridViewDsp.Columns[4].Width = 140;
            dataGridViewDsp.Columns[5].Width = 120;
            dataGridViewDsp.Columns[6].Width = 140;
            dataGridViewDsp.Columns[7].Width = 160;
            dataGridViewDsp.Columns[8].Width = 550;
            dataGridViewDsp.Columns[9].Width = 100;
            dataGridViewDsp.Columns[10].Width = 100;


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
            dataGridViewDsp.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewDsp.Columns[0].HeaderText = "商品ID";
            dataGridViewDsp.Columns[1].HeaderText = "メーカーID";
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[4].HeaderText = "安全在個数";
            dataGridViewDsp.Columns[5].HeaderText = "小分類ID";
            dataGridViewDsp.Columns[6].HeaderText = "型番";
            dataGridViewDsp.Columns[7].HeaderText = "色";
            dataGridViewDsp.Columns[8].HeaderText = "発売日";
            dataGridViewDsp.Columns[9].HeaderText = "商品管理フラグ";
            dataGridViewDsp.Columns[10].HeaderText = "非表示理由";


            dataGridViewDsp.Columns[11].Visible = false;
            dataGridViewDsp.Columns[12].Visible = false;
            dataGridViewDsp.Columns[13].Visible = false;
            dataGridViewDsp.Columns[14].Visible = false;
            dataGridViewDsp.Columns[15].Visible = false;
            dataGridViewDsp.Columns[16].Visible = false;
            dataGridViewDsp.Columns[17].Visible = false;
            dataGridViewDsp.Columns[18].Visible = false;
            dataGridViewDsp.Columns[19].Visible = false;
            dataGridViewDsp.Columns[20].Visible = false;

            lblPage.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            txbMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            txbName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            txbPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            txbSafetyStock.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
            txbScID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[6].Value.ToString();
            txbModelNumber.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[7].Value.ToString();
            txbColor.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[8].Value.ToString();
            txbReleaseDate.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[9].Value.ToString();
            if (dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[10].Value != null)
                txbFlag.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[11].Value.ToString();
            else
                txbFlag.Text = String.Empty;
        }


        private void txbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > 10)
                {
                    (sender as TextBox).Text = "10";
                    return;
                }
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                    return;
                }
            }
        }

        private void txbPageNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
            {
                if (int.Parse((sender as TextBox).Text) == 0)
                {
                    (sender as TextBox).Text = "1";
                }
            }
        }

        private void txbKeyID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {//※
                //fncButtonEnable(0);
                ClearInput();
            }
            else
            {
                //fncButtonEnable(1);
                txbFlag.Text = "0";

            }
            txbPrID.Text = txbPrID.Text;
        }

        private void txbHidden_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((sender as TextBox).Text.Trim()))
                txbFlag.Text = "0";
            else
                txbFlag.Text = "2";
        }

        //メイングリッドビュー,サブグリッドビューで使用する主キーのテキストボックスの文字を連動させる。
        private void txbKeyIDsub_TextChanged(object sender, EventArgs e)
        {
            txbPrID.Text = txbPrID.Text;
        }

        //PageSize,Noのテキストボックスに連結させる。
        private void txbPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //IDがつく全てのテキストボックスに連結させる。
        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length < 6)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if ((sender as TextBox).Text.Length == 6)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //数量or個数のテキストボックスに連結させる。
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length < 4)
            {
                if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (this.Text.Length == 4)
            {
                if (e.KeyChar != '\b')
                    e.Handled = true;
            }
        }
        //↓入力上限がある全てのデータに設定する。
        //private void txb~~~~~_KeyPress(object sender, KeyPressEventArgs e)



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            dataGridViewDsp.DataSource = Product.Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = "1";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            int pageNo = int.Parse(txbPageNo.Text) - 2;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

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
            int lastNo = (int)Math.Ceiling(Product.Count / (double)pageSize) - 1;
            //最終ページでなければ
            if (pageNo <= lastNo)
                dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            int lastPage = (int)Math.Ceiling(Product.Count / (double)pageSize);
            if (pageNo >= lastPage)
                txbPageNo.Text = lastPage.ToString();
            else
                txbPageNo.Text = (pageNo + 1).ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int pageSize = int.Parse(txbPageSize.Text);
            //最終ページの計算
            int pageNo = (int)Math.Ceiling(Product.Count / (double)pageSize) - 1;
            dataGridViewDsp.DataSource = Product.Skip(pageSize * pageNo).Take(pageSize).ToList();

            // DataGridViewを更新
            dataGridViewDsp.Refresh();
            //ページ番号の設定
            txbPageNo.Text = (pageNo + 1).ToString();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {//全てのテキストボックスを空白にする
            txbPrID.Text = String.Empty;
            txbMaID.Text = String.Empty;
            txbName.Text = String.Empty;
            txbPrice.Text = String.Empty;
            txbSafetyStock.Text = String.Empty;
            txbScID.Text = String.Empty;
            txbModelNumber.Text = String.Empty;
            txbColor.Text = String.Empty;
            txbReleaseDate.Text = String.Empty;
            txbFlag.Text = String.Empty;
            txbHidden.Text = String.Empty;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SetFormDataGridView();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            GenerateDataAtSelect();
            SetSelectData();

        }
        
        private void GenerateDataAtSelect()
        {
            if (!int.TryParse(txbPrID.Text, out int prID))
                prID = 0;
            if (!int.TryParse(txbMaID.Text, out int maID))
                maID = 0;
            M_Product selectCondition = new M_Product()
            {
                PrID = int.Parse(txbPrID.Text.Trim()),
            };
            Product = productDataAccess.GetProductData(selectCondition);

        }
        private void SetSelectData()
        {
            txbPageNo.Text = "1";
            int pageSize = int.Parse(txbPageSize.Text.Trim());
            dataGridViewDsp.DataSource = Product;

            lblPage.Text = "/" + ((int)Math.Ceiling(Product.Count / (double)pageSize)) + "ページ";
        }


        private void btnRegist_Click(object sender, EventArgs e)
        {
            //妥当な商品情報取得
            if (!GetValidDataAtRegistration())
                return;
            //商品情報作成
            var regProduct = GenereteDataAdRegistration();

            //商品情報登録
            RegistrationProduct(regProduct);
        }

        private bool GetValidDataAtRegistration()
        {
            
            if (!productDataAccess.CheckPrIDExistence(int.Parse(txbPrID.Text)))
            {
                    messageDsp.MsgDsp("");
                    txbPrID.Focus();
                    return false;
            }
            if (!makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text)))
            {
                messageDsp.MsgDsp("");
                txbMaID.Focus();
                return false;
            }
            if (!smallClassification.CheckScIDExistence(int.Parse(txbScID.Text)))
            {
                messageDsp.MsgDsp("");
                txbScID.Focus();
                return false;
            }
            return true;

        }
        private M_Product GenereteDataAdRegistration()
        {
            string hidden = txbHidden.Text;
            return new M_Product
            {
                //▼全部
                PrID = int.Parse(txbPrID.Text),
                MaID = int.Parse(txbMaID.Text),
                PrName = txbName.Text,
                Price = int.Parse(txbPrice.Text),
                PrSafetyStock = int.Parse(txbSafetyStock.Text),
                ScID = int.Parse(txbScID.Text),
                PrModelNumber = txbModelNumber.Text,
                PrColor = txbColor.Text,
                PrReleaseDate = DateTime.Parse(txbReleaseDate.Text),
                PrFlag = int.Parse(txbFlag.Text),
                PrHidden = hidden,
            }; 
        }
        private void RegistrationProduct(M_Product regProduct)
        {
            // 登録確認メッセージ
            DialogResult result = messageDsp.MsgDsp("");

            if (result == DialogResult.Cancel)
                return;

            // 部署情報の登録
            bool flg = productDataAccess.AddProductData(regProduct);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            txbPrID.Focus();

            // 入力エリアのクリア
            ClearInput();

            // データグリッドビューの表示
            GetDataGridView();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //妥当な顧客データを取得
            if (!GetValidDataAtUpdate())
                return;
            //顧客情報作成
            var updPr = GenerateDataAtUpdate();
            //顧客情報更新
            UpdateProduct(updPr);
        }

        private bool GetValidDataAtUpdate()
        {
            if (!productDataAccess.CheckPrIDExistence(int.Parse(txbPrID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbPrID.Focus();
                return false;
            }
            if (!makerDataAccess.CheckMaIDExistence(int.Parse(txbMaID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbMaID.Focus();
                return false;
            }
            if (!smallClassification.CheckScIDExistence(int.Parse(txbScID.Text.Trim())))
            {
                messageDsp.MsgDsp("");
                txbScID.Focus();
                return false;
            }
            return true;
        }
        private M_Product GenerateDataAtUpdate()
        {
            return new M_Product
            {
                //全部
                PrID =int.Parse(txbPrID.Text.Trim()),
                MaID =int.Parse(txbMaID.Text.Trim()),
                PrName =txbName.Text.Trim(),
                Price =int.Parse(txbPrice.Text.Trim()),
               // PrSafetyStock = 

            };
        }
        private void UpdateProduct(M_Product updPr)
        {
            DialogResult result = messageDsp.MsgDsp("");
            if (result == DialogResult.Cancel)
                return;

            bool flg = productDataAccess.UpdateProductData(updPr);
            if (flg == true)
                messageDsp.MsgDsp("");
            else
                messageDsp.MsgDsp("");

            ClearInput();
            txbPrID.Focus();

            GetDataGridView();
        }
    }
}
