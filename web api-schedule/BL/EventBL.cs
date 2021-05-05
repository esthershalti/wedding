using System;
using DAL;
using DTO;

namespace BL
{
    public class EventBL
    {
        public static EventDTO GetEventByUserCode(int userCode)
        {

            Events__tbl getEvent = DAL.EventDAL.GetEventByUserCode(userCode);
            if (getEvent == null)
                return null;
            else
            {
                EventDTO eventDTOs = EventDTO.ObjectToDTO(getEvent);

                return eventDTOs;
            }
        }

        public static EventDTO NewEvent(EventDTO e)
        {
            Events__tbl edal = EventDTO.ToDAL(e);
            Events__tbl etbl = DAL.EventDAL.NewEvent(edal);
            return new EventDTO(etbl);
        }
    }
}
