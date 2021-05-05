using System;
using System.Linq;

namespace DAL
{
    public class EventDAL
    {
        public static Events__tbl GetEventByUserCode(int userCode)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    Events__tbl getEvent = db.Events__tbl.Where(x => x.UserCode == userCode).Select(x => x).FirstOrDefault();
                    return getEvent;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary> - NewEvent: add new event in events tbl in db when user is register
        public static Events__tbl NewEvent(Events__tbl edal)
        {

            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {

                    Events__tbl newEvent = new Events__tbl
                    {
                        EventCode = edal.EventCode,
                        UserCode = edal.UserCode,
                        EventDate = edal.EventDate,
                        GroomOrBride = edal.GroomOrBride

                    };
                    db.Events__tbl.Add(newEvent);
                    db.SaveChanges();
                    return newEvent;
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
