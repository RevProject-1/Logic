using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClientManagement.Backend.Client;
using ClientManagement.Backend.Logic;
using ClientManagement.Backend.Logic.Models;
using ClientManagement.Backend.Logic.ServiceReference1;
namespace ClientManagement.Backend.Tests
{
   
    public class Tests
    {
      appLogic myLogic = new appLogic();

      [Fact]
      public void testGetAspNetUsers()
      {
         List<AspNetUsers> result = myLogic.getAspNetUsers();
         Assert.NotNull(result);
      }

   }
}
