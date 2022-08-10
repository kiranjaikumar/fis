using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using assgn1.Models;

namespace assgn1.Controllers
{
    public class countryController : ApiController
    {
        static List<country> countrylist = new List<country>()
        {
            new country{Id=1, Name="India",Capital="Delhi"},
            new country{Id=2, Name="Sri Lanka",Capital="Colombo"},
            new country{Id=3, Name="USA",Capital="Washington DC"},
            new country{Id=4, Name="Australia",Capital="Canberra"},
        };
        [HttpGet]
        [Route("countrydetails")]

        public IEnumerable<country> Get()
        {
            return countrylist;
        }

        [HttpGet]
        [Route("countrylist")]

        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, countrylist);
            return response;
        }

    }
}