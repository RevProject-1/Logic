using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   public class ExpenseDTO
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Cost { get; set; }

   }
}
