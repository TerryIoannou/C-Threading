using Microsoft.Extensions.DependencyInjection;
using EarthTask.Interfaces;
using EarthTask.Services;

namespace EarthTask
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

            // Register services with the dependency injection container
            builder.Services.AddSingleton<ITaskService, TaskService>();
            builder.Services.AddSingleton<HealthBarService>();

            return builder.Build();
        }
    }
}
