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

      [Fact]
      public void testGetAspNetUsersByName()
      {
         List<AspNetUsers> result = myLogic.getAspNetUsersByName("revature");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetClients()
      {
         List<ClientDTO> result = myLogic.getClients();
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetClientsByName()
      {
         List<ClientDTO> result = myLogic.getClientsByName("derek");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetClientsByPhoneNumber()
      {
         List<ClientDTO> result = myLogic.getClientsByPhoneNumber("1234567890");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetClientsByEmail()
      {
         List<ClientDTO> result = myLogic.getClientsByEmail("A@B.coM");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetClientsByAddressId()
      {
         List<ClientDTO> result = myLogic.getClientsByAddressId(1);
         Assert.NotNull(result);
      }
      [Fact]
      public void testGetAddresses()
      {
         List<AddressDTO> result = myLogic.getAddressDTOs();
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByZip()
      {
         var result = myLogic.getAddressDTOsByZip("22222");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByState()
      {
         var result = myLogic.getAddressDTOsByState("vA");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByCity()
      {
         var result = myLogic.getAddressDTOsByCity("reston");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByStreet()
      {
         var result = myLogic.getAddressDTOsByStreet("123 main");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByStreetandCity()
      {
         var result = myLogic.getAddressDTOsByStreetandCity("123 main", "reston");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByStreetandCityandState()
      {
         var result = myLogic.getAddressDTOsByStreetandCityandState("123 main", "reston","va");
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetAddressByStreetandCityandStateandZip()
      {
         var result = myLogic.getAddressDTOsByStreetandCityandStateandZip("123 main", "reston", "va","20190");
         Assert.NotNull(result);
      }
   }
}
