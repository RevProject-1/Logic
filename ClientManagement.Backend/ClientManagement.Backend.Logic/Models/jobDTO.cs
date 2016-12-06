using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   public class jobDTO
   {
      public int Id { get; set; }
      public int ServiceTypeId { get; set; }
      public int ClientId { get; set; }
      public string UserId { get; set; }
      public DateTime? StartDate { get; set; }
      public int? EstimatedDuration { get; set; }
      public string Notes { get; set; }
      public bool Complete { get; set; }
      public virtual ClientDTO client { get; set; }
      public virtual AspNetUsers user { get; set; }
      public virtual ServiceTypeDTO type { get; set; }
      public int? ExpenseId { get; set; }
      public ExpenseDTO Expense { get; set; }
   }
}
