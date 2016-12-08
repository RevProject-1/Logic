using ClientManagement.Backend.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Backend.Logic.ServiceReference1;

namespace ClientManagement.Backend.Logic
{
   
    public partial class appLogic
    {
      private Service1Client sc = new Service1Client();


      #region unimplemented unctions
      #region unimplemented get AspNetRoles functions
      //public List<AspNetRoles> getAspNetRoles();

      //public List<AspNetRoles> getAspNetRoles(string name);

      //public List<AspNetRoles> getAspNetRoles(int Id);
      //#endregion

      //#region get AspNetUserClaims functions
      //public List<AspNetUserClaims> getAspNetUserClaims();

      //public List<AspNetUserClaims> getAspNetUserClaims(int Id);

      //public List<AspNetUserClaims> getAspNetUserClaims(string userId, string claimType, string claimValue);
      #endregion

      #region unimplemented get AspNetUserLogins functions
      //public List<AspNetUserLogins> getAspNetUserLogins();

      //public List<AspNetUserLogins> getAspNetUserLogins(string loginProvider, string providerKey, string userId);
      #endregion

      #region unimplemented get AspNetUserRoles functions

      //public List<AspNetUserRoles> getAspNetUserRoles();

      //public List<AspNetUserRoles> getAspNetUserRoles(string userId, string roleId);

      #endregion

      #region unimplemented Insert Functions      

      //public bool insertAspNetRoles(AspNetRoles role);

      //public bool insertAspNetUserClaims(AspNetUserClaims claim);

      //public bool insertAspNetUserLogins(AspNetUserLogins login);

      //public bool insertAspNetUserRoles(AspNetUserRoles userRole);     

      #endregion

      #region unimplemented delete functions      

      //public bool deleteAspNetRole(AspNetUserRoles role);

      //public bool deleteAspNetUserClaim(AspNetUserClaims claim);

      //public bool deleteAspNetUserLogin(AspNetUserLogins login);

      //public bool deleteAspNetUserRoles(AspNetUserRoles userRole);      

      #endregion

      #region unimplemented update functions     

      //public bool updateAspNetRole(AspNetUserRoles role);

      //public bool updateAspNetUserClaim(AspNetUserClaims claim);

      //public bool updateAspNetUserLogin(AspNetUserLogins login);

      //public bool updateAspNetUserRoles(AspNetUserRoles userRole);

      #endregion
      #endregion


      public void login(AspNetUsers user)
      {
         sc.Login(Mapping.AspNetUserMapper.mapToUserDAO(user));
         
      }
   }
}
