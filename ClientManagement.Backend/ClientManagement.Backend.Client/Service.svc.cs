using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic;
using ClientManagement.Backend.Logic.ServiceReference1;

using DevTrends.WCFDataAnnotations;

namespace ClientManagement.Backend.Client
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   [ValidateDataAnnotationsBehavior]
   public class Service1 : IService
   {
      private appLogic logic = new appLogic();


      #region jobExpenses

      public List<JobExpenseDTO> getJobExpenses()
      {
         return logic.getJobExpenses();
      }

      public bool insertJobExpense(jobDTO job, ExpenseDTO expense)
      {
         return logic.insertJobExpense(job, expense);
      }

      public bool updateJobExpense(JobExpenseDTO je)
      {
         return logic.updateJobExpense(je);
      }

      public bool deleteJobExpense(JobExpenseDTO je)
      {
         return logic.deleteJobExpense(je);
      }
      #endregion

      #region users
      public bool updateAspNetUsers(AspNetUsers user)
      {
         return logic.updateAspNetUsers(user);
      }
      public bool deleteAspNetUsers(AspNetUsers user)
      {
         throw new NotImplementedException();
      }
      public bool insertAspNetUsers(AspNetUsers user)
      {
         return logic.insertAspNetUsers(user);
      }
      public List<AspNetUsers> getUserById(string userId)
      {
         return logic.getUserById(userId);
      }

      #region get aspnetuser functions
      public List<AspNetUsers> getAspNetUsers()
      {
         return logic.getAspNetUsers();
      }

      public List<AspNetUsers> getAspNetUsersByName(string name)
      {
         return logic.getAspNetUsersByName(name);
      }
      #endregion
      #endregion

      #region servicetypes
      public bool deleteServiceType(ServiceTypeDTO type)
      {
         return logic.deleteServiceType(type);
      }
      public bool updateServiceType(ServiceTypeDTO type)
      {
         return logic.updateServiceType(type);
      }
      public bool insertServiceType(ServiceTypeDTO type)
      {
         return logic.insertServiceType(type);
      }

      public List<ServiceTypeDTO> getServiceTypeByName(string name)
      {
         return logic.getServiceTypeByName(name);
      }
      #region get serviceType functions
      public List<ServiceTypeDTO> getServiceTypes()
      {
         return logic.getServiceTypes();
      }
      #endregion
      #endregion

      #region addresses
      public bool deleteAddress(AddressDTO address)
      {
         throw new NotImplementedException();
      }
      public bool insertAddressDTOs(AddressDTO address)
      {
         throw new NotImplementedException();
      }
      public bool updateAddress(AddressDTO address)
      {
         throw new NotImplementedException();
      }
      #region get address functions
      public List<AddressDTO> getAddressDTOs()
      {
         return logic.getAddressDTOs();
      }

      public List<AddressDTO> getAddressDTObyStreetandCityandStateandZip(string street, string city, string state, string zip)
      {
         return logic.getAddressDTOsByStreetandCityandStateandZip(street, city, state, zip);
      }

      public List<AddressDTO> getAddressDTOByStreet(string street)
      {
         return logic.getAddressDTOsByStreet(street);
      }

      public List<AddressDTO> getAddressDTOByStreetandCity(string street, string city)
      {
         return logic.getAddressDTOsByStreetandCity(street, city);
      }

      public List<AddressDTO> getAddressDTOByStreetandCityandState(string street, string city, string state)
      {
         return logic.getAddressDTOsByStreetandCityandState(street, city, state);
      }

      public List<AddressDTO> getAddressDTOByStreetandCityandStateandZip(string street, string city, string state, string zip)
      {
         return logic.getAddressDTOsByStreetandCityandStateandZip(street, city, state, zip);
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
      #endregion

      #endregion

      #region jobs
      public List<jobDTO> getJobsForUser(string userId)
      {
         return logic.getJobsForUser(userId);
      }
      public bool completeJob(jobDTO job)
      {
         return logic.completeJob(job);
      }
      public bool deleteJob(jobDTO job)
      {
         return logic.deleteJob(job);
      }
      public bool updateJob(jobDTO job)
      {
         return logic.updateJob(job);
      }
      public bool insertJob(jobDTO job)
      {
         var a = logic.getClientsByName(job.client.Name).FirstOrDefault();
         var b = logic.getServiceTypes().Where(m => m.Name.Equals(job.type.Name)).FirstOrDefault();
         var c = logic.getAspNetUsersByName(job.user.Name).FirstOrDefault();
         job.UserId = c.Id;
         job.ServiceTypeId = b.Id;
         job.ClientId = a.Id;

         return logic.insertJob(job);
      }

      #region get job functions
      public List<jobDTO> getJobsByUserComplete(string userId)
      {
         return logic.getJobsByUserComplete(userId);
      }

      public List<jobDTO> getJobsByUserIncomplete(string userId)
      {
         return logic.getJobsByUserIncomplete(userId);
      }

      public List<jobDTO> getjobs()
      {
         return logic.getJobs().ToList();
      }
      #endregion

      #endregion

      #region client
      public bool deleteClient(ClientDTO client)
      {
         return logic.deleteClient(client);
      }
      public bool updateClient(ClientDTO client)
      {
         return logic.updateClient(client);
      }
      public bool insertClients(ClientDTO client)
      {
         return logic.insertClients(client);
      }

      #region get client functions

      public List<ClientDTO> getClientsByUserId(string userId)
      {
         return logic.getClientsByUserId(userId);
      }


      public List<ClientDTO> getClientsforUser(AspNetUsers user)
      {
         return logic.getClientsForUser(user);
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
      #endregion

      #endregion

      #region unimplemented

      #region get aspnetroles functions
      //public List<AspNetRoles> getAspNetRoles()
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetRoles> getAspNetRolesById(int Id)
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetRoles> getAspNetRolesByName(string name)
      //{
      //   throw new NotImplementedException();
      //}
      #endregion

      #region get aspnetuserclaims functions
      //public List<AspNetUserClaims> getAspNetUserClaims()
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetUserClaims> getAspNetUserClaimsById(int Id)
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetUserClaims> getAspNetUserClaimsByUserIdandClaimtypeandClaimValue(string userId, string claimType, string claimValue)
      //{
      //   throw new NotImplementedException();
      //}
      #endregion

      #region get aspnetuserlogin functions
      //public List<AspNetUserLogins> getAspNetUserLogin(string loginProvider, string providerKey, string userId)
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetUserLogins> getAspNetUserLogins()
      //{
      //   throw new NotImplementedException();
      //}
      #endregion

      #region get aspnetuserrole functions
      //public List<AspNetUserRoles> getAspNetUserRole(string userId, string roleId)
      //{
      //   throw new NotImplementedException();
      //}

      //public List<AspNetUserRoles> getAspNetUserRoles()
      //{
      //   throw new NotImplementedException();
      //}
      #endregion

      //public bool insertAspNetRoles(AspNetRoles role)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool insertAspNetUserClaims(AspNetUserClaims claim)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool insertAspNetUserLogins(AspNetUserLogins login)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool insertAspNetUserRoles(AspNetUserRoles userRole)
      //{
      //   throw new NotImplementedException();
      //}
      //public bool updateAspNetRole(AspNetUserRoles role)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool updateAspNetUserClaim(AspNetUserClaims claim)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool updateAspNetUserLogin(AspNetUserLogins login)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool updateAspNetUserRoles(AspNetUserRoles userRole)
      //{
      //   throw new NotImplementedException();
      //}
      //public bool deleteAspNetRole(AspNetUserRoles role)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool deleteAspNetUserClaim(AspNetUserClaims claim)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool deleteAspNetUserLogin(AspNetUserLogins login)
      //{
      //   throw new NotImplementedException();
      //}

      //public bool deleteAspNetUserRoles(AspNetUserRoles userRole)
      //{
      //   throw new NotImplementedException();
      //}
      #endregion

      #region expenses
      public List<ExpenseDTO> getExpenses()
      {
         return logic.getExpenses();
      }

      public bool insertExpense(ExpenseDTO expense)
      {
         return logic.insertExpense(expense);
      }

      public bool updateExpense(ExpenseDTO expense)
      {
         return logic.updateExpense(expense);
      }

      public bool deleteExpense(ExpenseDTO expense)
      {
         return logic.deleteExpense(expense);
      }
      #endregion

      #region invoice
      public Invoice generateInvoice(jobDTO job)
      {
         return logic.generateInvoice(job);
      } 
      #endregion

      public void login(AspNetUsers user)
      {
         throw new NotImplementedException();
      }

      

     

     
   }
}
