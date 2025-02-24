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
        
        // Perform required operation after examining e.Value
    }
}