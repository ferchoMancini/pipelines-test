using data.test.com.Models;
using System.Collections.Generic;
using System.Linq;

namespace data.test.com.Services
{
	public class UserService
	{
		private static readonly List<User> _users = new List<User>
		{
			new User
			{
				ID = 1,
				Username = "test",
				Password = "test",
				Email = "test@test.com",
				Role = "Administrator",
				FullName = "Test"
			},
			new User
			{
				ID = 2,
				Username = "test2",
				Password = "test2",
				Email = "greg@test.com",
				Role = "Viewer",
				FullName = "Test 2"
			}
		};

		public static User Get(string username, string password) => _users.FirstOrDefault(u => u.Username == username && u.Password == password);
	}
}
