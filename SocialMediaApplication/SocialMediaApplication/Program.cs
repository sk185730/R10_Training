using System;
using System.Collections.Generic;

namespace SocialMediaApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User();
            user1.Id = 1;
            Post post1 = new Post();
            post1.PostContent = "Good morning 1";

            User user2 = new User();
            user2.Id = 2;
            Post post2 = new Post();
            post2.PostContent = "Good morning 2";

            User user3 = new User();
            user3.Id = 3;

            User user4 = new User();
            user4.Id = 4;

            Content content = new Content();

            content.Publish(user1, post1);
            content.Publish(user1, post1);
            content.Publish(user2, post2);

            content.Subscribe(user1, user1);
            content.Subscribe(user1, user2);
            content.Subscribe(user1, user4);

            List<User> userSubscriptions = content.GetSubscriptions(user1);
            content.GetFeed(userSubscriptions);

            content.Like(user1, post1);
            content.Like(user1, post2);
            content.Like(user2, post1);

            content.Share(user1, post2);
            content.Share(user2, post1);


            Console.WriteLine("\nPublished posts: ");
            foreach (var item in content.publishedPosts)
            {
                Console.Write($"{item.Key.Id} -- ");
                foreach (var i in item.Value)
                {
                    Console.Write($"{i.PostContent} \n     ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nSubscriptions: ");
            foreach (var item in content.subscriptions)
            {
                Console.Write($"{item.Key.Id} -- ");
                foreach (var i in item.Value)
                {
                    Console.Write($"{i.Id} ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nLiked posts: ");
            foreach (var item in content.LikedPosts)
            {
                Console.Write($"{item.Key.Id} -- ");
                foreach (var i in item.Value)
                {
                    Console.Write($"{i.PostContent} \n     ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nShared posts: ");
            foreach (var item in content.SharedPosts)
            {
                Console.Write($"{item.Key.Id} -- ");
                foreach (var i in item.Value)
                {
                    Console.Write($"{i.PostContent} \n     ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
