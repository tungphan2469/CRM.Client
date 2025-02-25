using CommunityToolkit.Maui;
using CRM.Client.Extensions;
using CRM.UI;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;

namespace CRM.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseTelerik()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter_18pt-Regular.ttf", FontNames.InterRegular);
                    fonts.AddFont("Inter_18pt-Bold.ttf", FontNames.InterBold);
                    fonts.AddFont("Inter_18pt-Italic.ttf", FontNames.InterItalic);
                    fonts.AddFont("Inter_24pt-Medium.ttf", FontNames.InterMedium);
                    fonts.AddFont("Brands-Regular-400.otf", FontNames.FABrand);
                    fonts.AddFont("Pro-Regular-400.otf", FontNames.FARegular);
                    fonts.AddFont("Pro-Solid-900.otf", FontNames.FASolid);
                    fonts.AddFont("Roboto-Regular.ttf", FontNames.RobotoRegular);
                    fonts.AddFont("Roboto-SemiBold.ttf", FontNames.RobotoSemiBold);
                })
                .ConfigureEssentials(essentials => { essentials.UseVersionTracking(); })
                .RegisterCore()
                .RegisterFeatures()
                .RegisterPages();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
