using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
    
   public class AddressDTO
   {
      
      [DataMember]
      [StringLength(255, ErrorMessage = "Length should be between 2 and 255", MinimumLength = 2)]
      public string Street { get; set; }
      [DataMember]
      [StringLength(255, ErrorMessage ="Length should be between 2 and 255",MinimumLength = 2)]
      public string City { get; set; }
      [DataMember]
      [RegularExpression("^[a-zA-Z]{2}$")]
      public string State { get; set; }
      [DataMember]      
      [RegularExpression("^[0-9]{5}(-[0-9]{4})?$", ErrorMessage ="Format failed")]
      public string Zip { get; set; }
   }
}