using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   public class JobExpenseDTO
   {
      public int Id { get; set; }
      public int JobId { get; set; }
      public int ExpenseId { get; set; }
   }
}
