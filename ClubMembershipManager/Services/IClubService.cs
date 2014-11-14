using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubMembershipManager.Models;

namespace ClubMembershipManager.Services
{
	public interface IClubService
	{
		IList<Club> GetAllClubs();
		Club GetClubByID(int Id);
	}
}