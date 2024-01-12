﻿using System;
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
                flg = context.M_Employees.Any(x => x.EmID == emID && x.EmFlag == 0);
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
                using (var context = new SalesManagement_DevContext())
                {
                    context.M_Employees.Add(regEm);
                    context.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateEmployeeData(M_Employee updEm)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                var employee = context.M_Employees.Single(x => x.EmID == updEm.EmID);

                if (updEm.EmName != String.Empty)
                    employee.EmName = updEm.EmName;
                if (updEm.SoID != 0)
                    employee.SoID = updEm.SoID;
                if (updEm.PoID != 0)
                    employee.PoID = updEm.PoID;
                if (updEm.EmPassword != String.Empty)
                    employee.EmPassword = updEm.EmPassword;
                if (updEm.EmPhone != String.Empty)
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
                        (selectCondition.EmHiredate == null||
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

        public void GetEmployeeNameData(string emID, Label lblName)
        {
            List<M_Employee> employee = new List<M_Employee>();
            if (!String.IsNullOrEmpty(emID))
            {
                if (CheckEmIDExistence(int.Parse(emID)))
                {
                    employee = GetEmployeeData();
                    var data = employee.Single(x => x.EmID == int.Parse(emID));
                    lblName.Text = data.EmName;
                    return;
                }
            }
            lblName.Text = "----";
        }

        public void GetEmployeeFlagData(object sender, TextBox hidden)
        {
            List<M_Employee> employee = new List<M_Employee>();


            if (CheckEmIDExistence(int.Parse((sender as TextBox).Text)))
            {

                var context = new SalesManagement_DevContext();
                employee = context.M_Employees.ToList();
                var data = employee.Single(x => x.EmID == int.Parse((sender as TextBox).Text));
                hidden.Text = data.EmFlag.ToString();
                context.Dispose();
                return;
            }
            hidden.Text = "------";
        }

        public bool GetEmployeePassData(string emID , string Pass)
        {
            List<M_Employee> employee = new List<M_Employee>();
            if (!String.IsNullOrEmpty(emID))
            {
                if (CheckEmIDExistence(int.Parse(emID)))
                {
                    employee = GetEmployeeData();
                    var data = employee.Single(x => x.EmID == int.Parse(emID));

                    if(data.EmPassword == Pass)
                    return true;
                }
            }
            return false;
        }

        public int GetEmployeePoIDData(string emID)
        {

            List<M_Employee> employee = new List<M_Employee>();
            employee = GetEmployeeData();
            var data = employee.Single(x => x.EmID == int.Parse(emID));
            return data.PoID;

        }
    }
}








