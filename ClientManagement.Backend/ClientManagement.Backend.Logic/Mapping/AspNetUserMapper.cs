using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Mapping
{
   class AspNetUserMapper
   {
      public static AspNetUsers mapToAspNetUsers(UserDAO b)
      {
         var a = new AspNetUsers();
         a.City = b.City;
         a.Email = b.Email;
         a.EmailConfirmed = b.EmailConfirmed;
         a.Id = b.Id;
         a.LockoutEnabled = b.LockoutEnabled;
         a.LockoutEndDateUtc = b.LockoutEndDateUtc;
         a.Name = b.Name;
         a.PasswordHash = b.PasswordHash;
         a.PhoneNumber = b.PhoneNumber;
         a.PhoneNumberConfirmed = b.PhoneNumberConfirmed;
         a.SecurityStamp = b.SecurityStamp;
         a.State = b.State;
         a.StreetAddress = b.StreetAddress;
         a.TwoFactorEnabled = b.TwoFactorEnabled;
         a.UserName = b.UserName;
         a.Zip = b.Zip;

         return a;
      }

      public static UserDAO mapToUserDAO(AspNetUsers b)
      {
         var a = new UserDAO();
         a.City = b.City;
         a.Email = b.Email;
         a.EmailConfirmed = b.EmailConfirmed;
         a.Id = b.Id;
         a.LockoutEnabled = b.LockoutEnabled;
         a.LockoutEndDateUtc = b.LockoutEndDateUtc;
         a.Name = b.Name;
         a.PasswordHash = b.PasswordHash;
         a.PhoneNumber = b.PhoneNumber;
         a.PhoneNumberConfirmed = b.PhoneNumberConfirmed;
         a.SecurityStamp = b.SecurityStamp;
         a.State = b.State;
         a.StreetAddress = b.StreetAddress;
         a.TwoFactorEnabled = b.TwoFactorEnabled;
         a.UserName = b.UserName;
         a.Zip = b.Zip;

         return a;
      }
   }
}
