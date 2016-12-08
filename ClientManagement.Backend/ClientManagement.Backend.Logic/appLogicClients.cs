using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic
{
   public partial class appLogic
   {

      #region get client functions

      public List<ClientDTO> getClientsByUserId(string userID)
      {

         var list = sc.GetClients().Where(a => a.UserId != null && a.UserId.Equals(userID));
         var list2 = new List<ClientDTO>();
         foreach (var item in list)
         {
            list2.Add(Mapping.ClientMapper.MapToClientDTO(item));
         }
         return list2;
      }

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
         var list = getClients().Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();
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

      /// <summary>
      /// takes client arg, maps it to dao, sends it to insert function in data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if succuss, else false</returns>
      public bool insertClients(ClientDTO client)
      {
         
         client.Email = client.Email.ToLower();
         client.Name = stringFormatter(client.Name).ToString();
         client.Address.Street = stringFormatter(client.Address.Street).ToString();
         client.Address.City = stringFormatter(client.Address.City).ToString();         
         client.Address.State=client.Address.State.ToUpper();
         client.PhoneNumber = phoneFormatter(client.PhoneNumber).ToString();
         return sc.AddClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      /// <summary>
      /// takes a client object, maps it to dao and calls delete client from data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if success, else false</returns>
      public bool deleteClient(ClientDTO client)
      {
         return sc.DeleteClient(Mapping.ClientMapper.MapToClientDAO(client));
      }

      /// <summary>
      /// takes client object, maps it to dao, calls update client from data access service
      /// </summary>
      /// <param name="client"></param>
      /// <returns>true if success, else false</returns>
      public bool updateClient(ClientDTO client)
      {
         client.Email = client.Email.ToLower();
         client.Name = stringFormatter(client.Name).ToString();
         client.Address.Street = stringFormatter(client.Address.Street).ToString();
         client.Address.City = stringFormatter(client.Address.City).ToString();
         client.Address.State = client.Address.State.ToUpper();
         client.PhoneNumber = phoneFormatter(client.PhoneNumber).ToString();
         return sc.UpdateClient(Mapping.ClientMapper.MapToClientDAO(client));
      }
   }
}
