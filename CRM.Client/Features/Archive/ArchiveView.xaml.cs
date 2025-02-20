namespace CRM.Client.Features.Archive;

public partial class ArchiveView : ContentView
{

	private ArchiveViewModel _viewModel;
    public ArchiveView()
	{
		InitializeComponent();
        _viewModel = new ArchiveViewModel();
        BindingContext = _viewModel;
	}
}