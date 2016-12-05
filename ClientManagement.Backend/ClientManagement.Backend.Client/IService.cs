using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClientManagement.Backend.Client
{
   [ServiceContract]
   public interface IService
   {

      #region get functions

      #region get AspNetUsers functions
      [OperationContract]
      List<AspNetUsers> getAspNetUsers();

      [OperationContract]
      List<AspNetUsers> getAspNetUsersByName(string name);
      #endregion

      #region get client functions
      [OperationContract]
      List<ClientDTO> getClients();

      [OperationContract]
      List<ClientDTO> getClientsByName(string name);

      [OperationContract]
      List<ClientDTO> getClientsByPhoneNumber(string phoneNumber);

      [OperationContract]
      List<ClientDTO> getClientsByEmail(string email);

      [OperationContract]
      List<ClientDTO> getClientsByAddressId(int AddressId);
      #endregion

      #region get AspNetRoles functions
      [OperationContract]
      List<AspNetRoles> getAspNetRoles();

      [OperationContract]
      List<AspNetRoles> getAspNetRolesByName(string name);

      [OperationContract]
      List<AspNetRoles> getAspNetRolesById(int Id);
      #endregion

      #region get AspNetUserClaims functions
      [OperationContract]
      List<AspNetUserClaims> getAspNetUserClaims();

      [OperationContract]
      List<AspNetUserClaims> getAspNetUserClaimsById(int Id);

      [OperationContract]
      List<AspNetUserClaims> getAspNetUserClaimsByUserIdandClaimtypeandClaimValue(string userId, string claimType, string claimValue);
      #endregion

      #region get AspNetUserLogins functions
      [OperationContract]
      List<AspNetUserLogins> getAspNetUserLogins();

      [OperationContract]
      List<AspNetUserLogins> getAspNetUserLogin(string loginProvider,string providerKey,string userId);
      #endregion

      #region AspNetUserRoles functions

      [OperationContract]
      List<AspNetUserRoles> getAspNetUserRoles();

      [OperationContract]
      List<AspNetUserRoles> getAspNetUserRole(string userId, string roleId);

      #endregion

      #region get AddressDTO functions

      [OperationContract]
      List<AddressDTO> getAddressDTOs();

      [OperationContract]
      List<AddressDTO> getAddressDTO(string street, string city, string state, string zip);

      [OperationContract]
      List<AddressDTO> getAddressDTOByStreet(string street);

      [OperationContract]
      List<AddressDTO> getAddressDTOByStreetandCity(string street, string city);

      [OperationContract]
      List<AddressDTO> getAddressDTOByStreetandCityandState(string street, string city, string state);

      [OperationContract]
      List<AddressDTO> getAddressDTOsByZip(string zip);

      [OperationContract]
      List<AddressDTO> getAddressDTOsByState(string state);

      [OperationContract]
      List<AddressDTO> getAddressDTOsByCity(string city);

      #endregion

      #endregion

      #region Insert Functions

      [OperationContract]
      bool insertAspNetUsers(AspNetUsers user);

      [OperationContract]
      bool insertClients(ClientDTO client);

      [OperationContract]
      bool insertAspNetRoles(AspNetRoles role);

      [OperationContract]
      bool insertAspNetUserClaims(AspNetUserClaims claim);

      [OperationContract]
      bool insertAspNetUserLogins(AspNetUserLogins login);

      [OperationContract]
      bool insertAspNetUserRoles(AspNetUserRoles userRole);

      [OperationContract]
      bool insertAddressDTOs(AddressDTO address);

      #endregion

      #region delete functions

      [OperationContract]
      bool deleteAddress(AddressDTO address);

      [OperationContract]
      bool deleteAspNetRole(AspNetUserRoles role);

      [OperationContract]
      bool deleteAspNetUserClaim(AspNetUserClaims claim);

      [OperationContract]
      bool deleteAspNetUserLogin(AspNetUserLogins login);

      [OperationContract]
      bool deleteAspNetUserRoles(AspNetUserRoles userRole);

      [OperationContract]
      bool deleteAspNetUsers(AspNetUsers user);

      [OperationContract]
      bool deleteClient(ClientDTO client);

      #endregion

      #region update functions

      [OperationContract]
      bool updateAddress(AddressDTO address);

      [OperationContract]
      bool updateAspNetRole(AspNetUserRoles role);

      [OperationContract]
      bool updateAspNetUserClaim(AspNetUserClaims claim);

      [OperationContract]
      bool updateAspNetUserLogin(AspNetUserLogins login);

      [OperationContract]
      bool updateAspNetUserRoles(AspNetUserRoles userRole);

      [OperationContract]
      bool updateAspNetUsers(AspNetUsers user);

      [OperationContract]
      bool updateClient(ClientDTO client);


      #endregion

      void login(AspNetUsers user);
   }
}

