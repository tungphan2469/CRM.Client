using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRM.Utilities.Navigation;
namespace CRM.Utilities.MVVM;

public abstract partial class BaseViewModel : ObservableRecipient
{
    protected BaseViewModel(IAppNavigator appNavigator)
    {
        AppNavigator = appNavigator;
    }

    protected IAppNavigator AppNavigator { get; }

    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    // ReSharper disable once VirtualMemberNeverOverridden.Global
    public virtual Task OnAppearingAsync()
    {
        Debug.WriteLine($"{GetType().Name}.{nameof(OnAppearingAsync)}");
        return Task.CompletedTask;
    }

    // ReSharper disable once UnusedParameter.Global
    // ReSharper disable once UnusedMethodReturnValue.Global
    // ReSharper disable once VirtualMemberNeverOverridden.Global
    public virtual Task OnDisappearingAsync()
    {
        Debug.WriteLine($"{GetType().Name}.{nameof(OnDisappearingAsync)}");

        return Task.CompletedTask;
    }

    [RelayCommand]
    protected virtual Task BackAsync()
    {
        return AppNavigator.GoBackAsync(data: GetType().FullName);
    }
}