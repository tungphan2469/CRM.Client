using CRM.Client.Extensions;
using CRM.Client.Layouts;

namespace CRM.Client
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            LoadPlatformSpecificXaml();
            ServicesExtension.RegisterRoute();
        }
        private void LoadPlatformSpecificXaml()
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                this.LoadFromXaml(typeof(AndroidLayout));
            }
            else if (DeviceInfo.Platform == DevicePlatform.WinUI)
            {
                this.LoadFromXaml(typeof(WindowsLayout));
            }
        }
    }
}
