using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic
{
   public partial class appLogic
   {
      public List<ExpenseDTO> getExpenses()
      {
         var expenses = new List<ExpenseDTO>();
         var list = sc.GetExpenses();
         foreach (var item in list)
         {
            expenses.Add(Mapping.ExpenseMapper.mapToExpenseDTO(item));
         }
         return expenses;         
      }

      public bool insertExpense(ExpenseDTO expense)
      {
         expense.Name = stringFormatter(expense.Name).ToString();
         return sc.AddExpense(Mapping.ExpenseMapper.mapToExpenseDAO(expense));
      }

      public bool updateExpense(ExpenseDTO expense)
      {
         return sc.UpdateExpense(Mapping.ExpenseMapper.mapToExpenseDAO(expense));
      }

      public bool deleteExpense(ExpenseDTO expense)
      {
         return sc.DeleteExpense(Mapping.ExpenseMapper.mapToExpenseDAO(expense));
      }
   }
}
