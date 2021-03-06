﻿using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ClubMembershipManager.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public List<Club> GetAllClubs()
        {
			using (Database Memberships = new Database("ClubMembershipManager"))
				return Memberships.Query<Club>("").ToList<Club>();
			
        }

		public Club GetClub(int Id)
		{
			using (Database Memberships = new Database("ClubMembershipManager"))
				return Memberships.Query<Club>("").Where(c => c.Id == Id).FirstOrDefault();
		}
    }
}