using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClubMembershipManager;
using ClubMembershipManager.Controllers;
using ClubMembershipManager.Models;

namespace ClubMembershipManager.Tests.Controllers
{
	[TestClass]
	public class ClubsControllerTest
	{
		[TestMethod]
		public void Get()
		{
			// Arrange
			ClubsController controller = new ClubsController();

			// Act 
			List<Club> result = controller.Get();

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Count());
			Assert.AreEqual("Grand Rapids Steelheaders", result.ElementAt(0).Name);
			Assert.AreEqual("Circle K at Davenport University", result.ElementAt(1).Name);
		}
	}
}
