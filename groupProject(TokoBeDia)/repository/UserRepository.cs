using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groupProject_TokoBeDia_.repository
{
    public class UserRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void register(User newUser)
        {
           db.Users.Add(newUser);
           db.SaveChanges();
        }

        public static User login(String email, String password)
        {
            User u = db.Users.Where(user => user.Email.Equals(email) && user.Password.Equals(password)).FirstOrDefault();
            return u;
        }

        public static void updateProfile(int userId, String email, String name, String gender)
        {
            User u = db.Users.Where(user => user.UsersId == userId).FirstOrDefault();

            u.Email = email;
            u.Name = name;
            u.Gender = gender;

            db.SaveChanges();
        }

        public static void changeRolesOrStatus(int userId, String roles, String status)
        {
            User u = db.Users.Where(user => user.UsersId == userId).FirstOrDefault();

            u.Status = status;

            if (roles.Equals("administrator"))
             {
                u.RolesId = 1;
             }
             else if (roles.Equals("member"))
             {
                 u.RolesId = 2;
             }

              db.SaveChanges();
         }

         public static void changePassword(int userId, String ConfirmPassword)
         {
             User u = db.Users.Where(user => user.UsersId == userId).FirstOrDefault();
             u.Password = ConfirmPassword;

             db.SaveChanges();
         }
    }
}