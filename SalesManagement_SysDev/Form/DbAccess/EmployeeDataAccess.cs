using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
        public bool CheckEmIDExistence(int emID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                flg = context.M_Employees.Any(x => x.EmID == emID);
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }
        public bool AddEmployeeData(M_Employee regEm)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(regEm);
                context.Dispose();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpadateEmployeeData(M_Employee updEm)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var employee = context.M_Employees.Single(x => x.EmID == updEm.EmID);

                employee.EmName = updEm.EmName;
                employee.SoID = updEm.SoID;
                employee.PoID = updEm.PoID;
                employee.EmHiredate = updEm.EmHiredate;
                employee.EmPassword = updEm.EmPassword;
                employee.EmPhone = updEm.EmPhone;
                employee.EmFlag = updEm.EmFlag;
                employee.EmHidden = updEm.EmHidden;

                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public List<M_Employee> GetEmployeeData()
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x => x.EmFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return employee;
        }
        public List<M_Employee> GetEmployeeData(M_Employee selectCondition,int dateCondition)
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x =>
                        (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                        (selectCondition.EmName == null || x.EmName.Contains(selectCondition.EmName)) &&
                        (selectCondition.SoID == 0 || x.SoID == selectCondition.SoID) &&
                        (selectCondition.PoID == 0 || x.PoID == selectCondition.PoID) &&
                        (selectCondition.EmHiredate == DateTime.Parse("0001/01/01") ||
                        (dateCondition == 0 && x.EmHiredate == selectCondition.EmHiredate) ||
                        (dateCondition == 1 && x.EmHiredate >= selectCondition.EmHiredate) ||
                        (dateCondition == 2 && x.EmHiredate <= selectCondition.EmHiredate)) &&
                        (selectCondition.EmPhone == null || x.EmPhone.Contains(selectCondition.EmPhone)) &&
                        (selectCondition.EmFlag == 3 || x.EmFlag == selectCondition.EmFlag)
                ).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return employee;
        }

        public void GetEmployeeNameData(object sender, Label lblName)
        {
            List<M_Employee> employee = new List<M_Employee>();
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (CheckEmIDExistence(int.Parse((sender as TextBox).Text)))
                {
                    employee = GetEmployeeData();
                    var data = employee.Single(x => x.EmID == int.Parse((sender as TextBox).Text));
                    lblName.Text = data.EmName;
                    return;
                }
            }
            lblName.Text = "----";
        }
    }
}








