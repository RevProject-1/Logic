using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClientManagement.Backend.Logic.Models;

namespace ClientManagement.Backend.Client
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   public class Service1 : IService
   {
      public bool deleteAddress(AddressDTO address)
      {
         throw new NotImplementedException();
      }

      public bool deleteAspNetRole(AspNetUserRoles role)
      {
         throw new NotImplementedException();
      }

      public bool deleteAspNetUserClaim(AspNetUserClaims claim)
      {
         throw new NotImplementedException();
      }

      public bool deleteAspNetUserLogin(AspNetUserLogins login)
      {
         throw new NotImplementedException();
      }

      public bool deleteAspNetUserRoles(AspNetUserRoles userRole)
      {
         throw new NotImplementedException();
      }

      public bool deleteAspNetUsers(AspNetUsers user)
      {
         throw new NotImplementedException();
      }

      public bool deleteClient(ClientDTO client)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOs()
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOs(string street)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOs(string street, string city)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOs(string street, string city, string state)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOs(string street, string city, string state, string zip)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOsByCity(string city)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOsByState(string state)
      {
         throw new NotImplementedException();
      }

      public List<AddressDTO> getAddressDTOsByZip(string zip)
      {
         throw new NotImplementedException();
      }

      public List<AspNetRoles> getAspNetRoles()
      {
         throw new NotImplementedException();
      }

      public List<AspNetRoles> getAspNetRoles(int Id)
      {
         throw new NotImplementedException();
      }

      public List<AspNetRoles> getAspNetRoles(string name)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaims()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaims(int Id)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaims(string userId, string claimType, string claimValue)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserLogins> getAspNetUserLogins()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserLogins> getAspNetUserLogins(string loginProvider, string providerKey, string userId)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserRoles> getAspNetUserRoles()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserRoles> getAspNetUserRoles(string userId, string roleId)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUsers> getAspNetUsers()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUsers> getAspNetUsers(string name)
      {
         throw new NotImplementedException();
      }

      public List<ClientDTO> getClients()
      {
         throw new NotImplementedException();
      }

      public List<ClientDTO> getClients(string name)
      {
         throw new NotImplementedException();
      }

      public List<ClientDTO> getClientsByAddressId(int AddressId)
      {
         throw new NotImplementedException();
      }

      public List<ClientDTO> getClientsByEmail(string email)
      {
         throw new NotImplementedException();
      }

      public List<ClientDTO> getClientsByPhoneNumber(string phoneNumber)
      {
         throw new NotImplementedException();
      }

      public bool insertAddressDTOs(AddressDTO address)
      {
         throw new NotImplementedException();
      }

      public bool insertAspNetRoles(AspNetRoles role)
      {
         throw new NotImplementedException();
      }

      public bool insertAspNetUserClaims(AspNetUserClaims claim)
      {
         throw new NotImplementedException();
      }

      public bool insertAspNetUserLogins(AspNetUserLogins login)
      {
         throw new NotImplementedException();
      }

      public bool insertAspNetUserRoles(AspNetUserRoles userRole)
      {
         throw new NotImplementedException();
      }

      public bool insertAspNetUsers(AspNetUsers user)
      {
         throw new NotImplementedException();
      }

      public bool insertClients(ClientDTO client)
      {
         throw new NotImplementedException();
      }

      public void login(AspNetUsers user)
      {
         throw new NotImplementedException();
      }

      public bool updateAddress(AddressDTO address)
      {
         throw new NotImplementedException();
      }

      public bool updateAspNetRole(AspNetUserRoles role)
      {
         throw new NotImplementedException();
      }

      public bool updateAspNetUserClaim(AspNetUserClaims claim)
      {
         throw new NotImplementedException();
      }

      public bool updateAspNetUserLogin(AspNetUserLogins login)
      {
         throw new NotImplementedException();
      }

      public bool updateAspNetUserRoles(AspNetUserRoles userRole)
      {
         throw new NotImplementedException();
      }

      public bool updateAspNetUsers(AspNetUsers user)
      {
         throw new NotImplementedException();
      }

      public bool updateClient(ClientDTO client)
      {
         throw new NotImplementedException();
      }
   }
}
