using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_AdEmployee : Form
    {
        //メッセージ表示用のインスタンス化
        MessageDsp messageDsp = new MessageDsp();
        //データベース社員テーブルアクセス用のクラスのインスタンス化
        EmployeeDateAccess employeeDateAccess = new EmployeeDateAccess();
        //入力形式チェック用クラスのインスタンス化
        DataInputFormCheck dataInputFormCheck = new DataInputFormCheck();
        //データグリッドビュー用の社員データ
        private static List<M_Employee> Employees;



        public F_AdEmployee()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!GetValidDataAtSelect())
                return;

            GenerateDataAtSelect();

            SetSelectData();
        }


        private bool GetValidDataAtSelect()
        {
            if (!String.IsNullOrEmpty(txbEmID.Text.Trim()))
            {
                //社員IDの入力時チェック
                if(!dataInputFormCheck.CheckHalfAlphabetNumeric(txbEmID.Text.Trim()))
                {
                    messageDsp.DspMsg("");
                    txbEmID.Focus();
                    return false;
                  
                }
                //社員IDの文字数が7文字以上をチェック
                if(txbEmID.TextLength > 6)
                {
                    messageDsp.DspMsg("");
                    txbEmID.Focus();
                    return false;
                }


            }
            return true;
        }
        private void GenerateDataAtSelect()
        {　　//検索条件セット
            M_Employee selectCondition = new M_Employee()
            {
                EmID = int.Parse(txbEmID.Text.Trim()),

            };
            //社員データの抽出
            Employees = employeeDateAccess.GetEmployeeData(selectCondition);
        }

        private void SetSelectData()
        {
            txbPageNo.Text = "1";

            int pageSize = int.Parse(txbPageNo.Text.Trim());

            dataGridViewDsp.DataSource = Employees;

            lblPage.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ ";
            dataGridViewDsp.Refresh();
        }

        private void F_AdEmployee_Load(object sender, EventArgs e)
        {
            SetFromDataGridView();
        }
        private void SetFromDataGridView()
        {
            txbPageSize.Text = "100";
            txbPageNo.Text = "1";
            dataGridViewDsp.ReadOnly = true;
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewDsp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetDataGridView();
        }
        private void GetDataGridView()
        {
            Employees = employeeDateAccess.GetEmployeeData();

            SetDataGridView();

        }
        
        private void SetDataGridView()
        {
            int pageSize =  int.Parse(txbPageSize.Text);
            int pageNO = int.Parse(txbPageNo.Text) - 1;
            dataGridViewDsp.DataSource = Employees.Skip(pageSize * pageNO);

            dataGridViewDsp.Columns[0].Width = 100;
            dataGridViewDsp.Columns[1].Width = 200;
            dataGridViewDsp.Columns[2].Width = 100;
            dataGridViewDsp.Columns[3].Width = 400;

            dataGridViewDsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            lblPage.Text = "/" + ((int)Math.Ceiling(Employees.Count / (double)pageSize)) + "ページ";

            dataGridViewDsp.Refresh();

        }
        private void buttonPageSizeChange_Click(object sender, EventArgs e)
        {
            SetDataGridView();
        }
    }
}
