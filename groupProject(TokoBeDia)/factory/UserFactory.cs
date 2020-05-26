using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.factory
{
    public class UserFactory
    {
        public static User createUser(String name, String email, String password, String gender, String status, int rolesId)
        {

            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Password = password;
            user.Gender = gender;
            user.Status = status;
            user.RolesId = rolesId;

            return user;
        }
    }
}