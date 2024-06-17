﻿using Microsoft.Extensions.Logging;

namespace RealEstateApp
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
                    fonts.AddFont("Mulish-Italic.ttf", "MulishItalic");
                    fonts.AddFont("Mulish.ttf", "Mulish");
                    fonts.AddFont("fa-brands-400.ttf", "FAbrands400");
                    fonts.AddFont("fa-regular-400.ttf", "FAregular400");
                    fonts.AddFont("fa-solid-900.ttf", "FAsolid900");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
