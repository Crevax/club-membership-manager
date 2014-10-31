using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubMembershipManager.Services
{
    public class ClubRepository
    {
        public IEnumerable<Club> GetAllClubs()
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