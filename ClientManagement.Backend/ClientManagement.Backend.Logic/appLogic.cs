using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientManagement.Backend.Logic
{
    public class appLogic
    {
      #region get functions

      #region get AspNetUsers functions
      List<AspNetUsers> getAspNetUsers()
      {
         
      }

      List<AspNetUsers> getAspNetUsers(string name);
      #endregion

      #region get client functions
      List<ClientDTO> getClients();

      List<ClientDTO> getClients(string name);

      List<ClientDTO> getClientsByPhoneNumber(string phoneNumber);

      List<ClientDTO> getClientsByEmail(string email);

      List<ClientDTO> getClientsByAddressId(int AddressId);
      #endregion

      #region get AspNetRoles functions
      List<AspNetRoles> getAspNetRoles();

      List<AspNetRoles> getAspNetRoles(string name);

      List<AspNetRoles> getAspNetRoles(int Id);
      #endregion

      #region get AspNetUserClaims functions
      List<AspNetUserClaims> getAspNetUserClaims();

      List<AspNetUserClaims> getAspNetUserClaims(int Id);

      List<AspNetUserClaims> getAspNetUserClaims(string userId, string claimType, string claimValue);
      #endregion

      #region get AspNetUserLogins functions
      List<AspNetUserLogins> getAspNetUserLogins();

      List<AspNetUserLogins> getAspNetUserLogins(string loginProvider, string providerKey, string userId);
      #endregion

      #region AspNetUserRoles functions

      List<AspNetUserRoles> getAspNetUserRoles();

      List<AspNetUserRoles> getAspNetUserRoles(string userId, string roleId);

      #endregion

      #region get AddressDTO functions

      List<AddressDTO> getAddressDTOs();

      List<AddressDTO> getAddressDTOs(string street, string city, string state, string zip);

      List<AddressDTO> getAddressDTOs(string street);

      List<AddressDTO> getAddressDTOs(string street, string city);

      List<AddressDTO> getAddressDTOs(string street, string city, string state);

      List<AddressDTO> getAddressDTOsByZip(string zip);

      List<AddressDTO> getAddressDTOsByState(string state);

      List<AddressDTO> getAddressDTOsByCity(string city);

      #endregion

      #endregion

      #region Insert Functions

      bool insertAspNetUsers(AspNetUsers user);

      bool insertClients(ClientDTO client);

      bool insertAspNetRoles(AspNetRoles role);

      bool insertAspNetUserClaims(AspNetUserClaims claim);

      bool insertAspNetUserLogins(AspNetUserLogins login);

      bool insertAspNetUserRoles(AspNetUserRoles userRole);

      bool insertAddressDTOs(AddressDTO address);

      #endregion

      #region delete functions

      bool deleteAddress(AddressDTO address);

      bool deleteAspNetRole(AspNetUserRoles role);

      bool deleteAspNetUserClaim(AspNetUserClaims claim);

      bool deleteAspNetUserLogin(AspNetUserLogins login);

      bool deleteAspNetUserRoles(AspNetUserRoles userRole);

      bool deleteAspNetUsers(AspNetUsers user);

      bool deleteClient(ClientDTO client);

      #endregion

      #region update functions

      bool updateAddress(AddressDTO address);

      bool updateAspNetRole(AspNetUserRoles role);

      bool updateAspNetUserClaim(AspNetUserClaims claim);

      bool updateAspNetUserLogin(AspNetUserLogins login);

      bool updateAspNetUserRoles(AspNetUserRoles userRole);

      bool updateAspNetUsers(AspNetUsers user);

      bool updateClient(ClientDTO client);


      #endregion
   }
}
