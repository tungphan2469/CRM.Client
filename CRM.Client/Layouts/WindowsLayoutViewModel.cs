using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CRM.Client.Features.Archive;
using CRM.Client.Features.Home;
using CRM.Utilities.MVVM;
using Microsoft.Maui.Controls;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace CRM.Client.Layouts
{
    public partial class WindowsLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private object selectedView;

        [ObservableProperty]
        private bool isOpen; // This will sync with the View's IsOpen
        public WindowsLayoutViewModel()
        {
            // Set the default view
            SelectedView = new HomeView(); // Replace with your default view
            TogglePaneCommand = new Command(() => IsOpen = !IsOpen);
        }

        public ICommand TogglePaneCommand { get; }

        public void ChangeView(string viewName)
        {
            switch (viewName)
            {
                case "Home":
                    SelectedView = new HomeView(); // Replace with your actual view
                    break;
                case "Archive":
                    SelectedView = new ArchiveView(); // Replace with your actual view
                    break;
                default:
                    break;
            }
        }
    }
}
