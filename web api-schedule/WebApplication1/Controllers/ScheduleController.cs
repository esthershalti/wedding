using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/schedule")]
    public class ScheduleController : ApiController
    {
        [Route("getAllScheduleByEventCode")]
        [HttpGet]
        public IHttpActionResult GetAllScheduleByEventCode(int eventCode)
        {

            List<ScheduleDTO> scheduleList = BL.ScheduleBL.GetAllScheduleByEventCode(eventCode);
            if (scheduleList.Count() > 0)
                return Ok(scheduleList);
            return BadRequest();
        }
        [Route("newSchedule")]
        [HttpPost]
        public IHttpActionResult NewSchedule(ScheduleDTO s)
        {
            ScheduleDTO schedule = BL.ScheduleBL.NewSchedule(s);
            if (schedule != null)
                return Ok(schedule);
            return Ok(false);
        }
        [Route("getLastScheduleId")]
        [HttpGet]
        public IHttpActionResult GetLastScheduleId()
        {
            String lastScheduleId = BL.ScheduleBL.GetLastScheduleId();
            if (lastScheduleId != null)
                return Ok(lastScheduleId);
            return Ok(false);
        }
        [Route("removeSchedule")]
        [HttpGet]
        public IHttpActionResult RemoveSchedule(string id)
        {
            int effected = BL.ScheduleBL.RemoveSchedule(id);
            if (effected >=1)
                return Ok(effected);
            return Ok(false);
        }
    }
}
