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
      #region get AddressDTO functions

      /// <summary>
      /// calls getaddress from service 
      /// </summary>
      /// <returns>list of addresses</returns>
      public List<AddressDTO> getAddressDTOs()
      {
         var list = sc.GetAddress();
         List<AddressDTO> newlist = new List<AddressDTO>();
         foreach (var item in list)
         {
            newlist.Add(Mapping.AddressMapper.MapToAddressDTO(item));
         }
         return newlist;
      }

      /// <summary>
      /// calls getaddress and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <param name="state"></param>
      /// <param name="zip"></param>
      /// <returns>list of addresses with matching params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCityandStateandZip(string street, string city, string state, string zip)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower()) && m.Zip.Equals(zip)).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by street
      /// </summary>
      /// <param name="street"></param>
      /// <returns>list of addresses with matching street</returns>
      public List<AddressDTO> getAddressDTOsByStreet(string street)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <returns>list of addresses that matches params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCity(string street, string city)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;

      }

      /// <summary>
      /// get addresses and filters by following params
      /// </summary>
      /// <param name="street"></param>
      /// <param name="city"></param>
      /// <param name="state"></param>
      /// <returns>list of addresses that match params</returns>
      public List<AddressDTO> getAddressDTOsByStreetandCityandState(string street, string city, string state)
      {
         var list = getAddressDTOs().Where(m => m.Street.ToLower().Equals(street.ToLower()) && m.City.ToLower().Equals(city.ToLower()) && m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by zip
      /// </summary>
      /// <param name="zip"></param>
      /// <returns>list of adddresses with matching zip</returns>
      public List<AddressDTO> getAddressDTOsByZip(string zip)
      {
         var list = getAddressDTOs().Where(m => m.Zip.Equals(zip)).ToList();

         return list;
      }

      /// <summary>
      /// gets addresses and filters by state
      /// </summary>
      /// <param name="state"></param>
      /// <returns>list of addresses with matching state</returns>
      public List<AddressDTO> getAddressDTOsByState(string state)
      {
         var list = getAddressDTOs().Where(m => m.State.ToLower().Equals(state.ToLower())).ToList();
         return list;
      }

      /// <summary>
      /// gets addresses and filters by city
      /// </summary>
      /// <param name="city"></param>
      /// <returns>list of addresses with matching city</returns>
      public List<AddressDTO> getAddressDTOsByCity(string city)
      {
         var list = getAddressDTOs().Where(m => m.City.ToLower().Equals(city.ToLower())).ToList();
         return list;
      }

      #endregion

      //public bool insertAddressDTOs(AddressDTO address);

      //public bool deleteAddress(AddressDTO address);

      //public bool updateAddress(AddressDTO address);

   }
}
