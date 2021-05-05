using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DTO;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/hours")]
    public class BusinessOpeningHoursController : ApiController
    {
        [HttpGet]
        [Route("getHoursByBusinessCode")]
        public IHttpActionResult GetHoursByBusinessCode(int businessCode)
        {
            List<BusinessOpeningHoursDTO> hoursList = BL.BusinessOpeningHoursBL.GetHoursByBusinessCode(businessCode);
            if (hoursList.Count() > 0)
                return Ok(hoursList);
            return BadRequest();
        }
    }
}
