using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubMembershipManager.Repositories;

namespace ClubMembershipManager.Services
{
	public class ClubService : IClubService
	{
		private IClubRepository ClubRepository; 

		public ClubService()
		{
			ClubRepository = new ClubRepository();
		}

		public IList<Models.Club> GetAllClubs()
		{
			return ClubRepository.GetAllClubs();
		}

		public Models.Club GetClubByID(int Id)
		{
			return ClubRepository.GetClub(Id);
		}
	}
}