using GlobalUsingTestProject.MVVM.ViewModels;
using GlobalUsingTestProject.MVVM.Views;

using Microsoft.Extensions.Logging;

namespace GlobalUsingTestProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts( fonts =>
                {
                    fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular" );
                    fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold" );
                } );

            builder.Services.AddSingleton<GlobalViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPageViewModel>();

            builder.Services.AddTransient<DisplayListPage>();
            builder.Services.AddTransient<DisplayPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
