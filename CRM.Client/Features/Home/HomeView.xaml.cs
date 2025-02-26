using CRM.Library.Entities;

namespace CRM.Client.Features.Home;

public partial class HomeView : ContentView
{
    private HomeViewModel _viewModel;
    public HomeView()
    {
        InitializeComponent();
        _viewModel = new HomeViewModel();
        BindingContext = _viewModel;
    }

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is Role selectedRole)
        {
            string roleId = selectedRole.Id;
            _viewModel.IdsToDeleteListUpdate(roleId, e.Value);

        }
    }
}