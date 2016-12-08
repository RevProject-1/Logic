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
      public List<JobExpenseDTO> getJobExpenses()
      {
         var list = sc.GetJobExpenses();
         List<JobExpenseDTO> newlist = new List<JobExpenseDTO>();
         foreach (var item in list)
         {
            newlist.Add(Mapping.JobExpenseMapper.mapToJobExpenseDTO(item));
         }
         return newlist;
      }
      List<JobExpenseDTO >getJobExpenseByJobId(jobDTO job)
      {
         var list = getJobExpenses().Where(m => m.JobId == job.Id).ToList();
         return list;
      }

      public bool insertJobExpense(jobDTO job, ExpenseDTO expense)
      {
         return sc.AddJobExpense(Mapping.JobMapper.mapToJobDAO(job), Mapping.ExpenseMapper.mapToExpenseDAO(expense));
      }

      public bool updateJobExpense(JobExpenseDTO je)
      {
         return sc.UpdateJobExpense(Mapping.JobExpenseMapper.mapToJobExpenseDAO(je));
      }

      public bool deleteJobExpense(JobExpenseDTO je)
      {
         return sc.DeleteJobExpense(Mapping.JobExpenseMapper.mapToJobExpenseDAO(je));
      }
   }
}
