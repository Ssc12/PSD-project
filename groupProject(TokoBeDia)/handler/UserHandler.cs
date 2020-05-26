using groupProject_TokoBeDia_.factory;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.handler
{
    public class UserHandler
    {
        public static void registerNewUser(String name, String email, String password, String gender, String status, int rolesId)
        {
            User newUser = UserFactory.createUser(name, email, password, gender, status, rolesId);
            UserRepository.register(newUser);
        }

        public static User login(String email, String password)
        {
            return UserRepository.login(email, password);
        }

        public static void updateProfile(int userId, String email, String name, String gender)
        {
            UserRepository.updateProfile(userId, email, name, gender);
        }

        public static void changePassword(int userId, String confirmPassword)
        {
            UserRepository.changePassword(userId, confirmPassword);
        }

        public static void changeRolesOrStatus(int userId, String roles, String status)
        {
            UserRepository.changeRolesOrStatus(userId, roles, status);
        }
    }
}