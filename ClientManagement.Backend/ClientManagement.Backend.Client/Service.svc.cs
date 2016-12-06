using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic;

namespace ClientManagement.Backend.Client
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   public class Service1 : IService
   {
      private appLogic logic = new appLogic();

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

      public List<AddressDTO> getAddressDTO(string street, string city, string state, string zip)
      {
         return logic.getAddressDTOs();
      }

      public List<AddressDTO> getAddressDTOByStreet(string street)
      {
         return logic.getAddressDTOsByStreet(street);
      }

      public List<AddressDTO> getAddressDTOByStreetandCity(string street, string city)
      {
         return logic.getAddressDTOsByStreetandCity(street,city);
      }

      public List<AddressDTO> getAddressDTOByStreetandCityandState(string street, string city, string state)
      {
         return logic.getAddressDTOsByStreetandCityandState(street,city,state);
      }

      public List<AddressDTO> getAddressDTOsByStreetandCityandStateandZip(string street,string city,string state,string zip)
      {
         return logic.getAddressDTOsByStreetandCityandStateandZip(street,city,state,zip);
      }

      public List<AddressDTO> getAddressDTOsByCity(string city)
      {
         return logic.getAddressDTOsByCity(city);
      }

      public List<AddressDTO> getAddressDTOsByState(string state)
      {
         return logic.getAddressDTOsByState(state);
      }

      public List<AddressDTO> getAddressDTOsByZip(string zip)
      {
         return logic.getAddressDTOsByZip(zip);
      }

      public List<AspNetRoles> getAspNetRoles()
      {
         throw new NotImplementedException();
      }

      public List<AspNetRoles> getAspNetRolesById(int Id)
      {
         throw new NotImplementedException();
      }

      public List<AspNetRoles> getAspNetRolesByName(string name)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaims()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaimsById(int Id)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserClaims> getAspNetUserClaimsByUserIdandClaimtypeandClaimValue(string userId, string claimType, string claimValue)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserLogins> getAspNetUserLogin(string loginProvider, string providerKey, string userId)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserLogins> getAspNetUserLogins()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserRoles> getAspNetUserRole(string userId, string roleId)
      {
         throw new NotImplementedException();
      }

      public List<AspNetUserRoles> getAspNetUserRoles()
      {
         throw new NotImplementedException();
      }

      public List<AspNetUsers> getAspNetUsers()
      {
         return logic.getAspNetUsers();
      }

      public List<AspNetUsers> getAspNetUsersByName(string name)
      {
         return logic.getAspNetUsersByName(name);
      }

      public List<ClientDTO> getClients()
      {
         return logic.getClients();
      }

      public List<ClientDTO> getClientsByAddressId(int AddressId)
      {
         return logic.getClientsByAddressId(AddressId);
      }

      public List<ClientDTO> getClientsByEmail(string email)
      {
         return logic.getClientsByEmail(email);
      }

      public List<ClientDTO> getClientsByName(string name)
      {
         return logic.getClientsByName(name);
      }

      public List<ClientDTO> getClientsByPhoneNumber(string phoneNumber)
      {
         return logic.getClientsByPhoneNumber(phoneNumber);
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
         return logic.insertClients(client);
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

      public List<AddressDTO> getAddressDTOs()
      {
         return logic.getAddressDTOs();
      }
   }
}
