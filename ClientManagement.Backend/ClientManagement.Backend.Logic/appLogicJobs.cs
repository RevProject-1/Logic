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
      public List<jobDTO> getJobsByUserComplete(string userId)
      {
         return getJobs().Where(m => m.UserId.Equals(userId) && m.Complete).ToList();
      }
      public List<jobDTO> getJobsByUserIncomplete(string userId)
      {
         return getJobs().Where(m => m.UserId.Equals(userId) && !m.Complete).ToList();
      }

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

      public bool insertJob(jobDTO job)
      {
         return sc.AddJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      public bool deleteJob(jobDTO job)
      {
         return sc.DeleteJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      public bool updateJob(jobDTO job)
      {
         return sc.UpdateJob(Mapping.JobMapper.mapToJobDAO(job));
      }

      public bool completeJob(jobDTO job)
      {
         job.Complete = true;
         return sc.UpdateJob(Mapping.JobMapper.mapToJobDAO(job));
        
      }


   }
}
