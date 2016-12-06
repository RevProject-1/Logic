using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Backend.Logic.ServiceReference1;

namespace ClientManagement.Backend.Logic
{
   
    public class appLogic
    {
      private Service1Client sc = new Service1Client();
      
      #region get functions

      #region get AspNetUsers functions
      public List<AspNetUsers> getAspNetUsers()
      {
         var result = sc.GetUsers();
         var newList = new List<AspNetUsers>();
         foreach (var item in result)
         {
            newList.Add(Mapping.AspNetUserMapper.mapToAspNetUsers(item));
         }
         return newList;
      }

      public List<AspNetUsers> getAspNetUsersByName(string name)
      {
         var newList = getAspNetUsers().Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();
         return newList;
      }
      #endregion

      #region get client functions
      public List<ClientDTO> getClients()
      {
         var clients = new List<ClientDTO>();
         var list = sc.GetClients();
         foreach (var item in list)
         {
            clients.Add(Mapping.ClientMapper.MapToClientDTO(item));
         }
         return clients;
      }

      public List<ClientDTO> getClientsByName(string name)
      {
         var list=getClients().Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();
         return list;
      }

      public List<ClientDTO> getClientsByPhoneNumber(string phoneNumber)
      {
         var list = getClients().Where(m => m.PhoneNumber.Equals(phoneNumber)).ToList();
         return list;
      }

      public List<ClientDTO> getClientsByEmail(string email)
      {
         var list = getClients().Where(m => m.Email.ToLower().Equals(email.ToLower())).ToList();
         return list;
      }

      public List<ClientDTO> getClientsByAddressId(int AddressId)
      {
         var list = getClients().Where(m => m.AddressID == AddressId).ToList();
         return list;
      }
      #endregion

      #region get AspNetRoles functions
      //public List<AspNetRoles> getAspNetRoles();

      //public List<AspNetRoles> getAspNetRoles(string name);

      //public List<AspNetRoles> getAspNetRoles(int Id);
      //#endregion

      //#region get AspNetUserClaims functions
      //public List<AspNetUserClaims> getAspNetUserClaims();

      //public List<AspNetUserClaims> getAspNetUserClaims(int Id);

      //public List<AspNetUserClaims> getAspNetUserClaims(string userId, string claimType, string claimValue);
      #endregion

      #region get AspNetUserLogins functions
      //public List<AspNetUserLogins> getAspNetUserLogins();

      //public List<AspNetUserLogins> getAspNetUserLogins(string loginProvider, string providerKey, string userId);
      #endregion

      #region get AspNetUserRoles functions

      //public List<AspNetUserRoles> getAspNetUserRoles();

      //public List<AspNetUserRoles> getAspNetUserRoles(string userId, string roleId);

      #endregion

      #region get AddressDTO functions

      public List<AddressDTO> getAddressDTOs()
      {
         var list = sc.GetAddress();
         List<AddressDTO> newlist = new List<AddressDTO>();
         foreach (var item in list)
         {
            newlist.Add(Mapping.AddressMapper.MapToAddressDTO(item));
            
         }
         return newlist;
      }

      public List<AddressDTO> getAddressDTOsByStreetandCityandStateandZip(string street, string city, string state, string zip)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower()) && m.Zip.Equals(zip)).ToList();
         return list;
      }

      public List<AddressDTO> getAddressDTOsByStreet(string street)
      {
         var list = getAddressDTOs().Where(m =>m.Street.ToLower().Equals(street.ToLower())).ToList();
         return list;
      }

      public List<AddressDTO> getAddressDTOsByStreetandCity(string street, string city)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;

      }

      public List<AddressDTO> getAddressDTOsByStreetandCityandState(string street, string city, string state)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      public List<AddressDTO> getAddressDTOsByZip(string zip)
      {
         var list = getAddressDTOs().Where(m => m.Zip.Equals(zip)).ToList();
         
         return list;
      }

      public List<AddressDTO> getAddressDTOsByState(string state)
      {
         var list = getAddressDTOs().Where(m => m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      public List<AddressDTO> getAddressDTOsByCity(string city)
      {
         var list = getAddressDTOs().Where(m => m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;
      }

      #endregion

      #endregion

      #region Insert Functions

      public bool insertAspNetUsers(AspNetUsers user)
      {
         return sc.Register(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }

      public bool insertClients(ClientDTO client)
      {
         return sc.AddClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      //public bool insertAspNetRoles(AspNetRoles role);

      //public bool insertAspNetUserClaims(AspNetUserClaims claim);

      //public bool insertAspNetUserLogins(AspNetUserLogins login);

      //public bool insertAspNetUserRoles(AspNetUserRoles userRole);

      //public bool insertAddressDTOs(AddressDTO address);

      #endregion

      #region delete functions

      //public bool deleteAddress(AddressDTO address);

      //public bool deleteAspNetRole(AspNetUserRoles role);

      //public bool deleteAspNetUserClaim(AspNetUserClaims claim);

      //public bool deleteAspNetUserLogin(AspNetUserLogins login);

      //public bool deleteAspNetUserRoles(AspNetUserRoles userRole);

      //public bool deleteAspNetUsers(AspNetUsers user);

      public bool deleteClient(ClientDTO client)
      {
         return sc.DeleteClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      #endregion

      #region update functions

      //public bool updateAddress(AddressDTO address);

      //public bool updateAspNetRole(AspNetUserRoles role);

      //public bool updateAspNetUserClaim(AspNetUserClaims claim);

      //public bool updateAspNetUserLogin(AspNetUserLogins login);

      //public bool updateAspNetUserRoles(AspNetUserRoles userRole);

      //public bool updateAspNetUsers(AspNetUsers user);

      public bool updateClient(ClientDTO client)
      {
         return sc.UpdateClient(Mapping.ClientMapper.MapToClientDAO(client));
      }


      #endregion

      public void login(AspNetUsers user)
      {
         sc.Login(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }
   }
}
