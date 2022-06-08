using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using System;

namespace ObserverPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            var jazza = new Jazza();
            var rae = new Rae();

            var firstFan = new Fan();
            var secondFan = new Fan();

            jazza.AddFollower(firstFan);
            jazza.AddFollower(secondFan);
            rae.AddFollower(firstFan);

            jazza.Tweet = "Hellooooooooo";
            jazza.Tweet= "Good morning";
            rae.Tweet = "Good Day!";

        }
    }
}
