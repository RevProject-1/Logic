using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Mapping
{
   public class ExpenseMapper
   {
      public static ExpenseDTO mapToExpenseDTO(ExpenseDAO b)
      {
         ExpenseDTO a = new ExpenseDTO();
         a.Cost = b.Cost;
         a.Id = b.Id;
         a.Name = b.Name;
         return a;
      }

      public static ExpenseDAO mapToExpenseDAO(ExpenseDTO b)
      {
         ExpenseDAO a = new ExpenseDAO();
         a.Cost = b.Cost;
         a.Id = b.Id;
         a.Name = b.Name;
         return a;
      }
   }
}
