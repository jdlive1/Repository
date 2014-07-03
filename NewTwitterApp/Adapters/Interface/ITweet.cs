using NewTwitterApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTwitterApp.Adapters.Interface
{
    interface ITweet
    {
        List<Tweet> listTweets(int id);
        void Create(Tweet tweet);
    }
}
