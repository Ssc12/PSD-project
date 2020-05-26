using groupProject_TokoBeDia_.handler;
using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.controller
{
    public class UserController
    {
        public static void registerNewUser(String name,String email,String password,String gender,String status,int rolesId)
        {
            UserHandler.registerNewUser(name, email, password, gender, status, rolesId);
        }

        public static User login(String email, String password)
        {
            return UserHandler.login(email, password);
        }

        public static void updateProfile(int userId, String email,String name, String gender)
        {
            UserHandler.updateProfile(userId, email, name, gender);
        }

        public static void changePassword(int userId, String confirmPassword)
        {
            UserHandler.changePassword(userId, confirmPassword);
        }

        public static void changeRolesOrStatus(int userId, String roles,String status)
        {
            UserHandler.changeRolesOrStatus(userId, roles, status);
        }
    }
}