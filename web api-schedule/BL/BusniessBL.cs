using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class BusniessBL
    {
        public static List<BusinessDTO> GetAllBusiness()
        {
            List<Business__tbl> busniessListDal = DAL.BusinessDAL.GetAllBusiness();
            List<BusinessDTO> busniessDTOs = BusinessDTO.ListToDTO(busniessListDal);
            return busniessDTOs;
        }
        public static List<BusinessDTO> GetBusinessByCategoryCode(int code)
        {
            List<Business__tbl> busniessListDal = DAL.BusinessDAL.GetBusinessByCategoryCode(code);
            List<BusinessDTO> busniessDTOs = BusinessDTO.ListToDTO(busniessListDal);
            return busniessDTOs;
        }
        public static BusinessDTO NewBusiness(BusinessDTO b)
        {
            Business__tbl budal = BusinessDTO.ToDAL(b);
            Business__tbl btbl = DAL.BusinessDAL.NewBusiness(budal);
            return new BusinessDTO(btbl);
        }

        public static List<BusinessDTO> GetBusinessByOwnerCode(string code)
        {
            List<Business__tbl> busniessListDal = DAL.BusinessDAL.GetBusinessByOwnerCode(code);
            List<BusinessDTO> busniessDTOs = BusinessDTO.ListToDTO(busniessListDal);
            return busniessDTOs;
        }
        
        public static int getCategoryByBusinessCode(int code)
        {
            throw new NotImplementedException();
        }
    }
}
