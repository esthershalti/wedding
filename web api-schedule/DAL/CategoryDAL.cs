using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class CategoryDAL
    {
        public static List<Category__tbl> GetAllCategory()
        {


            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    List<Category__tbl> categoryList = db.Category__tbl.
                    Include(c => c.Business__tbl).
                    Include(c => c.Business__tbl.Select(b => b.Schedule_tbl)).
                    Include(c => c.Business__tbl.Select(b => b.Schedule_tbl.Select(e => e.Events__tbl.Users__tbl)))
                   .ToList();
                    return categoryList;
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
