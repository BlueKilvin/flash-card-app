using Microsoft.Extensions.DependencyInjection;
using System;

namespace FlashCard
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var services = MauiProgram.CreateMauiApp().Services;

            using (var scope = services.CreateScope())
            {

/* Unmerged change from project 'FlashCard (net8.0-android)'
Before:
                var dbContext = scope.ServiceProvider.GetRequiredService<Data.Models.FlashCardDbContext>();
After:
                var dbContext = scope.ServiceProvider.GetRequiredService<FlashCardDbContext>();
*/
                var dbContext = scope.ServiceProvider.GetRequiredService<Data.Services.FlashCardDbContext>();
                var dbInitializer = scope.ServiceProvider.GetRequiredService<DatabaseInitialiser>();
                dbInitializer.Initialize();
            }

            MainPage = new MainPage();
        }
    }
}
