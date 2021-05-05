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
    [RoutePrefix("api/events")]
    public class EventsController : ApiController
    {
        [HttpGet]
        [Route("getEventByUserCode")]
        public IHttpActionResult GetEventByUserCode(int userCode)
        {
            EventDTO getEvent = BL.EventBL.GetEventByUserCode(userCode);
            if (getEvent != null)
                return Ok(getEvent);
            return BadRequest();
        }
        [Route("newEvent")]
        [HttpPost]
        public IHttpActionResult NewEvent(EventDTO e)
        {
           
            EventDTO eventToAdd = BL.EventBL.NewEvent(e);
            if (eventToAdd != null)
                return Ok(eventToAdd);
            return Ok(false);
        }
    }
}