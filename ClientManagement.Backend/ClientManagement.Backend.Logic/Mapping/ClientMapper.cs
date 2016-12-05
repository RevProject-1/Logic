using ClientManagement.Backend.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagement.Backend.Logic.Mapping
{
   public class ClientMapper
   {
      public static ClientDTO MapToCustomerDTO(ClientDAO b)
      {
         var a = new ClientDTO();
         a.AddressID = b.AddressId;
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;

         return a;
      }

      public static ClientDAO MapToCustomerDAO(ClientDTO b)
      {
         var a = new ClientDAO();
         a.AddressId = b.AddressID;
         a.Email = b.Email;
         a.Name = b.Name;
         a.Phone = b.PhoneNumber;
         
         return a;
      }
   }
}