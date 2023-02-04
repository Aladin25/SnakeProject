using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.UserServices
{
    public static class UserInitializer
    {
        public static List<User> GetSampleUserDate()
        {
            List<User> user = new List<User>();
            user.Add(new User { Name = "Some Name", Score = 123 });
            user.Add(new User { Name = "Some Name2", Score = 124 });
            user.Add(new User { Name = "Simple user", Score = 3 });
            user.Add(new User { Name = "Profetional", Score = 500 });

            return user;
        }
    }
}
