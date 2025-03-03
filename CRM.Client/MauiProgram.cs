using CommunityToolkit.Maui;
using CRM.Client.Extensions;
using CRM.UI;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;
#if WINDOWS
using Microsoft.Maui.LifecycleEvents;
using Microsoft.UI;
using Microsoft.UI.Windowing;
#endif


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
#if WINDOWS
    builder.ConfigureLifecycleEvents(lifecycleBuilder =>
    {
        lifecycleBuilder.AddWindows(windowsLifecycleBuilder =>
        {
            windowsLifecycleBuilder.OnWindowCreated(window =>
            {
                if (window is not MauiWinUIWindow mauiWinUiWindow)
                    return;
                mauiWinUiWindow.ExtendsContentIntoTitleBar = false;
                var handle = WinRT.Interop.WindowNative.GetWindowHandle(mauiWinUiWindow);
                var id = Win32Interop.GetWindowIdFromWindow(handle);
                var appWindow = AppWindow.GetFromWindowId(id);

                switch (appWindow.Presenter)
                {
                    case OverlappedPresenter overlappedPresenter:
                        overlappedPresenter.IsMaximizable = true;
                        overlappedPresenter.IsResizable = false;
                        overlappedPresenter.IsMinimizable = false;
                        overlappedPresenter.SetBorderAndTitleBar(false, false);
                        overlappedPresenter.Maximize();
                        break;
                }
            });
        });
    });
#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
