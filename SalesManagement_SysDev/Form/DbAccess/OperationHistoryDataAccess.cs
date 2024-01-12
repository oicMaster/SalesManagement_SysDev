using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class OperationHistoryDataAccess
    {

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
