using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ClubMembershipManager.Models
{
	[TableName("Clubs")]
	[PrimaryKey("ID", autoIncrement = true)]
	public class Club
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Club()
		{
		}
	}
}