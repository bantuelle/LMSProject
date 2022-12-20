using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class User
	{
		public int UserID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Title { get; set; }
		public string Role { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string UserStatus { get; set; }

		public User(string name, string surname, string title, string role, string email, string password, string userStatus)
		{
			Name = name;
			Surname = surname;
			Title = title;
			Role = role;
			Email = email;
			Password = password;
			UserStatus = userStatus;
		}
		public User()
		{

		}
	}	
}
