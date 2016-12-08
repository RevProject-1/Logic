using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
    public class ServiceTypeDTO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public string UserId { get; set; }
      [DataMember]
      public decimal? Rate { get; set; }
   }
}
