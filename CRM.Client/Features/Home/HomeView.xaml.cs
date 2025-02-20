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
}