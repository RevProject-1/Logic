using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class ClientDTO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public int? AddressID { get; set; }
      [DataMember]
      public string PhoneNumber { get; set; }
      [DataMember]
      public string Email { get; set; }
      [DataMember]
      public AddressDTO Address { get; set; }
      [DataMember]
      public string UserId { get; set; }
   }
}