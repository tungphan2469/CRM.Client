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
        }
    }
}
