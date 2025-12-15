using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MyFirstMAUIApp.ViewModel;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();

            builder.Services.AddSingleton<UpdatableCollectionViewModel>();
            builder.Services.AddSingleton<UpdatableCollectionWButtonsPage>();
            builder.Services.AddSingleton<CollectionsWIcons>();
#endif
            return builder.Build();
        }
    }
}