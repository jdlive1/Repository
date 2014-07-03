using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTwitterApp.Data.Model
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public List<Tweet> Tweets { get; set; }


    }
}
