using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class InvoiceExpenses
   {
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public string Cost { get; set; }

   }
}
