using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class AspNetUserLogins
   {
      [DataMember]
      public string LoginProvider { get; set; }
      [DataMember]
      public string ProviderKey { get; set; }
      [DataMember]
      public string UserId { get; set; }
   }
}