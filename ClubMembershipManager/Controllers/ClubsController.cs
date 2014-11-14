using ClubMembershipManager.Models;
using ClubMembershipManager.Services;
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
        private ClubRepository ClubRepository;

        public ClubsController()
        {
            this.ClubRepository = new ClubRepository();
        }

        public HttpResponseMessage Get()
        {
            var clubs = ClubRepository.GetAllClubs();
            if (clubs.Count > 0)
                return Request.CreateResponse(HttpStatusCode.OK, clubs);
            else 
                return Request.CreateResponse(HttpStatusCode.NotFound, clubs);
        }
    }
}
