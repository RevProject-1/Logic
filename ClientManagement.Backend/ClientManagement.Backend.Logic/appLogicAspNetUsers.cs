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

      public List<AspNetUsers> getUserById(string userId)
      {
         return getAspNetUsers().Where(m => m.Id.Equals(userId)).ToList();
      }

      #endregion

      /// <summary>
      /// takes user argument, maps it to dao and send user to insert function in data access service
      /// </summary>
      /// <param name="user"></param>
      /// <returns>true if insert success, else returns false</returns>
      public bool insertAspNetUsers(AspNetUsers user)
      {
         user.Email = user.Email.ToLower();
         user.Name = stringFormatter(user.Name).ToString();
         user.StreetAddress = stringFormatter(user.StreetAddress).ToString();
         user.City = stringFormatter(user.City).ToString();
         user.State = user.State.ToUpper();
         user.PhoneNumber = phoneFormatter(user.PhoneNumber).ToString();
         return sc.Register(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }

     
      /// <summary>
      /// takes user object, maps it to dao and calls update user in data access service
      /// </summary>
      /// <param name="user"></param>
      /// <returns>true if success,else false</returns>
      public bool updateAspNetUsers(AspNetUsers user)
      {
         return sc.UpdateUser(Mapping.AspNetUserMapper.mapToUserDAO(user));
      }

      //public bool deleteAspNetUsers(AspNetUsers user);
   }
}
