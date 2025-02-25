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

    private List<string> IdsToDelete = new List<string>();
    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is Role selectedRole)
        {
            // Now you have access to the current row's data (selectedRole)
            string roleId = selectedRole.Id; // Assuming Role has an Id property
            if (IdsToDelete.Any(x => x != roleId))
            {
                IdsToDelete.Add(roleId);
            }
        }
        // Perform required operation after examining e.Value
    }

    private void OnDeleteButtonClicked()
    {
        _viewModel.DeleteRoles(IdsToDelete);
    }
}