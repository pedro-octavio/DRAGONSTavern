using Autofac;

namespace DRAGONSTavern.Infra.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder) => ConfigurationIOC.Load(builder);
    }
}
