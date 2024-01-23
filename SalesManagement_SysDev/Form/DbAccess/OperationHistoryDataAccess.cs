using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OperationHistoryDataAccess
    {
        public List<T_OperationHistory> GetOperationHistoryData()
        {
            List<T_OperationHistory> operationHistory = new List<T_OperationHistory>();
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    operationHistory = context.T_OperationHistorys.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return operationHistory;
        }

        public List<T_OperationHistory> GetOperationHistoryData(T_OperationHistory selectCondition, int dateCondition,int displayCondition)
        {
            List<T_OperationHistory> operationHistory = new List<T_OperationHistory>();
            try
            {

                using (var context = new SalesManagement_DevContext())
                {
                    operationHistory = context.T_OperationHistorys.Where(x =>
                    (selectCondition.EmID == 0 || x.EmID == selectCondition.EmID) &&
                   (selectCondition.OpForm == "条件なし" || x.OpForm == selectCondition.OpForm) &&
                  (
                  (displayCondition == 0 && selectCondition.OpButton =="条件なし") ||
                        (displayCondition == 0 && x.OpButton.Contains(selectCondition.OpButton)) ||
                         (displayCondition == 1 && x.OpButton.Contains("ログ") && selectCondition.OpButton == "条件なし") ||
                        (displayCondition == 1 && x.OpButton.Contains("ログ") && x.OpButton.Contains(selectCondition.OpButton)) ||
                         (displayCondition == 2 && !x.OpButton.Contains("ログ") && selectCondition.OpButton == "条件なし") ||
                        (displayCondition == 2 && !x.OpButton.Contains("ログ") && x.OpButton.Contains(selectCondition.OpButton))
                    ) &&
                   (selectCondition.OpTime == null ||
                  (dateCondition == 0 && DbFunctions.TruncateTime(x.OpTime.Value) == DbFunctions.TruncateTime(selectCondition.OpTime)) ||
                  (dateCondition == 1 && DbFunctions.TruncateTime(x.OpTime.Value) >= DbFunctions.TruncateTime(selectCondition.OpTime)) ||
                  (dateCondition == 2 && DbFunctions.TruncateTime(x.OpTime.Value) <= DbFunctions.TruncateTime(selectCondition.OpTime)))
                  ).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return operationHistory;
        }

        public T_OperationHistory GenereteDataAdRegistration(int emID, string form,string button)
        {
            return new T_OperationHistory
            {
                EmID = emID,
                OpForm = form,
                OpButton = button,
                OpTime = DateTime.Now
            };
        }

        public void AddOperationHistoryData(T_OperationHistory regOh)
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.T_OperationHistorys.Add(regOh);
                    context.SaveChanges();
                } 
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder validationErrors = new StringBuilder();
                foreach (var validationError in ex.EntityValidationErrors.SelectMany(validationResult => validationResult.ValidationErrors))
                {
                    validationErrors.AppendLine($"{validationError.PropertyName}: {validationError.ErrorMessage}");
                }

                MessageBox.Show($"Validation failed: {validationErrors.ToString()}", "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
