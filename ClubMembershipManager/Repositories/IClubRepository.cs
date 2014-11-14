using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubMembershipManager.Models;

namespace ClubMembershipManager.Repositories
{
	public interface IClubRepository
	{
		List<Club> GetAllClubs();

		Club GetClub(int id);
	}
}