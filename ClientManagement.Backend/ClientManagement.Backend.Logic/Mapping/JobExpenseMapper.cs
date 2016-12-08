using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Mapping
{
   public class JobExpenseMapper
   {
      public static JobExpenseDTO mapToJobExpenseDTO(JobExpenseDAO b)
      {
         JobExpenseDTO a = new JobExpenseDTO();
         a.Id = b.Id;
         a.ExpenseId = b.ExpenseID;
         a.JobId = b.JobID;
         a.Expense = ExpenseMapper.mapToExpenseDTO(b.Expense);
         a.Job = JobMapper.mapToJobDTO(b.Job);
         return a;
      }

      public static JobExpenseDAO mapToJobExpenseDAO(JobExpenseDTO b)
      {
         JobExpenseDAO a = new JobExpenseDAO();
         a.Id = b.Id;
         a.ExpenseID = b.ExpenseId;
         a.JobID = b.JobId;
         a.Expense = ExpenseMapper.mapToExpenseDAO(b.Expense);
         a.Job = JobMapper.mapToJobDAO(b.Job);
         return a;
      }
   }
}
