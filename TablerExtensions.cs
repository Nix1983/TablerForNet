namespace TablerForNet
{
    public static class TablerExtensions
    {
        public static IServiceCollection AddTablerForNet(this IServiceCollection services, Action<TablerOptions> tablerOptions = null)
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
                .AddScoped<TableFilterService>()
                .AddSingleton<FlagService>();
        }    
    }
}