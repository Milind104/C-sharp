﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RealEstateApp.Services;
using RealEstateApp.ViewModels;

namespace RealEstateApp
{
    public static class MauiProgram

    {
        static IServiceProvider ServiceProvider { get; set; }
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
            builder.Services.AddTransient<MainViewModel>();

            var mauiApp = builder.Build();

            ServiceProvider = mauiApp.Services;

            return mauiApp;
        }


        public static TService GetService<TService>()
        {
            var result = ServiceProvider.GetService<TService>();
            if (result == null)
                throw new Exception("service not registered");
            return result;
        }
    }
}
