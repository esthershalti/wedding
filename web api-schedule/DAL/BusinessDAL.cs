using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BusinessDAL
    {
        public static List<Business__tbl> GetAllBusiness()
        {

            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    List<Business__tbl> BusniessList = db.Business__tbl.Select(x => x).ToList();
                    return BusniessList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
        public static List<Business__tbl> GetBusinessByCategoryCode(int code)
        {

            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    List<Business__tbl> BusinessList = db.Business__tbl.Where(x => x.CategoryCode == code).ToList();

                    return BusinessList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static List<Business__tbl> GetBusinessByOwnerCode(string code)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    List<Business__tbl> BusinessList = db.Business__tbl.Where(x => x.BusinessOwnerCode == code).ToList();

                    return BusinessList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static int GetCategoryCodeByBusinessCode(int code)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                   var categoryCode = db.Business__tbl.Where(x => x.BusinessCode == code).Select(y => y.CategoryCode).FirstOrDefault();

                    return Convert.ToInt32(categoryCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

        /// <summary> - NewBusiness: add business to business tbl in db. 
        public static Business__tbl NewBusiness(Business__tbl budal)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {



                    Business__tbl newBusiness = new Business__tbl
                    {
                        BusinessCode = budal.BusinessCode,
                        CategoryCode = budal.CategoryCode,
                        BusinessOwnerCode = budal.BusinessOwnerCode,
                        BusinessName = budal.BusinessName,
                        FullAddress = budal.FullAddress,
                        Phone = budal.Phone,
                        BusinessDescription = budal.BusinessDescription,
              
                    };
                    db.Business__tbl.Add(newBusiness);
                    //db.Entry(newUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return newBusiness;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
