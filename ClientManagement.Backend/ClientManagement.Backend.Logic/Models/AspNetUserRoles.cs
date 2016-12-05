using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class AspNetUserRoles
   {
      [DataMember]
      public string UserId { get; set; }
      [DataMember]
      public string RoleId { get; set; }
   }
}