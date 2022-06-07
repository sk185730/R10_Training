using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplication
{
    interface IUserOperations
    {
        void GetFeed(List<User> userSubscriptions);
        List<User> GetSubscriptions(User user);
        void Like(User user, Post post);
        void Publish(User user, Post post);
        void Share(User user, Post post);
        void Subscribe(User firstUser, User secondUser);
    }
}
