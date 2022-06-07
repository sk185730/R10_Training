using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplication
{
    class Content : IUserOperations
    {
        public Dictionary<User, List<Post>> publishedPosts = new Dictionary<User, List<Post>>();
        public Dictionary<User, List<User>> subscriptions = new Dictionary<User, List<User>>();
        public Dictionary<User, List<Post>> LikedPosts = new Dictionary<User, List<Post>>();
        public Dictionary<User, List<Post>> SharedPosts = new Dictionary<User, List<Post>>();

        public void Publish(User user, Post post)
        {
            if (publishedPosts.ContainsKey(user))
            {
                publishedPosts[user].Add(post);
            }
            else
            {
                List<Post> posts = new List<Post> { post };
                publishedPosts.Add(user, posts);
            }
            
        }

        public void Subscribe(User firstUser, User secondUser)
        {
            if (firstUser!=secondUser)
            {
                if (subscriptions.ContainsKey(firstUser))
                {
                    subscriptions[firstUser].Add(secondUser);
                }
                else
                {
                    List<User> users = new List<User> { secondUser };
                    subscriptions.Add(firstUser, users);
                }
            }
        }

        public List<User> GetSubscriptions(User user)
        {
            if (subscriptions.ContainsKey(user))
            {
                return subscriptions[user];
            }
            else
            {
                return new List<User>();
            }
        }

        public void GetFeed(List<User> userSubscriptions)
        {
            Console.WriteLine("Feed: ");
            foreach (var item in publishedPosts)
            {
                if (userSubscriptions.Contains(item.Key))
                {
                    foreach (var i in item.Value)
                    {
                        Console.Write($"{i.PostContent} \n     ");
                    }
                }
            }
        }

        public void Like(User user, Post post)
        {
            if (LikedPosts.ContainsKey(user))
            {
                LikedPosts[user].Add(post);
            }
            else
            {
                List<Post> posts = new List<Post> { post };
                LikedPosts.Add(user, posts);
            }
        }

        public void Share(User user, Post post)
        {
            if (SharedPosts.ContainsKey(user))
            {
                SharedPosts[user].Add(post);
            }
            else
            {
                List<Post> posts = new List<Post> { post };
                SharedPosts.Add(user, posts);
            }
        }
    }
}
