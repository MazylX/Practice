using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracktice
{
    public class Data
    {
        public static PracticeEntities db = new PracticeEntities();

        public static User GetUserByLogin(string login, string password)
        {
            return db.User.FirstOrDefault(user => user.Login == login && user.Password == password);
        }

        public static Role GetUserRole(string roleName)
        {
            return db.Role.FirstOrDefault(role => role.Name == roleName);
        }

        public static bool CheckUserRole(string login, string password, string roleName)
        {
            User user = GetUserByLogin(login, password);
            if (user != null)
            {
                Role role = db.Role.FirstOrDefault(r => r.Name == roleName && r.Id == user.RoleID);
                if (role != null && role.Name == "Admin")
                {
                    return true; //если пользователь админ 
                }
            }
            return false; // если его не нашли или  он не админ
        }

    }
}

