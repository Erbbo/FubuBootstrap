using FubuMVC.Core;

namespace FubuBootstrap
{
    public class FubuAppRegistry : FubuRegistry
    {
        public FubuAppRegistry()
        {
            Actions.IncludeClassesSuffixedWithEndpoint();

            Services.IncludeRegistry<CoreRegistry>();

            Features.Diagnostics.Enable(TraceLevel.Verbose);
        }
    }
}