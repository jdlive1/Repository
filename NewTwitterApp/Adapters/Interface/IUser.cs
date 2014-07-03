using NewTwitterApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTwitterApp.Adapters.Interface
{
    public interface IUser
    {
        List<User> ListOfUsers();
        User getUser(int id);
        void Create(User user);
        void Friend(Friend friend);
    }
}
 