using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
    public class ServiceTypeDTO
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public string UserId { get; set; }
      public decimal? Rate { get; set; }
   }
}
