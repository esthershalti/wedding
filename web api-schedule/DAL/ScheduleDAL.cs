using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ScheduleDAL
    {
        /// <summary> - GetAllByEventCode: get schedule list by event code
        public static List<Schedule_tbl> GetAllScheduleByEventCode(int eventCode)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {
                    List<Schedule_tbl> scheduleList = db.Schedule_tbl.Where(x => x.EventCode == eventCode).Select(x => x).OrderBy(x => x.EventCode).ToList();
                    return scheduleList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary> - NewSchedule: add new schedule to schedule tbl in db
        public static Schedule_tbl NewSchedule(Schedule_tbl sdal)
        {
            using (projectDBEntities5 db = new projectDBEntities5())
            {
                try
                {
                    Schedule_tbl existSchedule = db.Schedule_tbl.Where
                        (x => x.ScheduleId == sdal.ScheduleId).
                        Select(x => x).FirstOrDefault();
                    if (existSchedule != null)
                    {
                        existSchedule.EventCode = sdal.EventCode;
                        existSchedule.BusinessCode = sdal.BusinessCode;
                        existSchedule.EventDate = sdal.EventDate;
                        existSchedule.Duration = sdal.Duration;
                        existSchedule.Done = sdal.Done;
                        existSchedule.Cost = sdal.Cost;
                        existSchedule.Hour = sdal.Hour;
                        existSchedule.Description = sdal.Description;
                        existSchedule.Subject = sdal.Subject;
                        db.SaveChanges();
                        return existSchedule;
                    }
                    else
                    {
                        try
                        {
                            Schedule_tbl newSchedule = new Schedule_tbl
                            {
                                EventCode = sdal.EventCode,
                                BusinessCode = sdal.BusinessCode,
                                EventDate = sdal.EventDate,
                                Duration = sdal.Duration,
                                Done = sdal.Done,
                                Cost = sdal.Cost,
                                Hour = sdal.Hour,
                                Description = sdal.Description,
                                Subject = sdal.Subject,
                                ScheduleId = sdal.ScheduleId
                            };
                            db.Schedule_tbl.Add(newSchedule);
                            db.SaveChanges();
                            return newSchedule;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            return null;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }

            }
        }
        public static int RemoveSchedule(string id)
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {
                    Schedule_tbl row = db.Schedule_tbl.Where(x => x.ScheduleId == id).Select(x => x).FirstOrDefault();
                    Schedule_tbl count = db.Schedule_tbl.Remove(row);
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        /// <summary> - GetLastScheduleId: get last row of schedule id in schedule list
        public static string GetLastScheduleId()
        {
            try
            {
                using (projectDBEntities5 db = new projectDBEntities5())
                {
                    string lastScheduleId = db.Schedule_tbl
                                         .OrderByDescending(x => x.ScheduleId)
                                         .Take(1).Select(x => x.ScheduleId).FirstOrDefault().ToString();
                    return lastScheduleId;

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
