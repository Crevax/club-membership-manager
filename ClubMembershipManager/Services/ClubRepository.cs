using ClubMembershipManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClubMembershipManager.Services
{
    public class ClubRepository
    {
        public List<Club> GetAllClubs()
        {
			List<Club> clubs = new List<Club>();

			var connectionString = ConfigurationManager.ConnectionStrings["ClubMembershipManager"].ConnectionString;
			var connection = new SqlConnection(connectionString);
            connection.Open();

			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT * FROM Clubs";

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Club club = new Club();
						club.Id = (int)reader["ID"];
						club.Name = (string)reader["Name"];
						clubs.Add(club);
					}
				}
			}

			return clubs;
        }
    }
}