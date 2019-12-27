using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Schema;
using Project.EF;

namespace Project.Core
{
    public class UserManager
    {
		private static UserManager _instance;
		private static readonly object _lock = new object();
		private UserManager()
		{
		}
		public static UserManager Instance
		{
			get {
				if (_instance == null) { 
					lock (_lock)
					{
						_instance = new UserManager();
					}
				}
				return _instance; 
			}
		}

		public List<User> GetAllUsers()
		{
			var result = new List<User>();
			var user = new User() { Name = "Enrique", ID = Guid.Parse("{C9F91B5D-C710-4708-BEB6-FECF755663A3}") };
			result.Add(user);
			return result;
		}
		public User GetUserByID(Guid ID)
		{
			var allUser = this.GetAllUsers();
			var result = allUser.Where(user => allUser.Select(u=>u.ID).Contains(ID)).FirstOrDefault();
			return result ?? default(User);
		}

		public void CreateUser()
		{
			var user = new User() { Name = "Enrique", ID = Guid.NewGuid(), CreationDate=DateTime.Now };
			using (var context= new UserContext())
			{
				context.User.Add(user);
				context.SaveChanges();
			}
		}
	}
}
