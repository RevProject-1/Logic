using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class jobDTO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public int ServiceTypeId { get; set; }
      [DataMember]
      public int ClientId { get; set; }
      [DataMember]
      public string UserId { get; set; }
      [DataMember]
      public DateTime? StartDate { get; set; }
      [DataMember]
      public int? EstimatedDuration { get; set; }
      [DataMember]
      public string Notes { get; set; }
      [DataMember]
      public decimal? Hours { get; set; }
      [DataMember]
      public bool Complete { get; set; }
      [DataMember]
      public virtual ClientDTO client { get; set; }
      [DataMember]
      public virtual AspNetUsers user { get; set; }
      [DataMember]
      public virtual ServiceTypeDTO type { get; set; }
      
   }
}
