namespace CRM.Utilities.Navigation;

public interface IAppNavigator
{
    Task GoBackAsync(bool animated = false, object? data = null);

    Task NavigateAsync(string target, bool animated = false, object? args = null);

    Task<bool> OpenUrlAsync(string url);

    Task ShareAsync(string text, string? title = null);

    Task ShowSnackbarAsync(string message, Action? action = null, string? actionText = null);
}