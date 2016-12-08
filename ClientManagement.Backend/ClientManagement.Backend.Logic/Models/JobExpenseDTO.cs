using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class JobExpenseDTO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public int JobId { get; set; }
      [DataMember]
      public int? ExpenseId { get; set; }
      [DataMember]
      public virtual ExpenseDTO Expense { get; set; }
      [DataMember]
      public virtual jobDTO Job { get; set; }
   }
}
