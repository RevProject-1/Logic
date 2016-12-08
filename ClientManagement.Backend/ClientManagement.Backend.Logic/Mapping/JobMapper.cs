using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Mapping
{
   class JobMapper
   {
      public static jobDTO mapToJobDTO(JobDAO b)
      {
         jobDTO a = new jobDTO();
         a.client = Mapping.ClientMapper.MapToClientDTO(b.Client);
         a.ClientId = b.ClientID;
         a.Complete = b.Complete;
         a.EstimatedDuration = b.EstimatedDuration;
         a.Id = b.Id;
         a.Notes = b.Notes;
         a.ServiceTypeId = b.ServiceTypeID;
         a.StartDate = b.StartDate;
         a.type = Mapping.ServiceTypeMapper.MaptoServiceTypeDTO(b.ServiceType);
         a.user = Mapping.AspNetUserMapper.mapToAspNetUsers(b.User);
         a.UserId = b.UserID;
         a.Hours = b.Hours;
         return a;
      }

      public static JobDAO mapToJobDAO(jobDTO b)
      {
         JobDAO a = new JobDAO();
         if (b.client!=null)
         {
            a.Client = Mapping.ClientMapper.MapToClientDAO(b.client); 
         }
         a.ClientID = b.ClientId;
         a.Complete = b.Complete;
         a.EstimatedDuration = b.EstimatedDuration;
         a.Id = b.Id;
         a.Notes = b.Notes;
         a.ServiceTypeID = b.ServiceTypeId;
         if(b.StartDate!=null)
         {
            a.StartDate = b.StartDate;

         }
         if (b.type!=null)
         {
            a.ServiceType = Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(b.type);

         }
         if(b.user!=null)
         {
            a.User = Mapping.AspNetUserMapper.mapToUserDAO(b.user);

         }
         a.UserID = b.UserId;
         a.Hours = b.Hours;
         return a;
      }
   }
}
