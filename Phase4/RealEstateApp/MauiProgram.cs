using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RealEstateApp.Services;
using RealEstateApp.ViewModels;
using RealEstateApp.ViewModels.Interfaces;
using RealEstateApp.Views;

namespace RealEstateApp
{
    public static class MauiProgram

    {
       
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Mulish-Italic.ttf", "MulishItalic");
                    fonts.AddFont("Mulish.ttf", "Mulish");
                    fonts.AddFont("fa-brands-400.ttf", "FAbrands400");
                    fonts.AddFont("fa-regular-400.ttf", "FAregular400");
                    fonts.AddFont("fa-solid-900.ttf", "FAsolid900");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
                    builder.Services.AddTransient<IRealStatePropertyServices,RealStatePropertyServices>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();

            builder.Services.AddTransient<RealStatePropertyDetailViewModel>();
            builder.Services.AddTransient<AgentProfilePage>();

            builder.Services.AddTransient<IMainViewModel, MainViewModel>();
            builder.Services.AddTransient<IRealStatePropertyDetailViewModel, RealStatePropertyDetailViewModel>();
            builder.Services.AddTransient<IAgentProfileViewModel, AgentProfileViewModel>();

            return builder.Build(); 
        }


        
    }
}
