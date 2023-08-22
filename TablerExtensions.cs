using Microsoft.Extensions.DependencyInjection;
using TablerForNet.Tabler.Components.Tables;
using TablerForNet.Tabler.Services;

namespace TablerForNet.Tabler
{
    public static class TablerExtensions
    {
        public static IServiceCollection AddTabler(this IServiceCollection services, Action<TablerOptions> tablerOptions = null)
        {
            if (tablerOptions is null)
            {
                tablerOptions = _ => {};
            }

            services.Configure(tablerOptions);
            
            return services
                .AddScoped<ToastService>()
                .AddScoped<TablerService>()
                .AddScoped<IModalService, ModalService>()
                .AddScoped<TableFilterService>();
        }
       
    }
}