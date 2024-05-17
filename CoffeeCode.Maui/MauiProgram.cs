﻿using CoffeeCode.Library.Data;
using CoffeeCode.Maui.Data;
using Microsoft.Extensions.Logging;

namespace CoffeeCode.Maui
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddTransient<ICoffeeService, CoffeeService>();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
