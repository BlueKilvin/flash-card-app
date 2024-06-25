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
                var dbContext = scope.ServiceProvider.GetRequiredService<Data.Models.FlashCardDbContext>();
                var dbInitializer = scope.ServiceProvider.GetRequiredService<DatabaseInitialiser>();
                dbInitializer.Initialize();
            }

            MainPage = new MainPage();
        }
    }
}
