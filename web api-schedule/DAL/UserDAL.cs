using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DAL
{
    public class UserDAL
    {
        /// <summary> - GetAll: get list of users.
        public static List<Users__tbl> GetAll()
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    List<Users__tbl> UserList = db.Users__tbl.Select(x => x).ToList();
                    return UserList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary> - Exist: check if user is exist. 
        public static Users__tbl Exist(Users__tbl u)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {
                    Users__tbl User = db.Users__tbl.Where(x => x.UserPassword == u.UserPassword && x.UserName==u.UserName).FirstOrDefault();
                    return User;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary> - NewUser: add new user to user tbl in db.
        public static Users__tbl NewUser(Users__tbl udal)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    Users__tbl newUser = new Users__tbl
                    {
                        UserName = udal.UserName,
                        UserLastName = udal.UserLastName,
                        UserMail = udal.UserMail,
                        UserPassword = udal.UserPassword,
                        UserType = udal.UserType
                    };
                    db.Users__tbl.Add(newUser);
                    db.SaveChanges();
                    return newUser;
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
