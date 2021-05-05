using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class BusinessDTO
    {
        public int BusinessCode { get; set; }
        public Nullable<int> CategoryCode { get; set; }
        public string BusinessOwnerCode { get; set; }
        public string BusinessName { get; set; }
        public string FullAddress { get; set; }
        public string Phone { get; set; }
        public string BusinessDescription { get; set; }


        public static List<BusinessDTO> ListToDTO(List<Business__tbl> businessListDal)
        {
            List<BusinessDTO> List = new List<BusinessDTO>();
            foreach (Business__tbl b in businessListDal)
            {
                BusinessDTO bussiness = new BusinessDTO(b);
                List.Add(bussiness);
            }
            return List;
        }



        public BusinessDTO()
        {

        }

        public BusinessDTO(DAL.Business__tbl business)
        {
            this.BusinessCode = business.BusinessCode;
            this.BusinessName = business.BusinessName;
            this.CategoryCode = business.CategoryCode;
            this.BusinessOwnerCode = business.BusinessOwnerCode;
            this.FullAddress = business.FullAddress;
            this.Phone = business.Phone;
            this.BusinessDescription = business.BusinessDescription;


        }
        public static Business__tbl ToDAL(BusinessDTO b)
        {
            return new Business__tbl
            {
                BusinessCode=b.BusinessCode,
                BusinessName = b.BusinessName,
                CategoryCode = b.CategoryCode,
                BusinessOwnerCode = b.BusinessOwnerCode,
                FullAddress=b.FullAddress,
                Phone=b.Phone,
                BusinessDescription=b.BusinessDescription,
 
            };
        }
    }
}
