using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public interface IModuleInitializer
    {
        void Init(IServiceCollection serviceCollection);
    }
}
