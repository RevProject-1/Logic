using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class AspNetRoles
   {
      [DataMember]
      public string Id { get; set; }
      [DataMember]
      public string Name { get; set; }
   }
}