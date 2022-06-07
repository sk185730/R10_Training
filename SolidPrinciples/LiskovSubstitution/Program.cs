using System;

namespace LiskovSubstitution
{
    public interface IRead
    {
        public void Read();
    }
    public interface IWrite
    {
        public void Write();
    }

    //class User
    //{
    //    public virtual void Read()
    //    {
    //        Console.WriteLine("File read");
    //    }
    //    public virtual void Write()
    //    {
    //        Console.WriteLine("File written");
    //    }
    //}

    class Admin : IRead, IWrite
    {
        public void Read()
        {
            Console.WriteLine("File read by admin");
        }
        public void Write()
        {
            Console.WriteLine("File written by admin");
        }
    }

    class RegularUser : IRead
    {
        public void Read()
        {
            Console.WriteLine("File read by regular user");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IRead iread = new RegularUser();
            iread.Read();
            iread = new Admin();
            iread.Read();

            IWrite user = new Admin();
            user.Write();


        }
    }
}
