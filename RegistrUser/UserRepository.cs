using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrUser
{
    public class UserRepository
    {
        ApplicationContext context;
        public UserRepository()
        {
            context = new ApplicationContext();
        }
        public bool UserIsNotNull(string userName)
        {
            var user = context.Users.FirstOrDefault(x => x.Login == userName);
            return user != null ? true : false;
        }

        public void SaveUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
