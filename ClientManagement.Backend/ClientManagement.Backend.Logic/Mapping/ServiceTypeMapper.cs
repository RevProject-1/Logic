using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Backend.Logic.Mapping
{
   class ServiceTypeMapper
   {
      public static ServiceTypeDTO MaptoServiceTypeDTO(ServiceTypeDAO b)
      {
         ServiceTypeDTO a = new ServiceTypeDTO();
         a.Name = b.Name;
         a.UserId = b.UserId;
         a.Id = b.Id;
         a.Rate = b.Rate;
         return a;
      }

      public static ServiceTypeDAO MaptoServiceTypeDAO(ServiceTypeDTO b)
      {
         ServiceTypeDAO a = new ServiceTypeDAO();
         a.Name = b.Name;
         a.UserId = b.UserId;
         a.Id = b.Id;
         a.Rate = b.Rate;
         return a;
      }
   }
}
