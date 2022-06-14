using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>().LifestyleTransient());

            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("Hello world");

            Console.ReadLine();

        }
    }
}
