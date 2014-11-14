using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ClubMembershipManager.Services
{
    public class ClubRepository
    {
        public List<Club> GetAllClubs()
        {
			Database Memberships = new Database("ClubMembershipManager");

			return Memberships.Query<Club>("SELECT * FROM Clubs").ToList<Club>();
        }
    }
}