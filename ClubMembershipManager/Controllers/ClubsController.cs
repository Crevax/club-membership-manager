using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClubMembershipManager.Controllers
{
    public class ClubsController : ApiController
    {
        // GET api/clubs
        public IEnumerable<Club> Get()
        {
            return new Club[]
            { 
                new Club
                {
                    Id = 1,
                    Name = "Grand Rapids Steelheaders"
                },
                new Club
                {
                    Id = 2,
                    Name = "Circle K at Davenport University"
                }
            };
        }
    }
}
