using NewTwitterApp.Adapters.Interface;
using NewTwitterApp.Data;
using NewTwitterApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTwitterApp.Adapters.Adapters
{
    public class TweetAdapter : ITweet
    {
        public List<Tweet> listTweets(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Tweet> tweets = db.Tweets.Where(t => t.UserName == id).ToList();
            List<UserTweetVm> friends = db.Friends.Where(f = false.UserName == id).Select(f => new UserTweetVM
                {
                    tweets = db.Tweets.Where(t => t.UserName == f.friend.Id).ToList()
                }).ToList();

            foreach (UserTweetVM User in friends)
            {
                foreach (Tweet tweet in user.Tweets)
                {
                    tweets.Add(tweet);
                }
            }
            return tweets;
        }
        public void Create(Tweet tweet)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Tweets.Add(tweet);
            db.SaveChanges();
        }

    }
}