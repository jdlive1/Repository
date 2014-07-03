using NewTwitterApp.Adapters.Interface;
using NewTwitterApp.Data;
using NewTwitterApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTwitterApp.Adapters.Adapters
{
    public class UserAdapter : IUser
    {
        public List<User> listUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<User> Users = db.Users.ToList();
            return Users;
        }
        public User getUser(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            User user = db.Users.Where(u => u.Id == id).FirstOrDefault;
            return user;

        }
        public void Create(User user)
        {
            ApplicationDbContex db = new ApplicationDbContex();
            db.Users.Add(user);
            db.SaveChanges();
        }
       public void Friend(Friend friend)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Users.Add(friend);
            db.SaveChanges();
        }
    }
}