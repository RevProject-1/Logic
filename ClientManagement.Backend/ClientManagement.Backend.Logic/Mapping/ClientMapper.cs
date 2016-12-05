using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagement.Backend.Logic.Mapping
{
   public class ClientMapper
   {
      public static ClientDTO MapToClientDTO(ClientDAO b)
      {
         var a = new ClientDTO();
         a.AddressID = b.AddressID;
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;
         a.Address = AddressMapper.MapToAddressDTO(b.Address);
         a.UserId = b.UserId;
         return a;
      }

      public static ClientDAO MapToClientDAO(ClientDTO b)
      {
         var a = new ClientDAO();
         a.AddressID = b.AddressID;
         a.Email = b.Email;
         a.Name = b.Name;
         a.PhoneNumber = b.PhoneNumber;
         a.Address = Mapping.AddressMapper.MapToAddressDAO(b.Address);
         a.UserId = b.UserId;
         return a;
      }
   }
}