using Microsoft.Extensions.Logging;
using OndeEstouApp.Services;
using OndeEstouApp.ViewModels;
using OndeEstouApp.Views;

namespace OndeEstouApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<LocalPage>();
            builder.Services.AddTransient<LocalViewModel>();
            builder.Services.AddSingleton<IGeoService, GeoService>();

            return builder.Build();
        }
    }
}
