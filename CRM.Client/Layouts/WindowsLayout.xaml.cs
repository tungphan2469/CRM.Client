using Telerik.Maui.Controls;
using Telerik.Maui.Controls.NavigationView;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace CRM.Client.Layouts;

public partial class WindowsLayout : ContentPage
{
    private WindowsLayoutViewModel _viewModel;

    public WindowsLayout()
    {
        InitializeComponent();
        _viewModel = new WindowsLayoutViewModel();
        BindingContext = _viewModel;
    }

    private void OnNavItemSelected(object sender, EventArgs e)
    {
        // Get the selected item from the navigation view
        var navigationView = sender as RadNavigationView;
        var selectedItem = navigationView?.SelectedItem as NavigationViewItem;

        if (selectedItem != null)
        {
            // Change the view based on the selected item's text
            _viewModel.ChangeView(selectedItem.Text);
        }
    }
}