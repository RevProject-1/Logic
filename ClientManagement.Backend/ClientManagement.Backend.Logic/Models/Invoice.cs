using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Models
{
   [DataContract]
   public class Invoice
   {
      [DataMember]
      public string BusinessName { get; set; }
      [DataMember]
      public string BusinessPhoneNumber { get; set; }
      [DataMember]
      public string ClientName { get; set; }
      [DataMember]
      public string ClientNumber { get; set; }
      [DataMember]
      public string ClientStreet { get; set; }
      [DataMember]
      public string ClientCity { get; set; }
      [DataMember]
      public string ClientState { get; set; }
      [DataMember]
      public string ZipCode { get; set; }
      [DataMember]
      public string ServiceType { get; set; }
      [DataMember]
      public string StartDate { get; set; }
      [DataMember]
      public string EndDate { get; set; }
      [DataMember]
      public string HourlyRate { get; set; }
      [DataMember]
      public string BilledHours { get; set; }
      [DataMember]
      public List<InvoiceExpenses> expenses { get; set; }
      [DataMember]
      public string totalExpenses { get; set; }
      [DataMember]
      public string subTotal { get; set; }
      //[DataMember]
      //public string Total { get; set; }
      [DataMember]
      public string Notes { get; set; }

   }
}
