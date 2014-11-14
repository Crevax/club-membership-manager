using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClubMembershipManager.Services;

namespace ClubMembershipManager.Controllers
{
    public class ClubsController : ApiController
    {
        private IClubService ClubService;

        public ClubsController()
        {
            ClubService = new ClubService();
        }

        public HttpResponseMessage Get()
        {
            var clubs = ClubService.GetAllClubs();
            if (clubs.Count > 0)
                return Request.CreateResponse(HttpStatusCode.OK, clubs);
            else 
                return Request.CreateResponse(HttpStatusCode.NotFound, clubs);
        }

		public HttpResponseMessage Get(int id)
		{
			var club = ClubService.GetClubByID(id);

			if (club != null)
				return Request.CreateResponse(HttpStatusCode.OK, club);
			else
				return Request.CreateResponse(HttpStatusCode.NotFound, club);
		}
    }
}
