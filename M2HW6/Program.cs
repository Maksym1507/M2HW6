using M2HW6.Configs;
using Autofac;

namespace M2HW6
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
