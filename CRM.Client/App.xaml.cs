using CRM.Client.Layouts;
using Microsoft.Maui.Platform;

namespace CRM.Client
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
            {
                MainPage = new NavigationPage(new WindowsLayout());
            }
            else
            {
                MainPage = new NavigationPage(new AndroidLayout());
            }
            var icon = new FontImageSource
            {
                Glyph = "\uF0C0",
                FontFamily = "Font Awesome 5 Free",
                Size = 20,
                Color = Colors.White
            };
        }

    }
}
