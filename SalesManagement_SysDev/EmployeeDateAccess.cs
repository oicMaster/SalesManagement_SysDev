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
    internal class EmployeeDateAccess
    {
        public bool CheckEmployeeCDXxistence(int emID)
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

                employee.EmID = updEm.EmID;
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
            List<M_Employee> employees = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employees = context.M_Employees.Where(x => x.EmFlag == 0).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return employees;
        }

        public List<M_Employee> GetEmployeeData(M_Employee selectCondition)
        {
            List<M_Employee> employees = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employees = context.M_Employees.Where(x => x.EmID == selectCondition.EmID).ToList();
                context.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return employees;
        }

        public List<M_Employee> GetEmployeeDspData()
        {
            List<M_Employee> employee = new List<M_Employee>();
            try
            {
                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.Where(x => x.EmFlag == 2).ToList();
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return employee;
        }
        }
    }
            
            

        
            
       
        

