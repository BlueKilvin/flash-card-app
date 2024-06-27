using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace FlashCard
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

            // Add DbContext

/* Unmerged change from project 'FlashCard (net8.0-android)'
Before:
            builder.Services.AddDbContext<Data.Models.FlashCardDbContext>(options =>
After:
            builder.Services.AddDbContext<FlashCardDbContext>(options =>
*/
            builder.Services.AddDbContext<Data.Services.FlashCardDbContext>(options =>
            {
                options.UseSqlite("Data Source=app.db");
            });

            builder.Services.AddTransient<DatabaseInitialiser>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
