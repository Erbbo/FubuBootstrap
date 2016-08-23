using FubuMVC.Core.Registration;

namespace FubuBootstrap
{
    public class CoreRegistry : ServiceRegistry
    {
        public CoreRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });
        }
    }
}