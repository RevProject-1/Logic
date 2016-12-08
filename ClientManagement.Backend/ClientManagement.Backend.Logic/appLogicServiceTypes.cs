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
      public List<ServiceTypeDTO> getServiceTypeByName(string name)
      {
         return getServiceTypes().Where(m => m.Name.Equals(name)).ToList();
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

      public bool insertServiceType(ServiceTypeDTO type)
      {
         return sc.AddType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }

      public bool deleteServiceType(ServiceTypeDTO type)
      {
         return sc.DeleteType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }

      public bool updateServiceType(ServiceTypeDTO type)
      {
         return sc.UpdateType(Mapping.ServiceTypeMapper.MaptoServiceTypeDAO(type));
      }
   }
}
