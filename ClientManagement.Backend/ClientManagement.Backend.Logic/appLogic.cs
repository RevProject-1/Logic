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

      /// <summary>
      /// calls get users from data access service
      /// </summary>
      /// <returns>list of aspnetusers</returns>
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

      /// <summary>
      /// calls get users and filters results by name
      /// </summary>
      /// <param name="name"></param>
      /// <returns>list of users where name is "name"</returns>
      public List<AspNetUsers> getAspNetUsersByName(string name)
      {
         var newList = getAspNetUsers().Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();
         return newList;
      }

      #endregion

      #region get client functions

      public List<ClientDTO> getClientsForUser(AspNetUsers user)
      {
         var list = sc.GetClients().Where(a => a.UserId.Equals(user.Id));
         var list2 = new List<ClientDTO>();
         foreach (var item in list)
         {
            list2.Add(Mapping.ClientMapper.MapToClientDTO(item));
         }
         return list2;
      }

      /// <summary>
      /// calls get clients from data access service
      /// </summary>
      /// <returns>list of clients</returns>
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

      /// <summary>
      /// calls getclients and filters results by name
      /// </summary>
      /// <param name="name"></param>
      /// <returns>list of clients where name = name</returns>
      public List<ClientDTO> getClientsByName(string name)
      {
         var list=getClients().Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// calls getclients and filters by phonenumber
      /// </summary>
      /// <param name="phoneNumber"></param>
      /// <returns>list of clients with matching phonenumber</returns>
      public List<ClientDTO> getClientsByPhoneNumber(string phoneNumber)
      {
         var list = getClients().Where(m => m.PhoneNumber.Equals(phoneNumber)).ToList();
         return list;
      }

      /// <summary>
      /// calls getclients and filters by email
      /// </summary>
      /// <param name="email"></param>
      /// <returns>list of clients with matching email</returns>
      public List<ClientDTO> getClientsByEmail(string email)
      {
         var list = getClients().Where(m => m.Email.ToLower().Equals(email.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// calls getclients and filters by addressId
      /// </summary>
      /// <param name="AddressId"></param>
      /// <returns>list of clients with matching addressId</returns>
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
      
      /// <summary>
      /// calls getaddress from service 
      /// </summary>
      /// <returns>list of addresses</returns>
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

      /// <summary>
      /// calls getaddress and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <param name="state"></param>
      /// <param name="zip"></param>
      /// <returns>list of addresses with matching params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCityandStateandZip(string street, string city, string state, string zip)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower()) && m.Zip.Equals(zip)).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by street
      /// </summary>
      /// <param name="street"></param>
      /// <returns>list of addresses with matching street</returns>
      public List<AddressDTO> getAddressDTOsByStreet(string street)
      {
         var list = getAddressDTOs().Where(m =>m.Street.ToLower().Equals(street.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <returns>list of addresses that matches params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCity(string street, string city)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;

      }

      /// <summary>
      /// get addresses and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <param name="state"></param>
      /// <returns>list of addresses that match params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCityandState(string street, string city, string state)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by zip
      /// </summary>
      /// <param name="zip"></param>
      /// <returns>list of adddresses with matching zip</returns>
      public List<AddressDTO> getAddressDTOsByZip(string zip)
      {
         var list = getAddressDTOs().Where(m => m.Zip.Equals(zip)).ToList();
         
         return list;
      }

      /// <summary>
      /// gets addresses and filters by state
      /// </summary>
      /// <param name="state"></param>
      /// <returns>list of addresses with matching state</returns>
      public List<AddressDTO> getAddressDTOsByState(string state)
      {
         var list = getAddressDTOs().Where(m => m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by city
      /// </summary>
      /// <param name="city"></param>
      /// <returns>list of addresses with matching city</returns>
      public List<AddressDTO> getAddressDTOsByCity(string city)
      {
         var list = getAddressDTOs().Where(m => m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;
      }

      #endregion



      public List<jobDTO> getJobs()
      {
         var list = sc.GetJobs().ToList();
         var list2 = new List<jobDTO>();
         foreach (var item in list)
         {
            list2.Add(Mapping.JobMapper.mapToJobDTO(item));
         }
         return list2;
      }

      public List<ServiceTypeDTO> getServiceTypes()
      {
         var list = sc.GetTypes().ToList();
         var list2 = new List<ServiceTypeDTO>();
         foreach (var item in list)
         {
            list2.Add(Mapping.ServiceTypeMapper.MaptoServiceTypeDTO(item));
         }
         return list2;
      }

      #endregion

      #region Insert Functions

      /// <summary>
      /// takes user argument, maps it to dao and send user to insert function in data access service
      /// </summary>
      /// <param name="user"></param>
      /// <returns>true if insert success, else returns false</returns>
      public bool insertAspNetUsers(AspNetUsers user)
      {
         return sc.Register(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }

      /// <summary>
      /// takes client arg, maps it to dao, sends it to insert function in data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if succuss, else false</returns>
      public bool insertClients(ClientDTO client)
      {
         return sc.AddClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      public bool insertServiceType(ServiceTypeDTO type)
      {
         return sc.AddType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }

      public bool insertJob(jobDTO job)
      {
         return sc.AddJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      //public bool insertAspNetRoles(AspNetRoles role);

      //public bool insertAspNetUserClaims(AspNetUserClaims claim);

      //public bool insertAspNetUserLogins(AspNetUserLogins login);

      //public bool insertAspNetUserRoles(AspNetUserRoles userRole);

      //public bool insertAddressDTOs(AddressDTO address);

      #endregion

      #region delete functions
      
      public bool deleteJob(jobDTO job)
      {
         return sc.DeleteJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      public bool deleteServiceType(ServiceTypeDTO type)
      {
         return sc.DeleteType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }

      //public bool deleteAddress(AddressDTO address);

      //public bool deleteAspNetRole(AspNetUserRoles role);

      //public bool deleteAspNetUserClaim(AspNetUserClaims claim);

      //public bool deleteAspNetUserLogin(AspNetUserLogins login);

      //public bool deleteAspNetUserRoles(AspNetUserRoles userRole);

      //public bool deleteAspNetUsers(AspNetUsers user);

      /// <summary>
      /// takes a client object, maps it to dao and calls delete client from data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if success, else false</returns>
      public bool deleteClient(ClientDTO client)
      {
         return sc.DeleteClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      #endregion

      #region update functions

      public bool updateJob(jobDTO job)
      {
         return sc.UpdateJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      public bool updateServiceType(ServiceTypeDTO type)
      {
         return sc.UpdateType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }

      //public bool updateAddress(AddressDTO address);

      //public bool updateAspNetRole(AspNetUserRoles role);

      //public bool updateAspNetUserClaim(AspNetUserClaims claim);

      //public bool updateAspNetUserLogin(AspNetUserLogins login);

      //public bool updateAspNetUserRoles(AspNetUserRoles userRole);

      /// <summary>
      /// takes user object, maps it to dao and calls update user in data access service
      /// </summary>
      /// <param name="user"></param>
      /// <returns>true if success,else false</returns>
      public bool updateAspNetUsers(AspNetUsers user)
      {
         return sc.UpdateUser(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }

      /// <summary>
      /// takes client object, maps it to dao, calls update client from data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if success, else false</returns>
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
