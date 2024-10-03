﻿using Microsoft.Extensions.Logging;

namespace MauiResources1
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
                    fonts.AddFont("Amble-Regular.ttf", "Amble");
                    fonts.AddFont("Quicksand-Regular.otf", "Quicksand");
                    fonts.AddFont("fontello.ttf", "IconsFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
