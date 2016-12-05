using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class AddressDTO
   {
      [DataMember]
      public string Street { get; set; }
      [DataMember]
      public string City { get; set; }
      [DataMember]
      public string State { get; set; }
      [DataMember]
      public string Zip { get; set; }
   }
}