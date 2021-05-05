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
    [RoutePrefix("api/business")]
    public class BussinesController : ApiController
    {
        [HttpGet]
        [Route("getAllBusniess")]
        public IHttpActionResult GetAllBusiness()
        {
            List<BusinessDTO> BusniessList = BL.BusniessBL.GetAllBusiness();
            if (BusniessList.Count() > 0)
                return Ok(BusniessList);
            return BadRequest();
        }
        [HttpPost]
        [Route("getBusinessByCategoryCode")]
        public IHttpActionResult GetBusinessByCategoryCode(int code)
        {
            List<BusinessDTO> BusniessList = BL.BusniessBL.GetBusinessByCategoryCode(code);
            if (BusniessList.Count() > 0)
                return Ok(BusniessList);
            return BadRequest();
        }
        [Route("newBusiness")]
        [HttpPost]
        public IHttpActionResult NewBusiness(BusinessDTO b)
        {
            BusinessDTO business = BL.BusniessBL.NewBusiness(b);
            if (business != null)
                return Ok(business);
            return Ok(false);
        }
        [Route("getBussinessByOwnerCode")]
        [HttpGet]
        
        public IHttpActionResult GetBusinessByOwnerCode(string code) 
        {
            List<BusinessDTO> BusniessList = BL.BusniessBL.GetBusinessByOwnerCode(code);
            if (BusniessList.Count() > 0)
                return Ok(BusniessList);
            return BadRequest();
        }
        [HttpPost]
        [Route("getCategoryByBusinessCode")]
        public IHttpActionResult getCategoryByBusinessCode(int code)
        {
            int categoryCode = BL.BusniessBL.getCategoryByBusinessCode(code);
            if (categoryCode>=0)
                return Ok(categoryCode);
            return BadRequest();
        }
    }
}
